using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Variedades.Application.Interfaces;
using proyectc_.src.Modules.Variedades.Domain.Entities;



namespace proyectc_.src.Modules.Variedades.Application.Services;

public class VariedadesService : IVariedadesService
{
    private readonly IVariedadesRepository _repo;

    public VariedadesService(IVariedadesRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<Variedad?>> ConsultarVariedadesAsync()
    {
        return await _repo.GetAllVariedadesAsync()!;
    }

    public async Task<Variedad?> ObtenerVariedadPorIdAsync(int id)
    {
        return await _repo.GetVariedadByIdAsync(id);
    }

    public async Task RegistrarVariedadAsync(string nombre, string descripcion, string origen)
    {
        var existentes = await _repo.GetAllVariedadesAsync();
        if (existentes.Any(v => v.Nombre == nombre))
        {
            throw new ArgumentException("Ya existe una variedad con ese nombre.");
        }

        var variedad = new Variedad
        {
            Nombre = nombre,
            Descripcion = descripcion,
            Origen = origen
        };

        _repo.Add(variedad);
       _repo.Update(variedad);
    }

    public async Task ActualizarVariedadAsync(int id, string nuevoNombre, string nuevoDescripcion, string nuevoOrigen)
    {
        var variedad = await _repo.GetVariedadByIdAsync(id);
        if (variedad == null)
        
            throw new KeyNotFoundException("No se encontró la variedad especificada.");
        variedad.Nombre = nuevoNombre;
        variedad.Descripcion = nuevoDescripcion;
        variedad.Origen = nuevoOrigen;


        await _repo.UpdateVariedadAsync(entity);
    }

    public async Task EliminarVariedadAsync(int id)
    {
        var Variedad = await _repo.GetVariedadByIdAsync(id);
        if (Variedad != null)
        {
            await _repo.RemoveVariedadAsync(Variedad);
        }
    }
}
