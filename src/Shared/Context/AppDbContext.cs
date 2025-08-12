using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyectc_.src.Modules.Usuarios.Domain.Entities;
using proyectc_.src.Shared.Domain.Entities.Filtros;
using proyectc_.src.Shared.Domain.Entities.Variedades;

namespace proyectc_.src.Shared.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();

    // public DbSet<Filtro> Filtros => Set<Filtro>();

    public DbSet<Variedad> Variedades => Set<Variedad>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }






}