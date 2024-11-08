using DataLayer.Models.Entity;

namespace OlgaCourseWork.Common.Interfaces.Repositories
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<bool> CreateAsync(Order order);
        Task<IEnumerable<Order>> GetOrdersByClientPhoneAsync(string clientPhone);
    }
}
