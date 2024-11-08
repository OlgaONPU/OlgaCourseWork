using OlgaCourseWork.DataLayer.Models.Entity;

namespace OlgaCourseWork.Common.Interfaces.Repositories
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetAllAsync();
        Task<Article> GetByIdAsync(Guid id);
    }
}
