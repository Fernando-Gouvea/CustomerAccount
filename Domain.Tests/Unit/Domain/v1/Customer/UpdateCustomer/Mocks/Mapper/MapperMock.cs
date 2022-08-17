using AutoFixture;
using AutoMapper;
using CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer;
using NSubstitute;
using CustomerDB = CustomerAccount.Infrastructure.Data.Service.Repository.Entities.Customer;

namespace CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.UpdateCustomer.Mocks.Mapper
{
    public class MapperMock
    {
        public static IMapper GetMock()
        {
            var mock = Substitute.For<IMapper>();

            var fixture = new Fixture();

            mock.Map<UpdateCustomerCommandRequest, CustomerDB>(Arg.Any<UpdateCustomerCommandRequest>()).Returns(fixture.Create<CustomerDB>());

            return mock;
        }
    }
}