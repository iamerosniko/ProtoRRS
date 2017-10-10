﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Reservation.Models
{
    public class ReservationContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public ReservationContext() : base("name=ReservationContext")
        {
        }

        public System.Data.Entity.DbSet<Reservation.Models.Reservations> Reservations { get; set; }
    
    }
}
