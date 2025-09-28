using DAL.EF.Tables;
using System.Collections.Generic;

namespace DAL.Interfaces
{
  public interface IBookingFeature
  {
    List<Seat> GetAvailableSeatsForShowtime(int showtimeId);
    Showtime GetShowtimeData(int showtimeId);
  }
}
