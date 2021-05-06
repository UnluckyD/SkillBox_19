using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mikhail__Moschenkov_19.Classes
{
    class ViewModelCE : BindableBase // Client Editor
    {
        Model model = new Model();
        ClientsDB client;
        public ClientsDB Client { get { return client; } set { client = value; RaisePropertyChanged("Client"); } }
        public ClientsDB ClientCopy { get; set; } = new ClientsDB();
        public ICommand Cancel_btn_click
        {
            get { return new CommandHandler(() => model.returnChanges(ClientCopy, Client), () => model.CanExecute); }
        }

        public void Copy(ClientsDB client)
        {
            this.ClientCopy.account = client.account;
            this.ClientCopy.contributionID = client.contributionID;
            this.ClientCopy.creditID = client.creditID;
            this.ClientCopy.excomes = client.excomes;
            this.ClientCopy.firstName = client.firstName;
            this.ClientCopy.Id = client.Id;
            this.ClientCopy.incomes = client.incomes;
            this.ClientCopy.isBanned = client.isBanned;
            this.ClientCopy.isLegal = client.isLegal;
            this.ClientCopy.isVip = client.isVip;
            this.ClientCopy.lastName = client.lastName;
            this.ClientCopy.middleName = client.middleName;
            this.ClientCopy.pasport = client.pasport;
        }
    }
}
