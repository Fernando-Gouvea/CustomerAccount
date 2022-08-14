using MediatR;

namespace CustomerAccount.Domain.Commands.v1.Customer.PostCustomer
{
    public class PostCustomerCommandHandler : IRequestHandler<PostCustomerCommandRequest, Unit>
    {
        private readonly IMediator _mediator;

        public PostCustomerCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<Unit> Handle(PostCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            return new Unit();
        }
    }
}