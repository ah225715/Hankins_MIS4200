using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Hankins_MIS4200.Models
{
    public class FlightDetail
    {
        [Key]
        public int flightId { get; set; }

        [Display(Name = "Departure Airport")]
        [Required(ErrorMessage = "Departure Airport is required")]
        public string depatureAirport { get; set; }

        [Display(Name = "Arrival Airport")]
        [Required(ErrorMessage = "Arrival Airport is required")]
        public string arrivalAirport { get; set; }

        [Display(Name = "Departure Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Departure Time is required")]
        public DateTime departureTime { get; set; }

        [Display(Name = "Arrival Time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:g}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Arrival Time is required")]
        public DateTime arrivalTime { get; set; }

        // the next two properties link the flightDetail to the Plane

        public int planeId { get; set; }
        public virtual Plane Plane { get; set; }

        // the next two properties link the flightDetail to the Passneger
        public int passengerId { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}