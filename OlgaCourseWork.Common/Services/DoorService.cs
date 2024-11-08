using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Services
{
    public class DoorService : IDoorService
    {
        private readonly IDoorRepository _doorRepository;
        public DoorService(IDoorRepository doorRepository) 
        {
            _doorRepository = doorRepository;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync(ProductType type, CancellationToken cancellationToken)
        {
            return await _doorRepository.GetByProductType(type);
        }

        public async Task<Product> GetProductInfoAsync(Guid id, ProductType type, CancellationToken cancellationToken)
        {
            return await _doorRepository.GetByIdAsync(id);
        }
    }
}
