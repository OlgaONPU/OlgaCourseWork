using Microsoft.Extensions.DependencyInjection;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Services
{
    public class ProductServiceFactory : IProductServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public ProductServiceFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IProductService GetProductService(ProductType productType)
        {
            switch (productType)
            {
                case ProductType.Doors:
                    return _serviceProvider.GetService<IDoorService>();
                case ProductType.Accessories:
                    return _serviceProvider.GetService<IAccessoryService>();
                case ProductType.Fireplace:
                    return _serviceProvider.GetService<IFireplaceService>();
                case ProductType.HeatingSystem:
                    return _serviceProvider.GetService<IHeatingSystemService>();
                default:
                    throw new ArgumentException($"Repository for {productType} not implemented.");
            }
        }
    }
}
