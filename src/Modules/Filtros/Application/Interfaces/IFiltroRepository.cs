using Microsoft.EntityFrameworkCore;
using proyectc_.src.Modules.Variedades.Domain.Entities;
using System.Collections.Generic;
using proyectc_.src.Modules.Filtros.Application.Interfaces;




namespace proyectc_.src.Modules.Filtros.Application.Interfaces
{
    public interface IFiltrosRepository
    {
        Task<List<Filtro>> GetAllAsync();
    }
}