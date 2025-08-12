using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Colombian_Coffe.src.Modules.Variedades.Domain.Entities;

namespace Colombian_Coffe.src.Modules.Variedades.Application.Interfaces;

public interface IVariedadesRepository
{
    Task<IEnumerable<Variedad?>> GetAllVariedadesAsync();
    Task<Variedad?> GetVariedadByIdAsync(int id);
    void Add(Variedad entity);
    void Update(Variedad entity);
    void Remove(Variedad entity);
    Task SaveChangesAsync();
}
