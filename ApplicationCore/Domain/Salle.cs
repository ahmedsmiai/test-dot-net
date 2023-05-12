using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Salle
    {
        [Key]
        public int IdSalle { get; set; }



        [Required(ErrorMessage ="numero de salle obligatoire")]
        public int Numero { get; set; }



        [Range(1, 50)]
        public int NbPlaces { get; set; }
        public virtual Cinema Cinema { get; set; }
        public int CinemaFK { get; set; }

        public virtual ICollection<Projection> projection { get; set; }

    }
}
