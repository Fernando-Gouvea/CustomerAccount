using MediatR;

namespace CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQueryRequest, GetCustomersQueryResponse>
    {
        private readonly IMediator _mediator;

        public GetCustomersQueryHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<GetCustomersQueryResponse> Handle(GetCustomersQueryRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}