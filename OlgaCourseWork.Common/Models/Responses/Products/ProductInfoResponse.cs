using DataLayer.Models;
using OlgaCourseWork.DataLayer.Enums;
using OlgaCourseWork.DataLayer.Models.Entity;

namespace OlgaCourseWork.Common.Models.Responses.Products
{
    public class ProductInfoResponse
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Link { get; set; }
        public string Url { get; set; }

        public DescriptionBase Description { get; set; }
    }
}
