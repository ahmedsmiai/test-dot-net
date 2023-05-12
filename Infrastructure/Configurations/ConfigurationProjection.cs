using Microsoft.EntityFrameworkCore;
using ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Configurations
{
    public class ConfigurationProjection : IEntityTypeConfiguration<Projection>
    {
        public void Configure(EntityTypeBuilder<Projection> builder)
        {
            builder.HasKey(a => new { a.DateProjection, a.FilmFK, a.SalleFK });
        }
    }
}
