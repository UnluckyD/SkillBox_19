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
                return new CommandHandler(() => {
                    Classes.StaticModel.model.Connection(strConnection);

                    if (Classes.StaticModel.model.CanExecute)
                        Classes.StaticModel.Connection.IsConnected = true;
                    else
                        Classes.StaticModel.Connection.IsConnected = false;
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }

        public ICommand btn_disconnect
        {
            get
            {
                return new CommandHandler(() => {
                    Classes.StaticModel.model.Disconnect();
                    Classes.StaticModel.Connection.IsConnected = false;
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
