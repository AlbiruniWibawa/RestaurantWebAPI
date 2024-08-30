using RestaurantWebAPI.Models;

namespace RestaurantWebAPI.Services
{
    public interface ICustomerService
    {
        Task<IEnumerable<Customer>> GetCustomerList();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task DeleteCustomer(Customer customer);
    }
}
