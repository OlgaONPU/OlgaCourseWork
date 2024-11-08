using AutoMapper;
using DataLayer.Models.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlgaCourseWork.Common.Commands;
using OlgaCourseWork.Common.Models.Requests;
using OlgaCourseWork.Common.Queries.Orders;

namespace OlgaCourseWork.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public OrdersController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("/api/v1/CreateOrder")]
        public async Task<IActionResult> CreateOrder(CreateOrderRequest request, CancellationToken cancellationToken = default)
        {
            var command = _mapper.Map<CreateOrderCommand>(request);

            return Ok(await _mediator.Send(command, cancellationToken));
        }


        [HttpGet("/api/v1/GetOrdersByClientPhone")]
        public async Task<IEnumerable<Order>> GetOrdersByClientPhone([FromQuery] string clientPhone)
        {
            return await _mediator.Send(new GetOrdersQuery() { ClientPhone = clientPhone });
        }
    }
}
