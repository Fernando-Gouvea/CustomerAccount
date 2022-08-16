using CustomerAccount.Infrastructure.Data.Infrastructure.Data.Query.Tests.Unit.Queries.v1.Customer.Mocks.Context;
using CustomerAccount.Infrastructure.Data.Infrastructure.Data.Query.Tests.Unit.Queries.v1.Customer.Mocks.Mapper;
using CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers;

namespace CustomerAccount.Infrastructure.Data.Infrastructure.Data.Query.Tests.Unit.Queries.v1.Customer
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
