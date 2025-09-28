using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.EF.Tables
{
  public class Booking
  {
    [Key]
    public int BookingId { get; set; }

    [ForeignKey("User")]
    public int UserId { get; set; }

    [ForeignKey("Showtime")]
    public int ShowtimeId { get; set; }

    [Column(TypeName = "FLOAT")]
    public float TotalPrice { get; set; }
    public BookingStatus Status { get; set; }

    [ForeignKey("PromoCode")]
    public int? PromoCodeId { get; set; }
    public DateTime CreatedAt { get; set; }
    public IList<Ticket> Tickets { get; } = new List<Ticket>();

    public virtual User User { get; set; }
    public virtual Showtime Showtime { get; set; }
    public virtual PromoCode PromoCode { get; set; }
  }

  public enum BookingStatus
  {
    PENDING,
    CONFIRMED,
    CANCELLED,
  }
}
