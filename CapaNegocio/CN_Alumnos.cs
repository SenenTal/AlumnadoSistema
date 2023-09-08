using System; 
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Alumnos
    {
        //Método para dar de Baja al Alumno
        public static string BajaAlumno(int Id)
        {
            CD_Alumnos S = new CD_Alumnos();
            return S.BajaAlumno(Id);
        }
        //Método para dar de Alta al Alumno
        public static string AltaAlumno(int Id)
        {
            CD_Alumnos S = new CD_Alumnos();
            return S.AltaAlumno(Id);
        }
        //Método para Insertar un registro de Alumno
        public static string InsertarAlumno(string Nombre)
        {
            CD_Alumnos S = new CD_Alumnos();
            string Existe;
            Existe = S.ExisteAlumno(Nombre);
            if(Existe.Equals("1"))
            {
                return "Ya existe alumno con ese nombre";
            }
            else
            {
                Alumnos A = new Alumnos();
                A.NombreCompleto = Nombre;
                return S.InsertarAlumno(A);
            }
        }
        //Método para Actualizar Alumno
        public static string ActualizarAlumno(int Id, string nombre)
        {
            CD_Alumnos A = new CD_Alumnos();
            string Existe;
            Existe = A.ExisteAlumno(nombre);
            if (Existe.Equals("1"))
            {
                return "No se actualizo";
            }
            else
            {
                Alumnos a = new Alumnos();
                a.IdAlumno = Id;
                a.NombreCompleto = nombre;
                return A.ActualizaAlumno(a);
            }
        }
        //Método para Eliminar Alumno
        public static string EliminarAlumno(int id)
        {
            CD_Alumnos A = new CD_Alumnos();
            return A.EliminaAlumno(id);
        }
        //Método para llamar los registros de Tabla Alumnos
        public static DataTable ListarAlumnos()
        {
            CD_Alumnos A = new CD_Alumnos();
            return A.ListarAlumnos();
        }
        public static DataTable BuscarAlumnos(string nAlumnos)
        {
            CD_Alumnos A = new CD_Alumnos();
            return A.BuscarAlumnos(nAlumnos);
        }
    }
}
