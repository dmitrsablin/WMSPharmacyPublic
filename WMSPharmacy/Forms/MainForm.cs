using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;
using WMSPharmacy.Properties;
using NLog;
using WMSPharmacy.Helpers;
using WMSPharmacy.Model;
using Application = System.Windows.Forms.Application;
using DataTable = System.Data.DataTable;
using Point = System.Drawing.Point;

namespace WMSPharmacy.Forms
{
    public partial class MainForm : Form
    {
        public MainForm(string userName, string userEmail, string userRole)
        {
            InitializeComponent();
            _userName = userName;
            _userEmail = userEmail;
            _userRole = userRole;
        }

        //Данные пользователя
        private readonly string _userName;
        private readonly string _userRole;
        private readonly string _userEmail;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private void MainFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {
            if (_userRole == "Администратор")
            {
                usersToolStripMenuItem.Visible = true;
                systemSettingsToolStripMenuItem.Visible = true;
            }

            helloLabel.Text = $@"Привет {_userName}";
            emailTextbox.Text = _userName;

            NewPasswordTextBoxOnValueChanged(sender, e);
            ConfirmNewPasswordTextBoxOnValueChanged(sender, e);
            
            #region Выравнивание элементов

            //Главная
            helloLabel.Location = new Point
            (
                dashboardPage.Width / 2 - helloLabel.Width / 2,
                dashboardPage.Height / 2 - helloLabel.Height / 2
            );

            //Смена пароля
            changePasswordPanel.Location = new Point
            (
                dashboardPage.Width / 2 - changePasswordPanel.Width / 2,
                dashboardPage.Height / 4 + changePasswordPanel.Height / 2
            );

            #endregion
        }

        #region меню настроек

        private void SaveDbButtonClick(object sender, EventArgs e)
        {
            //Смена БД
            try
            {
                Settings.Default.AdressDB = ipDBTextbox.Text;
                Settings.Default.NameDB = nameDBTextbox.Text;
                Settings.Default.LoginDB = loginDBTextbox.Text;
                Settings.Default.PasswordDB = passwordDBTextbox.Text;
                Settings.Default.Save();

                Logger.Info(
                    $@"Смена БД {Settings.Default.AdressDB} {Settings.Default.NameDB} {Settings.Default.LoginDB} {Settings.Default.PasswordDB}");
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
            }
        }

        private void SaveRecoveryMenuSettingsButtonClick(object sender, EventArgs e)
        {
            //Меню настроек на панели входа
            try
            {
                Settings.Default.RecoveryMenuPassword = recoveryMenuPasswordTextbox.Text;
                Settings.Default.ShowRecoveryMenu = showRecoveryMenuCheckBox.Checked;
                Settings.Default.Save();
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
            }
        }

        private void DocumentsPathButtonClick(object sender, EventArgs e)
        {
            //Изменить путь к отчетам
            try
            {
                Settings.Default.DocumentsPath = documentsPathTextbox.Text;
                Settings.Default.Save();
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
            }
        }

        #endregion

        #region Fix Bunifu TextBox isPassword

        //Пароли принято закрывать звездочками
        //В Bunifu это делается свойством isPassword
        //Но если свойство включено, подсказка отображается звездочками, а не текстом
        //Разработчики не могут исправить эту проблему несколько лет 

        //Хотелось еще добавить кнопку показать пароль

        private bool _viewPasswordSemaphore;
        private bool _viewPasswordSemaphore2;

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

            NewPasswordTextBoxOnValueChanged(sender, e);
        }

        private void NewPasswordTextBoxOnValueChanged(object sender, EventArgs e)
        {
            if (newUserPasswordTextbox.Text.Length == 0)
            {
                newUserPasswordTextbox.isPassword = false;
            }
            else
            {
                newUserPasswordTextbox.isPassword = !_viewPasswordSemaphore;
            }
        }

        private void ViewConfirmPasswordButtonClick(object sender, EventArgs e)
        {
            if (_viewPasswordSemaphore2)
            {
                _viewPasswordSemaphore2 = false;
                viewConfirmPasswordButton.Image = Resources.ShowPassword;
            }
            else
            {
                _viewPasswordSemaphore2 = true;
                viewConfirmPasswordButton.Image = Resources.HidePassword;
            }

            ConfirmNewPasswordTextBoxOnValueChanged(sender, e);
        }

        private void ConfirmNewPasswordTextBoxOnValueChanged(object sender, EventArgs e)
        {
            if (confirmNewUserPasswordTextbox.Text.Length == 0)
            {
                confirmNewUserPasswordTextbox.isPassword = false;
            }
            else
            {
                confirmNewUserPasswordTextbox.isPassword = !_viewPasswordSemaphore2;
            }
        }

        #endregion

        #region Переключение вкладок

        private void DashboardToolStripMenuItemClick(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 0;
        }

        private void MedicinesToolStripMenuItemClick(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 1;
            UpdateDataInMedicinesGridView();

            using (var context = new WmsPharmacyContext())
            {
                medicinesTypeComboBox.DataSource =
                    (from medicinesTypes in context.MedicinesTypes select medicinesTypes.MedicinesTypeName).ToList();

                medicineManufacturerComboBox.DataSource =
                    (from manufacturers in context.Manufacturers select manufacturers.ManufacturerName).ToList();
            }
        }

        private void UsersToolStripMenuItemClick(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 2;
            UpdateDataInUsersGridView();

            using (var context = new WmsPharmacyContext())
            {
                userRoleComboBox.DataSource =
                    (from userRoles in context.UserRoles select userRoles.NameRole).ToList();
            }
        }

        private void ChangePasswordToolStripMenuItemClick(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 3;
        }

        private void SystemSettingsToolStripMenuItemClick(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 4;

            //БД
            ipDBTextbox.Text = Settings.Default.AdressDB;
            nameDBTextbox.Text = Settings.Default.NameDB;
            loginDBTextbox.Text = Settings.Default.LoginDB;
            passwordDBTextbox.Text = Settings.Default.PasswordDB;

            //Кнопка на странице авторизации
            recoveryMenuPasswordTextbox.Text = Settings.Default.RecoveryMenuPassword;
            showRecoveryMenuCheckBox.Checked = Settings.Default.ShowRecoveryMenu;

            //Путь к экспортируемым документам
            documentsPathTextbox.Text = Settings.Default.DocumentsPath;
        }

        private void ManufacturersToolStripMenuItemClick(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 5;
            UpdateDataInManufacturerGridView();
        }

        private void MedicineTypesToolStripMenuItemClick(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 6;
            UpdateDataInMedicinesTypeGridView();
        }

        private void HistoryToolStripMenuItemClick(object sender, EventArgs e)
        {
            mainTabControl.SelectedIndex = 7;
            UpdateDataInHistoryGridView();
        }

        #endregion

        #region Обновление DataGrid

        private void UpdateDataInMedicinesGridView(string searchString = "")
        {
            medicinesGridView.DataSource = GetMedicinesFromDb(searchString);
        }

        private void UpdateDataInMedicinesTypeGridView(string searchString = "")
        {
            medicinesTypeGridView.DataSource = GetMedicinesTypesFromDb(searchString);
        }

        private void UpdateDataInUsersGridView(string searchString = "")
        {
            usersGridView.DataSource = GetUsersFromDb(searchString);
        }

        private void UpdateDataInHistoryGridView(string searchString = "")
        {
            historyGridView.DataSource = GetHistoryFromDb(searchString);
        }

        private void UpdateDataInManufacturerGridView(string searchString = "")
        {
            manufacturersGridView.DataSource = GetManufacturersFromDb(searchString);
        }

        #endregion

        #region Нажатие на таблицу

        private void UsersDataGridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            idUserTextbox.Text = usersGridView.CurrentRow?.Cells[0].Value.ToString();
            lastNameUserTextbox.Text = usersGridView.CurrentRow?.Cells[1].Value.ToString();
            firstNameUserTextbox.Text = usersGridView.CurrentRow?.Cells[2].Value.ToString();
            middleNameUserTextbox.Text = usersGridView.CurrentRow?.Cells[3].Value.ToString();
            userRoleComboBox.SelectedItem = usersGridView.CurrentRow?.Cells[4].Value;
            emailUserTextbox.Text = usersGridView.CurrentRow?.Cells[5].Value.ToString();
            passwordUserTextbox.Text = usersGridView.CurrentRow?.Cells[6].Value.ToString();
            confirmPasswordUserTextbox.Text = usersGridView.CurrentRow?.Cells[6].Value.ToString();
        }

        private void MedicinesTypeGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            medicinesTypeIdTextbox.Text = medicinesTypeGridView.CurrentRow?.Cells[0].Value.ToString();
            medicinesTypeNameTextbox.Text = medicinesTypeGridView.CurrentRow?.Cells[1].Value.ToString();
        }

        private void ManufacturersGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            manufacturerIdTextbox.Text = manufacturersGridView.CurrentRow?.Cells[0].Value.ToString();
            manufacturerNameTextbox.Text = manufacturersGridView.CurrentRow?.Cells[1].Value.ToString();
        }

        private void HistoryGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            historyIdTextbox.Text = historyGridView.CurrentRow?.Cells[0].Value.ToString();
            historyUserTextbox.Text = historyGridView.CurrentRow?.Cells[1].Value.ToString();
            historyMedicineNameTextbox.Text = historyGridView.CurrentRow?.Cells[2].Value.ToString();
            historyWasQuantityTextbox.Text = historyGridView.CurrentRow?.Cells[3].Value.ToString();
            historyIsQuantityTextbox.Text = historyGridView.CurrentRow?.Cells[4].Value.ToString();
            historyDateTextbox.Text = historyGridView.CurrentRow?.Cells[5].Value.ToString();
        }

        private void MedicinesGridViewCellClick(object sender, DataGridViewCellEventArgs e)
        {
            medicineIdTextbox.Text = medicinesGridView.CurrentRow?.Cells[0].Value.ToString();
            medicineNameTextbox.Text = medicinesGridView.CurrentRow?.Cells[1].Value.ToString();
            medicineManufacturerComboBox.SelectedItem = medicinesGridView.CurrentRow?.Cells[2].Value;
            medicinesTypeComboBox.SelectedItem = medicinesGridView.CurrentRow?.Cells[3].Value;
            medicineQuantityTextbox.Text = medicinesGridView.CurrentRow?.Cells[4].Value.ToString();
            medicinePriceTextbox.Text = medicinesGridView.CurrentRow?.Cells[5].Value.ToString();
            medicineDescriptionTextbox.Text = medicinesGridView.CurrentRow?.Cells[6].Value.ToString();
            medicineStructureTextbox.Text = medicinesGridView.CurrentRow?.Cells[7].Value.ToString();
            medicineDiseasesTextbox.Text = medicinesGridView.CurrentRow?.Cells[8].Value.ToString();

            //Без проверки приложение падает, но проверка на null не помогает 
            if (medicinesGridView.CurrentRow?.Cells[9].Value.ToString() == "True" ||
                medicinesGridView.CurrentRow?.Cells[9].Value.ToString() == "False")
            {
                medicineIsDrugCheckBox.Checked = Convert.ToBoolean(medicinesGridView.CurrentRow?.Cells[9].Value);
            }
        }

        #endregion

        #region Очистка полей

        private void ClearPasswordTextboxesButtonClick(object sender, EventArgs e)
        {
            //Очистить поля на вкладке смены пароля
            newUserPasswordTextbox.ResetText();
            confirmNewUserPasswordTextbox.ResetText();
        }

        private void ClearUsersTextboxesButtonClick(object sender, EventArgs e)
        {
            idUserTextbox.ResetText();
            lastNameUserTextbox.ResetText();
            firstNameUserTextbox.ResetText();
            middleNameUserTextbox.ResetText();
            userRoleComboBox.SelectedItem = 1;
            emailUserTextbox.ResetText();
            passwordUserTextbox.ResetText();
            confirmPasswordUserTextbox.ResetText();
        }

        private void ClearHistoryTextboxesButtonClick(object sender, EventArgs e)
        {
            historyIdTextbox.ResetText();
            historyUserTextbox.ResetText();
            historyMedicineNameTextbox.ResetText();
            historyWasQuantityTextbox.ResetText();
            historyIsQuantityTextbox.ResetText();
            historyDateTextbox.ResetText();
        }

        private void ClearMedicinesTextboxesButtonClick(object sender, EventArgs e)
        {
            medicineIdTextbox.ResetText();
            medicineNameTextbox.ResetText();
            medicinesTypeComboBox.SelectedIndex = 1;
            medicineManufacturerComboBox.SelectedIndex = 1;
            medicineQuantityTextbox.ResetText();
            medicinePriceTextbox.ResetText();
            medicineDescriptionTextbox.ResetText();
            medicineStructureTextbox.ResetText();
            medicineDiseasesTextbox.ResetText();
            medicineIsDrugCheckBox.Checked = false;
        }

        private void ClearMedicinesTypesTextboxesButtonClick(object sender, EventArgs e)
        {
            medicinesTypeIdTextbox.ResetText();
            medicinesTypeNameTextbox.ResetText();
        }

        private void ClearManufacturersTextboxesButtonClick(object sender, EventArgs e)
        {
            manufacturerIdTextbox.ResetText();
            manufacturerNameTextbox.ResetText();
        }

        #endregion

        #region Добавление и обновление

        private void SaveNewPasswordButtonClick(object sender, EventArgs e)
        {
            //Смена пароля аккаунта
            if (newUserPasswordTextbox.Text != "" && confirmNewUserPasswordTextbox.Text != "")
                if (newUserPasswordTextbox.Text == confirmNewUserPasswordTextbox.Text)
                {
                    try
                    {
                        using (var context = new WmsPharmacyContext())
                        {
                            //resharper говорит, что возможен null reference
                            //это действительно так, если программа будет
                            //запущена на 2 компьютерах одновременно, и кто-то удалит запись
                            //в другой таблице, в момент записи в эту

                            //но курсовой не требует использование транзакций
                            //и реализации работы нескольких пользователей с БД
                            var user = context.Users.FirstOrDefault
                                (u => u.Email == _userEmail);
                            user.Password = BCrypt.Net.BCrypt.HashPassword(newUserPasswordTextbox.Text);

                            context.SaveChanges();
                        }
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(@"Возникла техническая ошибка, попробуйте позже");
                        Logger.Error(exception);
                    }
                }
                else
                {
                    MessageBox.Show(@"Пароли не совпали", @"Ошибка");
                    ClearPasswordTextboxesButtonClick(sender, e);
                }
            else
                MessageBox.Show(@"Вы не заполнили поля", @"Ошибка");
        }

        //Код создания объекта везде примерно одинаковый
        //Если Id нет значит создаем новую запись,
        //Если Id есть значит изменяем существующую
        //Далее везде аналогично

        private void SaveMedicinesTypeButtonClick(object sender, EventArgs e)
        {
            if (medicinesTypeNameTextbox.Text.Length > 0)
            {
                var medicineType = new MedicinesTypes
                {
                    MedicinesTypeName = medicinesTypeNameTextbox.Text
                };
                
                if (medicinesTypeIdTextbox.Text == "")
                {
                    Insert(medicineType);
                }
                else
                {
                    medicineType.Id = int.Parse(medicinesTypeIdTextbox.Text);
                    Update(medicineType);
                }

                ClearMedicinesTypesTextboxesButtonClick(sender, e);
                UpdateDataInMedicinesTypeGridView();
            }
            else
            {
                MessageBox.Show(@"Вы заполнили не все поля");
            }
        }

        private void SaveManufacturerButtonClick(object sender, EventArgs e)
        {
            if (manufacturerNameTextbox.Text.Length > 0)
            {
                var manufacturer = new Manufacturers
                {
                    ManufacturerName = manufacturerNameTextbox.Text
                };

                if (manufacturerIdTextbox.Text == "")
                {
                    Insert(manufacturer);
                }
                else
                {
                    manufacturer.Id = int.Parse(manufacturerIdTextbox.Text);
                    Update(manufacturer);
                }

                UpdateDataInManufacturerGridView();
                ClearManufacturersTextboxesButtonClick(sender, e);
            }
            else
            {
                MessageBox.Show(@"Вы заполнили не все поля");
            }
        }

        private void SaveUserButtonClick(object sender, EventArgs e)
        {
            if (emailUserTextbox.Text.Length > 0
                && firstNameUserTextbox.Text.Length > 0
                && lastNameUserTextbox.Text.Length > 0
                && passwordUserTextbox.Text.Length > 0
                && confirmPasswordUserTextbox.Text.Length > 0)
            {
                var user = new Users
                {
                    Email = emailUserTextbox.Text,
                    FirstName = firstNameUserTextbox.Text,
                    LastName = lastNameUserTextbox.Text,
                    MiddleName = middleNameUserTextbox.Text,

                    //resharper говорит, что возможен null reference
                    //это действительно так, если программа будет
                    //запущена на 2 компьютерах одновременно, и кто-то удалит запись
                    //в другой таблице, в момент записи в эту

                    //но курсовой не требует использование транзакций
                    //и реализации работы нескольких пользователей с БД
                    UserRole = new WmsPharmacyContext().UserRoles
                        .SingleOrDefault(roles => roles.NameRole == userRoleComboBox.Text).Id
                };

                //Какой пароль будет записан, старый или новый
                if (passwordUserTextbox.Text == confirmPasswordUserTextbox.Text)
                {
                    if (idUserTextbox.Text == "")
                    {
                        //Это новая запись
                        user.Password = BCrypt.Net.BCrypt.HashPassword(passwordUserTextbox.Text);
                        Insert(user);
                    }
                    else
                    {
                        //Это существующая запись
                        user.Id = int.Parse(idUserTextbox.Text);

                        //Получаем старый пароль
                        var oldPassword = new WmsPharmacyContext().Users
                            .SingleOrDefault(x => x.Id == user.Id)
                            ?.Password;

                        //Если хеш пароля совпадает с texbox,
                        //Значит пароль не менялся,
                        //Если нет, будет записан новый пароль

                        user.Password = oldPassword == passwordUserTextbox.Text
                            ? oldPassword
                            : BCrypt.Net.BCrypt.HashPassword(passwordUserTextbox.Text);

                        Update(user);
                    }
                }
                else
                {
                    MessageBox.Show(@"Пароли не совпадают");
                }

                UpdateDataInUsersGridView();
                ClearUsersTextboxesButtonClick(sender, e);
            }
            else
            {
                MessageBox.Show(@"Вы заполнили не все поля");
            }
        }

        private void SaveMedicineButtonClick(object sender, EventArgs e)
        {
            if (medicineNameTextbox.Text.Length > 0
                && medicineDescriptionTextbox.Text.Length > 0
                && medicineDiseasesTextbox.Text.Length > 0
                && medicineStructureTextbox.Text.Length > 0
                && medicinePriceTextbox.Text.Length > 0
                && medicineQuantityTextbox.Text.Length > 0)
            {
                var medicine = new Medicines
                {
                    MedicineName = medicineNameTextbox.Text,
                    Description = medicineDescriptionTextbox.Text,
                    Diseases = medicineDiseasesTextbox.Text,
                    Structure = medicineStructureTextbox.Text,
                    Price = double.Parse(medicinePriceTextbox.Text),
                    Quantity = int.Parse(medicineQuantityTextbox.Text),

                    //Resharper говорит, что возможен null reference
                    //Это действительно так, если программа будет
                    //Запущена на 2 компьютерах одновременно, и кто-то удалит запись
                    //В другой таблице, в момент записи в эту

                    //Но курсовой не требует использование транзакций
                    //И реализации работы нескольких пользователей с БД
                    MedicinesType = new WmsPharmacyContext().MedicinesTypes.FirstOrDefault(medicinesTypes =>
                        medicinesTypes.MedicinesTypeName == medicinesTypeComboBox.Text).Id,
                    Manufacturer = new WmsPharmacyContext().Manufacturers.SingleOrDefault(manufacturer =>
                        manufacturer.ManufacturerName == medicineManufacturerComboBox.Text).Id,

                    IsDrug = medicineIsDrugCheckBox.Checked
                };

                if (medicineIdTextbox.Text == "")
                {
                    Insert(medicine);
                }
                else
                {
                    medicine.Id = int.Parse(medicineIdTextbox.Text);
                    Update(medicine);
                }

                UpdateDataInMedicinesGridView();
                ClearMedicinesTextboxesButtonClick(sender, e);
            }
            else
            {
                MessageBox.Show(@"Вы заполнили не все поля");
            }
        }

        public static void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                using (var context = new WmsPharmacyContext())
                {
                    context.Entry(entity).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
            }
        }

        public static void Update<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                using (var context = new WmsPharmacyContext())
                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
            }
        }

        #endregion

        #region Чтение из базы

        //Получение таблицы из бд, если аргумент пустой, будет получена вся таблица,
        //Если аргумент не пустой, будет получена часть таблицы, содержащая аргумент
        //Это реализация полнотекстового поиска
        //Entity Frameword 6 его не поддерживает, но SQL server поддерживает
        private DataTable GetMedicinesFromDb(string searchString = "")
        {
            try
            {
                using (var context = new WmsPharmacyContext())
                {
                    return DataTableHelper.ToDataTable(
                        (from medicines in context.Medicines
                            join medicinesTypes in context.MedicinesTypes
                                on medicines.MedicinesType equals medicinesTypes.Id
                            join manufacturer in context.Manufacturers
                                on medicines.Manufacturer equals manufacturer.Id
                            select new
                            {
                                medicines.Id,
                                medicines.MedicineName,
                                manufacturer.ManufacturerName,
                                medicinesTypes.MedicinesTypeName,
                                medicines.Quantity,
                                medicines.Price,
                                medicines.Description,
                                medicines.Structure,
                                medicines.Diseases,
                                medicines.IsDrug
                            }).Where(medicines => (medicines.Id +
                                                   medicines.MedicineName +
                                                   medicines.ManufacturerName +
                                                   medicines.MedicinesTypeName +
                                                   medicines.Quantity +
                                                   medicines.Price +
                                                   medicines.Description +
                                                   medicines.Structure +
                                                   medicines.Diseases +
                                                   medicines.IsDrug)
                            .Contains(searchString)).AsNoTracking().ToList());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
                return null;
            }
        }

        private DataTable GetUsersFromDb(string searchString = "")
        {
            try
            {
                using (var context = new WmsPharmacyContext())
                {
                    return DataTableHelper.ToDataTable(
                        (from users in context.Users
                            join userRoles in context.UserRoles on users.UserRole equals userRoles.Id
                            select new
                            {
                                users.Id,
                                users.LastName,
                                users.FirstName,
                                users.MiddleName,
                                userRoles.NameRole,
                                users.Email,
                                users.Password
                            }).Where(users => (users.Id +
                                               users.LastName +
                                               users.FirstName +
                                               users.MiddleName +
                                               users.NameRole +
                                               users.Email +
                                               users.Password)
                            .Contains(searchString)).AsNoTracking().ToList());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
                return null;
            }
        }

        private DataTable GetHistoryFromDb(string searchString = "")
        {
            try
            {
                using (var context = new WmsPharmacyContext())
                {
                    return DataTableHelper.ToDataTable(
                        (from history in context.History
                            join medicines in context.Medicines
                                on history.Medicines equals medicines.Id
                            join users in context.Users
                                on history.UserName equals users.Id
                            select new
                            {
                                history.Id,
                                users.FirstName,
                                medicines.MedicineName,
                                history.WasQuantity,
                                history.HasQuantity,
                                history.DateOfChange
                            }).Where(history => (history.Id +
                                                 history.FirstName +
                                                 history.MedicineName +
                                                 history.WasQuantity +
                                                 history.HasQuantity +
                                                 history.DateOfChange)
                            .Contains(searchString)).AsNoTracking().ToList());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
                return null;
            }
        }

        private DataTable GetManufacturersFromDb(string searchString = "")
        {
            try
            {
                using (var context = new WmsPharmacyContext())
                {
                    return DataTableHelper.ToDataTable(
                        (from manufacturers in context.Manufacturers
                            select new
                            {
                                manufacturers.Id,
                                manufacturers.ManufacturerName
                            }).Where(manufacturers => (manufacturers.Id +
                                                       manufacturers.ManufacturerName)
                            .Contains(searchString)).AsNoTracking().ToList());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
                return null;
            }
        }

        private DataTable GetMedicinesTypesFromDb(string searchString = "")
        {
            try
            {
                using (var context = new WmsPharmacyContext())
                {
                    return DataTableHelper.ToDataTable(
                        (from medicinesTypes in context.MedicinesTypes
                            select new
                            {
                                medicinesTypes.Id,
                                medicinesTypes.MedicinesTypeName
                            }).Where(medicinesTypes => (medicinesTypes.Id +
                                                        medicinesTypes.MedicinesTypeName)
                            .Contains(searchString)).AsNoTracking().ToList());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
                return null;
            }
        }

        #endregion

        #region Удаление

        //Обобщенный метод удаления по id
        private void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                using (var context = new WmsPharmacyContext())
                {
                    context.Entry(entity).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Нельзя удалить данную запись, она используется в другой таблице");
                Logger.Error(exception);
            }
        }

        private void DeleteUserButtonClick(object sender, EventArgs e)
        {
            if (idUserTextbox.Text != "")
            {
                var user = new Users {Id = int.Parse(idUserTextbox.Text)};
                Delete(user);

                UpdateDataInUsersGridView();
                ClearUsersTextboxesButtonClick(sender, e);
            }
            else
            {
                MessageBox.Show("Вы не выбрали, что хотите удалить");
            }
        }

        private void DeleteMedicinesTypeButtonClick(object sender, EventArgs e)
        {
            if (medicinesTypeIdTextbox.Text != "")
            {
                var medicinesTypes = new MedicinesTypes {Id = int.Parse(medicinesTypeIdTextbox.Text)};
                Delete(medicinesTypes);

                UpdateDataInMedicinesTypeGridView();
                ClearMedicinesTextboxesButtonClick(sender, e);
            }
            else
            {
                MessageBox.Show("Вы не выбрали, что хотите удалить");
            }
        }

        private void DeleteMedicineButtonClick(object sender, EventArgs e)
        {
            if (medicineIdTextbox.Text != "")
            {
                var medicines = new Medicines {Id = int.Parse(medicineIdTextbox.Text)};
                Delete(medicines);

                UpdateDataInMedicinesGridView();
                ClearMedicinesTextboxesButtonClick(sender, e);
            }
            else
            {
                MessageBox.Show("Вы не выбрали, что хотите удалить");
            }
        }

        private void DeleteManufacturerButtonClick(object sender, EventArgs e)
        {
            if (manufacturerIdTextbox.Text != "")
            {
                var manufacturers = new Manufacturers {Id = int.Parse(manufacturerIdTextbox.Text)};
                Delete(manufacturers);

                UpdateDataInManufacturerGridView();
                ClearManufacturersTextboxesButtonClick(sender, e);
            }
            else
            {
                MessageBox.Show("Вы не выбрали, что хотите удалить");
            }
        }

        #endregion

        #region Поиск в таблицах

        private void SearchMedicinesButtonClick(object sender, EventArgs e)
        {
            //Поиск в таблице medicines
            UpdateDataInMedicinesGridView(searchMedicineTextbox.Text);
        }

        private void SearchUserButtonClick(object sender, EventArgs e)
        {
            //Поиск в таблице users
            UpdateDataInUsersGridView(searchUserTextbox.Text);
        }

        private void SearchManufacturerButtonClick(object sender, EventArgs e)
        {
            //Поиск в таблице manufacturers
            UpdateDataInManufacturerGridView(searchManufacturerTextbox.Text);
        }

        private void SearchMedicinesTypeButtonClick(object sender, EventArgs e)
        {
            //Поиск в таблице medicinestype
            UpdateDataInMedicinesTypeGridView(searchMedicinesTypeTextbox.Text);
        }

        private void SearchHistoryButtonClick(object sender, EventArgs e)
        {
            //Поиск в таблице history
            UpdateDataInHistoryGridView(searchHistoryTextbox.Text);
        }

        #endregion

        #region Экпорт в документы

        private void ExportInDocumentButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (sender is MaterialFlatButton button)
                {
                    var tagSplit = button.Tag.ToString().Split(',');

                    Enum.TryParse(tagSplit[0], out TypeOfDocument myStatus);

                    Export.ExportInDocument(ReturnTableByName(tagSplit[1]), tagSplit[1], myStatus,
                        Settings.Default.DocumentsPath);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Произошла ошибка, обратитесь к администратору");
                Logger.Error(exception);
            }
        }

        private DataTable ReturnTableByName(string className)
        {
            switch (className)
            {
                case "Medicines":
                {
                    return GetMedicinesFromDb();
                }

                case "Users":
                {
                    return GetMedicinesFromDb();
                }

                case "Manufacturer":
                {
                    return GetManufacturersFromDb();
                }

                case "MedicinesTypes":
                {
                    return GetMedicinesTypesFromDb();
                }

                case "History":
                {
                    return GetHistoryFromDb();
                }

                default:
                {
                    throw new ArgumentException("Недопустимый код операции");
                }
            }
        }

        #endregion
    }
}