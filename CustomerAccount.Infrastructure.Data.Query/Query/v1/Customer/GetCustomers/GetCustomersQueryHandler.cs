using AutoMapper;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQueryRequest, IEnumerable<GetCustomersQueryResponse>>
    {
        private readonly IDbfuncions _context;
       // private readonly CustomerAccountContext _context;
        private readonly IMapper _mapper;

        //public GetCustomersQueryHandler(IMapper mapper, CustomerAccountContext context)
        //{
        //    _context = context;
        //    _mapper = mapper;
        //}

        public GetCustomersQueryHandler(IMapper mapper, IDbfuncions context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCustomersQueryResponse>> Handle(GetCustomersQueryRequest request, CancellationToken cancellationToken)
        {
            var customers = await _context.GetCustomerAsync();

            if (!customers.Any())
                throw new Exception(HttpStatusCode.NotFound.ToString());

            var getCustomersResponse = _mapper.Map<List<Service.DataBase.Entities.Customer>, IEnumerable<GetCustomersQueryResponse>>(customers);

            return getCustomersResponse;
        }
    }
}