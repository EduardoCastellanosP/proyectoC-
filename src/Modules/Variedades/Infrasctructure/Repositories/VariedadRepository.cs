using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Colombian_Coffe.src.Modules.Variedades.Infrastructure.Repositories;

    public class VariedadRepository : IVariedadRepository
    {

        private readonly AppDbContext _context;

        public VariedadRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Variedad?> GetByIdAsync(int id)
        {
            return await _context.Variedades
            .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<IEnumerable<Variedad>> GetAllAsync()
        {
            return await _context.Variedades.ToListAsync();
        }

        public void Add(Variedad entity)
        {
            _context.Variedades.Add(entity);

        }

        public void Update(Variedad entity)
        {

            _context.SaveChangesAsync();
        }

        public void Remove(Variedad entity)
        {
            _context.Variedades.Remove(entity);
        }

    }
