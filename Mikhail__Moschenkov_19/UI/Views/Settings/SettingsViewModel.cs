using BankSystemApp.DataAccess;
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
        PermisionsSettings.PermitionsDBWindow window = new PermisionsSettings.PermitionsDBWindow();
        public Classes.Connection Connection { get; set; } = Classes.StaticModel.Connection;
        public DarkModLogic.DarkMod dMod { get; set; } = Views.DM;
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
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }

        public ICommand btn_disconnect
        {
            get
            {
                return new CommandHandler(() => {
                    Classes.StaticModel.model.Disconnect();
                    Classes.StaticModel.model.Clients = null;
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }

        public ICommand Roles_btn
        {
            get
            {
                return new CommandHandler(() => {
                    if (Classes.StaticModel.Connection.Role >= Role.ADMINISTRATOR)
                        window.Show();
                    else
                        Alerts.MsgWarning($"Выш уровень допуска недостаточный." +
                            $"\nВаш: {Classes.StaticModel.Connection.Role}\nТребуемый: {Role.ADMINISTRATOR}");
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }
    }
}
