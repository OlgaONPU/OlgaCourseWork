using DataLayer;
using OlgaCourseWork.Common.Interfaces.Repositories;
using OlgaCourseWork.DataLayer.Models.Entity;

namespace OlgaCourseWork.Common.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(PrometeiDbContext context) : base(context)
        {
        }
    }
}
