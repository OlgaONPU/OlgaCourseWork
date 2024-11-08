using AutoMapper;
using MediatR;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.Common.Models.Responses.Articles;
using OlgaCourseWork.Common.Queries.Articles;

namespace OlgaCourseWork.Common.Handlers.Queries.Articles
{
    public class GetArticleQueryHandler : IRequestHandler<GetArticleQuery, ArticleResponse>
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public GetArticleQueryHandler(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public async Task<ArticleResponse> Handle(GetArticleQuery query, CancellationToken cancellationToken)
        {
            var result = await _articleService.GetArticle(query.Id, cancellationToken);

            if (result == null)
                throw new KeyNotFoundException($"Article with ID {query.Id} was not found.");


            return _mapper.Map<ArticleResponse>(result);
        }
        private bool IsValidCommand(GetArticleQuery query)
        {
            if (query == null || query.Id == Guid.Empty)
                return false;

            return true;
        }
    }
}
