using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class MovieActor
    {
        public int Id { get; set; }

        [ForeignKey("Movie")]
        public int MovieId { get; set; }

        [ForeignKey("Actor")]
        public int ActorId { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual Actor Actor { get; set; }
    }
}
