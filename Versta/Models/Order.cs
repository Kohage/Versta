#nullable disable
using System.ComponentModel.DataAnnotations;

namespace Versta.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string SendCity { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string SendAdress { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string ArriveCity { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string ArriveAdress { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public double Weight { get; set;}
        [Required(ErrorMessage = "Поле обязательно")]
        public DateOnly PickupDate { get; set; }
    }
}