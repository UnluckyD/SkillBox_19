﻿using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mikhail__Moschenkov_19.Classes
{
    class ViewModelCreator : BindableBase
    {
        public Model model = new Model();
        ClientsDB client = new ClientsDB();
        public ClientsDB Client { get { return client; } set { client = value; RaisePropertyChanged("Client"); } }

        public ICommand AddClient_btn
        {
            get { return new CommandHandler(() => model.AddClient(Client), () => model.CanExecute); }
        }
    }
}
