using DataLayer.Models.Entity;
using MediatR;

namespace OlgaCourseWork.Common.Queries.Orders
{
    public class GetOrdersQuery : IRequest<IEnumerable<Order>>
    {
        public string ClientPhone { get; set; }
    }
}
