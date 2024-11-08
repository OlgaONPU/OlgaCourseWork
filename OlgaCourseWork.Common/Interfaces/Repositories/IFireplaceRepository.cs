using DataLayer.Models.Entity;
using OlgaCourseWork.DataLayer.Enums;


namespace OlgaCourseWork.Common.Interfaces.Repositories
{
    public interface IFireplaceRepository : IProductRepository<Fireplace>
    {
        Task<IEnumerable<Fireplace>> GetByStyle(FireplaceStyle style);
    }
}
