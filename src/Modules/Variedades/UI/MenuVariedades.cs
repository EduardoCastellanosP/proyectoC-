using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Modules.Variedades.Application.Interfaces;
using Colombian_Coffe.src.Modules.Variedades.Application.Services;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;



namespace Colombian_Coffe.src.Modules.Variedades.UI;

public class MenuVariedades
{
    private readonly AppDbContext _context;
    readonly VariedadesRepository repo = null!;
    readonly VariedadesService service = null!;

    public MenuVariedades(AppDbContext context)
    {
        _context = context;
        repo = new VariedadesRepository(context);
        service = new VariedadesService(repo);
    }

    public async Task RenderMenu()
    {
        bool salir = false;
        while (!salir)
        {
            Console.Clear();
            DibujarMarcoTitulo("🌱 Variedades – Catálogo / CRUD");
            Console.WriteLine("║ 1. Ver catálogo completo                 ║");
            Console.WriteLine("║ 2. Ver ficha técnica (por ID)            ║");
            Console.WriteLine("║ 3. Buscar por texto (nombre/descr.)      ║");
            Console.WriteLine("║ 4. Crear variedad                        ║");
            Console.WriteLine("║ 5. Actualizar variedad                   ║");
            Console.WriteLine("║ 6. Eliminar variedad                     ║");
            Console.WriteLine("║ 7. Volver                                ║");
            Console.WriteLine("╚══════════════════════════════════════════╝");
            Console.Write("Opción: ");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    await VerCatalogoAsync();
                    break;
                case "2":
                    await VerFichaPorIdAsync();
                    break;
                case "3":
                    await BuscarPorTextoAsync();
                    break;
                case "4":
                    await CrearVariedadAsync();
                    break;
                case "5":
                    await ActualizarVariedadAsync();
                    break;
                case "6":
                    await EliminarVariedadAsync();
                    break;
                case "7":
                    salir = true;
                    break;
                default:
                    Error("Opción inválida.");
                    Pausa();
                    break;
            }
        }
    }

}





