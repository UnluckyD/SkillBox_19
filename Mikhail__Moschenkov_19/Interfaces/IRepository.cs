using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mikhail__Moschenkov_19.Interfaces
{
    public interface IRepository<T1,T2,T3> : IDisposable
        where T1 : ClientsDB
        where T2 : Credit
        where T3 : Contribution
    {
        IEnumerable<T1> GetDBClients();
        T1 GetClient(long id);
        void CreateClient(T1 item);
        void UpdateClient(T1 item);
        void DeleteClient(T1 id);

        IEnumerable<T2> GetDBCredits();
        T2 GetCredit(long id);
        void CreateCredit(T2 item);
        void UpdateCredit(T2 item);
        void DeleteCredit(long id);

        IEnumerable<T3> GetDBContributions();
        T3 GetContribution(long id);
        void CreateContribution(T3 item);
        void UpdateContribution(T3 item);
        void DeleteContribution(long id);

        void Save();

        void Load();
        void LoadCredit();
        void LoadClients();
        void LoadContribution();
    }
}
