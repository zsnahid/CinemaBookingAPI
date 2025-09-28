using DAL.EF.Tables;
using System;

namespace BLL.DTOs
{
  public class BookingDTO
  {
    public int BookingId { get; set; }
    public int UserId { get; set; }
    public int ShowtimeId { get; set; }
    public float TotalPrice { get; set; }
    public BookingStatus Status { get; set; }
    public string QrCode { get; set; }
    public int? PromoCodeId { get; set; }
    public DateTime CreatedAt { get; set; }
  }
}

