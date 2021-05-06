using MsgBoxAlertClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikhail__Moschenkov_19.Classes
{
    public class SQLRepository : Interfaces.IRepository<ClientsDB, Credit, Contribution>
    {
        private BankSystemEntities bankSystem;

        public SQLRepository()
        {
            this.bankSystem = new BankSystemEntities();
        }
        public SQLRepository(string strConnections)
        {
            SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder(strConnections);
            this.bankSystem = new BankSystemEntities(sqlConnectionString.ConnectionString);
        }

        public void CreateClient(ClientsDB item)
        {
            if (item != null)
                bankSystem.ClientsDB.Add(item);
        }

        public void CreateCredit(Credit item)
        {
            if (item != null)
                bankSystem.Credit.Add(item);
        }

        public void CreateContribution(Contribution item)
        {
            if (item != null)
                bankSystem.Contribution.Add(item);
        }

        public void DeleteClient(ClientsDB client)
        {
            if (client != null)
                bankSystem.ClientsDB.Remove(client);
        }
        public void DeleteCredit(long id)
        {
            Credit credit = bankSystem.Credit.FirstOrDefault(c => c.Id == id);
            if (credit != null)
                bankSystem.Credit.Remove(credit);
        }
        public void DeleteContribution(long id)
        {
            Contribution contribution = bankSystem.Contribution.FirstOrDefault(c => c.Id == id);
            if (contribution != null)
                bankSystem.Contribution.Remove(contribution);
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    bankSystem.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<ClientsDB> GetDBClients()
        {
            return bankSystem.ClientsDB.Local;
        }
        public IEnumerable<Credit> GetDBCredits()
        {
            return bankSystem.Credit.Local;
        }
        public IEnumerable<Contribution> GetDBContributions()
        {
            return bankSystem.Contribution.Local;
        }

        public ClientsDB GetClient(long id)
        {
            return bankSystem.ClientsDB.Find(id);
        }
        public Credit GetCredit(long id)
        {
            return bankSystem.Credit.Find(id);
        }
        public Contribution GetContribution(long id)
        {
            return bankSystem.Contribution.Find(id);
        }

        public void Save()
        {
            try
            {
                bankSystem.SaveChanges();
            }
            catch (Exception ex)
            {
                Alerts.MsgError($"Не удалось сохранить изменения в бд:\n{ex.Message}");
            }
        }

        public void UpdateClient(ClientsDB item)
        {
            bankSystem.Entry(item).State = EntityState.Modified;
        }
        public void UpdateCredit(Credit item)
        {
            bankSystem.Entry(item).State = EntityState.Modified;
        }
        public void UpdateContribution(Contribution item)
        {
            bankSystem.Entry(item).State = EntityState.Modified;
        }

        public void Load()
        {
            bankSystem.ClientsDB.Load();
            bankSystem.Credit.Load();
            bankSystem.Contribution.Load();
        }
        public void LoadClients()
        {
            bankSystem.ClientsDB.Load();
        }

        public void LoadCredit()
        {
            bankSystem.Credit.Load();
        }
        public void LoadContribution()
        {
            bankSystem.Contribution.Load();
        }
    }
}
