using CustomerAccount.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerAccount.Infrastructure.Data.Service.DataBase
{
    public class CustomerAccountContext : DbContext
    {
        public CustomerAccountContext(DbContextOptions<CustomerAccountContext> options)
            : base(options)
        {
        }
        public DbSet<Customer> Customer { get; set; } = default!;
    }
}
