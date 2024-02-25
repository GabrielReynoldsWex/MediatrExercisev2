using MediatR;
using MediatrExercisev2.Abstraction.Requests.Purchase;
using MediatrExercisev2.Application.Customers.Queries;
using MediatrExercisev2.Application.ItemPurchases.Commands.CreatePurchase;
using Microsoft.AspNetCore.Mvc;

namespace MediatrExercisev2.Controllers
{
    [Route("api/purchase")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PurchaseController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /*
        [HttpPost]
        public async Task<IActionResult> CreatePurchase([FromBody] CreatePurchaseRequest request) 
        {
            var result = await _mediator.Send(new CreatePurchaseCommand(request.CustomerID, request.ProductID));
            return Ok(result);
        } */

        [HttpPost]
        public async Task<IActionResult> GetCustomerDiscountById([FromBody] GetCustomerDiscountByIdQuery query)
        {
            var customer = await _mediator.Send(new GetCustomerDiscountByIdQuery(query.CustomerId));
            return Ok(customer);
        }
    }
}
