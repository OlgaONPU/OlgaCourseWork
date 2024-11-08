using DataLayer.Models;
using MediatR;
using OlgaCourseWork.DataLayer.Enums;

namespace OlgaCourseWork.Common.Commands
{
    public class CreateOrderCommand : IRequest<bool>
    {
        public Guid ProductId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public ProductType Type { get; set; }
    }
}
