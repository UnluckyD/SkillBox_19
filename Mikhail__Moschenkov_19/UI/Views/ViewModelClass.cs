using Prism.Mvvm;
using BankSystemApp.DataAccess;
using System.Windows.Input;

namespace BankSystemApp.UI.Views
{
    public class ViewModelClass : BindableBase
    {
        public Classes.Model model { get; set; } = Classes.StaticModel.model;
        ClientsDB client;

        public ClientsDB TransferClient { get; set; }
        public ClientsDB Client { get { return client; } set { client = value; RaisePropertyChanged("Client"); } }
        public decimal TransferAmount { get; set; }

        public ICommand Add_window {
            get { return new CommandHandler(() => {
                if (Classes.StaticModel.Connection.Role >= Role.EMPLOYEE)
                    model.OpenAddWindow();
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный." +
                        $"\nВаш: {Classes.StaticModel.Connection.Role}\nТребуемый: {Role.EMPLOYEE}");
                }, () => model.CanExecute); }
        }
        public ICommand Edit_window
        {
            get { return new CommandHandler(() =>
            {
                if (Classes.StaticModel.Connection.Role >= Role.MANAGER)
                    model.EditMenu(Client);
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный." +
                        $"\nВаш: {Classes.StaticModel.Connection.Role}\nТребуемый: {Role.MANAGER}");
            }
            , () => model.CanExecute); }
        }

        public ICommand Delete_Client
        {
            get { return new CommandHandler(() =>
            {
                if (Classes.StaticModel.Connection.Role >= Role.MANAGER)
                    model.RemoveClient(Client);
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный." +
                        $"\nВаш: {Classes.StaticModel.Connection.Role}\nТребуемый: {Role.MANAGER}");
            }, () => model.CanExecute); }
        }

        public ICommand Transfer_window
        {
            get { return new CommandHandler(() =>
            {
                if (Classes.StaticModel.Connection.Role >= Role.EMPLOYEE)
                    model.TransferMenu(Client);
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный." +
                        $"\nВаш: {Classes.StaticModel.Connection.Role}\nТребуемый: {Role.EMPLOYEE}");
            }, () => model.CanExecute); }
        }
        public ICommand Credit_window
        {
            get { return new CommandHandler(() =>
            {
                if (Classes.StaticModel.Connection.Role >= Role.EMPLOYEE)
                    model.CreditMenu(Client);
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный." +
                        $"\nВаш: {Classes.StaticModel.Connection.Role}\nТребуемый: {Role.EMPLOYEE}");
            }, () => model.CanExecute); }
        }
        public ICommand Contribution_window
        {
            get { return new CommandHandler(() =>
            {
                if (Classes.StaticModel.Connection.Role >= Role.EMPLOYEE)
                    model.ContributionMenu(Client);
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный." +
                        $"\nВаш: {Classes.StaticModel.Connection.Role}\nТребуемый: {Role.EMPLOYEE}");
            }, () => model.CanExecute); }
        }

        public ICommand Transfer_btn_click
        {
            get { return new CommandHandler(() =>
            {
                if (Classes.StaticModel.Connection.Role >= Role.EMPLOYEE)
                    model.transfer_btn_click(TransferClient, Client, TransferAmount);
                else
                    Alerts.MsgWarning($"Выш уровень допуска недостаточный." +
                        $"\nВаш: {Classes.StaticModel.Connection.Role}\nТребуемый: {Role.EMPLOYEE}");
            }, () => model.CanExecute); }
        }
    }
}
