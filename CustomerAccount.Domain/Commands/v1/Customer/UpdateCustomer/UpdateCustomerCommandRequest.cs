using MediatR;

namespace CustomerAccount.Domain.Commands.v1.Customer.PostCustomer
{
    public class UpdateCustomerCommandRequest : IRequest<Unit>
    {               
        public Guid Id { get; set; }
    }
}
