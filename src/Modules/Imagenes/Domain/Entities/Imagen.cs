using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proyectc_.src.Modules.Imagenes.Domain.Entities
{
    public class Imagen
    {
        public string Path { get; set; }
        public string Name { get; set; }

        public Imagen(string path, string name)
        {
            Path = path;
            Name = name;
        }
    }
}