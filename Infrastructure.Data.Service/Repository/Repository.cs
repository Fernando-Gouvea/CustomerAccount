using CustomerAccount.Infrastructure.Data.Service.Repository.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerAccount.Infrastructure.Data.Service.Repository
{
    public class Repository : IRepository
    {

        private readonly CustomerAccountContext _context;

        public Repository(CustomerAccountContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomerAsync(int skip, int take)
        {
            var customers = await _context.Customer
                 .AsNoTracking()
                 .Skip(skip)
                 .Take(take)
                 .ToListAsync();

            return customers;
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            var customer = await _context.Customer
                .Where(x => x.Id.Equals(id))
                .FirstOrDefaultAsync();

            return customer;
        }

        public async Task<int> AddCustomerAsync(Customer customer)
        {
            _context.Customer.Add(customer);

            return _context.SaveChanges();
        }

        public async Task<int> UpdateCustomerAsync(Customer customer)
        {
            _context.Customer.Update(customer);

            return _context.SaveChanges();
        }

        public async Task<int> DeleteCustomerAsync(Customer customer)
        {
            _context.Customer.Remove(customer);

            return _context.SaveChanges();
        }
    }
}
