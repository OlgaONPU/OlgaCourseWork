using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Services
{
    public class AccessoryService : IAccessoryService
    {
        private readonly IAccessoryRepository _accessoryService;
        public AccessoryService(IAccessoryRepository accessoryRepository)
        {
            _accessoryService = accessoryRepository;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync(ProductType type, CancellationToken cancellationToken)
        {
            return await _accessoryService.GetByProductType(type);
        }

        public Task<Product> GetProductInfoAsync(Guid id, ProductType type, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
