using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace BankSystemApp.UI.Views
{
    class MainViewModel : BindableBase
    {
        public Localization.CurrentLanguage currentLanguage = Classes.StaticModel.currentLanguage;
        public DarkModLogic.DarkMod darkMod { get; set; } = Views.DM;
        Classes.Connection connection = Classes.StaticModel.Connection;
        public Components.LanguageAnimationsParam languageAnimations { get; set; } = Classes.StaticModel.languageAnimations;
        public Classes.Connection Connection { get { return connection; } set { connection = value; 
                RaisePropertyChanged("Connection"); RaisePropertyChanged("CurrentViewModel"); } }

        //public double Height { 
        //    get { return Components.LanguageAnimationsParam.h; } 
        //    set { Components.LanguageAnimationsParam.h = value; RaisePropertyChanged("Height"); } }

        public Components.LangSwitcher langView { get; set; } = new Components.LangSwitcher();
        IView currentViewModel = Views.homePage;
        public IView CurrentViewModel { get { return currentViewModel; } set { currentViewModel = value; RaisePropertyChanged("CurrentViewModel"); } }

        public ICommand GitHub_btn_click
        {
            get { return new CommandHandler(() => Process.Start("https://github.com/UnluckyD/SkillBox_19"), () => true); }
        }

        public ICommand Login_btn_click
        {
            get { return new CommandHandler(() => CurrentViewModel = Views.View, () => Classes.StaticModel.model.CanExecute); }
        }
        public ICommand LangAnimation
        {
            get 
            { return new CommandHandler(() => 
                {
                    languageAnimations.StartAnimation();
                }, () => Classes.StaticModel.model.CanExecute);
            }
        }

        public ICommand Home_btn_click
        {
            get { return new CommandHandler(() => CurrentViewModel = Views.homePage, () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand Clients_btn_click
        {
            get { return new CommandHandler(() => {
                if (Classes.StaticModel.Connection.Role >= DataAccess.Role.EMPLOYEE)
                    CurrentViewModel = Views.clientsVM;
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный.\nВаш: {Classes.StaticModel.Connection.Role}");
            }, () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand Credits_btn_click
        {
            get { return new CommandHandler(() =>
            {
                if (Classes.StaticModel.Connection.Role >= DataAccess.Role.EMPLOYEE)
                    CurrentViewModel = Views.credits;
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный.\nВаш: {Classes.StaticModel.Connection.Role}");
            }, () => Classes.StaticModel.model.CanExecute); }
        }
        public ICommand Contributions_btn_click
        {
            get { return new CommandHandler(() =>
            {
                if (Classes.StaticModel.Connection.Role >= DataAccess.Role.EMPLOYEE)
                    CurrentViewModel = Views.contributions;
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный.\nВаш: {Classes.StaticModel.Connection.Role}");
            }, () => Classes.StaticModel.model.CanExecute); }
        }

        public ICommand Settings_btn_click
        {
            get { return new CommandHandler(() => CurrentViewModel = Views.settingsView, () => Classes.StaticModel.model.CanExecute); }
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
