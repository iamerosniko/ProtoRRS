using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Reservation.Models
{
    public class Reservations
    {
        [Key]
        public int ReservationID { get; set; }
        public string RoomName { get; set; }
        public string TimeSlot { get; set; }
        public string TeamName { get; set; }
        public int Players { get; set; }
        public Decimal Amount { get; set; }
        public double TimeElapse { get; set; }
    }
}