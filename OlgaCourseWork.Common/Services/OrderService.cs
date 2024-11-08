using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Commands;
using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.Common.Interfaces.Services;

namespace OlgaCourseWork.Common.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<bool> CreateOrder(CreateOrderCommand command, CancellationToken cancellationToken)
        {
            var newOrder = new Order()
            {
                ClientName = command.ClientName,
                ClientPhone = command.ClientPhone,
                ProductId = command.ProductId
            };

            return await _orderRepository.CreateAsync(newOrder);
        }

        public async Task<IEnumerable<Order>> GetOrdersByClientPhoneAsync(string customerPhone)
        {
           return await _orderRepository.GetOrdersByClientPhoneAsync(customerPhone);
        }
    }
}
