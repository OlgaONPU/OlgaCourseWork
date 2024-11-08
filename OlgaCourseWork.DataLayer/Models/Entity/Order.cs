namespace DataLayer.Models.Entity
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string ClientName { get; set; }
        public string ClientPhone { get; set; }
        public DateTime CreateDate { get; set; }

        public Product Product { get; set; }
    }
}
