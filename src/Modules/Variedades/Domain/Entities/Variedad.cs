using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;


namespace proyectc_.src.Modules.Variedades.Domain.Entities
{
    public class Variedad
    {
       public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public string Descripcion { get; set; } = "";

        public int? TamanoGranoId { get; set; }
        public int? PorteId { get; set; }

        public int? AltitudMinima { get; set; }
        public int? AltitudMaxima { get; set; }

        public TamanoGrano? TamanoGrano { get; set; }
        public Porte? Porte { get; set; }
    }
}