using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Seat
    {
        [Key]
        public int SeatId { get; set; }

        [ForeignKey("Screen")]
        public int ScreenId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string RowNumber { get; set; }

        [Required]
        public int SeatNumber { get; set; }
        public AvailabilityStatus Status { get; set; }
        public virtual Screen Screen { get; set; }
    }

    public enum AvailabilityStatus
    {
        AVAILABLE,
        BOOKED,
    }
}
