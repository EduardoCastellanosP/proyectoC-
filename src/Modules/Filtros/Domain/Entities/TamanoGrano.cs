using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectc_.src.Modules.Variedades.Domain.Entities
{
    public class TamanoGrano
    {
        public int TamanoGranoId { get; set; }
        public string Nombre { get; set; } = "";
        public string Descripcion { get; set; } = "";
        public ICollection<Variedad> Variedades { get; set; }
            = new List<Variedad>();
    }
    
}