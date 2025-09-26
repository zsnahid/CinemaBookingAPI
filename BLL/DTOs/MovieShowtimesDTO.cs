using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MovieShowtimesDTO
    {
        public MovieDTO Movie { get; set; }
        public List<ShowtimeDTO> Showtimes { get; set; }
    }
}
