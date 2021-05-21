using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemApp.DataAccess
{
    public interface IRepository<T> : IDisposable
    {
        IEnumerable<T> GetDB();
        T GetClient(long id);
        void Create(T item);
        void Update(T item);
        void Delete(T item);

        void Load();
        void Save();

    }
}
