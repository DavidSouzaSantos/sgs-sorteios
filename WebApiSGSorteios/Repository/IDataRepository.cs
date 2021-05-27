using Domain.Models;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDataRepository
    {
        //GERAL
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        Task<bool> SaveChangesAsync();

        //CLIENT
        Task<Client[]> GetAllClientsAsync();
        Task<Client[]> GetAllClientsAsyncByName(string pClientName);
        Task<Client> GetClientAsyncById(int pClientId);

        //CHOSEN NUMBER
        Task<ChosenNumber[]> GetAllChosenNumbersAsyncBySortitionId(string pSortitionId);
        Task<ChosenNumber[]> GetAllChosenNumbersAsyncByClientName(string pClientName);
        Task<ChosenNumber> GetChosenNumberAsyncById(int pChosenNumberId);

        //Sortition
        Task<Sortition[]> GetAllSortitionsAsyncByUserId(string pUserId);
        Task<Sortition> GetSortitionAsyncById(int pChosenNumberId);
    }
}
