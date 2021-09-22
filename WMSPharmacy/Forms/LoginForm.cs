using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WMSPharmacy.Helpers;
using MaterialSkin;
using NLog;
using WMSPharmacy.Model;
using WMSPharmacy.Properties;
using Bcrypt = BCrypt.Net.BCrypt;

namespace WMSPharmacy.Forms
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            if (!Settings.Default.ShowRecoveryMenu)
            {
                showSettingsButton.Hide();
            }
        }

        #region usingClasses

        //Смена цвета для компонентов MaterialSkin
        private readonly MaterialSkinManager _materialSkinManager = MaterialSkinManager.Instance;

        //Логер
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        //Запоминание логина с паролем
        private readonly SaveMeHelper _saveMeHelper = new SaveMeHelper();

        //Форма настроек
        private SettingsForm _settingsForm;

        #endregion

        private void ClearTextBox()
        {
            //Очистка полей ввода логина и пароля
            loginTextbox.ResetText();
            passwordTextbox.ResetText();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            //Что такое безопасность?
            //Авторизация на клиенте
            //Для учебного проекта этого достаточно
            Users user;
            UserRoles userRole;

            try
            {
                if (loginTextbox.Text != "" && passwordTextbox.Text != "")
                {
                    using (var context = new WmsPharmacyContext())
                    {
                        user = context.Users.SingleOrDefault(users => users.Email == loginTextbox.Text);
                        userRole = context.UserRoles.SingleOrDefault(role => role.Id == user.UserRole);
                    }

                    if (user != null)
                    {
                        if (userRole != null)
                        {
                            if (Bcrypt.Verify(passwordTextbox.Text, user.Password))
                            {
                                Logger.Info($"Вход в приложение пользователем {loginTextbox.Text}");

                                //Запомнить пользователя
                                if (saveMeCheckBox.Checked)
                                {
                                    Logger.Info(
                                        $"Сохранение пароля включено пользователем {loginTextbox.Text}");
                                    _saveMeHelper.RememberUser(loginTextbox.Text, passwordTextbox.Text);
                                }
                                else
                                {
                                    Logger.Info(
                                        $"Выключено сохранение пароля пользователем {loginTextbox.Text}");
                                    _saveMeHelper.EraseUser();
                                }

                                Hide();
                                var mainForm = new MainForm(user.FirstName + " " + user.LastName, user.Email,
                                    userRole.NameRole);
                                mainForm.Show();
                            }
                            else
                            {
                                Logger.Info("Неверный логин или пароль");
                                MessageBox.Show(@"Неверный логин или пароль", @"Ошибка");
                                ClearTextBox();
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Произошла ошибка обратитесь к администратоору");
                            Logger.Error($@"У пользователя {user.Email} не назначена роль");
                        }
                    }
                    else
                    {
                        Logger.Info("Неверный логин или пароль");
                        MessageBox.Show(@"Неверный логин или пароль", @"Ошибка");
                        ClearTextBox();
                    }
                }
                else
                {
                    MessageBox.Show(@"Заполните оба поля", @"Ошибка");
                    Logger.Error(@"Пользователь не заполнил поля");
                    ClearTextBox();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
            }
        }

        private void LoginFormLoad(object sender, EventArgs e)
        {
            //Установка цвета CheckBox-ов и кнопок из MaterialSkin
            //Установить цвета компонентам по отдельности нельзя,
            //Только всем сразу через менеджер 
            _materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue200, Primary.Blue200, Primary.Blue200,
                Accent.Blue400, TextShade.WHITE);

            //Чтения пароля из реестра
            try
            {
                loginTextbox.Text = _saveMeHelper.ReadUserFromRegistry().login;
                passwordTextbox.Text = _saveMeHelper.ReadUserFromRegistry().password;
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
                return;
            }

            #region Выравнивание элeментов
            
            //Кодом выровнять компоненты быстрее, чем руками

            loginTextbox.Location = new Point
            (
                Width / 2 - loginTextbox.Width / 2,
                Top + 20
            );

            passwordTextbox.Location = new Point
            (
                Width / 2 - passwordTextbox.Width / 2,
                loginTextbox.Top + loginTextbox.Height + 20
            );

            viewPasswordButton.Location = new Point
            (
                passwordTextbox.Left + passwordTextbox.Width - viewPasswordButton.Width,
                passwordTextbox.Top
            );

            authPanel.Width = authButton.Width;
            authPanel.Height = authButton.Height;

            authPanel.Location = new Point
            (
                passwordTextbox.Left + passwordTextbox.Width - authButton.Width,
                passwordTextbox.Top + passwordTextbox.Height + 10
            );

            saveMeCheckBox.Location = new Point
            (
                passwordTextbox.Left - 7,
                authPanel.Top
            );

            #endregion
        }

        private void LoginFormFormClosed(object sender, FormClosedEventArgs e)
        {
            //Закрытие приложения
            //Возможно код избыточный
            try
            {
                Logger.Info("Выхода из приложения");
                Application.Exit();
            }
            catch (Exception exception)
            {
                Logger.Error("Аварийный выход из приложения");
                Logger.Error(exception);
                Environment.Exit(0);
            }
        }

        #region Fix Bunifu TextBox isPassword

        //Пароли принято закрывать звездочками
        //В Bunifu это делается свойством isPassword
        //Но если свойство включено, подсказка отображается звездочками, а не текстом
        //Разработчики не могут исправить эту проблему несколько лет 

        //Хотелось еще добавить кнопку показать пароль

        private bool _viewPasswordSemaphore;

        private void PasswordTextBoxOnValueChanged(object sender, EventArgs e)
        {
            if (passwordTextbox.Text.Length == 0)
            {
                passwordTextbox.isPassword = false;
            }
            else
            {
                if (passwordTextbox.Text.Length == 0)
                {
                    passwordTextbox.isPassword = false;
                }
                else
                {
                    passwordTextbox.isPassword = !_viewPasswordSemaphore;
                }
            }
        }

        //Кнопка показать пароль
        private void ViewPasswordButtonClick(object sender, EventArgs e)
        {
            if (_viewPasswordSemaphore)
            {
                _viewPasswordSemaphore = false;
                viewPasswordButton.Image = Resources.ShowPassword;
            }
            else
            {
                _viewPasswordSemaphore = true;
                viewPasswordButton.Image = Resources.HidePassword;
            }

            PasswordTextBoxOnValueChanged(sender, e);
        }

        #endregion

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }

        private void MinimizeClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SettingsButtonClick(object sender, EventArgs e)
        {
            //Ввод пароля для переход в настройки

            if (!adminPasswordTextbox.Visible)
            {
                adminPasswordTextbox.Show();
                toSettingsButton.Show();
            }
            else
            {
                adminPasswordTextbox.Hide();
                toSettingsButton.Hide();
            }

            adminPasswordTextbox.ResetText();
        }

        private void ToSettingsButtonClick(object sender, EventArgs e)
        {
            //Переход в настройки программы
            if (adminPasswordTextbox.Text == Settings.Default.RecoveryMenuPassword)
            {
                Hide();

                _settingsForm = new SettingsForm();
                _settingsForm.Show();

                adminPasswordTextbox.ResetText();
            }
            else
            {
                MessageBox.Show(@"Неверный пароль", @"Ошибка");
                adminPasswordTextbox.ResetText();
            }
        }
    }
}