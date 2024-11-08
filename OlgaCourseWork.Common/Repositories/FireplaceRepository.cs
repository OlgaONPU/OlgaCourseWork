using DataLayer;
using DataLayer.Models.Entity;
using Microsoft.EntityFrameworkCore;
using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Repositories
{
    public class FireplaceRepository : ProductRepository<Fireplace>, IFireplaceRepository
    {
        public FireplaceRepository(PrometeiDbContext context) : base(context) { }

        public async Task<IEnumerable<Fireplace>> GetByStyle(FireplaceStyle style)
        {
            return await _context.Fireplaces.Where(f => f.Style == style).ToListAsync();
        }
    }
}
