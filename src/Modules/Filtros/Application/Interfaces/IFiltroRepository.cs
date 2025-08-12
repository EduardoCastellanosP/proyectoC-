using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Filtros.Domain.Entities;

namespace proyectc_.src.Modules.Filtros.Application.Interfaces
{
    public interface IFiltroRepository
    {
        IEnumerable<Variedad> GetAllVarieties();
        IEnumerable<Variedad> FilterVarieties(Dictionary<string, object> filters);
        IEnumerable<Porte> GetPorteOptions();
        IEnumerable<TamanoGrano> GetTamanoGranoOptions();
        IEnumerable<RendimientoPotencial> GetRendimientoOptions();
        IEnumerable<CalidadAltitudNivel> GetCalidadAltitudOptions();
        IEnumerable<Enfermedad> GetEnfermedadOptions();
        IEnumerable<ResistenciaNivel> GetResistenciaNivelOptions();
    }
}