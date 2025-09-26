using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class PromoCode
    {
        [Key]
        public int PromoCodeId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Code { get; set; }
        public DiscountType DiscountType { get; set; }

        [Required]
        [Column(TypeName = "FLOAT")]
        public float DiscountValue { get; set; }

        [Column(TypeName = "date")]
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
    }

    public enum DiscountType
    {
        PERCENT,
        FIXED,
    }
}
