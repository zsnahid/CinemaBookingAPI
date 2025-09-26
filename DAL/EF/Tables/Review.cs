using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [Column(TypeName = "TEXT")]
        public string ReviewText { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
