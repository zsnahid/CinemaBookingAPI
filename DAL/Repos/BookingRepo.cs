using DAL.EF;
using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repos
{
  internal class BookingRepo : IRepo<Booking, int, bool>, IBookingFeature
  {
    BMSContext db;

    public BookingRepo()
    {
      db = new BMSContext();
    }

    public bool Create(Booking booking)
    {
      booking.CreatedAt = DateTime.Now;

      // Change the status of selected seats
      var seatIds = booking.Tickets.Select(t => t.SeatId).ToList();
      var selectedSeats = db.Seats.Where(s => seatIds.Contains(s.SeatId)).ToList();
      foreach (var seat in selectedSeats)
      {
        seat.Status = AvailabilityStatus.BOOKED;
      }

      db.Bookings.Add(booking);
      return db.SaveChanges() > 0;
    }

    public bool Delete(int id)
    {
      var booking = db.Bookings.Find(id);
      if (booking == null)
      {
        return false;
      }
      db.Bookings.Remove(booking);
      return db.SaveChanges() > 0;
    }

    public List<Booking> Get()
    {
      return db.Bookings.ToList();
    }

    public Booking Get(int id)
    {
      return db.Bookings.Find(id);
    }

    public bool Update(Booking obj)
    {
      throw new NotImplementedException();
    }

    public List<Seat> GetAvailableSeatsForShowtime(int showtimeId)
    {
      var showtime = db.Showtimes.Find(showtimeId);
      if (showtime == null)
      {
        return null;
      }

      var availableSeats = db.Seats
          .Where(s => s.ScreenId == showtime.ScreenId && s.Status == AvailabilityStatus.AVAILABLE)
          .ToList();
      return availableSeats;
    }

    public Showtime GetShowtimeData(int showtimeId)
    {
      return db.Showtimes.Find(showtimeId);
    }
  }
}
