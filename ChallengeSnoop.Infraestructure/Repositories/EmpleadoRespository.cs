using ChallengeSnopp.Core.Entities;
using ChallengeSnopp.Core.Interface;
using ChallengeSnopp.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnoop.Infraestructure.Repositories
{
    public class EmpleadoRespository : BaseRepository<Empleado>, IEmpleadoRespository
    {

        public EmpleadoRespository(DataContext context) : base(context)
        { 
        
        }
        public async Task<IEnumerable<Empleado>> Antiguedad(int antiguedad)
        {
            return  await _context.Empleados.Where(x => x.FechaIngreso.Year.Equals(antiguedad)).ToListAsync();
        }
    }
}
