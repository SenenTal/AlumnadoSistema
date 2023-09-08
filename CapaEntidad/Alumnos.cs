using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    //Nota: El error de que no conoce la clase Alumnos en la Capa Datos, es porque estaba como internal
    //y no como public
    public class Alumnos
    {
        public int IdAlumno { get; set; }
        public string NombreCompleto { get; set; }
        public string FechaRegistro { get; set; }
        public bool Estado { get; set; }
    }
}
