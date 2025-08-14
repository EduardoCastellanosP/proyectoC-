using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectc_.src.Modules.Variedades.Domain.Entities
{
    public class VariedadResistencia
    {
             public int VariedadId { get; set; }
        public Variedad Variedad { get; set; } = null!;

        public int EnfermedadId { get; set; }
        public Enfermedad Enfermedad { get; set; } = null!;

        public int ResistenciaNivelId { get; set; }
        public ResistenciaNivel ResistenciaNivel { get; set; } = null!;
    }
}