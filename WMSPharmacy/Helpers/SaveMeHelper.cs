using System;
using System.Windows.Forms;
using Microsoft.Win32;
using NLog;

namespace WMSPharmacy.Helpers
{
    internal class SaveMeHelper
    {
        //Логер
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        //Учебный проект
        //Да, я храню пароли в открытом доступе в реестре
        //Да, я понимаю, что такое безопасность

        public (string login, string password) ReadUserFromRegistry()
        {
            //Чтение данных из реестра
            string login = null;
            string password = null;

            try
            {
                using (RegistryKey userData = Registry.CurrentUser.OpenSubKey("WMSPharmacy"))
                {
                    if (userData != null)
                    {
                        login = userData.GetValue("login").ToString();
                        password = userData.GetValue("password").ToString();
                        userData.Close();
                    }
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
            }

            return (login, password);
        }

        public void RememberUser(string login, string password)
        {
            //Запись данных в реестр
            try
            {
                using (RegistryKey userData = Registry.CurrentUser.CreateSubKey("WMSPharmacy"))
                {
                    userData.SetValue("login", login);
                    userData.SetValue("password", password);
                    userData.Close();
                }
            }
            catch (Exception exception)
            {
                Logger.Error(exception);
            }
        }

        public void EraseUser()
        {
            //Удаление данных из реестра
            try
            {
                Registry.CurrentUser.DeleteSubKey("WMSPharmacy", true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(@"Не удалось стереть пользователя", @"Ошибка", MessageBoxButtons.OK);
                Logger.Error(exception);
            }
        }
    }
}