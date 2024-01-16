#nullable disable
namespace Versta.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string SendCity { get; set; }
        public string SendAdress { get; set; }
        public string ArriveCity { get; set; }
        public string ArriveAdress { get; set; }
        public double Weight { get; set;}
        public DateOnly PickupDate { get; set; }
    }
}