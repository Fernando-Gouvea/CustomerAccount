using MediatR;

namespace CustomerAccount.Domain.Commands.v1.Customer.DeleteCustomer
{
    public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommandRequest, Unit>
    {
        private readonly IMediator _mediator;

        public DeleteCustomerCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(DeleteCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            return new Unit();
        }
    }
}