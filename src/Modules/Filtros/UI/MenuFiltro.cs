using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using proyectc_.src.Modules.Filtros.Application.Interfaces;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Filtros.UI
{
    public class MenuFiltros
    {
        private readonly IFiltrosService _svc;
        public MenuFiltros(IFiltrosService svc) => _svc = svc;

        public async Task RenderAsync()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Filtros Variedades ===");
                Console.WriteLine("1) Por Tamaño de grano (Id)");
                Console.WriteLine("2) Por Porte (Id)");
                Console.WriteLine("3) Por Altitud (min/max)");
                Console.WriteLine("4) Por nombre (contiene)");
                Console.WriteLine("0) Volver");
                Console.Write("Opción: ");
                var op = Console.ReadLine();

                IReadOnlyList<Variedad> res;
                switch (op)
                {
                    case "1":
                        if (!TryReadInt("Id Tamaño de grano: ", out var tg)) break;
                        res = await _svc.FiltrarPorTamanoGranoAsync(tg);
                        Mostrar(res); break;

                    case "2":
                        if (!TryReadInt("Id Porte: ", out var po)) break;
                        res = await _svc.FiltrarPorPorteAsync(po);
                        Mostrar(res); break;

                    case "3":
                        Console.Write("Altitud mínima (Enter = sin mínimo): ");
                        var smin = Console.ReadLine();
                        Console.Write("Altitud máxima (Enter = sin máximo): ");
                        var smax = Console.ReadLine();
                        int? amin = int.TryParse(smin, out var m1) ? m1 : (int?)null;
                        int? amax = int.TryParse(smax, out var m2) ? m2 : (int?)null;
                        res = await _svc.FiltrarPorAltitudAsync(amin, amax);
                        Mostrar(res); break;

                    case "4":
                        Console.Write("Nombre contiene: ");
                        var q = Console.ReadLine() ?? "";
                        res = await _svc.BuscarPorNombreAsync(q);
                        Mostrar(res); break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Opción inválida.");
                        Pause(); break;
                }
            }
        }

        private static bool TryReadInt(string prompt, out int value)
        {
            Console.Write(prompt);
            var ok = int.TryParse(Console.ReadLine(), out value);
            if (!ok)
            {
                Console.WriteLine("❌ Número inválido.");
                Pause();
            }
            return ok;
        }

        private static void Mostrar(IReadOnlyList<Variedad> lista)
        {
            Console.WriteLine($"Resultados: {lista.Count}");
            foreach (var v in lista)
            {
                var tam = v.TamanoGrano?.Nombre ?? "-";
                var por = v.Porte?.Nombre ?? "-";
                Console.WriteLine($"{v.Id} - {v.Nombre} | Tamaño: {tam} | Porte: {por}");
            }
            Pause();
        }

        private static void Pause()
        {
            Console.Write("Continuar... ");
            Console.ReadKey();
        }
    }
}
