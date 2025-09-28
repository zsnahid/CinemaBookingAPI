using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class SeatDTO
    {
        public int SeatId { get; set; }
        public int ScreenId { get; set; }
        public string RowNumber { get; set; }
        public int SeatNumber { get; set; }
        public AvailabilityStatus Status { get; set; }
    }
}
