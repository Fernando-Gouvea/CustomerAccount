using CustomerAccount.Domain.Commands.v1.Customer.DeleteCustomer;
using CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.DeleteCustomer.Mocks.Repository;
using NUnit.Framework;

namespace CustomerAccount.Domain.Tests.Unit.Domain.v1.Customer.DeleteCustomer
{
    public sealed class PostCustomerCommandHandlerTest
    {
        [Test]
        public void DeleteCustomer_ShouldReturnUnit()
        {
            var repository = RepositotyMock.MockDeleteCustomerAsync();
            var handler = new DeleteCustomerCommandHandler(repository);
            var response = handler.Handle(new DeleteCustomerCommandRequest(Guid.NewGuid()), CancellationToken.None);

            Assert.IsNotNull(response);
        }
    }
}
