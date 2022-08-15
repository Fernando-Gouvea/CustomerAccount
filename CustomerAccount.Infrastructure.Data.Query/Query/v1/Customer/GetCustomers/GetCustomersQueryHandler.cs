using AutoMapper;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers
{
    public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQueryRequest, IEnumerable<GetCustomersQueryResponse>>
    {
        private readonly CustomerAccountContext _context;
        private readonly IMapper _mapper;

        public GetCustomersQueryHandler(IMapper mapper, CustomerAccountContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<GetCustomersQueryResponse>> Handle(GetCustomersQueryRequest request, CancellationToken cancellationToken)
        {
            var customers = await _context.Customer
                .AsNoTracking()
                .Skip(request.Skip)
                .Take(request.Take)
                .ToListAsync();

            if (!customers.Any())
                throw new ArgumentException("Exceção ocorrida ao obter os alunos.");


            //throw HttpStatusCode.BadRequest;

            // return new HttpRequestException("Nothing Found");
            // throw new HttpRequestException("Nothing Found", HttpStatusCode.NotFound);


            var getCustomersResponse = _mapper.Map<List<Service.DataBase.Entities.Customer>, IEnumerable<GetCustomersQueryResponse>>(customers);

            return getCustomersResponse;
        }
    }
}