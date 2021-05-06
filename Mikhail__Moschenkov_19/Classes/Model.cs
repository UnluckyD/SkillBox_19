using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MsgBoxAlertClass;
using System.Linq;

namespace Mikhail__Moschenkov_19
{
    public class Model : BindableBase
    {
        Interfaces.IRepository<ClientsDB,Credit,Contribution> repository;

        IEnumerable<ClientsDB> clients;
        IEnumerable<Credit> credits;
        IEnumerable<Contribution> contributions;

        public IEnumerable<ClientsDB> Clients { get { return clients; } set { clients = value; RaisePropertyChanged("Clients"); } }
        public IEnumerable<Credit> Credits { get { return credits; } set { credits = value; RaisePropertyChanged("Credits"); } }
        public IEnumerable<Contribution> Contributions { get { return contributions; } set { contributions = value; RaisePropertyChanged("Contributions"); } }

        public bool Transfer(ClientsDB client1, ClientsDB client2, decimal transfer)
        {
            try
            {
                if (!client1.isBanned && !client2.isBanned)
                {
                    client1.account -= transfer;
                    client1.excomes++;
                    client2.account += transfer;
                    client2.incomes++;

                    if ((int)client1.excomes > 9) client1.isBanned = true;
                    if ((int)client2.incomes > 9) client2.isBanned = true;
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                Alerts.MsgError($"Ошибка при переводе средств:\n{ex.Message}");
                return false;
            }
        }

        
        public void transfer_btn_click(ClientsDB client, ClientsDB SelectedItem, decimal transfer_sum)
        {
            try
            {
                if (SelectedItem != null)
                {
                    if (Transfer(client, SelectedItem, transfer_sum))
                        Alerts.MsgWarning("Один из пользователей заблокирован или возникла ошибка!");
                    if (repository != null)
                        repository.Save();
                }
            }
            catch (Exception ex)
            {
                Alerts.MsgError(ex.Message);
            }
        }

        public void ConnectByStr(string strConnections)
        {
            try
            {
                SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder(strConnections);
                repository = new Classes.SQLRepository(sqlConnectionString.ConnectionString);
                LoadDB();
            }catch (Exception ex)
            {
                Alerts.MsgError($"Ошибка при подключении по строке:\n{ex.Message}");
            }
        }

        void LoadDB()
        {
            try
            {
                if(Clients == null)
                    repository.Load();

                Clients = repository.GetDBClients();
                Credits = repository.GetDBCredits();
                Contributions = repository.GetDBContributions();
            }
            catch(Exception ex)
            {
                Alerts.MsgError($"Ошибка при загрузке БД:\n{ex.Message}");
            }
        }
        public void Connect()
        {
            try
            {
                repository = new Classes.SQLRepository();
            }
            catch (Exception ex)
            {
                Alerts.MsgError($"Ошибка при подключении:\n{ex.Message}");
            }
            LoadDB();
        }

        public bool CanExecute
        {
            get
            {
                return this != null;
            }
        }

        public void Connection(string strConnection)
        {
            if (strConnection != string.Empty)
                ConnectByStr(strConnection);
            else
                Connect();
        }

        public void OpenAddWindow()
        {
            AddWindow add = new AddWindow(this);
            add.ShowDialog();
        }
        public void AddClient(ClientsDB client)
        {
            try
            {
                if (repository != null)
                    repository.CreateClient(client);
                repository.Save();
            }
            catch (Exception ex)
            {
                Alerts.MsgError(ex.Message);
            }
        }

        public void EditMenu(ClientsDB row)
        {
            if (row != null)
            {
                ClientEditorWindow edit = new ClientEditorWindow(row);
                edit.ShowDialog();

                try
                {
                    if (edit.DialogResult.Value)
                    {
                        repository.UpdateClient(row);
                        repository.Save();
                        LoadDB();
                    }
                }
                catch (Exception ex)
                {
                    Alerts.MsgError(ex.Message);
                }
            }
        }

        public void TransferMenu(ClientsDB row)
        {
            if (row != null)
            {
                TransferWindow tf = new TransferWindow(row, this);
                tf.ShowDialog();

                if (tf.DialogResult.Value)
                {
                    // импровизированное обновление, 
                    // которое реализованно в ClientsDB через INotifyPropertyChanged
                    repository.Save();
                }
            }
        }

        public void ContributionMenu(ClientsDB row)
        {
            if (row != null)
            {
                ContributionWindow CoW = new ContributionWindow(row, this);
                CoW.ShowDialog();

                if (CoW.DialogResult.Value)
                {
                    repository.Save();
                }
            }
        }

        public void CreditMenu(ClientsDB row)
        {
            if (row != null)
            {
                CreditWindow cw = new CreditWindow(row, this);
                cw.ShowDialog();

                if (cw.DialogResult.Value)
                {
                    repository.Save();
                }
            }
        }

        public void GetCredit(ClientsDB client, Credit credit, decimal creditSum)
        {
            if (client != null)
            {
                try
                {
                    credit.Amount = creditSum;
                    repository.CreateCredit(credit);

                    client.creditID = credit.Id;

                    client.account += creditSum;
                    repository.Save();
                }
                catch (SqlException ex)
                {
                    Alerts.MsgError($"Ошибка SQLDB:\n{ex.Message}");
                }
            }
        }

        internal void GetContribution(ClientsDB client, Contribution contribution)
        {
            if (client != null)
            {
                try
                {
                    if (client.account - contribution.contribut >= 0 && client.account != 0)
                    {
                        repository.CreateContribution(contribution);
                        repository.LoadContribution();

                        var a = repository.GetDBContributions().Last().Id;                     //проблема присвоения ID
                        
                        client.contributionID = a;
                        client.account -= contribution.contribut;
                        repository.Save();
                    }
                    else
                    {
                        Alerts.MsgWarning($"У клиента недостаточно средств.");
                    }

                }
                catch (Exception ex)
                {
                    Alerts.MsgError($"Ошибка при создании вклада:\n{ex.Message}");
                }
            }
        }

        public void RemoveClient(ClientsDB client)
        {
            if (client != null)
            {
                repository.DeleteClient(client);
                repository.Save();
            }
        }


        public void returnChanges(ClientsDB copy, ClientsDB client)
        {
            client.account = copy.account;
            client.contributionID = copy.contributionID;
            client.creditID = copy.creditID;
            client.excomes = copy.excomes;
            client.firstName = copy.firstName;
            client.Id = copy.Id;
            client.incomes = copy.incomes;
            client.isBanned = copy.isBanned;
            client.isLegal = copy.isLegal;
            client.isVip = copy.isVip;
            client.lastName = copy.lastName;
            client.middleName = copy.middleName;
            client.pasport = copy.pasport;
        }
    }
}
