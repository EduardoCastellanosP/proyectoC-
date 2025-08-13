// src/Modules/Variedades/Infrastructure/Configurations/VariedadResistenciaConfig.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Configurations
{
    public class VariedadResistenciaConfig : IEntityTypeConfiguration<VariedadResistencia>
    {
        public void Configure(EntityTypeBuilder<VariedadResistencia> builder)
        {
            builder.ToTable("variedad_resistencia");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");

            builder.Property(x => x.VariedadId).HasColumnName("variedad_id");
            builder.Property(x => x.EnfermedadId).HasColumnName("enfermedad_id");
            builder.Property(x => x.Id).HasColumnName("resistencia_nivel_id");

            builder.HasIndex(x => new { x.VariedadId, x.EnfermedadId }).IsUnique();

            // Relaciones (ajusta los nombres de navegación si las tienes en tus entidades)
            builder.HasOne<Variedad>()
             .WithMany()
             .HasForeignKey(x => x.VariedadId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<Enfermedad>()
             .WithMany()
             .HasForeignKey(x => x.EnfermedadId)
             .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne<ResistenciaNivel>()
             .WithMany()
             .HasForeignKey(x => x.Id)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
