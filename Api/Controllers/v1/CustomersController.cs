using CustomerAccount.Domain.Commands.v1.Customer.DeleteCustomer;
using CustomerAccount.Domain.Commands.v1.Customer.PostCustomer;
using CustomerAccount.Domain.Commands.v1.Customer.UpdateCustomer;
using CustomerAccount.Infrastructure.Data.Query.Queries.v1.Customer.GetCustomers;
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

        [HttpGet("customers/{skip}/{take}")]
        public async Task<ActionResult<IEnumerable<GetCustomersQueryResponse>>> GetCustomer([FromRoute] int skip, [FromRoute] int take)
        {
            return Ok(await _mediator.Send(new GetCustomersQueryRequest(skip, take)));
        }

        [HttpPut("customer/update/{id}")]
        public async Task<IActionResult> PutCustomer(Guid id, UpdateCustomerCommandRequest request)
        {
            request.Id = id;

            return Created("", await _mediator.Send(request));
        }

        [HttpPost("customer")]
        public async Task<ActionResult> PostCustomer(PostCustomerCommandRequest request)
        {
            return Created("", await _mediator.Send(request));
        }

        [HttpDelete("customer/{id}")]
        public async Task<IActionResult> DeleteCustomer(Guid id)
        {
            return Ok(await _mediator.Send(new DeleteCustomerCommandRequest(id)));
        }
    }
}
