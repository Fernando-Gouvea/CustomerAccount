using CustomerAccount.Domain.Commands.v1.Customer.PostCustomer;
using CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.PostCustomer.Mocks.Mapper;
using CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.PostCustomer.Mocks.Repository;
using NUnit.Framework;

namespace CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.PostCustomer
{
    public sealed class PostCustomerCommandHandlerTest
    {
        [Test]
        public void PostCustomer_ShouldReturnUnit()
        {
            var mapper = MapperMock.GetMock();
            var repository = RepositotyMock.MockAddCustomerAsync();
            var handler = new PostCustomerCommandHandler(mapper, repository);
            var response = handler.Handle(new PostCustomerCommandRequest(), CancellationToken.None);

            Assert.IsNotNull(response);
        }
    }
}
