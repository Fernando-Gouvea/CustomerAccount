using AutoMapper;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;

namespace CustomerAccount.Domain.Commands.v1.Customer.PostCustomer
{
    public class PostCustomerCommandHandler : IRequestHandler<PostCustomerCommandRequest, bool>
    {
        private readonly CustomerAccountContext _context;
        private readonly IMapper _mapper;


        public PostCustomerCommandHandler(IMapper mapper, CustomerAccountContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> Handle(PostCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var addCustomer = _mapper.Map<PostCustomerCommandRequest, Infrastructure.Data.Service.DataBase.Entities.Customer>(request);

            _context.Add(addCustomer);

            return _context.SaveChanges() > 0 ? true : false;
        }
    }
}