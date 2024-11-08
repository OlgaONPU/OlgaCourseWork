using DataLayer;
using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Interfaces.Repositories;

namespace OlgaCourseWork.Common.Repositories
{
    public class AccessoryRepository : ProductRepository<Accessory>, IAccessoryRepository
    {
        public AccessoryRepository(PrometeiDbContext context) : base(context) { }
    }
}
