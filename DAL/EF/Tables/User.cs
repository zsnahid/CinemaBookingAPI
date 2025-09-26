using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        [Index(IsUnique = true)]
        public string Email { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string Password { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string UserName { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime CreatedAt { get; set; }
        public IList<Booking> Bookings { get; } = new List<Booking>();
        public IList<Review> Reviews { get; } = new List<Review>();
    }
}
