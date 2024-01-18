#nullable disable
using Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Versta.Data.Models
{
    public class Order : BaseEntity
    {
        public string SendCity { get; set; }
        public string SendAdress { get; set; }
        public string ArriveCity { get; set; }
        public string ArriveAdress { get; set; }
        public double Weight { get; set; }
        public DateOnly PickupDate { get; set; }
    }
}