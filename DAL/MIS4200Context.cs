﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hankins_MIS4200.Models;   // this is needed to access the models
using System.Data.Entity;       // this is needed to access the DBContext

namespace Hankins_MIS4200.DAL
{
    public class MIS4200Context : DbContext   // inherits from Dbcontext
    {
        public MIS4200Context() : base("name=DefaultConnection")
        {
            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use

            // add the set initializer statement here
           Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context, Hankins_MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code

       // public System.Data.Entity.DbSet<Hankins_MIS4200.Models.Customer> Customers { get; set; } <-- idk what this is

        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<FlightDetail> FlightDetails { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}