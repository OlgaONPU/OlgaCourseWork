namespace OlgaCourseWork.Common.Models.Responses.Articles
{
    public abstract class ArticleBase
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}