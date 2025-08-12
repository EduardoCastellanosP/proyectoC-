using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Filtros.Domain.Entities;

namespace proyectc_.src.Modules.Filtros.Application.Interfaces
{
    public interface IFiltroService
    {
        IEnumerable<Variedad> ApplyFilters(Dictionary<string, object> filters);
        Dictionary<string, IEnumerable<object>> GetFilterOptions();
        Variedad GetVarietyDetails(int id);
    }
}