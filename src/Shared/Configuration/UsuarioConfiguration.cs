using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Usuarios.Domain.Entities;


namespace proyectc_.src.Modules.Usuarios.Infrastructure.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuarios");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
        builder.Property(x => x.Clave).IsRequired().HasMaxLength(200);
        builder.Property(x => x.Rol).IsRequired();              // enum -> int (columna: Rol)

        builder.HasIndex(x => x.Nombre).IsUnique();
    }
}
