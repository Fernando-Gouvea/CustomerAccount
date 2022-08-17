using AutoMapper;
using CustomerAccount.Infrastructure.Data.Service.Repository;
using MediatR;
using System.Net;

namespace CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommandRequest, Unit>
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public UpdateCustomerCommandHandler(IMapper mapper, IRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<UpdateCustomerCommandRequest, Infrastructure.Data.Service.Repository.Entities.Customer>(request);

            return await _repository.UpdateCustomerAsync(customer) > 0 ? new Unit() : throw new Exception(HttpStatusCode.UnprocessableEntity.ToString());
        }
    }
}