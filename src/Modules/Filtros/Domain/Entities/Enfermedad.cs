using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectc_.src.Modules.Variedades.Domain.Entities
{
    public class Enfermedad
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Descripcion { get; set; } = "";

        public ICollection<VariedadResistencia> VariedadesResistencias { get; set; } = new List<VariedadResistencia>();
    }
}