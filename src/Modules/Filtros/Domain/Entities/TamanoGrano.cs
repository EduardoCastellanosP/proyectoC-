using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectc_.src.Modules.Variedades.Domain.Entities
{
    public class TamanoGrano
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Pequeño / Medio / Gra
        
        public string? Descripcion { get; set; } // Descripción opcional del tamaño del grano
    }
}