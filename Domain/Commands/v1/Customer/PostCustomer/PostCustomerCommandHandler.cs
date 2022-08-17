using AutoMapper;
using CustomerAccount.Infrastructure.Data.Service.Repository;
using MediatR;
using System.Net;

namespace CustomerAccount.Domain.Commands.v1.Customer.PostCustomer
{
    public class PostCustomerCommandHandler : IRequestHandler<PostCustomerCommandRequest, Unit>
    {
        private readonly IRepository _repository;
        private readonly IMapper _mapper;

        public PostCustomerCommandHandler(IMapper mapper, IRepository repository)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(PostCustomerCommandRequest request, CancellationToken cancellationToken)
        {
            var customer = _mapper.Map<PostCustomerCommandRequest, Infrastructure.Data.Service.Repository.Entities.Customer>(request);

            if (customer == null)
                throw new Exception(HttpStatusCode.UnprocessableEntity.ToString());

            return await _repository.AddCustomerAsync(customer) > 0 ? new Unit() : throw new Exception(HttpStatusCode.UnprocessableEntity.ToString());
        }
    }
}