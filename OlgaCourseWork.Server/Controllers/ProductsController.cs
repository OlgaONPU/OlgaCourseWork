using AutoMapper;
using DataLayer.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlgaCourseWork.Common.Models.Responses.Products;
using OlgaCourseWork.Common.Queries.Products;
using OlgaCourseWork.DataLayer.Enums;
using System.ComponentModel.DataAnnotations;

namespace OlgaCourseWork.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public ProductsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("/api/v1/GetAllProductsByType")]
        public async Task<IEnumerable<ProductResponse>> GetAllProductsByType([Required][FromQuery] ProductType type, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetAllProductsQuery() { ProductType = type }, cancellationToken);
        }

        [HttpGet("/api/v1/GetProductInfo")]
        public async Task<ProductInfoResponse> GetProductInfo([Required][FromQuery] Guid id, ProductType type, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new GetProductInfoQuery() { Id = id, Type = type }, cancellationToken);
        }
    }
}
