using DataLayer;
using DataLayer.Models.Entity;
using Microsoft.EntityFrameworkCore;
using OlgaCourseWork.Common.Interfaces.Repositories;

namespace OlgaCourseWork.Common.Repositories
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(PrometeiDbContext context) : base(context) { }

        public async Task<bool> CreateAsync(Order order)
        {
            return await AddAsync(order) != 0;
        }

        public async Task<IEnumerable<Order>> GetOrdersByClientPhoneAsync(string customerPhone)
        {
            return await GetByCustomerPhoneAsync(customerPhone);
        }

        private async Task<IEnumerable<Order>> GetByCustomerPhoneAsync(string clientPhone)
        {
            return await _context.Orders
                                 .Where(or => or.ClientPhone == clientPhone)
                                 .ToListAsync();
        }
    }
}
