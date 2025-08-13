using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace proyectc_.src.Modules.Variedades.Domain.Entities
{
    public class Variedad
    {
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;
        public string NombreCientifico { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;

        public int? PorteId { get; set; }
        public int? TamanoGranoId { get; set; }

        public int? AltitudMax { get; set; }  // msnm

        public int? RendimientoPotencialId { get; set; }
        public int? CalidadAltitudNivelId { get; set; }

        public string TiempoCosecha { get; set; } = string.Empty;
        public string Maduracion { get; set; } = string.Empty;
        public string Nutricion { get; set; } = string.Empty;
        public string DensidadSiembra { get; set; } = string.Empty;

        public string Obtentor { get; set; } = string.Empty;
        public string Familia { get; set; } = string.Empty;
        public string GrupoGenetico { get; set; } = string.Empty;

       


        public DateTime CreadoEn { get; set; } = DateTime.UtcNow;
        public DateTime ActualizadoEn { get; set; } = DateTime.UtcNow;
    }
}