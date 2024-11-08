using DataLayer;
using DataLayer.Models.Entity;
using Microsoft.EntityFrameworkCore;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Repositories
{
    public abstract class ProductRepository<T> : Repository<T> where T : Product
    {
        public ProductRepository(PrometeiDbContext context) : base(context) { }

        public async Task<IEnumerable<T>> GetByProductType(ProductType type)
        {
            return await _context.Set<T>()
                .Where(p => p.Type == type)
                .ToListAsync();
        }
    }
}
