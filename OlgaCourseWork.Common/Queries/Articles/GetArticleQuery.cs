using MediatR;
using OlgaCourseWork.Common.Models.Responses.Articles;

namespace OlgaCourseWork.Common.Queries.Articles
{
    public class GetArticleQuery : IRequest<ArticleResponse>
    {
        public Guid Id { get; set; }
    }
}
