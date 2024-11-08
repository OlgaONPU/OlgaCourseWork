using DataLayer.Models;
using DataLayer.Models.Entity;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Interfaces.Repositories
{
    public interface IProductRepository<T> : IRepository<T> where T: Product
    {
        Task<IEnumerable<T>> GetByProductType(ProductType type);
    }
}
