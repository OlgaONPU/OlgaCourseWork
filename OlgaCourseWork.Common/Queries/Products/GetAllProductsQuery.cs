using DataLayer.Models;
using MediatR;
using OlgaCourseWork.Common.Models.Responses.Products;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Queries.Products
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductResponse>>
    {
        public ProductType ProductType { get; set; }
    }
}
