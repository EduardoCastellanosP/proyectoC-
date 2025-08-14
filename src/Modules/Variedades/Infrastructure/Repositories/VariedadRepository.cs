using Microsoft.EntityFrameworkCore;
using proyectc_.src.Modules.Variedades.Application.Interfaces;
using proyectc_.src.Shared.Context;
using proyectc_.src.Modules.Variedades.Domain.Entities; // Ajusta si tus entidades viven en otro namespace

namespace proyectc_.src.Modules.Variedades.Infrastructure.Repositories
{
    public class CatalogosRepository : IVariedadRepository
    {
        private readonly AppDbContext _context;

        public CatalogosRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        // Helper simple para ordenar por la propiedad "Nombre" sin crear interfaces adicionales
        private IQueryable<T> OrderByNombre<T>(bool descending) where T : class
        {
            var set = _context.Set<T>().AsNoTracking();
            return descending
                ? set.OrderByDescending(e => EF.Property<string>(e, "Nombre"))
                : set.OrderBy(e => EF.Property<string>(e, "Nombre"));
        }

        public Task<List<TamanoGrano>> ListarTamanoGranoAsync(bool descending = false, CancellationToken ct = default)
            => OrderByNombre<TamanoGrano>(descending).ToListAsync(ct);

        public Task<List<Porte>> ListarPorteAsync(bool descending = false, CancellationToken ct = default)
            => OrderByNombre<Porte>(descending).ToListAsync(ct);

        public Task<List<ResistenciaNivel>> ListarResistenciaNivelAsync(bool descending = false, CancellationToken ct = default)
            => OrderByNombre<ResistenciaNivel>(descending).ToListAsync(ct);

        public Task<List<RendimientoPotencial>> ListarRendimientoPotencialAsync(bool descending = false, CancellationToken ct = default)
            => OrderByNombre<RendimientoPotencial>(descending).ToListAsync(ct);

        public Task<List<CalidadAltitudNivel>> ListarCalidadAltitudNivelAsync(bool descending = false, CancellationToken ct = default)
            => OrderByNombre<CalidadAltitudNivel>(descending).ToListAsync(ct);

        public Task<List<Enfermedad>> ListarEnfermedadAsync(bool descending = false, CancellationToken ct = default)
            => OrderByNombre<Enfermedad>(descending).ToListAsync(ct);

      

        // Clona el patrón para los demás catálogos que tengas.
    }
}
