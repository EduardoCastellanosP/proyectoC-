using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Usuarios.Application.Interfaces;
using proyectc_.src.Modules.Usuarios.Domain.Entities;



namespace proyectc_.src.Modules.Usuarios.Application.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repo;
        public UsuarioService(IUsuarioRepository repo)
        {
            _repo = repo;
        }
        public async Task<IEnumerable<Usuario>> ConsultarUsuariosAsync()
        {
            return await _repo.GetAllAsync();
        }
        public async Task<Usuario?> ObtenerUsuarioPorIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }
        public async Task RegistrarUsuarioAsync(string nombre, string clave, string rol = "Operador")
        {
            var existentes = await _repo.GetAllAsync();

            if (existentes.Any(u => u.Nombre == nombre))
                throw new Exception("El usuario ya existe.");

            var usuario = new Usuario
            {
                Nombre = nombre,
                Clave = clave
            };

            _repo.Add(usuario);
            await _repo.SaveAsync();
        }
    }
}