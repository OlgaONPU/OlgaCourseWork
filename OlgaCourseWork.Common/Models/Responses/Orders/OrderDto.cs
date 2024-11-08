namespace OlgaCourseWork.Common.Models.Responses.Orders
{
    public class OrderDto
    {
        public ProductDto Product { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
