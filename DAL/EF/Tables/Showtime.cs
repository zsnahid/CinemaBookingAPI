using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Showtime
    {
        [Key]
        public int ShowtimeId { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        [ForeignKey("Screen")]
        public int ScreenId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        [Column(TypeName = "FLOAT")]
        public float Price { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Screen Screen { get; set; }
    }
}
