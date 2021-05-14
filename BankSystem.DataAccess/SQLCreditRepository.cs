using MsgBoxAlertClass;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.DataAccess
{
    public class SQLCreditRepository : IRepository<Credit>
    {
        private BankSystemEntities bankSystem;

        public SQLCreditRepository(BankSystemEntities bankSystem)
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
            bankSystem.Credit.Load();
        }

        public IEnumerable<Credit> GetDB()
        {
            return bankSystem.Credit.Local;
        }

        public Credit GetClient(long id)
        {
            return bankSystem.Credit.FirstOrDefault(c => c.Id == id);
        }

        public void Create(Credit item)
        {
            bankSystem.Credit.Add(item);
        }

        public void Update(Credit item)
        {
            bankSystem.Entry(item).State = EntityState.Modified;
        }

        public void Delete(Credit item)
        {
            bankSystem.Credit.Remove(item);
        }
    }
}
