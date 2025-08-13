// src/Modules/Variedades/Infrastructure/Configurations/VariedadConfig.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Configurations
{
    public class VariedadConfiguration : IEntityTypeConfiguration<Variedad>
    {
        public void Configure(EntityTypeBuilder<Variedad> builder)
        {
            builder.ToTable("variedades");

            builder.HasKey(v => v.Id);
            builder.Property(v => v.Id).HasColumnName("id");

            builder.Property(v => v.Nombre).IsRequired().HasMaxLength(100).HasColumnName("nombre");
            builder.HasIndex(v => v.Nombre).IsUnique();

            builder.Property(v => v.NombreCientifico).HasMaxLength(150).HasColumnName("nombre_cientifico");
            builder.Property(v => v.Descripcion).HasMaxLength(1000).HasColumnName("descripcion");

            builder.Property(v => v.PorteId).HasColumnName("porte_id");
            builder.Property(v => v.TamanoGranoId).HasColumnName("tamano_grano_id");
            builder.Property(v => v.AltitudMax).HasColumnName("altitud_max");
            builder.Property(v => v.RendimientoPotencialId).HasColumnName("rendimiento_potencial_id");
            builder.Property(v => v.CalidadAltitudNivelId).HasColumnName("calidad_altitud_nivel_id");

            builder.Property(v => v.TiempoCosecha).HasMaxLength(100).HasColumnName("tiempo_cosecha");
            builder.Property(v => v.Maduracion).HasMaxLength(100).HasColumnName("maduracion");
            builder.Property(v => v.Nutricion).HasMaxLength(200).HasColumnName("nutricion");
            builder.Property(v => v.DensidadSiembra).HasMaxLength(100).HasColumnName("densidad_siembra");

            builder.Property(v => v.Obtentor).HasMaxLength(100).HasColumnName("obtentor");
            builder.Property(v => v.Familia).HasMaxLength(100).HasColumnName("familia");
            builder.Property(v => v.GrupoGenetico).HasMaxLength(100).HasColumnName("grupo_genetico");


            builder.Property(v => v.CreadoEn).HasColumnName("creado_en");
            builder.Property(v => v.ActualizadoEn).HasColumnName("actualizado_en");

            // Relaciones opcionales (descomenta cuando tengas las entidades)
            builder.HasOne<Porte>().WithMany().HasForeignKey(v => v.PorteId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne<TamanoGrano>().WithMany().HasForeignKey(v => v.TamanoGranoId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne<RendimientoPotencial>().WithMany().HasForeignKey(v => v.RendimientoPotencialId).OnDelete(DeleteBehavior.SetNull);
            builder.HasOne<CalidadAltitudNivel>().WithMany().HasForeignKey(v => v.CalidadAltitudNivelId).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
