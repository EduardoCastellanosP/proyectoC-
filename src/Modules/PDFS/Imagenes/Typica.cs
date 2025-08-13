using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace proyectc_.src.Modules.PDFS.Resources
{
    public class Typica
    {
        static void Main()
        {
            string rutaArchivo = "Typica_cafe.pdf";

            // Crear documento tamaño A4
            Document documento = new Document(PageSize.A4, 40, 40, 40, 40);

            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                PdfWriter.GetInstance(documento, fs);
                documento.Open();

                // ===== Colores y fuentes =====
                BaseColor verde = new BaseColor(34, 139, 34);
                BaseColor verdeClaro = new BaseColor(50, 200, 50);
                BaseColor grisClaro = new BaseColor(240, 240, 240);
                var tituloFuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 30, verde);
                var subtituloFuente = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12, BaseColor.DARK_GRAY);
                var labelFuente = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11, BaseColor.BLACK);
                var valorFuente = FontFactory.GetFont(FontFactory.HELVETICA, 11, BaseColor.BLACK);
                var subtituloTablas = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 12, verdeClaro);

                // ===== Imagen principal =====
                string rutaImagen = Path.Combine("Imagenes", "typica.png"); // Cambia por tu imagen
                if (File.Exists(rutaImagen))
                {
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(rutaImagen);
                    img.ScaleToFit(500, 200);
                    img.Alignment = Element.ALIGN_CENTER;
                    documento.Add(img);
                }

                documento.Add(new Paragraph("\n"));

                // ===== Título y subtítulo =====
                documento.Add(new Paragraph("Typica", tituloFuente));
                documento.Add(new Paragraph("Coffea arabica var. typica'.", subtituloFuente));
                documento.Add(new Paragraph("\n"));

                var textoLibreFuente = FontFactory.GetFont(FontFactory.HELVETICA, 10);
                documento.Add(new Paragraph(
                    "This cultivar has received high cupping scores in multiple evaluations. " +
                    "It performs well under irrigation and is classified as a 'Fine Robusta'. " +
                    "Average beverage quality scored 10 points, with flavors of chocolate, caramel, and fruit.",
                    textoLibreFuente
                ));
                documento.Add(new Paragraph("\n"));

                // ===== Tabla de información =====
                PdfPTable tabla = new PdfPTable(2);
                tabla.WidthPercentage = 100;
                tabla.SetWidths(new float[] { 2, 3 }); // Proporción columnas

                // Función para agregar celda
                void Celda(string texto, Font fuente, BaseColor fondo)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
                    celda.BackgroundColor = fondo;
                    celda.Padding = 5;
                    celda.BorderColor = BaseColor.LIGHT_GRAY;
                    tabla.AddCell(celda);
                }

                // Datos
                Celda("Potencial de rendimiento", labelFuente, grisClaro);
                Celda("Medio", valorFuente, BaseColor.WHITE);

                Celda("Porte", labelFuente, grisClaro);
                Celda("Alto", valorFuente, BaseColor.WHITE);

                Celda("Tamaño Grano", labelFuente, grisClaro);
                Celda("Medio", valorFuente, BaseColor.WHITE);

                Celda(" Altitud Optima", labelFuente, grisClaro);
                Celda("1200-1800 msnm", valorFuente, BaseColor.WHITE);

                Celda("Calidad del grano", labelFuente, grisClaro);
                Celda("5", valorFuente, BaseColor.WHITE);

                Celda("Tiempo de Cosecha", labelFuente, grisClaro);
                Celda("9-11 meses", valorFuente, BaseColor.WHITE);

                Celda("Maduracion", labelFuente, grisClaro);
                Celda("Tardía", valorFuente, BaseColor.WHITE);

                Celda("Densidad Siembra", labelFuente, grisClaro);
                Celda("2.0 m x 2.0 m", valorFuente, BaseColor.WHITE);

                Celda("Nutricion", labelFuente, grisClaro);
                Celda("Nitrógeno, Fósforo, Potasio, Calcio, Magnesio", valorFuente, BaseColor.WHITE);

                Celda("Maduracion", labelFuente, grisClaro);
                Celda("Tardía", valorFuente, BaseColor.WHITE);

                documento.Add(tabla);
                documento.Add(new Paragraph("\n"));

                documento.Add(new Paragraph("Resistencias.", subtituloTablas));
                documento.Add(new Paragraph("\n"));

                PdfPTable tabla2 = new PdfPTable(2);
                tabla2.WidthPercentage = 100;
                tabla2.SetWidths(new float[] { 2, 3 }); // Proporción columnas

                // Función para agregar celda
                void Celda2(string texto, Font fuente, BaseColor fondo)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
                    celda.BackgroundColor = fondo;
                    celda.Padding = 5;
                    celda.BorderColor = BaseColor.LIGHT_GRAY;
                    tabla2.AddCell(celda);
                }
                Celda2("Roya", labelFuente, grisClaro);
                Celda2("Susceptible", valorFuente, BaseColor.WHITE);

                Celda2("Antracnosis", labelFuente, grisClaro);
                Celda2("Tolerante", valorFuente, BaseColor.WHITE);

                Celda2("Nematodos", labelFuente, grisClaro);
                Celda2("Susceptible", valorFuente, BaseColor.WHITE);

                documento.Add(tabla2);
                documento.Add(new Paragraph("\n"));

                documento.Add(new Paragraph("Linaje Genetico.", subtituloTablas));
                documento.Add(new Paragraph("\n"));

                PdfPTable tabla3 = new PdfPTable(2);
                tabla3.WidthPercentage = 100;
                tabla3.SetWidths(new float[] { 2, 3 });

                void Celda3(string texto, Font fuente, BaseColor fondo)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(texto, fuente));
                    celda.BackgroundColor = fondo;
                    celda.Padding = 5;
                    celda.BorderColor = BaseColor.LIGHT_GRAY;
                    tabla3.AddCell(celda);
                }
                Celda3("Obtentor", labelFuente, grisClaro);
                Celda3("Natural(Etiopia)", valorFuente, BaseColor.WHITE);

                Celda3("Familia", labelFuente, grisClaro);
                Celda3("Tipyca", valorFuente, BaseColor.WHITE);

                Celda3("Grupo", labelFuente, grisClaro);
                Celda3("Landrace", valorFuente, BaseColor.WHITE);

                documento.Add(tabla3);

                documento.Close();
            }

            Console.WriteLine($"PDF creado en: {Path.GetFullPath(rutaArchivo)}");
        }
    }
}