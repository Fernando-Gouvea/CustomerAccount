using CustomerAccount.Infrastructure.Data.Service.Repository;
using MediatR;
using System.Net;

namespace CustomerAccount.Domain.Commands.v1.Customer.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, Unit>
    {
        private readonly IRepository _repository;

        public DeleteCustomerCommandHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetCustomerByIdAsync(request.Id);

            if (customer == null)
                throw new Exception(HttpStatusCode.NotFound.ToString());

            return await _repository.DeleteCustomerAsync(customer) > 0 ? Unit.Value : throw new Exception(HttpStatusCode.UnprocessableEntity.ToString());
        }
    }
}