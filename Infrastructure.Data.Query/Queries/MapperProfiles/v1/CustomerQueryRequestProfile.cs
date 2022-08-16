using AutoMapper;
using CustomerAccount.Infrastructure.Data.Query.Queries.v1.Customer.GetCustomers;
using CustomerAccount.Infrastructure.Data.Service.DataBase.Entities;

namespace CustomerAccount.Infrastructure.Data.Query.Queries.MapperProfiles.v1
{
    public sealed class CustomerQueryRequestProfile : Profile
    {
        public CustomerQueryRequestProfile()
        {
            CreateMap<Customer, GetCustomersQueryResponse>();
        }
    }
}
