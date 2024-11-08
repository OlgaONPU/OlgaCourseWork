using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.Common.Interfaces.Services;
using OlgaCourseWork.DataLayer.Models.Entity;

namespace OlgaCourseWork.Common.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IArticleRepository _articleRepository;
        public ArticleService(IArticleRepository articlesRepository)
        {
            _articleRepository = articlesRepository;
        }

        public async Task<IEnumerable<Article>> GetAll()
        {
            return await _articleRepository.GetAllAsync();
        }

        public async Task<Article> GetArticle(Guid id, CancellationToken cancellationToken)
        {
            return await _articleRepository.GetByIdAsync(id);
        }
    }
}
