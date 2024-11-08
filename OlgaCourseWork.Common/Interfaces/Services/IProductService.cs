using DataLayer.Models.Entity;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync(ProductType type, CancellationToken cancellationToken);
        Task<Product> GetProductInfoAsync(Guid id, ProductType type, CancellationToken cancellationToken);
    }
}
