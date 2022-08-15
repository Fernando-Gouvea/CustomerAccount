using AutoMapper;
using CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers;
using CustomerAccount.Infrastructure.Data.Service.DataBase.Entities;

namespace CustomerAccount.Infrastructure.Data.Query.Query.MapperProfiles.v1
{
    public sealed class CustomerQueryRequestProfile : Profile
    {
        public CustomerQueryRequestProfile()
        {
            CreateMap<Customer, GetCustomersQueryResponse>();
        }
    }
}
