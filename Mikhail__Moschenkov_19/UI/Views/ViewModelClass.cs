using Catel.MVVM;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystemApp.DataAccess;
using System.Windows.Input;
using System.Diagnostics;

namespace BankSystemApp.UI.Views
{
    class ViewModelClass : BindableBase
    {
        public Classes.Model model { get; set; } = new Classes.Model();
        ClientsDB client;
        public BindableBase CurrentViewModel { get; set; }

        string strConnection = string.Empty;
        public string StrConnection { get => strConnection; set => strConnection = value; }

        public ClientsDB TransferClient { get; set; }
        public ClientsDB Client { get { return client; } set { client = value; RaisePropertyChanged("Client"); } }
        public decimal TransferAmount { get; set; }

        public ICommand btn_connect { 
            get { return new CommandHandler(() => model.Connection(strConnection), () => model.CanExecute);
            }
        }

        public ICommand Add_window {
            get { return new CommandHandler(() => model.OpenAddWindow(), () => model.CanExecute); }
        }
        public ICommand Edit_window
        {
            get { return new CommandHandler(() => model.EditMenu(Client), () => model.CanExecute); }
        }

        public ICommand Delete_Client
        {
            get { return new CommandHandler(() => model.RemoveClient(Client), () => model.CanExecute); }
        }

        public ICommand Transfer_window
        {
            get { return new CommandHandler(() => model.TransferMenu(Client), () => model.CanExecute); }
        }
        public ICommand Credit_window
        {
            get { return new CommandHandler(() => model.CreditMenu(Client), () => model.CanExecute); }
        }
        public ICommand Contribution_window
        {
            get { return new CommandHandler(() => model.ContributionMenu(Client), () => model.CanExecute); }
        }

        public ICommand Transfer_btn_click
        {
            get { return new CommandHandler(() => model.transfer_btn_click(TransferClient,Client, TransferAmount), () => model.CanExecute); }
        }

        public ICommand GitHub_btn_click
        {
            get { return new CommandHandler(() => Process.Start("https://github.com/UnluckyD/SkillBox_19"), () => model.CanExecute); }
        }
    }
}
