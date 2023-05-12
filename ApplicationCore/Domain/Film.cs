using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{


    public class Film
    {
        public enum TypeFilm
        {
            Fiction, Action,Comedie, Autre

        }

        [Key]
        public int FilmId { get; set; }
        public string Titre { get; set; }

        public double Duree { get; set; }

        public DateTime DateRealisation { get; set; }

        public double Prix { get; set; }

        public TypeFilm typeFilm { get; set; }

        public virtual ICollection<Projection> projection { get; set; }
    }
}
