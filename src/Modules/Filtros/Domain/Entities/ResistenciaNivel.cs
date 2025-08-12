using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  proyectc_.src.Modules.Filtros.Domain.Entities
{
    public class ResistenciaNivel
    {
         public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Susceptible / Tolerante / Resistente
    }
}