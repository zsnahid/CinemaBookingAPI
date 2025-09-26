using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }

        [ForeignKey("Booking")]
        public int BookingId { get; set; }

        [ForeignKey("Seat")]
        public int? SeatId { get; set; }

        [ForeignKey("Showtime")]
        public int ShowtimeId { get; set; }

        public TicketStatus Status { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual Showtime Showtime { get; set; }
    }

    public enum TicketStatus
    {
        BOOKED,
        AVAILABLE,
    }
}
