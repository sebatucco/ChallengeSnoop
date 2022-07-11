using ChallengeSnopp.Core.DTOs;
using ChallengeSnopp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnopp.Core.Interface
{
    public interface IEmpleadoService
    {

        Task<Empleado> GetByIdAsync(int id);

        Task<List<Empleado>> GetAllAsync();

        Task<Empleado> Add(EmpleadoDTO empleado);

        Task<Empleado> Update(Empleado empleado);

        Task DeleteByIdAsync(int id);

        Task<List<Empleado>> AntiguedadEmpleado(string antiguedad);
    }
}
