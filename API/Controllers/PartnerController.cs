using Application.PageDetails.PartnerPageDetails.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        [HttpGet]
        public async Task<IActionResult> GetAllPartners()
        {
            return Ok(await _mediator.Send(new GetAllPartnersQuery()));
        }
    }
}
