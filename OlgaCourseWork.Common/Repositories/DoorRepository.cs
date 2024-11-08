using DataLayer;
using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Interfaces.Repositories;

namespace OlgaCourseWork.Common.Repositories
{
    public class DoorRepository : ProductRepository<Door>, IDoorRepository
    {
        public DoorRepository(PrometeiDbContext context) : base(context) { }
    }
}
