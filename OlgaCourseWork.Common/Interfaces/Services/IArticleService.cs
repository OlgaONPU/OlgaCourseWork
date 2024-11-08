using DataLayer.Models.Entity;
using OlgaCourseWork.DataLayer.Models.Entity;

namespace OlgaCourseWork.Common.Interfaces.Services
{
    public interface IArticleService
    {
        Task<IEnumerable<Article>> GetAll();
        Task<Article> GetArticle(Guid id, CancellationToken cancellationToken);
    }
}
