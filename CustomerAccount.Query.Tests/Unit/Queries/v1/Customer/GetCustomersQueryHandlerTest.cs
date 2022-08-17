﻿using CustomerAccount.Infrastructure.Data.Query.Queries.v1.Customer.GetCustomers;
using CustomerAccount.Query.Tests.Unit.Queries.v1.Customer.Mocks.Mapper;
using CustomerAccount.Query.Tests.Unit.Queries.v1.Customer.Mocks.Repository;
using NUnit.Framework;

namespace CustomerAccount.Query.Tests.Unit.Queries.v1.Customer
{
    public sealed class GetCustomersQueryHandlerTest
    {
        [Test]
        public void GetCustomer_ShouldRetunCustomers()
        {
            var mapper = MapperMock.GetMock();

            var repository = RepositotyMock.MockGetCustomerAsync();

            var handler = new GetCustomersQueryHandler(mapper, repository);
            var response = handler.Handle(new GetCustomersQueryRequest(1, 5), CancellationToken.None);

            Assert.IsNotEmpty(response.Result);
        }
    }
}
