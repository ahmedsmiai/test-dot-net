using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Projection
    {
        [Key]
        public DateTime DateProjection { get; set; }
        public string TypeProjection { get; set; }

        public virtual Salle Salle { get; set; }

        [ForeignKey("Salle")]
        public int SalleFK { get; set; }
        public virtual Film Film { get; set; }
        [ForeignKey("Film")]
        public int FilmFK { get; set; }
    }
}
