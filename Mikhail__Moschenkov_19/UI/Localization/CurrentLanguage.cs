using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.UI.Localization
{
    public class CurrentLanguage : BindableBase
    {
        string[] Localization = Languages.en_En;
        public string Login { get { return Localization[(int)WordsEnum.LOGIN]; } }
        public string Logout { get { return Localization[(int)WordsEnum.LOGOUT]; } }
        public string Home { get { return Localization[(int)WordsEnum.HOME]; } }
        public string Clients { get { return Localization[(int)WordsEnum.CLIENTS]; } }
        public string Account { get { return Localization[(int)WordsEnum.ACCOUNT]; } }
        public string Credits { get { return Localization[(int)WordsEnum.CREDIT]; } }
        public string Contributions { get { return Localization[(int)WordsEnum.CONTRIBUTION]; } }
        public string Settings { get { return Localization[(int)WordsEnum.SETTINGS]; } }
        public string Enter { get { return Localization[(int)WordsEnum.ENTER]; } }
        public string Sing_up { get { return Localization[(int)WordsEnum.SING_UP]; } }
        public string Sing_in { get { return Localization[(int)WordsEnum.SING_IN]; } }
        public string Connection_string { get { return Localization[(int)WordsEnum.CONNECTION_STRING]; } }
        public string Connection { get { return Localization[(int)WordsEnum.CONNECTION]; } }
        public string Diconnection { get { return Localization[(int)WordsEnum.DISCONNECTION]; } }
        public string Roles { get { return Localization[(int)WordsEnum.ROLES]; } }
        public string Theme { get { return Localization[(int)WordsEnum.THEME]; } }

        public void SetLanguage(string[] arr)
        {
            Localization = arr;
            RaisePropertyChanged("Localization");
            RaisePropertyChanged("Login");
            RaisePropertyChanged("Logout");
            RaisePropertyChanged("Home");
            RaisePropertyChanged("Clients");
            RaisePropertyChanged("Account");
            RaisePropertyChanged("Credits");
            RaisePropertyChanged("Contributions");
            RaisePropertyChanged("Settings");
            RaisePropertyChanged("Enter");
            RaisePropertyChanged("Sing_up");
            RaisePropertyChanged("Sing_in");
            RaisePropertyChanged("Connection_string");
            RaisePropertyChanged("Connection");
            RaisePropertyChanged("Diconnection");
            RaisePropertyChanged("Roles");
            RaisePropertyChanged("Theme");
            RaisePropertyChanged("CurrentLanguage");
        }
    }
}
