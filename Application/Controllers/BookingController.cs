using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Application.Controllers
{
  [RoutePrefix("api/booking")]
  public class BookingController : ApiController
  {
    [HttpGet]
    [Route("showtime/{showtimeId}/seats")]
    public HttpResponseMessage GetSeats(int showtimeId)
    {
      var res = BookingService.GetAvailableSeatsForShowtime(showtimeId);
      return Request.CreateResponse(HttpStatusCode.OK, res);
    }

    // Create a PENDING booking for selected seats;
    // until the payment is completed
    [HttpPost]
    [Route("showtime/{showtimeId}/seats/reserve")]
    public HttpResponseMessage ReserveSeats(int showtimeId, BookingRequestDTO bookingRequestDTO)
    {
      try
      {
        if (bookingRequestDTO.SeatIds.Count == 0)
        {
          return Request.CreateResponse(HttpStatusCode.BadRequest, "No seats selected");
        }
        var res = BookingService.CreatePendingBooking(showtimeId, bookingRequestDTO);
        return Request.CreateResponse(HttpStatusCode.OK, "Booking is pending. Complete payment to confirm.");
      }
      catch (ArgumentException ex)
      {
        return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
      }
      catch (Exception ex)
      {
        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex);
      }
    }
  }
}
