using System;
using System.Windows.Forms;
using WMSPharmacy.Properties;
using NLog;
using WMSPharmacy.Helpers;
using WMSPharmacy.Model;

namespace WMSPharmacy.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        //Логгер
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            //БД
            adressDBTextbox.Text = Settings.Default.AdressDB;
            nameDBTextbox.Text = Settings.Default.NameDB;
            loginDBTextbox.Text = Settings.Default.LoginDB;
            passwordDBTextbox.Text = Settings.Default.PasswordDB;
        }

        private void SaveDbButtonClick(object sender, EventArgs e)
        {
            //Смена БД
            try
            {
                Settings.Default.AdressDB = adressDBTextbox.Text;
                Settings.Default.NameDB = nameDBTextbox.Text;
                Settings.Default.LoginDB = loginDBTextbox.Text;
                Settings.Default.PasswordDB = passwordDBTextbox.Text;
                Settings.Default.Save();

                Logger.Info("Смена настроек БД");
            }
            catch (Exception)
            {
                Logger.Error("Ошибка смены БД");
            }
        }

        private void MinimizeButtonClick(object sender, EventArgs e)
        {
            //Сворачивание приложения
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            //Возврат на авторизацию
            Hide();
            Form loginForm = Application.OpenForms[1];
            loginForm.Show();
        }

        private void CreateDbButtonClick(object sender, EventArgs e)
        {
            var seedData = new SeedData(new WmsPharmacyContext());

            MessageBox.Show("База данных создана.");
        }
    }
}