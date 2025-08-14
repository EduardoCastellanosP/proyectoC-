using Microsoft.EntityFrameworkCore;
using proyectc_.src.Modules.Variedades.Domain.Entities;
using proyectc_.src.Modules.Filtros.Domain.Entities;

namespace proyectc_.src.Shared.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Variedad> Variedades { get; set; } = null!;
        public DbSet<TamanoGrano> TamanosGrano { get; set; } = null!;
        public DbSet<Porte> Portes { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Variedad>(e =>
            {
                e.Property(p => p.Nombre).HasMaxLength(200).IsRequired();
                e.Property(p => p.Descripcion).HasMaxLength(1000);

                e.HasOne(v => v.TamanoGrano).WithMany()
                  .HasForeignKey(v => v.TamanoGranoId);

                e.HasOne(v => v.Porte).WithMany()
                  .HasForeignKey(v => v.PorteId);
            });

            mb.Entity<TamanoGrano>(e =>
            {
                e.Property(p => p.Nombre).HasMaxLength(200).IsRequired();
                e.Property(p => p.Descripcion).HasMaxLength(1000);
            });

            mb.Entity<Porte>(e =>
            {
                e.Property(p => p.Nombre).HasMaxLength(200).IsRequired();
                e.Property(p => p.Descripcion).HasMaxLength(1000);
            });
        }
    }
}
