using MediatR;
using OlgaCourseWork.Common.Models.Responses.Products;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Queries.Products
{
    public class GetProductInfoQuery : IRequest<ProductInfoResponse>
    {
        public Guid Id { get; set; }
        public ProductType Type { get; set; }
    }
}
