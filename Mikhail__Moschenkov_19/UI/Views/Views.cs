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
    class Views : INotifyPropertyChanged
    {
        public static DarkModLogic.DarkMod DM = new DarkModLogic.DarkMod();

        static LoginViewCP loginView = new LoginViewCP();
        static AllreadyLog allreadyLog = new AllreadyLog();

        public static ClientsViewModel clientsVM = new ClientsViewModel();
        public static SettingsView settingsView = new SettingsView();
        public static HomePage homePage = new HomePage();

        public event PropertyChangedEventHandler PropertyChanged;

        public static IView View { get { return GetCurrentView(); } }
        static IView GetCurrentView()
        {
            if (Classes.StaticModel.Connection.IsConnected)
                return allreadyLog;
            else
                return loginView;
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public void UpdateView()
        {
            OnPropertyChanged("View");
        }
    }
}
