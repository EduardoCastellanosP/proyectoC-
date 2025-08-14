using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

// Ajusta estos using a tus namespaces reales:
using proyectc_.src.Modules.Variedades.Domain.Entities;
// Si tus catálogos están en otro namespace, ajústalo aquí:
using proyectc_.src.Modules.Filtros.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Configurations
{
    // =========================
    // Variedad
    // =========================
    public class VariedadConfiguration : IEntityTypeConfiguration<Variedad>
    {
        public void Configure(EntityTypeBuilder<Variedad> builder)
        {
            builder.ToTable("Variedades");

            builder.HasKey(v => v.Id);

            builder.Property(v => v.Nombre)
                   .IsRequired()
                   .HasMaxLength(150);

            builder.Property(v => v.Descripcion)
                   .HasMaxLength(1000);

            // Índices útiles
            builder.HasIndex(v => v.Nombre);
            builder.HasIndex(v => v.TamanoGranoId);
            builder.HasIndex(v => v.PorteId);
            builder.HasIndex(v => v.ResistenciaNivelId);
            builder.HasIndex(v => v.RendimientoPotencialId);
            builder.HasIndex(v => v.CalidadAltitudNivelId);
            builder.HasIndex(v => v.EnfermedadId);
            builder.HasIndex(v => v.ClimaId);
            builder.HasIndex(v => v.DensidadSiembraId);
            builder.HasIndex(v => v.FamiliaId);
            builder.HasIndex(v => v.GrupoGeneticoId);
            builder.HasIndex(v => v.MaduracionId);
            builder.HasIndex(v => v.NutricionId);
            builder.HasIndex(v => v.ObtentorId);
            builder.HasIndex(v => v.TiempoCosechaId);
            builder.HasIndex(v => v.TipoCafeId);
            builder.HasIndex(v => v.AltitudMaximaId);
            builder.HasIndex(v => v.VariedadResistenciaId);

            // Relaciones (Restrict para no borrar catálogos por cascada)
            builder.HasOne<TamanoGrano>().WithMany()
                   .HasForeignKey(v => v.TamanoGranoId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Porte>().WithMany()
                   .HasForeignKey(v => v.PorteId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<ResistenciaNivel>().WithMany()
                   .HasForeignKey(v => v.ResistenciaNivelId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<RendimientoPotencial>().WithMany()
                   .HasForeignKey(v => v.RendimientoPotencialId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<CalidadAltitudNivel>().WithMany()
                   .HasForeignKey(v => v.CalidadAltitudNivelId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Enfermedad>().WithMany()
                   .HasForeignKey(v => v.EnfermedadId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Clima>().WithMany()
                   .HasForeignKey(v => v.ClimaId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<DensidadSiembra>().WithMany()
                   .HasForeignKey(v => v.DensidadSiembraId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Familia>().WithMany()
                   .HasForeignKey(v => v.FamiliaId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<GrupoGenetico>().WithMany()
                   .HasForeignKey(v => v.GrupoGeneticoId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Maduracion>().WithMany()
                   .HasForeignKey(v => v.MaduracionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Nutricion>().WithMany()
                   .HasForeignKey(v => v.NutricionId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Obtentor>().WithMany()
                   .HasForeignKey(v => v.ObtentorId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<TiempoCosecha>().WithMany()
                   .HasForeignKey(v => v.TiempoCosechaId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<TipoCafe>().WithMany()
                   .HasForeignKey(v => v.TipoCafeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<AltitudMaxima>().WithMany()
                   .HasForeignKey(v => v.AltitudMaximaId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<VariedadResistencia>().WithMany()
                   .HasForeignKey(v => v.VariedadResistenciaId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }

    // =========================
    // Catálogos (Id, Nombre)
    // Puedes copiar/pegar y ajustar si algún catálogo
    // tiene más columnas o un nombre distinto.
    // =========================

    public class TamanoGranoConfig : IEntityTypeConfiguration<TamanoGrano>
    {
        public void Configure(EntityTypeBuilder<TamanoGrano> builder)
        {
            builder.ToTable("Cat_TamanoGrano");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique(); // quita IsUnique si permites duplicados
        }
    }

    public class PorteConfig : IEntityTypeConfiguration<Porte>
    {
        public void Configure(EntityTypeBuilder<Porte> builder)
        {
            builder.ToTable("Cat_Porte");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class ResistenciaNivelConfig : IEntityTypeConfiguration<ResistenciaNivel>
    {
        public void Configure(EntityTypeBuilder<ResistenciaNivel> builder)
        {
            builder.ToTable("Cat_ResistenciaNivel");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class RendimientoPotencialConfig : IEntityTypeConfiguration<RendimientoPotencial>
    {
        public void Configure(EntityTypeBuilder<RendimientoPotencial> builder)
        {
            builder.ToTable("Cat_RendimientoPotencial");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class CalidadAltitudNivelConfig : IEntityTypeConfiguration<CalidadAltitudNivel>
    {
        public void Configure(EntityTypeBuilder<CalidadAltitudNivel> builder)
        {
            builder.ToTable("Cat_CalidadAltitudNivel");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class EnfermedadConfig : IEntityTypeConfiguration<Enfermedad>
    {
        public void Configure(EntityTypeBuilder<Enfermedad> builder)
        {
            builder.ToTable("Cat_Enfermedad");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class ClimaConfig : IEntityTypeConfiguration<Clima>
    {
        public void Configure(EntityTypeBuilder<Clima> builder)
        {
            builder.ToTable("Cat_Clima");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class DensidadSiembraConfig : IEntityTypeConfiguration<DensidadSiembra>
    {
        public void Configure(EntityTypeBuilder<DensidadSiembra> builder)
        {
            builder.ToTable("Cat_DensidadSiembra");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class FamiliaConfig : IEntityTypeConfiguration<Familia>
    {
        public void Configure(EntityTypeBuilder<Familia> builder)
        {
            builder.ToTable("Cat_Familia");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class GrupoGeneticoConfig : IEntityTypeConfiguration<GrupoGenetico>
    {
        public void Configure(EntityTypeBuilder<GrupoGenetico> builder)
        {
            builder.ToTable("Cat_GrupoGenetico");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class MaduracionConfig : IEntityTypeConfiguration<Maduracion>
    {
        public void Configure(EntityTypeBuilder<Maduracion> builder)
        {
            builder.ToTable("Cat_Maduracion");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class NutricionConfig : IEntityTypeConfiguration<Nutricion>
    {
        public void Configure(EntityTypeBuilder<Nutricion> builder)
        {
            builder.ToTable("Cat_Nutricion");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class ObtentorConfig : IEntityTypeConfiguration<Obtentor>
    {
        public void Configure(EntityTypeBuilder<Obtentor> builder)
        {
            builder.ToTable("Cat_Obtentor");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class TiempoCosechaConfig : IEntityTypeConfiguration<TiempoCosecha>
    {
        public void Configure(EntityTypeBuilder<TiempoCosecha> builder)
        {
            builder.ToTable("Cat_TiempoCosecha");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class TipoCafeConfig : IEntityTypeConfiguration<TipoCafe>
    {
        public void Configure(EntityTypeBuilder<TipoCafe> builder)
        {
            builder.ToTable("Cat_TipoCafe");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class AltitudMaximaConfig : IEntityTypeConfiguration<AltitudMaxima>
    {
        public void Configure(EntityTypeBuilder<AltitudMaxima> builder)
        {
            builder.ToTable("Cat_AltitudMaxima");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }

    public class VariedadResistenciaConfig : IEntityTypeConfiguration<VariedadResistencia>
    {
        public void Configure(EntityTypeBuilder<VariedadResistencia> builder)
        {
            builder.ToTable("Cat_VariedadResistencia");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre).IsRequired().HasMaxLength(120);
            builder.HasIndex(e => e.Nombre).IsUnique();
        }
    }
}
