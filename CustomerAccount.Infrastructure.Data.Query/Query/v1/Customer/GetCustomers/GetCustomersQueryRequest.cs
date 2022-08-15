using MediatR;

namespace CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers
{
    public class GetCustomersQueryRequest : IRequest<IEnumerable<GetCustomersQueryResponse>>
    {
        public GetCustomersQueryRequest(int skip, int take)
        {
            Skip = skip;
            Take = take;
        }

        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
