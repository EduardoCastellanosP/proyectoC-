// src/Modules/Variedades/Infrastructure/Configurations/ResistenciaNivelConfig.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Configurations
{
    public class ResistenciaNivelConfig : IEntityTypeConfiguration<ResistenciaNivel>
    {
        public void Configure(EntityTypeBuilder<ResistenciaNivel> b)
        {
            b.ToTable("resistencia_nivel");
            b.HasKey(x => x.Id);
            b.Property(x => x.Id).HasColumnName("id");
            b.Property(x => x.Nombre).IsRequired().HasMaxLength(100).HasColumnName("nombre");
            b.HasIndex(x => x.Nombre).IsUnique();
        }
    }
}
