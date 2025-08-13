using proyectc_.src.Modules.Filtros.Application.Interfaces;
using proyectc_.src.Modules.Filtros.Domain.Entities;

namespace proyectc_.src.Modules.Filtros.Application.Services
{
    public class FiltrosService : IFiltrosService
    {
        private readonly IFiltrosRepository _repo;
        public FiltrosService(IFiltrosRepository repo) => _repo = repo;

        public async Task<List<Filtro>> FiltrarPorTamanoGranoAsync(int tamanoGranoId)
        {
            var all = await _repo.GetAllAsync();
            return all.Where(v => v.TamanoGranoId == tamanoGranoId).ToList();
        }

        public async Task<List<Filtro>> FiltrarPorPorteAsync(int porteId)
        {
            var all = await _repo.GetAllAsync();
            return all.Where(v => v.PorteId == porteId).ToList();
        }

        public async Task<List<Filtro>> FiltrarPorResistenciaAsync(int resistenciaNivelId)
        {
            var all = await _repo.GetAllAsync();
            return all.Where(v => v.ResistenciaNivelId == resistenciaNivelId).ToList();
        }

        public async Task<List<Filtro>> FiltrarPorRendimientoAsync(int rendimientoPotencialId)
        {
            var all = await _repo.GetAllAsync();
            return all.Where(v => v.RendimientoPotencialId == rendimientoPotencialId).ToList();
        }

        public async Task<List<Filtro>> FiltrarPorTipoCafeAsync(int tipoCafeId)
        {
            var all = await _repo.GetAllAsync();
            return all.Where(v => v.TipoCafeId == tipoCafeId).ToList();
        }

        public async Task<List<Filtro>> FiltrarPorAltitudAsync(int? altMin, int? altMax)
        {
            var all = await _repo.GetAllAsync();
            if (altMin.HasValue) all = all.Where(v => v.Altitud >= altMin.Value).ToList();
            if (altMax.HasValue) all = all.Where(v => v.Altitud <= altMax.Value).ToList();
            return all;
        }

        public async Task<List<Filtro>> BuscarPorNombreAsync(string contiene)
        {
            var all = await _repo.GetAllAsync();
            contiene = (contiene ?? "").Trim();
            return string.IsNullOrEmpty(contiene)
                ? all
                : all.Where(v => v.Nombre.Contains(contiene, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}