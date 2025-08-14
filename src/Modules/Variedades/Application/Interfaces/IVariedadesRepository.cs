// src/Modules/Variedades/Application/Interfaces/IVariedadesRepository.cs
using System.Collections.Generic;
using System.Threading.Tasks;
using proyectc_.src.Modules.Variedades.Domain.Entities;

namespace proyectc_.src.Modules.Variedades.Application.Interfaces
{
    public interface IVariedadesRepository
    {
        Task<IEnumerable<Variedad>> GetAllVariedadesAsync();
        Task<Variedad?> GetByIdAsync(int id);

        Task AddAsync(Variedad entity);
        void Update(Variedad entity);
        void Remove(Variedad entity);
        Task<int> SaveChangesAsync();
    }
}
