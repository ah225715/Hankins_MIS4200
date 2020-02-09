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
        public string passengerName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        public ICollection<FlightDetail> FlightDetail { get; set; }
    }
}