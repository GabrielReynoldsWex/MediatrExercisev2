using MediatR;
using MediatrExercisev2.Abstraction.Requests.Customer;
using MediatrExercisev2.Application.Customers.Commands.CreateCustomer;
using MediatrExercisev2.Application.Customers.Queries.GetCustomers;
using Microsoft.AspNetCore.Mvc;

namespace MediatrExercisev2.Controllers
{

    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromBody] CreateCustomerRequest request) 
        {
            var customers = await _mediator.Send(new CreateCustomerCommand(request.Name, request.ContactNumber));
            return Ok(customers);
        }

        [HttpGet]
        public async Task<ActionResult> GetCustomers() 
        {
            var customers = await _mediator.Send(new GetCustomersQuery());
            return Ok(customers);   
        }  
    }
}