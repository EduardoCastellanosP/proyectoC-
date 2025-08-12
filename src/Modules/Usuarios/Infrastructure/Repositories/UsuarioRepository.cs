using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using proyectc_.src.Modules.Usuarios.Application.Interfaces;
using proyectc_.src.Modules.Usuarios.Domain.Entities;
using proyectc_.src.Shared.Context;


namespace proyectc_.src.Modules.Usuarios.Infrastructure.Repositories;


public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;
    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }
    public async Task<Usuario?> GetByIdAsync(int id)
    {
        return await _context.Usuarios
            .AsNoTracking()
            .FirstOrDefaultAsync(u => u.Id == id);
    }
    public async Task<IEnumerable<Usuario?>> GetAllAsync() =>
        await _context.Usuarios.AsNoTracking().ToListAsync();
    
    public async Task<Usuario?> GetByNombreAsync(string nombre)
        {
            var n = (nombre ?? string.Empty).Trim();
            return await _context.Usuarios
                .FirstOrDefaultAsync(u => u.Nombre == n);
        }

      public async Task<bool> ExistsByNombreAsync(string nombre)
        {
            var n = (nombre ?? string.Empty).Trim();
            return await _context.Usuarios.AnyAsync(u => u.Nombre == n);
        }
    public void Add(Usuario entity) =>
        _context.Usuarios.Add(entity);
    public async Task SaveAsync() =>
    await _context.SaveChangesAsync();

    public void Remove(Usuario entity) =>
        _context.Usuarios.Remove(entity);

    public void Update(Usuario entity) =>
        _context.SaveChanges();

    }
