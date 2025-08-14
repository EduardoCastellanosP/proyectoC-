
using proyectc_.src.Modules.Variedades.Application.Interfaces;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Application.Services
{
    public class VariedadesService
    {
        private readonly IVariedadRepository _repo;

        public VariedadesService(IVariedadRepository repo)
        {
            _repo = repo;
        }

        public Task<IEnumerable<Variedad>> ListarAsync() => _repo.GetAllVariedadesAsync();
        public Task<Variedad?> ObtenerPorIdAsync(int id) => _repo.GetByIdAsync(id);
        public Task<List<Variedad>> BuscarPorFiltrosAsync(Variedad filtros) => _repo.BuscarPorFiltrosAsync(filtros);
    }
}
