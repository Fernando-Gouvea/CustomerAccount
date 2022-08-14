using CustomerAccount.Domain.Commands.v1.Customer.PostCustomer;
using CustomerAccount.Domain.Entities;
using CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers;
using CustomerAccount.Infrastructure.Data.Service.DataBase;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CustomerAccountApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly CustomerAccountContext _context;

        public CustomersController(IMediator mediator, CustomerAccountContext context)
        {
            _mediator = mediator;
            _context = context;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<ActionResult<GetCustomersQueryResponse>> GetCustomer()
        {
            return Ok(await _mediator.Send(new GetCustomersQueryRequest()));
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(string id)
        {
            if (_context.Customer == null)
            {
                return NotFound();
            }
            var customer = await _context.Customer.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // PUT: api/Customers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(Guid id, UpdateCustomerCommandRequest request)
        {
            request.Id = id;

            return Ok(await _mediator.Send(request));
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> PostCustomer(PostCustomerCommandRequest request)
        {
            return Ok(await _mediator.Send(request));
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteCustomerCommandRequest(id)));
        }
    }
}
