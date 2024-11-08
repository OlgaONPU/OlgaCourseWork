namespace DataLayer.Models
{
    public abstract class DescriptionBase
    {
        public string Title { get; set; }
    }

    public class FireplaceDescription : DescriptionBase
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public decimal Price { get; set; }
    }

    public class DoorDescription : DescriptionBase
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public decimal Price { get; set; }
    }

    public class AccessoryDescription : DescriptionBase
    {
        public string Details { get; set; }
        public decimal Price { get; set; }
    }

    public class HeatingSystemDescription : DescriptionBase
    {
        public string Power { get; set; }
        public string Efficiency { get; set; }
        public decimal Price { get; set; }
    }
}
