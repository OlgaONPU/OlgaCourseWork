using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Commands;

namespace OlgaCourseWork.Common.Interfaces.Services
{
    public interface IOrderService
    {
        Task<bool> CreateOrder(CreateOrderCommand command, CancellationToken cancellationToken);
        Task<IEnumerable<Order>> GetOrdersByClientPhoneAsync(string customerPhone);
    }
}
