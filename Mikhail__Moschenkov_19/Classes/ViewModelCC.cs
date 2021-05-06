using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mikhail__Moschenkov_19
{
    class ViewModelCC : BindableBase // ViewModelCreditContribution
    {
        public Model model = new Model();
        ClientsDB client;
        Credit credit;
        Contribution contribution;
        public DateTime Date { get; set; }
        public ClientsDB Client { get { return client; } set { client = value; RaisePropertyChanged("Client"); } }
        public Credit Credit { get { return credit; } set { credit = value; RaisePropertyChanged("Credit"); } }
        public Contribution Contribution { get { return contribution; } set { contribution = value; RaisePropertyChanged("Contribution"); } }
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
