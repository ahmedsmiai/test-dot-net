using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Cinema
    {
        [Key]
        public int CinemaId { get; set; }
        public string Nom { get;set; }
        public string Localisation { get; set; }
        public virtual ICollection<Salle> Salle { get; set; }



    }
}
