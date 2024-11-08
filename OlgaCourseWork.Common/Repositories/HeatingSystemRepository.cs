using DataLayer;
using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Interfaces.Repositories;

namespace OlgaCourseWork.Common.Repositories
{
    public class HeatingSystemRepository : ProductRepository<HeatingSystem>, IHeatingSystemRepository
    {
        public HeatingSystemRepository(PrometeiDbContext context) : base(context) { }
    }
}
