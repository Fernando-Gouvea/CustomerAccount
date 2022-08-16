using CustomerAccount.Infrastructure.Data.Query.Queries.v1.Customer.GetCustomers;
using CustomerAccount.Infrastructure.Query.Tests.Unit.Queries.v1.Customer.Mocks.Context;
using CustomerAccount.Infrastructure.Query.Tests.Unit.Queries.v1.Customer.Mocks.Mapper;

namespace CustomerAccount.Infrastructure.Query.Tests.Unit.Queries.v1.Customer
{
    public sealed class GetCustomersQueryHandlerTest
    {
        [Test]
        public void Test1()
        {
            var map = MapperMock.GetMock();

            var con = MockContext.MockContextRepository();

            var handler = new GetCustomersQueryHandler(map, con);
            var result = handler.Handle(new GetCustomersQueryRequest(1, 5), CancellationToken.None);

            Assert.IsNotEmpty(result.Result);
        }
    }
}
