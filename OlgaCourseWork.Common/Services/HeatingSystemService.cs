using DataLayer.Models.Entity;
using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Services
{
    public class HeatingSystemService : IHeatingSystemService
    {
        private readonly IHeatingSystemRepository _heatingSystemRepository;
        public HeatingSystemService(IHeatingSystemRepository heatingSystemRepository) 
        {
            _heatingSystemRepository = heatingSystemRepository;
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync(ProductType type, CancellationToken cancellationToken)
        {
            return await _heatingSystemRepository.GetByProductType(type);
        }

        public Task<Product> GetProductInfoAsync(Guid id, ProductType type, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
