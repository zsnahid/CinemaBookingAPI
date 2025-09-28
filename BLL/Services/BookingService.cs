using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;

namespace BLL.Services
{
  public class BookingService
  {
    public static Mapper GetMapper()
    {
      var config = new MapperConfiguration(cfg =>
      {
        cfg.CreateMap<Booking, BookingDTO>().ReverseMap();
        cfg.CreateMap<Seat, SeatDTO>().ReverseMap();
      });
      return new Mapper(config);
    }

    public static List<BookingDTO> Get()
    {
      var bookings = DataAccessFactory.BookingData().Get();
      return GetMapper().Map<List<BookingDTO>>(bookings);
    }

    public BookingDTO Get(int bookingId)
    {
      var booking = DataAccessFactory.BookingData().Get();
      return GetMapper().Map<BookingDTO>(booking);
    }

    public static bool Create(BookingDTO bookingDTO)
    {
      var booking = GetMapper().Map<Booking>(bookingDTO);
      return DataAccessFactory.BookingData().Create(booking);
    }

    public static bool Update(BookingDTO bookingDTO)
    {
      var booking = GetMapper().Map<Booking>(bookingDTO);
      return DataAccessFactory.BookingData().Update(booking);
    }

    public static bool Delete(int bookingId)
    {
      return DataAccessFactory.BookingData().Delete(bookingId);
    }

    public static List<SeatDTO> GetAvailableSeatsForShowtime(int showtimeId)
    {
      var availableSeats = DataAccessFactory
          .BookingFeature()
          .GetAvailableSeatsForShowtime(showtimeId);
      return GetMapper().Map<List<SeatDTO>>(availableSeats);
    }
    public static bool CreatePendingBooking(int showtimeId, BookingRequestDTO bookingRequestDTO)
    {
      var user = DataAccessFactory.UserData().Get(bookingRequestDTO.UserId);
      if (user == null)
      {
        throw new ArgumentException("User not found!");
      }

      var showtimeData = DataAccessFactory.BookingFeature().GetShowtimeData(showtimeId);

      // Create a new booking
      var booking = new Booking
      {
        UserId = bookingRequestDTO.UserId,
        ShowtimeId = showtimeId,
        TotalPrice = showtimeData.Price * bookingRequestDTO.SeatIds.Count,
        Status = BookingStatus.PENDING,
      };

      // Create a ticket for each selected seat
      foreach (var seatId in bookingRequestDTO.SeatIds)
      {
        booking.Tickets.Add(
          new Ticket
          {
            SeatId = seatId,
            ShowtimeId = showtimeId,
            QrCode = Guid.NewGuid().ToString(),
          });
      }
      return DataAccessFactory.BookingData().Create(booking);
    }
  }
}


