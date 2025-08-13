// src/Modules/Variedades/Infrastructure/Configurations/CalidadAltitudNivelConfig.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Configurations
{
    public class CalidadAltitudNivelConfig : IEntityTypeConfiguration<CalidadAltitudNivel>
    {
        public void Configure(EntityTypeBuilder<CalidadAltitudNivel> builder)
        {
            builder.ToTable("calidad_altitud_nivel");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(100).HasColumnName("nombre");
            builder.HasIndex(x => x.Nombre).IsUnique();
        }
    }
}
