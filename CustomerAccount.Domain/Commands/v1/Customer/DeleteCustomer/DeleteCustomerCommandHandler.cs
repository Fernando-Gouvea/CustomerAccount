using AutoMapper;
using CustomerAccount.Domain.Commands.v1.Customer.PostCustomer;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerAccount.Domain.Commands.v1.Customer.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, bool>
    {
        private readonly CustomerAccountContext _context;
       
        public DeleteCustomerCommandHandler(CustomerAccountContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer
                .Where(x => x.Id.Equals(request.Id))
                .FirstOrDefaultAsync();

            if (customer == null)
                return false;

            _context.Customer.Remove(customer);

            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}