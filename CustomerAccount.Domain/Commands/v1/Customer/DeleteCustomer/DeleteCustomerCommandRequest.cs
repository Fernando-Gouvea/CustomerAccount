using MediatR;

namespace CustomerAccount.Domain.Commands.v1.Customer.DeleteCustomer
{
    public class DeleteCustomerCommandRequest : IRequest<bool>
    {
        public DeleteCustomerCommandRequest(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
