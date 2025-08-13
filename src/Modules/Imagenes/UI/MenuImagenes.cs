using System;
using System.Collections.Generic;
using proyectc_.src.Modules.Imagenes.Application.Interfaces;
using proyectc_.src.Modules.Imagenes.Application.Services;
using proyectc_.src.Modules.Imagenes.Infrastructure.Repositories;

namespace proyectc_.src.Modules.Imagenes.UI
{
    public class MenuImagenes
    {
        // Método principal que controla el flujo del menú de imágenes
        public void MostrarMenuImagenes(IImagenService imagenService)
        {
            while (true)
            {
                // Obtener las imágenes desde el servicio
                var images = imagenService.GetImages();

                if (images.Count == 0)
                {
                    Console.WriteLine("No se encontraron imágenes.");
                    return;
                }

                // Mostrar imágenes disponibles con un estilo personalizado
                Console.Clear();
                Console.WriteLine("╔════════════════════════════════════════════╗");
                Console.WriteLine("║               Menú de Imágenes             ║");
                Console.WriteLine("╠════════════════════════════════════════════╣");
                Console.ResetColor();

                // Mostrar las opciones de imágenes (hasta 5 imágenes por ejemplo)
                for (int i = 0; i < images.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {images[i].Name}");
                }

                // Agregar opciones de regresar o salir
                Console.WriteLine("6. Regresar al menú principal");
                Console.WriteLine("7. Salir del programa");

                Console.WriteLine("\nOpciones:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Seleccione una opción: ");
                string seleccion = Console.ReadLine()?.ToUpper();

                // Usar switch para gestionar las opciones
                switch (seleccion)
                {
                    case "7":
                        Console.WriteLine("Saliendo del programa...");
                        return; 

                    case "6":
                        Console.WriteLine("Regresando al menú principal...");
                        return; 

                    default:
                        // Verificar si la opción es válida y abrir la imagen seleccionada
                        if (int.TryParse(seleccion, out int numSeleccion) && numSeleccion >= 1 && numSeleccion <= images.Count)
                        {
                            // Abrir la imagen seleccionada
                            imagenService.OpenImage(images[numSeleccion - 1].Path);
                        }
                        else
                        {
                            Console.WriteLine("Selección no válida, por favor intenta de nuevo.");
                        }
                        break;
                }
            }
        }
    }
}
