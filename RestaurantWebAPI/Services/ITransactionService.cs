using RestaurantWebAPI.Models;

namespace RestaurantWebAPI.Services
{
    public interface ITransactionService
    {
        Task<IEnumerable<Transaction>> GetTransactionList();
        Task<Transaction> GetTransactionById(int id);
        Task<Transaction> CreateTransaction(Transaction transaction);
        Task UpdateTransaction(Transaction transaction);
        Task DeleteTransaction(Transaction transaction);
    }
}
