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
        bool isConnected = false;
        public bool IsConnected { get { return isConnected; } set { isConnected = value; 
                RaisePropertyChanged("IsConnected"); 
                RaisePropertyChanged("Status"); 
                RaisePropertyChanged("ConnectionInfo"); } }

        public string Status { get { return IsConnected ? "Sign Out" : "Login"; } }

        public string ConnectionInfo { get { return StaticModel.model.GetConnectionInfo(); } }
    }
}
