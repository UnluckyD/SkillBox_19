using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;

namespace BankSystemApp.UI.Views
{
    class MainViewModel : BindableBase
    {
        public UI.DarkModLogic.DarkMod darkMod { get; set; } = Classes.StaticModel.DM;
        public Classes.Connection connection { get; set; } = Classes.StaticModel.Connection;

        ClientsViewModel clientsVM = new ClientsViewModel();
        SettingsView settingsView = new SettingsView();
        static HomePage homePage = new HomePage();

        IView currentViewModel = homePage;
        public IView CurrentViewModel { get { return currentViewModel; } set { currentViewModel = value; RaisePropertyChanged("CurrentViewModel"); } }

        public ICommand GitHub_btn_click
        {
            get { return new CommandHandler(() => Process.Start("https://github.com/UnluckyD/SkillBox_19"), () => true); }
        }

        public ICommand Login_btn_click
        {
            get { return new CommandHandler(() => CurrentViewModel = Classes.StaticModel.View, () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand Home_btn_click
        {
            get { return new CommandHandler(() => CurrentViewModel = homePage, () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand Clients_btn_click
        {
            get { return new CommandHandler(() => {
                if (Classes.StaticModel.Connection.PermissionLvl >= 3)
                    CurrentViewModel = clientsVM;
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный.\nВаш: {Classes.StaticModel.Connection.PermissionLvl}");
            }, () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand Settings_btn_click
        {
            get { return new CommandHandler(() => CurrentViewModel = settingsView, () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand CloseApp_btn_click
        {
            get { return new CommandHandler(() => System.Windows.Application.Current.Shutdown(), () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand MinimazeApp_btn_click
        {
            get { return new CommandHandler(() => System.Windows.Application.Current.MainWindow.WindowState = System.Windows.WindowState.Minimized, () => Classes.StaticModel.model.CanExecute); }
        }
    }
}
