using OlgaCourseWork.DataLayer.Enums;
using OlgaCourseWork.DataLayer.Models.Entity;
using System.Text.Json.Serialization;

namespace DataLayer.Models.Entity;

public abstract class Product
{
    public Guid Id { get; set; }
    public ProductType Type { get; set; }
    public string Link { get; set; }

    [JsonIgnore]
    public List<Photo> Photos { get; set; }

}

