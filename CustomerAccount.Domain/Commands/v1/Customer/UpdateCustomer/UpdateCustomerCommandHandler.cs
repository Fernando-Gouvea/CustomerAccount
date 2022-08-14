using MediatR;

namespace CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, Unit>
    {
        private readonly IMediator _mediator;

        public UpdateCustomerCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            return new Unit();
        }
    }
}