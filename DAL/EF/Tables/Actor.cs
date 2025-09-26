﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Actor
    {
        [Key]
        public int ActorId { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR")]
        public string Name { get; set; }
    }
}
