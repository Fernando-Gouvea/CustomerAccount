using CustomerAccount.Infrastructure.Data.Service.DataBase.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAccount.Infrastructure.Data.Service.DataBase
{
    public class Dbfuncions : IDbfuncions
    {

        private readonly CustomerAccountContext _context;

        public Dbfuncions(CustomerAccountContext context)
        {
            _context = context;
        }

        public async Task<List<Customer>> GetCustomerAsync()
        {
           var customers = await _context.Customer
                .AsNoTracking()
                .Skip(0)
                .Take(5)
                .ToListAsync();

            return customers;

        }



    }
}
