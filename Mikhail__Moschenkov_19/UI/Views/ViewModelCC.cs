using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankSystemApp.DataAccess;
using System.Windows.Input;

namespace BankSystemApp.UI.Views
{
    class ViewModelCC : BindableBase // ViewModelCreditContribution
    {
        public Classes.Model model = new Classes.Model();
        ClientsDB client;
        DataAccess.Credit credit;
        DataAccess.Contribution contribution;
        public DateTime Date { get; set; }
        public ClientsDB Client { get { return client; } set { client = value; RaisePropertyChanged("Client"); } }
        public DataAccess.Credit Credit { get { return credit; } set { credit = value; RaisePropertyChanged("Credit"); } }
        public DataAccess.Contribution Contribution { get { return contribution; } set { contribution = value; RaisePropertyChanged("Contribution"); } }
        public bool capitalization { get; set; }
        public string CreditSum { get; set; }
        public ICommand Credit_btn_click
        {
            get { return new CommandHandler(() => model.GetCredit(Client, Credit, decimal.Parse(CreditSum)), () => model.CanExecute); }
        }

        public ICommand Contribution_btn_click
        {
            get { return new CommandHandler(() => model.GetContribution(Client, Contribution), () => model.CanExecute); }
        }
    }
}
