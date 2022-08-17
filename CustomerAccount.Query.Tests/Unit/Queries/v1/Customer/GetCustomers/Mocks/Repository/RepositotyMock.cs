using AutoFixture;
using CustomerAccount.Infrastructure.Data.Service.Repository;
using NSubstitute;
using CustomerDB = CustomerAccount.Infrastructure.Data.Service.Repository.Entities.Customer;

namespace CustomerAccount.Query.Tests.Unit.Queries.v1.Customer.Mocks.Repository
{
    public class RepositotyMock
    {
        public static IRepository MockGetCustomerAsync()
        {
            var mock = Substitute.For<IRepository>();

            var fixture = new Fixture();

            mock.GetCustomerAsync(1, 5).Returns(fixture.Create<List<CustomerDB>>());

            return mock;
        }
    }
}
