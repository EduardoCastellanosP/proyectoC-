using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyectc_.src.Modules.Usuarios.Domain.Entities;
using proyectc_.src.Shared.Context;

namespace proyectc_.src.Modules.Usuarios.Infrastructure.Repositories
{
    public class UsuarioRepository
    {
        private readonly AppDbContext _context;
        public UsuarioRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Usuario?> GetByIdAsync(int id)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Id == id);
        }
        public async Task<IEnumerable<Usuario?>> GetAllAsync() =>
            await _context.Usuarios.ToListAsync();
        public void Add(Usuario usuario) =>
            _context.Usuarios.Add(usuario);
        public async Task SaveAsync() =>
        await _context.SaveChangesAsync();
    }
}