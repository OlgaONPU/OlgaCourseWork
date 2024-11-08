using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Interfaces.Services
{
    public interface IProductServiceFactory
    {
        IProductService GetProductService(ProductType productType);
    }


}
