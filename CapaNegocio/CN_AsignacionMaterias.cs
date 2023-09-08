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
    public class CN_AsignacionMaterias
    {
        //Método que llama a SeleccionarMateriasAlumnos: lo que hace este es
        //mostrar los registros asignados de cada Materia con cada Alumno
        public static DataTable SeleccionarMateriasAlumnos()
        {
            CD_AsignacionMaterias Al = new CD_AsignacionMaterias();
            return Al.SeleccionarMateriasAlumnos();
        }
        //Método para seleccionar todos los Alumnos Válidos
        public static DataTable SeleccionarAlumnos()
        {
            CD_AsignacionMaterias Al = new CD_AsignacionMaterias();
            return Al.SeleccionarAlumnos();
        }
        //Método para seleccionar las Materias
        public static DataTable SeleccionarMaterias()
        {
            CD_AsignacionMaterias Al = new CD_AsignacionMaterias();
            return Al.SeleccionarMaterias();
        }
        //Método ListadoMaterias: este llama un Id y nombre de Alumno para mostrar especificamente
        //las materias del alumno
        public static DataTable ListadoMaterias(int IdAlumno, string NombreCompleto)
        {
            CD_AsignacionMaterias Al = new CD_AsignacionMaterias();
            Alumnos A = new Alumnos();
            A.IdAlumno = IdAlumno;
            A.NombreCompleto = NombreCompleto;
            return Al.ListadoMaterias(A);
        }
        //Método MateriaNueva: Sirve para registrar y asignar Alumnos con las Materias Asignadas
        //Este es el método Insertar: MateriaNueva
        public static string MateriaNueva(int IdAlumno, int IdMateria)
        {
            CD_AsignacionMaterias Z = new CD_AsignacionMaterias();
            string Existe = Z.Existe(IdAlumno, IdMateria);
            if (Existe.Equals("1"))
            {
                return "Ya existe registro con esa materia";

            }
            else
            {
                Alumnos A = new Alumnos();
                Materias B = new Materias();
                A.IdAlumno = IdAlumno;
                B.IdMateria = IdMateria;
                return Z.MateriaNueva(A, B);
            }
        }

        public static DataTable BuscarAsignacion(string nombre)
        {
            CD_AsignacionMaterias A = new CD_AsignacionMaterias();
            return A.BuscarAsignacion(nombre);
        }
        public static string BuscarIdMateria(string materia)
        {
            CD_AsignacionMaterias M = new CD_AsignacionMaterias();
            return M.BuscarIdMateria(materia);
        }
        public static string BuscarIdAlumno(string alumno)
        {
            CD_AsignacionMaterias M = new CD_AsignacionMaterias();
            return M.BuscarIdAlumno(alumno);
        }
        public static DataTable SeleccionarIdAlumno()
        {
            CD_AsignacionMaterias Al = new CD_AsignacionMaterias();
            return Al.SeleccionarIdAlumno();
        }
        public static DataTable SeleccionarIdMateria()
        {
            CD_AsignacionMaterias Al = new CD_AsignacionMaterias();
            return Al.SeleccionarIdMateria();
        }
    }
}
