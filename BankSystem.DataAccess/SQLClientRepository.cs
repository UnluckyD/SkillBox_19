using MsgBoxAlertClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace BankSystemApp.DataAccess
{
    public class SQLClientRepository : IRepository<ClientsDB>
    {
        private BankSystemEntities bankSystem;

        public SQLClientRepository(BankSystemEntities bankSystem)
        {
            this.bankSystem = bankSystem;
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

        public void Load()
        {
            bankSystem.ClientsDB.Load();
        }

        public IEnumerable<ClientsDB> GetDB()
        {
            return bankSystem.ClientsDB.Local;
        }

        public ClientsDB GetClient(long id)
        {
            return bankSystem.ClientsDB.FirstOrDefault(c => c.Id == id);
        }

        public void Create(ClientsDB item)
        {
            bankSystem.ClientsDB.Add(item);
        }

        public void Update(ClientsDB item)
        {
            bankSystem.Entry(item).State = EntityState.Modified;
        }

        public void Delete(ClientsDB item)
        {
            bankSystem.ClientsDB.Remove(item);
        }
    }
}
