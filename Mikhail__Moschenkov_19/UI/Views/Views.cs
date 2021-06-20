using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.UI.Views
{
    class Views
    {
        public static DarkModLogic.DarkMod DM = new DarkModLogic.DarkMod();

        static LoginViewCP loginView = new LoginViewCP();
        static AllreadyLog allreadyLog = new AllreadyLog();

        public static ClientsViewModel clientsVM = new ClientsViewModel();
        public static SettingsView settingsView = new SettingsView();
        public static Home.HomePage homePage = new Home.HomePage();
        public static Credits.CreditsView credits = new Credits.CreditsView();
        public static Contribution.ContributionsView contributions = new Contribution.ContributionsView();

        public static IView View { get { return GetCurrentView(); } }
        static IView GetCurrentView()
        {
            if (Classes.StaticModel.Connection.IsConnected)
                return allreadyLog;
            else
                return loginView;
        }
    }
}
