using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankSystemApp.UI.Views.Authorization
{
    class LoginViewModel
    {
        public Localization.CurrentLanguage currentLanguage = Classes.StaticModel.currentLanguage;
        public string Login { get; set; }
        public string Password { get; set; }
        public DarkModLogic.DarkMod darkMod { get; set; } = Views.DM;

        Classes.Connection connection { get; set; } = Classes.StaticModel.Connection;

        public ICommand LogIn_btn_click
        {
            get
            {
                return new CommandHandler(() => {
                    if (connection.Authorization(Login, Password))
                    {
                        Password = "";
                        connection.IsConnected = true;
                    }
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
