using CustomerAccount.Infrastructure.Data.Service.DataBase.Entities;

namespace CustomerAccount.Infrastructure.Data.Service.DataBase
{
    public interface IDbfuncions
    {
        Task<List<Customer>> GetCustomerAsync();
    }
}