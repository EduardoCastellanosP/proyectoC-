using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Filtros.Application.Interfaces;
using proyectc_.src.Modules.Variedades.Application.Interfaces; // IVariedadesRepository
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Filtros.Application.Services
{
    public class FiltrosService : IFiltrosService
    {
        private readonly IVariedadesRepository _repo;

        public FiltrosService(IVariedadesRepository repo)
        {
            _repo = repo;
        }

        // ===== Consultas base =====
        public Task<IEnumerable<Variedad>> ConsultarVariedadesAsync()
            => _repo.GetAllVariedadesAsync();

        public Task<Variedad?> ObtenerVariedadPorIdAsync(int id)
            => _repo.GetByIdAsync(id);

        // ===== Filtros por Id =====
        public async Task<IEnumerable<Variedad>> FiltrarPorTamanoGranoIdAsync(int tamanoGranoId)
        {
            var todas = await _repo.GetAllVariedadesAsync();
            return todas.Where(v => v.TamanoGranoId == tamanoGranoId).ToList();
        }

        public async Task<IEnumerable<Variedad>> FiltrarPorPorteIdAsync(int porteId)
        {
            var todas = await _repo.GetAllVariedadesAsync();
            return todas.Where(v => v.PorteId == porteId).ToList();
        }

        // ===== Filtros extra =====
        public async Task<IEnumerable<Variedad>> FiltrarPorAltitudAsync(int? altitudMin, int? altitudMax)
        {
            var todas = await _repo.GetAllVariedadesAsync();
            var q = todas.AsQueryable();

            if (altitudMin.HasValue)
                q = q.Where(v => v.AltitudMinima.HasValue && v.AltitudMinima.Value >= altitudMin.Value);

            if (altitudMax.HasValue)
                q = q.Where(v => v.AltitudMaxima.HasValue && v.AltitudMaxima.Value <= altitudMax.Value);

            return q.ToList();
        }

        public async Task<IEnumerable<Variedad>> BuscarPorNombreAsync(string contiene)
        {
            contiene = (contiene ?? "").Trim();
            if (contiene.Length == 0) return new List<Variedad>();

            var todas = await _repo.GetAllVariedadesAsync();
            return todas
                .Where(v => !string.IsNullOrWhiteSpace(v.Nombre) &&
                            v.Nombre.Contains(contiene, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }
    }
}
