using AutoMapper;
using CustomerAccount.Infrastructure.Data.Service.Repository;
using MediatR;
using System.Net;

namespace CustomerAccount.Infrastructure.Data.Query.Queries.v1.Customer.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQueryRequest, IEnumerable<GetCustomersQueryResponse>>
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public GetCustomersQueryHandler(IMapper mapper, IRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCustomersQueryResponse>> Handle(GetCustomersQueryRequest request, CancellationToken cancellationToken)
        {
            var customers = await _repository.GetCustomerAsync(request.Skip, request.Take);

            if (!customers.Any())
                throw new Exception(HttpStatusCode.NotFound.ToString());

            var getCustomersResponse = _mapper.Map<List<Service.Repository.Entities.Customer>, IEnumerable<GetCustomersQueryResponse>>(customers);

            return getCustomersResponse;
        }
    }
}