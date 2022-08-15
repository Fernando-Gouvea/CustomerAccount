using AutoMapper;
using CustomerAccount.Domain.Commands.v1.Customer.PostCustomer;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, bool>
    {
        private readonly CustomerAccountContext _context;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(IMapper mapper, CustomerAccountContext context)
        {
            _mapper = mapper;
            _context = context; 
        }

        public async Task<bool> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var addCustomer = _mapper.Map<UpdateCustomerCommandRequest, Infrastructure.Data.Service.DataBase.Entities.Customer>(request);

            _context.Customer.Update(addCustomer);

            return _context.SaveChanges() > 0 ? true : false;
          
        }
    }
}