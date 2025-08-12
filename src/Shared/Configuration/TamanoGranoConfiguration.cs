using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Variedades.Domain.Entities;


namespace proyectc_.src.Shared.Configuration
{
    public class TamanoGranoConfiguration : IEntityTypeConfiguration<TamanoGrano>
    {
        public void Configure(EntityTypeBuilder<TamanoGrano> builder)
        {
            builder.ToTable("tamano_grano");

            builder.HasKey(tg => tg.Id);
            builder.Property(tg => tg.Id).HasColumnName("id");
            builder.Property(tg => tg.Nombre).HasColumnName("nombre").IsRequired().HasMaxLength(100);
            builder.Property(tg => tg.Descripcion).HasColumnName("descripcion").HasMaxLength(500);
        }
    }



}