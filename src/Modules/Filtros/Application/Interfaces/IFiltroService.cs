using System.Collections.Generic;
using System.Threading.Tasks;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Filtros.Application.Interfaces
{
    public interface IFiltrosService
    {
        // Consultas base
        Task<IEnumerable<Variedad>> ConsultarVariedadesAsync();
        Task<Variedad?> ObtenerVariedadPorIdAsync(int id);

        // Filtros por Id (pueden devolver varias variedades)
        Task<IEnumerable<Variedad>> FiltrarPorTamanoGranoIdAsync(int tamanoGranoId);
        Task<IEnumerable<Variedad>> FiltrarPorPorteIdAsync(int porteId);

        // Filtros extra
        Task<IEnumerable<Variedad>> FiltrarPorAltitudAsync(int? altitudMin, int? altitudMax);
        Task<IEnumerable<Variedad>> BuscarPorNombreAsync(string contiene);
    }
}
