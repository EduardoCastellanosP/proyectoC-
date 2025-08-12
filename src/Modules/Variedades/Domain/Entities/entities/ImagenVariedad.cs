using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colombian_Coffe.src.Modules.Variedades.Domain.Entities
{
    public class ImagenVariedad
    {
         public int Id { get; set; }
        public int VariedadId { get; set; }
        public string Url { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public short Orden { get; set; }
    }
}