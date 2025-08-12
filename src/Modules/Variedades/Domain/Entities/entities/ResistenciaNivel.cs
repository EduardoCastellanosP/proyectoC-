using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colombian_Coffe.src.Modules.Variedades.Domain.Entities
{
    public class ResistenciaNivel
    {
         public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty; // Susceptible / Tolerante / Resistente
    }
}