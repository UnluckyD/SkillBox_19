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
    public class SQLContributionRepository : Interfaces.IRepository<Contribution>
    {
        private BankSystemEntities bankSystem;

        public SQLContributionRepository(BankSystemEntities bankSystem)
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
            bankSystem.Contribution.Load();
        }

        public IEnumerable<Contribution> GetDB()
        {
            return bankSystem.Contribution.Local;
        }

        public Contribution GetClient(long id)
        {
            return bankSystem.Contribution.FirstOrDefault(c => c.Id == id);
        }

        public void Create(Contribution item)
        {
            bankSystem.Contribution.Add(item);
        }

        public void Update(Contribution item)
        {
            bankSystem.Entry(item).State = EntityState.Modified;
        }

        public void Delete(Contribution item)
        {
            bankSystem.Contribution.Remove(item);
        }
    }
}
