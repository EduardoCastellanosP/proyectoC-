using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectc_.src.Modules.Filtros.Domain.Entities
{
    public class VariedadResistencia
    {
         public int Id { get; set; }
        public int VariedadId { get; set; }
        public int EnfermedadId { get; set; }
        public int NivelId { get; set; } // ResistenciaNivel.Id
    }
}