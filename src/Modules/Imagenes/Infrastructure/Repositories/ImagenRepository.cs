using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Imagenes.Application.Interfaces;
using proyectc_.src.Modules.Imagenes.Domain.Entities;

namespace proyectc_.src.Modules.Imagenes.Infrastructure.Repositories
{
    public class ImagenRepository : IImagenRepository
    {
        public List<Imagen> GetImagesFromDirectory(string directoryPath)
        {
            // Verificar si el directorio existe
            if (!Directory.Exists(directoryPath))
            {
                throw new DirectoryNotFoundException($"El directorio no existe: {directoryPath}");
            }

            // Obtener las imágenes desde el directorio
            var imageFiles = Directory.GetFiles(directoryPath, "*.*")
                                      .Where(file => file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                     file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase))
                                      .ToArray();

            var images = new List<Imagen>();

            foreach (var file in imageFiles)
            {
                images.Add(new Imagen(file, Path.GetFileName(file)));
            }

            return images;
        }
    }
}