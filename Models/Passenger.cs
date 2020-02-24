using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Hankins_MIS4200.Models
{
    public class Passenger
    {

        [Key]
        public int passengerId { get; set; }


        [Display (Name ="Passenger Name")]
        [Required(ErrorMessage ="Passenger Name is required")]
        public string passengerName { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)\d{3}-\d{4}$",
            ErrorMessage = "Phone mumbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        public string email { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is required")]
        public string address { get; set; }

        public ICollection<FlightDetail> FlightDetail { get; set; }
    }
}