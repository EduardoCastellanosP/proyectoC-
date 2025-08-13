using System.Collections.Generic;
using System.Threading.Tasks;
 
using proyectc_.src.Modules.Variedades.Domain.Entities;


namespace proyectc_.src.Modules.Filtros.Domain.Entities;

public class Variedad
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";

    public int? TamanoGranoId { get; set; }
    public TamanoGrano? TamanoGrano { get; set; }

    public int? PorteId { get; set; }
    public Porte? Porte { get; set; }

    public int? ResistenciaNivelId { get; set; }
    public ResistenciaNivel? ResistenciaNivel { get; set; }

    public int? RendimientoPotencialId { get; set; }
    public RendimientoPotencial? RendimientoPotencial { get; set; }

    public int? TipoCafeId { get; set; }
    public TipoCafe? TipoCafe { get; set; }

    public int? Altitud { get; set; }
}
