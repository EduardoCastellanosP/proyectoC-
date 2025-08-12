using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colombian_Coffe.src.Modules.Variedades.Domain.Entities
{
    public class TamanoGrano
    {
         public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Pequeño / Medio / Gra
    }
}