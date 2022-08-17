using CustomerAccount.Infrastructure.Data.Service.Repository.Entities;

namespace CustomerAccount.Infrastructure.Data.Service.Repository
{
    public interface IRepository
    {
        Task<List<Customer>> GetCustomerAsync(int skip, int take);

        Task<Customer> GetCustomerByIdAsync(Guid id);

        Task<int> AddCustomerAsync(Customer customer);

        Task<int> UpdateCustomerAsync(Customer customer);

        Task<int> DeleteCustomerAsync(Customer customer);
    }
}