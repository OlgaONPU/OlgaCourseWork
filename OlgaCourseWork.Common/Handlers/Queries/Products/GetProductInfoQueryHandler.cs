using AutoMapper;
using MediatR;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.Common.Models.Responses.Products;
using OlgaCourseWork.Common.Queries.Products;

namespace OlgaCourseWork.Common.Handlers.Queries.Products
{
    public class GetProductInfoQueryHandler : IRequestHandler<GetProductInfoQuery, ProductInfoResponse>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        public GetProductInfoQueryHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<ProductInfoResponse> Handle(GetProductInfoQuery request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProductInfoAsync(request.Id,request.Type, cancellationToken);

            return _mapper.Map<ProductInfoResponse>(product);
        }
    }
}
