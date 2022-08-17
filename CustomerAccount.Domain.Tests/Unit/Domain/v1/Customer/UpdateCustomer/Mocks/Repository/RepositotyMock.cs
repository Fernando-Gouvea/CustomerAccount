using CustomerAccount.Infrastructure.Data.Service.Repository;
using NSubstitute;
using CustomerDB = CustomerAccount.Infrastructure.Data.Service.Repository.Entities.Customer;

namespace CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.UpdateCustomer.Mocks.Repository
{
    public class RepositotyMock
    {
        public static IRepository MockAddCustomerAsync()
        {
            var mock = Substitute.For<IRepository>();

            mock.AddCustomerAsync(new CustomerDB()).Returns(1);

            return mock;
        }
    }
}
