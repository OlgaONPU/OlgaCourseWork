using DataLayer.Models;
using DataLayer.Models.Entity;
using Newtonsoft.Json.Linq;
using OlgaCourseWork.DataLayer.Enums;
using OlgaCourseWork.DataLayer.Models.Entity;

namespace DataLayer
{


    public static class DataInitializer
    {
        public static void Seed(PrometeiDbContext context)
        {
            var filePath = Path.Combine(AppContext.BaseDirectory, "data.json");
            var jsonData = File.ReadAllText(filePath);

            var jsonObject = JObject.Parse(jsonData);
            var productsToken = jsonObject["products"];

            var fireplaces = new List<Fireplace>();
            var doors = new List<Door>();
            var accessories = new List<Accessory>();
            var heatingSystems = new List<HeatingSystem>();

            var fireplacesToken = productsToken["fireplaces"];
            foreach (var category in fireplacesToken)
            {
                foreach (var item in category.First)
                {
                    var fireplace = DeserializeProduct<Fireplace, FireplaceDescription>(item);
                    AddPhotosFromToken(fireplace, item["photos"]);
                    fireplaces.Add(fireplace);
                }
            }

            var doorsToken = productsToken["doors"];
            foreach (var item in doorsToken)
            {
                var door = DeserializeProduct<Door, DoorDescription>(item);
                AddPhotosFromToken(door, item["photos"]);
                doors.Add(door);
            }

            var accessoriesToken = productsToken["accessories"];
            foreach (var item in accessoriesToken)
            {
                var accessory = DeserializeProduct<Accessory, AccessoryDescription>(item);
                AddPhotosFromToken(accessory, item["photos"]);
                accessories.Add(accessory);
            }

            var heatingSystemsToken = productsToken["heatingSystems"];
            foreach (var item in heatingSystemsToken)
            {
                var heatingSystem = DeserializeProduct<HeatingSystem, HeatingSystemDescription>(item);
                AddPhotosFromToken(heatingSystem, item["photos"]);
                heatingSystems.Add(heatingSystem);
            }

            context.Fireplaces.AddRange(fireplaces);
            context.Doors.AddRange(doors);
            context.Accessories.AddRange(accessories);
            context.HeatingSystems.AddRange(heatingSystems);

            context.SaveChanges();
        }

        private static TProduct DeserializeProduct<TProduct, TDescription>(JToken item)
            where TProduct : Product, new()
            where TDescription : DescriptionBase
        {
            var product = new TProduct
            {
                Id = Guid.Parse(item.Value<string>("id")),
                Type = (ProductType)Enum.Parse(typeof(ProductType), item.Value<string>("type"), true),
                Link = item.Value<string>("link"),
                Photos = new List<Photo>(),
            };

            var descriptionToken = item["description"];
            if (descriptionToken != null)
            {
                var description = descriptionToken.ToObject<TDescription>();
                if (typeof(TProduct).GetProperty("Description") != null)
                {
                    typeof(TProduct).GetProperty("Description").SetValue(product, description);
                }
            }

            return product;
        }

        private static void AddPhotosFromToken(Product product, JToken photosToken)
        {
            if (photosToken != null)
            {
                if (product.Photos == null)
                    product.Photos = new List<Photo>();

                foreach (var photoUrl in photosToken)
                {
                    var photo = new Photo
                    {
                        Id = Guid.NewGuid(),
                        Url = photoUrl.ToString(),
                        ProductId = product.Id,
                        Product = product
                    };
                    product.Photos.Add(photo);
                }
            }
        }
    }
}
