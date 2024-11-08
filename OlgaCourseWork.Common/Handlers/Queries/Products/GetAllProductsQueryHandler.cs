using AutoMapper;
using MediatR;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.Common.Models.Responses.Products;
using OlgaCourseWork.Common.Queries.Products;

namespace OlgaCourseWork.Common.Handlers.Queries.Products
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductResponse>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public GetAllProductsQueryHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductResponse>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _productService.GetAllProductsAsync(request.ProductType, cancellationToken);

            return _mapper.Map<IEnumerable<ProductResponse>>(products);
        }
    }
}
