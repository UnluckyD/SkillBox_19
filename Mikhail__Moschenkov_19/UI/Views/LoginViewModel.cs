using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace BankSystemApp.UI.Views
{
    class LoginViewModel : BindableBase
    {
        string strConnection = string.Empty;
        public string StrConnection { get => strConnection; set => strConnection = value; }
        public UI.DarkModLogic.DarkMod darkMod { get; set; } = Classes.StaticModel.DM;

        public ICommand btn_connect
        {
            get
            {
                return new CommandHandler(() => Classes.StaticModel.model.Connection(strConnection), () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
