using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using proyectc_.src.Modules.Imagenes.Domain.Entities;

namespace proyectc_.src.Shared.Configuration;

public class ImagenConfiguration : IEntityTypeConfiguration<Imagen>
{
    public void Configure(EntityTypeBuilder<Imagen> builder)
    {
        builder.ToTable("Imagenes");
        builder.HasKey(i => i.Path); 
        builder.Property(i => i.Path)
            .IsRequired()
            .HasMaxLength(500); 
        
        builder.Property(i => i.Name)
            .IsRequired()
            .HasMaxLength(200); 
        
    }
}

