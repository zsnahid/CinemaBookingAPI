using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MovieDTO
    {
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Director { get; set; }
        public int RuntimeMinutes { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string PosterUrl { get; set; }
    }
}
