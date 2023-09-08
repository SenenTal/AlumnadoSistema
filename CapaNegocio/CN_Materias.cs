using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Materias
    {
        public static string InsertarMateria(string MateriaNueva)
        {
            CD_Materias B= new CD_Materias();
            string Existe = B.ExisteMateria(MateriaNueva);
            if (Existe.Equals("1"))
            {
                return "Ya existe materia con ese nombre";
            }
            else
            {
                Materias c = new Materias();
                c.NombreMateria = MateriaNueva;
                return B.InsertarMateria(c);
            }
        }
        public static string EliminaMateria(int Id)
        {
            CD_Materias E = new CD_Materias();
            return E.EliminaMateria(Id);
        }
        public static DataTable ListarMaterias()
        {
            CD_Materias M = new CD_Materias();
            return M.ListarMaterias();
        }
        public static DataTable BuscarMaterias(string nMateria)
        {
            CD_Materias M = new CD_Materias();
            return M.BuscarMaterias(nMateria);
        }
        //Método para actualizar materia
        public static string ActualizarMateria(int Id, string materia)
        {
            CD_Materias M = new CD_Materias();
            string Existe;
            Existe = M.ExisteMateria(materia);
            if (Existe.Equals("1"))
            {
                return "No se actualizo";
            }
            else
            {
                Materias m = new Materias();
                m.IdMateria = Id;
                m.NombreMateria = materia;
                return M.ActualizaMateria(m);
            }
        }
    }
}
