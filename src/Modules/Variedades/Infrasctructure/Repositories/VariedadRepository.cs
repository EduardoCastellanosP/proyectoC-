using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyectc_.src.Modules.Variedades.Application.Interfaces;
using proyectc_.src.Modules.Variedades.Domain.Entities;
using proyectc_.src.Shared.Context;

namespace proyectc_.src.Modules.Variedades.Infrastructure.Repositories
{
    public class VariedadRepository : IVariedadesRepository
    {
        private readonly AppDbContext _db;

        public VariedadRepository(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Variedad>> GetAllVariedadesAsync()
        {
            // Incluye relaciones básicas que usas en el UI (ajusta si necesitas más)
            return await _db.Variedades
                .Include(v => v.TamanoGrano)
                .Include(v => v.Porte)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Variedad?> GetVariedadByIdAsync(int id)
        {
            return await _db.Variedades
                .Include(v => v.TamanoGrano)
                .Include(v => v.Porte)
                .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task AddAsync(Variedad entity)
        {
            await _db.Variedades.AddAsync(entity);
        }

        public void Update(Variedad entity)
        {
            _db.Variedades.Update(entity);
        }

        public void Remove(Variedad entity)
        {
            _db.Variedades.Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return _db.SaveChangesAsync();
        }
    }
}
