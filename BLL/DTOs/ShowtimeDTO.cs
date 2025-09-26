using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ShowtimeDTO
    {
        public int ShowtimeId { get; set; }
        public int MovieId { get; set; }
        public int ScreenId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public float Price { get; set; }
        public string MovieTitle { get; set; }
        public int ScreenNumber { get; set; }
        public string CinemaName { get; set; }
    }
}
