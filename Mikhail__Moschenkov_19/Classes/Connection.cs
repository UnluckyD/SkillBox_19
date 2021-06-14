using BankSystemApp.DataAccess;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.Classes
{
    public class Connection : BindableBase
    {
        Authorization user = new Authorization() { 
            Login = "guest"
        };
        bool isConnected = false;
        public bool IsConnected { get { return isConnected; } set { isConnected = value; 
                RaisePropertyChanged("IsConnected"); 
                RaisePropertyChanged("Status"); 
                RaisePropertyChanged("ConnectionInfo"); } }

        public string Status { get { return IsConnected ? "Logout" : "Login"; } }

        public string ConnectionInfo { get { return StaticModel.model.GetConnectionInfo(user); } }

        public int PermissionLvl { get { return user.Permission; } }

        public bool Authorization(string login, string pass)
        {
            try
            {
                var User = Classes.StaticModel.model.Authorization.FirstOrDefault(u => u.Login.Trim(' ') == login && u.Password.Trim(' ') == pass);
                if (User != null)
                {
                    user = User;
                    return true;
                }
                else {
                    Alerts.MsgWarning("Не нашлось ни одного совпадения логина и пароля");
                    return false; 
                }
            }catch (Exception ex)
            {
                Alerts.MsgError($"Не удалось авторизироваться.\nCode:\n{ex}");
                return false;
            }
        }
    }
}
