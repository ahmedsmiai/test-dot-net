using ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure
{
    public class AMContext: DbContext
    {


        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Salle> Salles { get; set; }
        public DbSet<Projection> Projections { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=CinemaAhmedSmiai;MultipleActiveResultSets=true;Integrated Security=true") ;
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*
            modelBuilder.ApplyConfiguration(new PlaneConfiguration());
            modelBuilder.ApplyConfiguration(new FlightConfiguration());
            modelBuilder.ApplyConfiguration(new PassengerConfiguration());
            modelBuilder.ApplyConfiguration(new TicketConfiguration());

            modelBuilder.Entity<Staff>().ToTable("Staff");
            modelBuilder.Entity<Traveller>().ToTable("Travellers");
            */
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            //ki y9oli configurer toute les propriete besh nesta3mel préconvension men hedhouma
            //    // Pre-convention model configuration goes here
            configurationBuilder
                .Properties<string>()
                .HaveMaxLength(100);
            //configurationBuilder
            //    .Properties<decimal>()
            //        .HavePrecision(8,3);
            /*configurationBuilder
              .Properties<DateTime>()
                  .HaveColumnType("date");*/
        }



    }
}
