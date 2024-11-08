using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OlgaCourseWork.Common.Models.Responses.Articles;
using OlgaCourseWork.Common.Queries.Articles;

namespace OlgaCourseWork.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticlesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;


        public ArticlesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet("/api/v1/GetArticle")]
        public async Task<ArticleResponse> GetArticle(Guid id)
        {
            return await _mediator.Send(new GetArticleQuery { Id = id });
        }

        [HttpGet("/api/v1/GetAll")]
        public async Task<IEnumerable<ArticleShortResponse>> GetAll()
        {
            return await _mediator.Send(new GetAllArticlesQuery());
        }
    }
}
