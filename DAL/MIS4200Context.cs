using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hankins_MIS4200.Models;
using System.Data.Entity;

namespace Hankins_MIS4200.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }

        public System.Data.Entity.DbSet<Hankins_MIS4200.Models.Customer> Customers { get; set; }
        public DbSet<Orders> Orders { get; set; }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code

        

    }
}