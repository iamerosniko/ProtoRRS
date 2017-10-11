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
                    p => p.ReservationID, 
                    new Reservations
                    {
                        ReservationID=1,
                        RoomName="Mystery Room",
                        TimeSlot = "10:00 - 10:30 AM"
                    },
                    new Reservations
                    {
                        ReservationID=2,
                        RoomName="Mystery Room",
                        TimeSlot = "10:30 - 11:00 AM"
                    },
                    new Reservations
                    {
                        ReservationID=3,
                        RoomName="Mystery Room",
                        TimeSlot = "11:00 - 11:30 AM"
                    },
                    new Reservations
                    {
                        ReservationID=4,
                        RoomName="Mystery Room",
                        TimeSlot = "11:30 - 12:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=5,
                        RoomName="Mystery Room",
                        TimeSlot = "1:00 - 1:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=6,
                        RoomName="Mystery Room",
                        TimeSlot = "1:30 - 2:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=7,
                        RoomName="Mystery Room",
                        TimeSlot = "2:00 - 2:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=8,
                        RoomName="Mystery Room",
                        TimeSlot = "2:30 - 3:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=9,
                        RoomName="Mystery Room",
                        TimeSlot = "3:00 - 3:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=10,
                        RoomName="Mystery Room",
                        TimeSlot = "3:30 - 4:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=11,
                        RoomName="Mystery Room",
                        TimeSlot = "4:00 - 4:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=12,
                        RoomName="Mystery Room",
                        TimeSlot = "4:30 - 5:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=13,
                        RoomName="Mystery Room",
                        TimeSlot = "5:00 - 5:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=14,
                        RoomName="Mystery Room",
                        TimeSlot = "5:30 - 6:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=15,
                        RoomName="Mystery Room",
                        TimeSlot = "6:00 - 6:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=16,
                        RoomName="Mystery Room",
                        TimeSlot = "6:30 - 7:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=17,
                        RoomName="Mystery Room",
                        TimeSlot = "7:00 - 7:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=18,
                        RoomName="Mystery Room",
                        TimeSlot = "7:30 - 8:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=19,
                        RoomName="Mystery Room",
                        TimeSlot = "8:00 - 8:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=20,
                        RoomName="Mystery Room",
                        TimeSlot = "8:30 - 9:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=21,
                        RoomName="Mystery Room",
                        TimeSlot = "9:00 - 9:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=22,
                        RoomName="Mystery Room",
                        TimeSlot = "9:30 - 10:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=23,
                        RoomName="Mystery Room",
                        TimeSlot = "10:00 - 10:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=24,
                        RoomName="Mystery Room",
                        TimeSlot = "10:30 - 11:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=25,
                        RoomName="Mystery Room",
                        TimeSlot = "11:00 - 11:30 PM"
                    }
                );


            context.Reservations.AddOrUpdate(
                    p => p.ReservationID, 
                    new Reservations
                    {
                        ReservationID=26,
                        RoomName="Breakout Room",
                        TimeSlot = "10:00 - 10:30 AM"
                    },
                    new Reservations
                    {
                        ReservationID=27,
                        RoomName="Breakout Room",
                        TimeSlot = "10:30 - 11:00 AM"
                    },
                    new Reservations
                    {
                        ReservationID=28,
                        RoomName="Breakout Room",
                        TimeSlot = "11:00 - 11:30 AM"
                    },
                    new Reservations
                    {
                        ReservationID=29,
                        RoomName="Breakout Room",
                        TimeSlot = "11:30 - 12:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=30,
                        RoomName="Breakout Room",
                        TimeSlot = "1:00 - 1:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=31,
                        RoomName="Breakout Room",
                        TimeSlot = "1:30 - 2:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=32,
                        RoomName="Breakout Room",
                        TimeSlot = "2:00 - 2:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=33,
                        RoomName="Breakout Room",
                        TimeSlot = "2:30 - 3:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=34,
                        RoomName="Breakout Room",
                        TimeSlot = "3:00 - 3:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=35,
                        RoomName="Breakout Room",
                        TimeSlot = "3:30 - 4:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=36,
                        RoomName="Breakout Room",
                        TimeSlot = "4:00 - 4:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=37,
                        RoomName="Breakout Room",
                        TimeSlot = "4:30 - 5:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=38,
                        RoomName="Breakout Room",
                        TimeSlot = "5:00 - 5:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=39,
                        RoomName="Breakout Room",
                        TimeSlot = "5:30 - 6:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=40,
                        RoomName="Breakout Room",
                        TimeSlot = "6:00 - 6:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=41,
                        RoomName="Breakout Room",
                        TimeSlot = "6:30 - 7:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=42,
                        RoomName="Breakout Room",
                        TimeSlot = "7:00 - 7:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=43,
                        RoomName="Breakout Room",
                        TimeSlot = "7:30 - 8:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=44,
                        RoomName="Breakout Room",
                        TimeSlot = "8:00 - 8:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=45,
                        RoomName="Breakout Room",
                        TimeSlot = "8:30 - 9:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=46,
                        RoomName="Breakout Room",
                        TimeSlot = "9:00 - 9:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=47,
                        RoomName="Breakout Room",
                        TimeSlot = "9:30 - 10:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=48,
                        RoomName="Breakout Room",
                        TimeSlot = "10:00 - 10:30 PM"
                    },
                    new Reservations
                    {
                        ReservationID=49,
                        RoomName="Breakout Room",
                        TimeSlot = "10:30 - 11:00 PM"
                    },
                    new Reservations
                    {
                        ReservationID=50,
                        RoomName="Breakout Room",
                        TimeSlot = "11:00 - 11:30 PM"
                    }
                );
        }
    }
}
