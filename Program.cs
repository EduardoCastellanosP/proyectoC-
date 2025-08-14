


using proyectc_.src.Shared.Context;
using proyectc_.src.Shared.Helpers;
using proyectc_.src.Modules.Usuarios.UI;


using var context = DbContextFactory.Create();


static async Task MostrarMenuPrincipal(AppDbContext context)
{

    Console.Clear();

    while (true)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║        ☕  Colombian Coffee  ☕             ║");
        Console.WriteLine("║            Menú Principal                  ║");
        Console.WriteLine("╠════════════════════════════════════════════╣");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("║ 1. 🔑 Login                                 ║");
        Console.WriteLine("║ 2. 🌱 Explorar variedades                   ║");
        Console.WriteLine("║ 3. 🛠 Panel Admin                           ║");
        Console.WriteLine("║ 4. 📄 Generar PDF                           ║");
        Console.WriteLine("║ 5. 🚪 Salir                                 ║");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╚════════════════════════════════════════════╝");
        Console.ResetColor();
        Console.Write("Seleccione una opción: ");
        string opcion = Console.ReadLine() ?? "";

        switch (opcion)
        {
            case "1":
                await new UsuarioMenu(context).RenderMenu();
                break;
            case "2":
                // await new MenuFiltros(filtrosSvc).RenderAsync();
                break;
            case "3":
                // Llamar a PanelAdmin aquí
                break;
            case "4":
                // Generar PDF aquí
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("📄 Generando PDF (pendiente implementar)...");
                Console.ResetColor();
                Console.ReadKey();
                break;
            case "5":
                Console.WriteLine("👋 Saliendo del sistema...");
                return;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("❌ Opción inválida. Intente nuevamente.");
                Console.ResetColor();
                Console.ReadKey();
                break;
        }
    }
}
