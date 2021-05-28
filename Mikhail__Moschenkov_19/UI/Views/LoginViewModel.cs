using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankSystemApp.UI.Views
{
    class LoginViewModel
    {
        string strConnection = string.Empty;
        public string StrConnection { get => strConnection; set => strConnection = value; }

        public ICommand btn_connect
        {
            get
            {
                return new CommandHandler(() => Classes.StaticModel.model.Connection(strConnection), () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
