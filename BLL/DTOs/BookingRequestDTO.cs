using System.Collections.Generic;

namespace BLL.DTOs
{
  public class BookingRequestDTO
  {
    public int UserId { get; set; }
    public List<int> SeatIds { get; set; }
  }
}
