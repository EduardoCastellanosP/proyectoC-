using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Imagenes.Domain.Entities;

namespace proyectc_.src.Modules.Imagenes.Application.Interfaces
{
    public interface IImagenService
    {
        void OpenImage(string imagePath);
        List<Imagen> GetImages();
    }
}