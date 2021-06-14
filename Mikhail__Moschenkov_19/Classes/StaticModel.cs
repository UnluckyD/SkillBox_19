using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.Classes
{
    public static class StaticModel
    {
        public static Model model = new Model();
        public static UI.DarkModLogic.DarkMod DM = new UI.DarkModLogic.DarkMod();
        public static Connection Connection = new Connection();

        static UI.Views.LoginViewCP loginView = new UI.Views.LoginViewCP();
        static UI.Views.AllreadyLog allreadyLog = new UI.Views.AllreadyLog();
        public static IView View { get { return GetCurrentView(); } }

        static IView GetCurrentView()
        {
            if (Connection.IsConnected)
                return allreadyLog;
            else
                return loginView;
        }
    }
}
