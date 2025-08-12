using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectc_.src.Modules.Variedades.UI;
public class MenuFiltros
{
    public async Task RenderMenu()
    {

        bool activo = false;

        while (!activo)
        {
            Console.Clear();
            Console.WriteLine("================================================");
            Console.WriteLine("||    🌿 FILTRAR VARIEDADES DE CAFÉ 🌿      ||");
            Console.WriteLine("================================================");
            Console.WriteLine("||                                            ||");
            Console.WriteLine("||    Seleccione su criterio de búsqueda:    ||");
            Console.WriteLine("||                                            ||");
            Console.WriteLine("================================================");

            Console.WriteLine("\n");
            Console.WriteLine(" 1. 🔍 Nombre común");
            Console.WriteLine(" 2. 🔬 Nombre científico");
            Console.WriteLine(" 3. 🌳 Porte (1-Alto | 2-Bajo)");
            Console.WriteLine(" 4. ☕ Tamaño del grano (1-Peq | 2-Med | 3-Gran)");
            Console.WriteLine(" 5. ⛰ Rango de altitud (msnm)");
            Console.WriteLine(" 6. 📈 Potencial de rendimiento (1-5)");
            Console.WriteLine(" 7. ⭐ Calidad por altitud (1-5)");
            Console.WriteLine(" 8. 🕰 Tiempo de cosecha");
            Console.WriteLine(" 9. 🧬 Familia genética");
            Console.WriteLine("10. 🧪 Grupo genético");
            Console.WriteLine("================================================");
            Console.Write(" ▶ Ingrese su opción: ");
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
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        break;

                    case "6":
                        break;

                    case "7":
                        break;

                    case "8":
                        break;

                    case "9":
                        break;

                    case "10":
                        break;

                    default:
                        Console.WriteLine("opcion invalida");
                        break;
                }
            }
        }
    }
}