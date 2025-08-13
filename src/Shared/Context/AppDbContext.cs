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
    public DbSet<Variedad> Variedades => Set<Variedad>();

    public DbSet<TamanoGrano> TamanoGranos => Set<TamanoGrano>();
    public DbSet<Porte> Portes => Set<Porte>();
    public DbSet<ResistenciaNivel> ResistenciasNivel => Set<ResistenciaNivel>();
    public DbSet<RendimientoPotencial> RendimientosPotenciales => Set<RendimientoPotencial>();
    public DbSet<TipoCafe> TiposCafe => Set<TipoCafe>();
    public DbSet<CalidadAltitudNivel> CalidadAltitudNiveles => Set<CalidadAltitudNivel>();
    
    public DbSet<Maduracion> Maduracions => Set<Maduracion>();

    public DbSet<GrupoGenetico> GruposGeneticos => Set<GrupoGenetico>();

    public DbSet<AltitudMaxima> AltitudMaximas => Set<AltitudMaxima>();
   
    public DbSet<Familia> Familias => Set<Familia>();

    public DbSet<Obtentor> Obtentors => Set<Obtentor>();

    public DbSet<Clima> Climas => Set<Clima>();

    
    public DbSet<TiempoCosecha> TiempoCosechas => Set<TiempoCosecha>();

    public DbSet<Nutricion> Nutricions => Set<Nutricion>();

    public DbSet<DensidadSiembra> DensidadSiembras => Set<DensidadSiembra>();

    public DbSet<Enfermedad> Enfermedades => Set<Enfermedad>();


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }






}