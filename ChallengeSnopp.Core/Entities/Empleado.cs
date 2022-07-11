using ChallengeSnopp.Core.Entities.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnopp.Core.Entities
{
    public class Empleado : Entity
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string  Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaIngreso { get; set; }
    }
}
