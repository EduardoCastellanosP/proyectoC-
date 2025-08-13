using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using proyectc_.src.Modules.Usuarios.Application.Interfaces;

using proyectc_.src.Modules.Usuarios.Domain.Entities;

namespace proyectc_.src.Modules.Usuarios.Domain.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Clave { get; set; } = string.Empty;
    public string Rol { get; set; } = "Operador"; // 'Admin' o 'Operador'
}

