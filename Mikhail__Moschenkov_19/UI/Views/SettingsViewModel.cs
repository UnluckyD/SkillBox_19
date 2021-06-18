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
    class SettingsViewModel : BindableBase
    {
        public UI.DarkModLogic.DarkMod dMod { get; set; } = Views.DM;
        string strConnection = string.Empty;
        public string StrConnection { get => strConnection; set => strConnection = value; }
        public ICommand ChangeMod_btn_click
        {
            get
            {
                return new CommandHandler(() => dMod.ChangeMod(), () => Classes.StaticModel.model.CanExecute);
            }
        }

        public ICommand btn_connect
        {
            get
            {
                return new CommandHandler(() => {
                    Classes.StaticModel.model.Connection(strConnection);

                    //if (Classes.StaticModel.model.CanExecute)
                    //    Classes.StaticModel.Connection.IsConnected = true;
                    //else
                    //    Classes.StaticModel.Connection.IsConnected = false;
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }

        public ICommand btn_disconnect
        {
            get
            {
                return new CommandHandler(() => {
                    Classes.StaticModel.model.Disconnect();
                    //Classes.StaticModel.Connection.IsConnected = false;
                    Classes.StaticModel.model.Clients = null;
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
