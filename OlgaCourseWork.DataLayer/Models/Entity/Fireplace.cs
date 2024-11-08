using OlgaCourseWork.DataLayer.Enums;

namespace DataLayer.Models.Entity
{
    public class Fireplace : Product
    {

        public FireplaceStyle Style { get; set; }
        public FireplaceDescription Description { get; set; }
    }
}
