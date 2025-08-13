using proyectc_.src.Modules.Filtros.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace proyectc_.src.Modules.Filtros.Application.Interfaces
{
    public interface IFiltrosService
    {
        Task<List<Filtro>> FiltrarPorTamanoGranoAsync(int tamanoGranoId);
        Task<List<Filtro>> FiltrarPorPorteAsync(int porteId);
        Task<List<Filtro>> FiltrarPorResistenciaAsync(int resistenciaNivelId);
        Task<List<Filtro>> FiltrarPorRendimientoAsync(int rendimientoPotencialId);
        Task<List<Filtro>> FiltrarPorTipoCafeAsync(int tipoCafeId);
        Task<List<Filtro>> FiltrarPorAltitudAsync(int? altMin, int? altMax);
        Task<List<Filtro>> BuscarPorNombreAsync(string contiene);
    }
}