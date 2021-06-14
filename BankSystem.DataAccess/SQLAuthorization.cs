using BankSystemApp.DataAccess;
using MsgBoxAlertClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.DataAccess
{
    public class SQLAuthorization : IRepository<Authorization>
    {
        private BankSystemEntities bankSystem;

        public SQLAuthorization(BankSystemEntities bankSystem)
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
            bankSystem.Authorization.Load();
        }

        public IEnumerable<Authorization> GetDB()
        {
            return bankSystem.Authorization.Local;
        }

        public Authorization GetClient(long id)
        {
            return bankSystem.Authorization.FirstOrDefault(c => c.Id == id);
        }

        public void Create(Authorization item)
        {
            bankSystem.Authorization.Add(item);
        }

        public void Update(Authorization item)
        {
            bankSystem.Entry(item).State = EntityState.Modified;
        }

        public void Delete(Authorization item)
        {
            bankSystem.Authorization.Remove(item);
        }
    }
}
