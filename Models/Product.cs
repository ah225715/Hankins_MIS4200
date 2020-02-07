using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hankins_MIS4200.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        public int supplierId { get; set; }

        // ad any other fields as appropriate

        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        // we indicate that with an ICollection

        public ICollection<OrderDetail> OrderDetail { get; set; }
    }
}