using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using Sistema.Datos;

namespace CapaDatos
{
    public class CD_Materias
    {
        public DataTable ListarMaterias()
        {
            //Nota es SqlDataReader no SqlDataAdapter
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ListaMateria", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();//Se abre la conexion
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //Se cierra la conexion
            }
        }
        public string InsertarMateria(Materias M)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("InsertarMateria", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = M.NombreMateria;
                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se inserto nada";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string EliminaMateria(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Elimina1Materia", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                //En esta variable voy a almacenar 2 posibles valores
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar materia";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string ExisteMateria(string materia)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ExisteMateria", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = materia;
                SqlParameter ParExiste = new SqlParameter();
                ParExiste.ParameterName = "@existe";
                //Le indico que ParExiste es un parametro Int
                ParExiste.SqlDbType = SqlDbType.Int;
                //Le indico a ParExiste como parametro de salida
                ParExiste.Direction = ParameterDirection.Output;
                //Agrego este parametro al comando
                comando.Parameters.Add(ParExiste);
                SqlCon.Open();
                //Vamos a ejecutar este comando
                comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParExiste.Value);
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public DataTable BuscarMaterias(string materia)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("BuscarMaterias", SqlCon);
                //Procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Se le indica que vamos a agregar un parametro al procedimiento almacenado
                Comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = materia;
                SqlCon.Open();//Se abre la conexion
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close(); //Se cierra la conexion
            }
        }
        public string ActualizaMateria(Materias M)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ActualizaMateria", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = M.IdMateria;
                comando.Parameters.Add("@materia", SqlDbType.VarChar).Value = M.NombreMateria;
                SqlCon.Open();
                //En esta variable voy a almacenar 2 posibles valores
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
    }
}
