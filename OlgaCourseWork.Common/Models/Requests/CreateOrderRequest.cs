using DataLayer.Models;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Models.Requests
{
    public class CreateOrderRequest
    {
        public Guid ProductId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public ProductType Type { get; set; }
    }
}
