using Microsoft.EntityFrameworkCore;
using proyectc_.src.Shared.Context;

namespace proyectc_.src.Modules.Filtros.Infrastructure.Repositories; 


    public class FiltroRepository : IFiltroRepository
    {
        private readonly AppDbContext _ctx;
        public FiltroRepository(AppDbContext ctx) => _ctx = ctx;

        public Task<List<Filtro>> GetAllAsync() =>
            _ctx.Filtros
               .AsNoTracking()
               .Include(v => v.TamanoGrano)          // <-- ajusta si tus nombres cambian
               .Include(v => v.Porte)
               .Include(v => v.ResistenciaNivel)
               .Include(v => v.RendimientoPotencial)
               .Include(v => v.TipoCafe)
               .ToListAsync();
    }
