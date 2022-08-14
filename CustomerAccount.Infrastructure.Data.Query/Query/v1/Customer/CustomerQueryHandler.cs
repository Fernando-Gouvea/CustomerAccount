using MediatR;

namespace CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer
{
    public class CustomerQueryHandler : IRequestHandler<CustomerQueryRequest, CustomerQueryResponse>
    {
        private readonly IMediator _mediator;

        public CustomerQueryHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CustomerQueryResponse> Handle(CustomerQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}