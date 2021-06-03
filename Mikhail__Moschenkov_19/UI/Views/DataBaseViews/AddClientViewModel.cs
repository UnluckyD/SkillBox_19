using BankSystemApp.DataAccess;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BankSystemApp.UI.Views.DataBaseViews
{
    class AddClientViewModel : BindableBase
    {
        public Classes.Model model = new Classes.Model();
        public UI.DarkModLogic.DarkMod darkMod { get; set; } = Classes.StaticModel.DM;

        ClientsDB client = new ClientsDB();
        public ClientsDB Client { get { return client; } set { client = value; RaisePropertyChanged("Client"); } }

        public ICommand AddClient_btn
        {
            get { return new CommandHandler(() => {
                model.AddClient(Client);
                Client = new ClientsDB();
                }, () => model.CanExecute); }
        }
    }
}
