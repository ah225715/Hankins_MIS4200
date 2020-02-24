using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Hankins_MIS4200.Models
{
    public class Plane
    {

        [Key]
        public int planeId { get; set; }

        [Display(Name = "Plane Name")]
        [Required(ErrorMessage = "Plane Name is required")]
        public string planeName { get; set; }

        [Display(Name = "Airline")]
        [Required(ErrorMessage = "Airline is required")]
        public string airline { get; set; }

        // this is the new property that will be added for the SD2 assignment

        [Display(Name = "Date Manufactured")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Date Manufactured is required")]
        public DateTime dateManufactured { get; set; }

        public ICollection<FlightDetail> FlightDetail { get; set; }
    }
}