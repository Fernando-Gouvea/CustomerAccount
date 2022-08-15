using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CustomerAccount.Domain.Commands.v1.Customer.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, Unit>
    {
        private readonly CustomerAccountContext _context;

        public DeleteCustomerCommandHandler(CustomerAccountContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var customer = await _context.Customer
                .Where(x => x.Id.Equals(request.Id))
                .FirstOrDefaultAsync();

            if (customer == null)
                throw new Exception(HttpStatusCode.NotFound.ToString());

            _context.Customer.Remove(customer);

            return _context.SaveChanges() > 0 ? new Unit() : throw new Exception(HttpStatusCode.UnprocessableEntity.ToString());
        }
    }
}