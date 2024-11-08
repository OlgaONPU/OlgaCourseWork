using AutoMapper;
using MediatR;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.Common.Models.Responses.Articles;
using OlgaCourseWork.Common.Queries.Articles;

namespace OlgaCourseWork.Common.Handlers.Queries.Articles
{
    public class GetAllArticlesQueryHandler : IRequestHandler<GetAllArticlesQuery, IEnumerable<ArticleShortResponse>>
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public GetAllArticlesQueryHandler(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ArticleShortResponse>> Handle(GetAllArticlesQuery query, CancellationToken cancellationToken)
        {
            var result = await _articleService.GetAll();

            return _mapper.Map<IEnumerable<ArticleShortResponse>>(result);
        }
    }
}
