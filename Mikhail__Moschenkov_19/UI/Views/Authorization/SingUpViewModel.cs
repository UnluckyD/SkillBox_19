using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankSystemApp.UI.Views.Authorization
{
    class SingUpViewModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public DarkModLogic.DarkMod darkMod { get; set; } = Classes.StaticModel.DM;
        Classes.Model model { get; set; } = Classes.StaticModel.model;
        public ICommand SingUp_btn_click
        {
            get
            {
                return new CommandHandler(() => { model.SingUpUser(Login, Password); }, () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
