// En tu Program.cs (o donde tengas el menú)
using proyectc_.src.Modules.Filtros.Application.Interfaces;
using System;
using System.Collections.Generic;
using proyectc_.src.Modules.Filtros.Domain.Entities;

static async Task MenuFiltrosAsync(IFiltrosService svc)
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("=== Filtros Variedades ===");
        Console.WriteLine("1) Por Tamaño de grano (Id)");
        Console.WriteLine("2) Por Porte (Id)");
        Console.WriteLine("3) Por Resistencia (Id)");
        Console.WriteLine("4) Por Rendimiento (Id)");
        Console.WriteLine("5) Por Tipo de café (Id)");
        Console.WriteLine("6) Por Altitud (min/max)");
        Console.WriteLine("7) Por nombre (contiene)");
        Console.WriteLine("0) Volver");
        Console.Write("Opción: ");
        var op = Console.ReadLine();

        List<Variedad> res;
        switch (op)
        {
            case "1":
                Console.Write("Id Tamaño de grano: ");
                int tg = int.Parse(Console.ReadLine() ?? "0");
                res = await svc.FiltrarPorTamanoGranoAsync(tg);
                Mostrar(res); break;

            case "2":
                Console.Write("Id Porte: ");
                int po = int.Parse(Console.ReadLine() ?? "0");
                res = await svc.FiltrarPorPorteAsync(po);
                Mostrar(res); break;

            case "3":
                Console.Write("Id Resistencia: ");
                int rn = int.Parse(Console.ReadLine() ?? "0");
                res = await svc.FiltrarPorResistenciaAsync(rn);
                Mostrar(res); break;

            case "4":
                Console.Write("Id Rendimiento: ");
                int rp = int.Parse(Console.ReadLine() ?? "0");
                res = await svc.FiltrarPorRendimientoAsync(rp);
                Mostrar(res); break;

            case "5":
                Console.Write("Id Tipo café: ");
                int tc = int.Parse(Console.ReadLine() ?? "0");
                res = await svc.FiltrarPorTipoCafeAsync(tc);
                Mostrar(res); break;

            case "6":
                Console.Write("Altitud mínima (Enter = sin mínimo): ");
                var smin = Console.ReadLine();
                Console.Write("Altitud máxima (Enter = sin máximo): ");
                var smax = Console.ReadLine();
                int? amin = int.TryParse(smin, out var m1) ? m1 : null;
                int? amax = int.TryParse(smax, out var m2) ? m2 : null;
                res = await svc.FiltrarPorAltitudAsync(amin, amax);
                Mostrar(res); break;

            case "7":
                Console.Write("Nombre contiene: ");
                var q = Console.ReadLine() ?? "";
                res = await svc.BuscarPorNombreAsync(q);
                Mostrar(res); break;

            case "0": return;
            default: Console.WriteLine("Opción inválida."); Console.ReadKey(); break;
        }
    }

    static void Mostrar(List<Variedad> lista)
    {
        Console.WriteLine($"Resultados: {lista.Count}");
        foreach (var v in lista)
        {
            Console.WriteLine($"{v.Id} - {v.Nombre} | Tamaño: {v.TamanoGrano?.Nombre} | Porte: {v.Porte?.Nombre}");
        }
        Console.Write("Continuar..."); Console.ReadKey();
    }
}
