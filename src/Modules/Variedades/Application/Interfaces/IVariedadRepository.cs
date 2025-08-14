// src/Modules/Variedades/Application/Interfaces/IVariedadesRepository.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Application.Interfaces
{
    public interface IVariedadRepository
    {
       Task<List<TamanoGrano>>         ListarTamanoGranoAsync(bool descending = false, CancellationToken ct = default);
        Task<List<Porte>>               ListarPorteAsync(bool descending = false, CancellationToken ct = default);
        Task<List<ResistenciaNivel>>    ListarResistenciaNivelAsync(bool descending = false, CancellationToken ct = default);
        Task<List<RendimientoPotencial>>ListarRendimientoPotencialAsync(bool descending = false, CancellationToken ct = default);
        Task<List<CalidadAltitudNivel>> ListarCalidadAltitudNivelAsync(bool descending = false, CancellationToken ct = default);
        Task<List<Enfermedad>>          ListarEnfermedadAsync(bool descending = false, CancellationToken ct = default);

        // void Add(Variedad entity);
        // void Update(Variedad entity);
        // void Remove(Variedad entity);
        // Task SaveAsync();
    }
}
