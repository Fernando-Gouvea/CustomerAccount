using AutoFixture;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using NSubstitute;
using CustomerDB = CustomerAccount.Infrastructure.Data.Service.DataBase.Entities.Customer;

namespace CustomerAccount.Infrastructure.Data.Infrastructure.Data.Query.Tests.Unit.Queries.v1.Customer.Mocks.Context
{
    public class MockContext
    {
        public static IDbfuncions MockContextRepository()
        {
            var mock = Substitute.For<IDbfuncions>();

            var fixture = new Fixture();

            mock.GetCustomerAsync().Returns(fixture.Create<List<CustomerDB>>());

            return mock;
        }
    }
}
