using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnopp.Core.DTOs
{
    public class EmpleadoDTO
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }
        public string Dni { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaIngreso { get; set; }
    }
}
