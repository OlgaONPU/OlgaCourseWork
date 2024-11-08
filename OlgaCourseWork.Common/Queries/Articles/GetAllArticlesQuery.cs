using MediatR;
using OlgaCourseWork.Common.Models.Responses.Articles;

namespace OlgaCourseWork.Common.Queries.Articles
{
    public class GetAllArticlesQuery : IRequest<IEnumerable<ArticleShortResponse>>
    {
    }
}
