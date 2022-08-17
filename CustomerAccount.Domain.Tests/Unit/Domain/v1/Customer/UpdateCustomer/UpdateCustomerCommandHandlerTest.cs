using AutoFixture;
using CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer;
using CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.UpdateCustomer.Mocks.Mapper;
using CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.UpdateCustomer.Mocks.Repository;
using NUnit.Framework;

namespace CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.UpdateCustomer
{
    public sealed class UpdateCustomerCommandHandlerTest
    {
        [Test]
        public void UpdateCustomer_ShouldReturnUnit()
        {
            var fixture = new Fixture();
            var mapper = MapperMock.GetMock();
            var repository = RepositotyMock.MockAddCustomerAsync();
            var handler = new UpdateCustomerCommandHandler(mapper, repository);
            var response = handler.Handle(fixture.Create<UpdateCustomerCommandRequest>(), CancellationToken.None);

            Assert.IsNotNull(response);
        }
    }
}
