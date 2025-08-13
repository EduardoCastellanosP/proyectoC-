// src/Modules/Variedades/Infrastructure/Configurations/EnfermedadConfig.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Configurations
{
    public class EnfermedadConfig : IEntityTypeConfiguration<Enfermedad>
    {
        public void Configure(EntityTypeBuilder<Enfermedad> builder)
        {
            builder.ToTable("enfermedad");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(150).HasColumnName("nombre");
            builder.HasIndex(x => x.Nombre).IsUnique();
        }
    }
}
