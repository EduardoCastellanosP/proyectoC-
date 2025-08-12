using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Filtros.Application.Interfaces;
using proyectc_.src.Modules.Filtros.Domain.Entities;

namespace proyectc_.src.Modules.Filtros.Application.Services
{
    public class FiltroService : IFiltroService
    {
        private readonly IFiltroRepository _repository;

        public FiltroService(IFiltroRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<Variedad> ApplyFilters(Dictionary<string, object> filters)
        {
            // Validación básica de filtros
            if (filters == null || !filters.Any())
                return _repository.GetAllVarieties();

            return _repository.FilterVarieties(filters);
        }

        public Dictionary<string, IEnumerable<object>> GetFilterOptions()
        {
            return new Dictionary<string, IEnumerable<object>>
            {
                { "Porte", _repository.GetPorteOptions() },
                { "TamanoGrano", _repository.GetTamanoGranoOptions() },
                { "RendimientoPotencial", _repository.GetRendimientoOptions() },
                { "CalidadAltitud", _repository.GetCalidadAltitudOptions() },
                { "Enfermedades", _repository.GetEnfermedadOptions() },
                { "NivelesResistencia", _repository.GetResistenciaNivelOptions() }
            };
        }

        
        
    }
}