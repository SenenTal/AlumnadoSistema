using System;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using Sistema.Datos;

namespace CapaDatos
{
    public class CD_Alumnos
    {
        public DataTable ListarAlumnos()
        {
            //Nota es SqlDataReader no SqlDataAdapter
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("ListaAlumno", SqlCon);
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
        public string InsertarAlumno(Alumnos A) {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("InsertarAlumno", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombreCompleto", SqlDbType.VarChar).Value = A.NombreCompleto;
                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso nada";
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
        public string AltaAlumno (int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("AltaAlumno", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se realizo la alta";
            }
            catch(Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State==ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }
        public string BajaAlumno(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("BajaAlumno", SqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se realizo la baja";
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
        public string ActualizaAlumno(Alumnos A)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ActualizaAlumno", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = A.IdAlumno;
                comando.Parameters.Add("@nombreAlumno", SqlDbType.VarChar).Value = A.NombreCompleto;
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
        public string EliminaAlumno(int Id)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("Elimina1Alumno", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                SqlCon.Open();
                //En esta variable voy a almacenar 2 posibles valores
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el Alumno";
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
        public string ExisteAlumno(string nombre)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ExisteAlumno", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
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
        public DataTable BuscarAlumnos(string nombre)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("BuscarAlumnos", SqlCon);
                //Procedimiento almacenado
                Comando.CommandType = CommandType.StoredProcedure;
                //Se le indica que vamos a agregar un parametro al procedimiento almacenado
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
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
    }
}
