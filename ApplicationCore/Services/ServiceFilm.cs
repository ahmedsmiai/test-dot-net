using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationCore.Interfaces;
using ApplicationCore.Domain;
using System.Security.Cryptography.X509Certificates;

namespace ApplicationCore.Services
{
    public class ServiceFilm : Service<Film>, IServiceFilm
    {
        public ServiceFilm(IUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }
    }
}
