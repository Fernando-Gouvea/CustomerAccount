using AutoFixture;
using AutoMapper;
using CustomerAccount.Infrastructure.Data.Query.Queries.v1.Customer.GetCustomers;
using NSubstitute;
using CustomerDB = CustomerAccount.Infrastructure.Data.Service.DataBase.Entities.Customer;

namespace CustomerAccount.Infrastructure.Query.Tests.Unit.Queries.v1.Customer.Mocks.Mapper
{
    public class MapperMock
    {
        public static IMapper GetMock()
        {
            var mock = Substitute.For<IMapper>();

            var fixture = new Fixture();

            mock.Map<List<CustomerDB>, IEnumerable<GetCustomersQueryResponse>>(Arg.Any<List<CustomerDB>>()).Returns(fixture.Create<List<GetCustomersQueryResponse>>());

            return mock;
        }
    }
}
