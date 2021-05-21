using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankSystemApp.DataAccess;
using System.Windows.Input;

namespace BankSystemApp.UI.Views
{
    class ViewModelCreator : BindableBase
    {
        public Classes.Model model = new Classes.Model();
        ClientsDB client = new ClientsDB();
        public ClientsDB Client { get { return client; } set { client = value; RaisePropertyChanged("Client"); } }

        public ICommand AddClient_btn
        {
            get { return new CommandHandler(() => model.AddClient(Client), () => model.CanExecute); }
        }
    }
}
