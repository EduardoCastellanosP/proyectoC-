using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Usuarios.Application.Service;
using proyectc_.src.Modules.Usuarios.Infrastructure.Repositories;



using proyectc_.src.Shared.Context;

namespace proyectc_.src.Modules.Usuarios.UI
{
    public class UsuarioMenu
    {
        private readonly AppDbContext _context;
        readonly UsuarioRepository repo = null!;
        readonly UsuarioService service = null!;
        public UsuarioMenu(AppDbContext context)
        {
            _context = context;
            repo = new UsuarioRepository(context);
            service = new UsuarioService(repo);
        }
        public async Task RenderMenu()
        {
            bool regresar = false;
            while (!regresar)
            {
                Console.Clear();
                Console.WriteLine("+==================================+");
                Console.WriteLine("|           Menu Usuario           |");
                Console.WriteLine("+==================================+");
                Console.WriteLine("| 1. Registrar usuario             |");
                Console.WriteLine("| 2. Iniciar sesión                |");
                Console.WriteLine("| 3.Regresar al menu princial      |");
                Console.WriteLine("+==================================+");
                Console.WriteLine("¿Qué acción desea realizar?");
                string? opcion = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(opcion))
                {
                    continue;
                }
                else
                {
                    switch (opcion)
                    {
                        case "1":
                            Console.Clear();
                            Console.WriteLine("== Registrar Usuario ==");
                            Console.WriteLine("Ingrese el nombre del usuario:");
                            string? nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese la contraseña (letras y/o números):");
                            string? clave = Console.ReadLine();
                            await service.RegistrarUsuarioAsync(nombre!, clave!);
                            Console.WriteLine("✅ Usuario registrado con exito.");
                            Console.ReadKey();
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("== Iniciar Sesión ==");
                            var usuarios = await service.ConsultarUsuariosAsync();
                            Console.WriteLine("Todos los usuarios:");
                            foreach (var u in usuarios)
                                Console.WriteLine($"Id: {u.Id} - Nombre: {u.Nombre}");
                            Console.WriteLine("Ingrese el Id del  usuario: ");
                            if (!int.TryParse(Console.ReadLine(), out int usuarioId))
                            {
                                Console.WriteLine("Id inválido.");
                                Console.ReadKey();
                                break;
                            }
                            var usuario = await service.ObtenerUsuarioPorIdAsync(usuarioId);
                            if (usuario == null)
                            {
                                Console.WriteLine("Usuario no encontrado.");
                                Console.ReadKey();
                                break;
                            }
                            Console.WriteLine("Ingrese la contraseña:");
                            string? claveIngresada = Console.ReadLine();
                            if (usuario.Clave == claveIngresada)
                            {
                                Console.WriteLine($"✅ Bienvenido, {usuario.Nombre}.");
                            }
                            else
                            {
                                Console.WriteLine("❌ Contraseña incorrecta.");
                            }
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Adios...");
                            Console.ReadKey();
                            regresar = true;
                            break;
                        default:
                            Console.WriteLine("Opción no valida");
                            Console.ReadKey();
                            break;
                    }
                }
            }
        }
    }
}