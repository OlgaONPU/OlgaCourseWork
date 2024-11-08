using DataLayer.Models.Entity;
using MediatR;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.Common.Queries.Orders;

namespace OlgaCourseWork.Common.Handlers.Queries.Orders
{
    public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, IEnumerable<Order>>
    {
        private readonly IOrderService _orderService;


        public GetOrdersQueryHandler(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IEnumerable<Order>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
        {
            return await _orderService.GetOrdersByClientPhoneAsync(request.ClientPhone);
        }
    }
}
