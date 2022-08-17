using CustomerAccount.Infrastructure.Data.Service.Repository;
using NSubstitute;
using CustomerDB = CustomerAccount.Infrastructure.Data.Service.Repository.Entities.Customer;

namespace CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.DeleteCustomer.Mocks.Repository
{
    public class RepositotyMock
    {
        public static IRepository MockDeleteCustomerAsync()
        {
            var mock = Substitute.For<IRepository>();

            mock.DeleteCustomerAsync(new CustomerDB()).Returns(5);

            return mock;
        }
    }
}
