namespace Reservation.Migrations
{
    using Reservation.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Reservation.Models.ReservationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Reservation.Models.ReservationContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
                context.Reservations.AddOrUpdate(
                    p => p.ReservationID, new Reservations
                    {
                        ReservationID=1,
                        RoomName="",
                        Players=2,
                        Amount=(decimal)2.10,
                        TimeElapse=(double)3.10,
                        TeamName="sample"
                    }
                );
        }
    }
}
