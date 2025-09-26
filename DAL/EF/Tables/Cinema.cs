using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string Location { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(100)]
        public string City { get; set; }
        public IList<Screen> Screens { get; } = new List<Screen>();
    }
}
