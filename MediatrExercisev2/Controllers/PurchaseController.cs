using MediatR;
using MediatrExercisev2.Abstraction.Requests.Purchase;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

using MediatrExercisev2.Application.

namespace MediatrExercisev2.Controllers
{
    public class PurchaseController
    {
        [Route("api/purchase")]
        [ApiController]

        private readonly IMediator _mediator;

        public PurchaseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePurchase([FromBody] CreatePurchaseRequest request) 
        {
            var result = await _mediator.Send(request);
        }
    }
}
