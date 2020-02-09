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
        public string planeName { get; set; }
        public string airline { get; set; }

        // this is the new property that will be added for the SD2 assignment
        public DateTime dateManufactured { get; set; }

        public ICollection<FlightDetail> FlightDetail { get; set; }
    }
}