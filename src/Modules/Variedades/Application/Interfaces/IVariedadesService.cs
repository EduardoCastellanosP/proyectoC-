using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Application.Interfaces;

public interface IVariedadesService
{
    Task<IEnumerable<Variedad?>> ConsultarVariedadesAsync();
    Task<Variedad?> ObtenerVariedadPorIdAsync(int id);
    Task RegistrarVariedadAsync(Variedad entity);
    Task ActualizarVariedadAsync(Variedad entity);
    Task EliminarVariedadAsync(int id);
}
