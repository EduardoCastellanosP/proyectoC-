// src/Modules/Variedades/Infrastructure/Configurations/VariedadResistenciaConfig.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Configurations
{
    public class VariedadResistenciaConfig : IEntityTypeConfiguration<VariedadResistencia>
    {
        public void Configure(EntityTypeBuilder<VariedadResistencia> b)
        {
            b.ToTable("variedad_resistencia");

            b.HasKey(x => x.Id);
            b.Property(x => x.Id).HasColumnName("id");

            b.Property(x => x.VariedadId).HasColumnName("variedad_id");
            b.Property(x => x.EnfermedadId).HasColumnName("enfermedad_id");
            b.Property(x => x.ResistenciaNivelId).HasColumnName("resistencia_nivel_id");

            b.HasIndex(x => new { x.VariedadId, x.EnfermedadId }).IsUnique();

            // Relaciones (ajusta los nombres de navegación si las tienes en tus entidades)
            b.HasOne<Variedad>()
             .WithMany()
             .HasForeignKey(x => x.VariedadId)
             .OnDelete(DeleteBehavior.Cascade);

            b.HasOne<Enfermedad>()
             .WithMany()
             .HasForeignKey(x => x.EnfermedadId)
             .OnDelete(DeleteBehavior.Cascade);

            b.HasOne<ResistenciaNivel>()
             .WithMany()
             .HasForeignKey(x => x.ResistenciaNivelId)
             .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
