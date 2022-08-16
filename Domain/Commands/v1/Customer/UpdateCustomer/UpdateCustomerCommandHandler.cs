using AutoMapper;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using System.Net;

namespace CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, Unit>
    {
        private readonly CustomerAccountContext _context;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(IMapper mapper, CustomerAccountContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Unit> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var addCustomer = _mapper.Map<UpdateCustomerCommandRequest, Infrastructure.Data.Service.DataBase.Entities.Customer>(request);

            _context.Customer.Update(addCustomer);

            return _context.SaveChanges() > 0 ? new Unit() : throw new Exception(HttpStatusCode.UnprocessableEntity.ToString());
        }
    }
}