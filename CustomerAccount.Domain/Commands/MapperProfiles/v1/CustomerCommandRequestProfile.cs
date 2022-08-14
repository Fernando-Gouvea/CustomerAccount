using AutoMapper;
using CustomerAccount.Domain.Commands.v1.Customer.PostCustomer;
using CustomerAccount.Infrastructure.Data.Service.DataBase.Entities;

namespace Podosys.ServiceData.Domain.MapperProfiles.v1
{
    public sealed class CustomerCommandRequestProfile : Profile
    {
        public CustomerCommandRequestProfile()
        {
            CreateMap<PostCustomerCommandRequest, Customer>();
        }
    }
}
