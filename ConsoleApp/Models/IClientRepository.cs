using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace EFCoreConsoleApp
{
    public interface IClientsRepository
    {
        Task<Clients> Insert(string newLogin);
        Task<IEnumerable<Clients>> Select();
        Task<Clients> Delete(string login);
        Task<Clients> Update(string login, string newlogin);
    }
}
