using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class AsignacionMaterias
    {
        public int IdAsignacion { get; set; }
        public int oMateria { get; set; }
        public int oAlumnos { get; set; }
        public string FechaAsignacion { get; set; }
    }
}
