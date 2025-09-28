using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

    [Column(TypeName = "VARCHAR")]
    [StringLength(255)]
    public string? QrCode { get; set; }
    public virtual Booking Booking { get; set; }
    public virtual Seat Seat { get; set; }
    public virtual Showtime Showtime { get; set; }
  }
}
