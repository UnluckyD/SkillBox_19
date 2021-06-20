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
        Authorization user = new Authorization()
        {
            Login = "guest"
        };

        public Authorization User { get { return user; } 
            private set { user = value; 
                RaisePropertyChanged("User");
                RaisePropertyChanged("ConnectionInfo");
                RaisePropertyChanged("ConnectionFullInfo");
            } } 

        bool isConnected = false;
        public bool IsConnected { get { return isConnected; } set { isConnected = value; 
                RaisePropertyChanged("IsConnected"); 
                RaisePropertyChanged("Status"); 
                RaisePropertyChanged("ConnectionFullInfo");
                RaisePropertyChanged("IsConnectedAsAdmin");
                RaisePropertyChanged("ConnectionInfo"); } }

        public bool IsConnectedAsAdmin { get { return (isConnected && user.role == Role.ADMINISTRATOR); } }

        public string Status { get { return IsConnected ? "Logout" : "Login"; } }

        public string ConnectionInfo { get { return StaticModel.model.GetConnectionInfo(user); } }
        public string ConnectionFullInfo { get { return StaticModel.model.GetConnectionFullInfo(user); } }

        //public int PermissionLvl { get { return User.Permission; } }
        public Role Role { get { return User.role; } }

        public bool Authorization(string login, string pass)
        {
            try
            {
                var _User = Classes.StaticModel.model.Authorization.FirstOrDefault(u => u.Login.Trim(' ') == login && u.Password.Trim(' ') == pass);
                if (_User != null)
                {
                    User = _User;
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

        public bool LogOut()
        {
            try
            {
                User = new Authorization()
                {
                    Login = "guest"
                };
                IsConnected = false;
                return true;
            }
            catch (Exception ex)
            {
                Alerts.MsgError(ex.Message);
                return false;
            }
        }
    }
}
