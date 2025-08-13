using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Imagenes.Application.Interfaces;
using proyectc_.src.Modules.Imagenes.Domain.Entities;

namespace proyectc_.src.Modules.Imagenes.Application.Services
{
    public class ImagenService : IImagenService
    {
        private readonly IImagenRepository _imagenRepository;

        public ImagenService(IImagenRepository imagenRepository)
        {
            _imagenRepository = imagenRepository;
        }

        public void OpenImage(string imagePath)
        {
            // Lógica para abrir la imagen
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = imagePath,
                UseShellExecute = true // Usa la app asociada para abrir la imagen
            });
        }

        public List<Imagen> GetImages()
        {
            // Obtener las imágenes desde el repositorio
            return _imagenRepository.GetImagesFromDirectory("assets/images");
        }
    }
}