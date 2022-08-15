using AutoMapper;
using CustomerAccount.Domain.Commands.v1.Customer.PostCustomer;
using CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer;
using CustomerAccount.Infrastructure.Data.Service.DataBase.Entities;

namespace CustomerAccount.Domain.Commands.MapperProfiles.v1
{
    public sealed class CustomerCommandRequestProfile : Profile
    {
        public CustomerCommandRequestProfile()
        {
            CreateMap<PostCustomerCommandRequest, Customer>();
            CreateMap<UpdateCustomerCommandRequest, Customer>();
        }
    }
}
