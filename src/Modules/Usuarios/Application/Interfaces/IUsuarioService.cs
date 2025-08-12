using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Usuarios.Domain.Entities;

namespace proyectc_.src.Modules.Usuarios.Application.Interfaces
{
    public interface IUsuarioService
    {
        Task RegistrarUsuarioAsync(string nombre, string clave, string rol= "Operador");
        Task<IEnumerable<Usuario>> ConsultarUsuariosAsync();
        Task<Usuario?> ObtenerUsuarioPorIdAsync(int id);
    }
}