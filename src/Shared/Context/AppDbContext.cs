using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyectc_.src.Modules.Usuarios.Domain.Entities;
using proyectc_.src.Modules.Filtros.Domain.Entities;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Shared.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();

    public DbSet<Filtro> Filtros => Set<Filtro>();

    public DbSet<Variedad> Variedades => Set<Variedad>();

    public DbSet<TamanoGrano> TamanoGranos => Set<TamanoGrano>();
    public DbSet<Porte> Portes => Set<Porte>();
    public DbSet<ResistenciaNivel> ResistenciasNivel => Set<ResistenciaNivel>();
    public DbSet<RendimientoPotencial> RendimientosPotenciales => Set<RendimientoPotencial>();
    public DbSet<TipoCafe> TiposCafe => Set<TipoCafe>();



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }






}