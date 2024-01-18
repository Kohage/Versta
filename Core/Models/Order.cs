#nullable disable
using Core.Models;
using System.ComponentModel.DataAnnotations;

namespace Versta.Data.Models
{
    public class Order : BaseEntity
    {
        [Required(ErrorMessage = "Поле обязательно")]
        public string SendCity { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string SendAdress { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string ArriveCity { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public string ArriveAdress { get; set; }
        [Required(ErrorMessage = "Поле обязательно")]
        public double Weight { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Поле обязательно")]
        [DisplayFormat(DataFormatString = "{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        public DateOnly PickupDate { get; set; }
    }
}