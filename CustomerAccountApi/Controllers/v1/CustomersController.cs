using CustomerAccount.Domain.Commands.v1.Customer.DeleteCustomer;
using CustomerAccount.Domain.Commands.v1.Customer.PostCustomer;
using CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer;
using CustomerAccount.Infrastructure.Data.Query.Query.v1.Customer.GetCustomers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CustomerAccountApi.Controllers.v1
{
    [Route("api/customeraccount/v1")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("customers")]
        public async Task<ActionResult<GetCustomersQueryResponse>> GetCustomer()
        {
            return Ok(await _mediator.Send(new GetCustomersQueryRequest()));
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> PutCustomer(Guid id, UpdateCustomerCommandRequest request)
        {
            request.Id = id;

            return Ok(await _mediator.Send(request));
        }

        [HttpPost("customer")]
        public async Task<ActionResult<Unit>> PostCustomer(PostCustomerCommandRequest request)
        {
            return await _mediator.Send(request) ? StatusCode(201) : StatusCode(422, "PostCustomerCommandException");
        }

        [HttpDelete("customer/{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteCustomerCommandRequest(id)));
        }
    }
}
