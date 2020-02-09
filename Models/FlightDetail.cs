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
        public string depatureAirport { get; set; }
        public string arrivalAirport { get; set; }
        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }

        // the next two properties link the flightDetail to the Plane

        public int planeId { get; set; }
        public virtual Plane Plane { get; set; }

        // the next two properties link the flightDetail to the Passneger
        public int passengerId { get; set; }
        public virtual Passenger Passenger { get; set; }
    }
}