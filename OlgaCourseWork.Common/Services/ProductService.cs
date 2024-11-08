using DataLayer.Models;
using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductServiceFactory _productFactory;

        public ProductService(IProductServiceFactory productFactory)
        {
            _productFactory = productFactory;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync(ProductType type, CancellationToken cancellationToken)
        {
            var service = _productFactory.GetProductService(type);

            return await service.GetAllProductsAsync(type, cancellationToken);
        }

        public async Task<Product> GetProductInfoAsync(Guid id, ProductType type, CancellationToken cancellationToken)
        {
            var service = _productFactory.GetProductService(type);
            return await service.GetProductInfoAsync(id, type, cancellationToken);
        }
    }
}
