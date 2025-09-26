using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Screen
    {
        [Key]
        public int ScreenId { get; set; }

        [ForeignKey("Cinema")]
        public int CinemaId { get; set; }

        [Required]
        public int ScreenNumber { get; set; }

        [Required]
        public int Capacity { get; set; }
        public virtual Cinema Cinema { get; set; }
        public IList<Seat> Seats { get; } = new List<Seat>();
        public IList<Showtime> Showtimes { get; } = new List<Showtime>();
    }
}
