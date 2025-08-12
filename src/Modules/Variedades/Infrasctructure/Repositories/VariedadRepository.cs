using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyectc_.src.Shared.Context;
using proyectc_.src.Modules.Variedades.Domain.Entities;
using proyectc_.src.Modules.Variedades.Application.Interfaces;


namespace proyectc_.src.Modules.Variedades.Infrastructure.Repositories;

    public class VariedadRepository : IVariedadesRepository
    {

        private readonly AppDbContext _context;

        public VariedadRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Variedad?> GetVariedadByIdAsync(int id)
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
