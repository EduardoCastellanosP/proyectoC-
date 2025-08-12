using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Usuarios.Domain.Entities;

namespace proyectc_.src.Modules.Usuarios.Infrastructure.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> b)
    {
        b.ToTable("usuarios");
        b.HasKey(x => x.Id);

        b.Property(x => x.Nombre).IsRequired().HasMaxLength(50);
        b.Property(x => x.Clave).IsRequired().HasMaxLength(200);
        b.Property(x => x.Rol).IsRequired();              // enum -> int (columna: Rol)

        b.HasIndex(x => x.Nombre).IsUnique();
    }
}
