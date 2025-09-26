using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string Title { get; set; }

        [Column(TypeName = "TEXT")]
        public string Synopsis { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string Director { get; set; }
        public int RuntimeMinutes { get; set; }

        [Column(TypeName = "date")]
        public DateTime ReleaseDate { get; set; }

        [Column(TypeName = "VARCHAR")]
        public string PosterUrl { get; set; }
        public IList<MovieActor> MovieActors { get; } = new List<MovieActor>();
        public IList<Showtime> Showtimes { get; } = new List<Showtime>();
        public IList<Review> Reviews { get; } = new List<Review>();
    }
}
