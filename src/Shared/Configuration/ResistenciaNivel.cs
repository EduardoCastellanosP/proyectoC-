// src/Modules/Variedades/Infrastructure/Configurations/ResistenciaNivelConfig.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Configurations
{
    public class ResistenciaNivelConfig : IEntityTypeConfiguration<ResistenciaNivel>
    {
        public void Configure(EntityTypeBuilder<ResistenciaNivel> builder)
        {
            builder.ToTable("resistencia_nivel");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(100).HasColumnName("nombre");
            builder.HasIndex(x => x.Nombre).IsUnique();
        }
    }
}
