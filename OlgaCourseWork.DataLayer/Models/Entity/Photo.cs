using DataLayer.Models.Entity;

namespace OlgaCourseWork.DataLayer.Models.Entity
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Url { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }

}
