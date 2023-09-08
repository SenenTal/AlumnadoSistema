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
    public class CD_AsignacionMaterias
    {
        //Este es el método InsertarAsignacion: MateriaNueva
        public string MateriaNueva(Alumnos A, Materias B)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("MateriaNueva", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdAlumno", SqlDbType.Int).Value = A.IdAlumno;
                comando.Parameters.Add("@IdMateria", SqlDbType.Int).Value = B.IdMateria;
                SqlCon.Open();
                //En esta variable voy a almacenar 2 posibles valores
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se asigno nada";
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
        public DataTable ListadoMaterias(Alumnos A)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ListadoMaterias", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = A.IdAlumno;
                comando.Parameters.Add("@NombreAlumno", SqlDbType.VarChar).Value = A.NombreCompleto;
                SqlCon.Open();
                Resultado = comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
        public DataTable SeleccionarMateriasAlumnos()
        {
            //Nota es SqlDataReader no SqlDataAdapter
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SeleccionarMateriasAlumnos", SqlCon);
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
        public string Existe(int IdAlumno, int IdMateria)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("ExisteRegistro", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@IdAlumno", SqlDbType.Int).Value = IdAlumno;
                comando.Parameters.Add("@IdMateria", SqlDbType.Int).Value = IdMateria;
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
        public DataTable BuscarAsignacion(string nombre)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("BuscarAsignacion", SqlCon);
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
        public DataTable SeleccionarMaterias()
        {
            //Nota es SqlDataReader no SqlDataAdapter
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SeleccionarMaterias", SqlCon);
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
        public DataTable SeleccionarAlumnos()
        {
            //Nota es SqlDataReader no SqlDataAdapter
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SeleccionarAlumnos", SqlCon);
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
        public string BuscarIdMateria(string materia)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("BuscarIdMateria", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Materia", SqlDbType.VarChar).Value = materia;
                SqlCon.Open();
                //En esta variable voy a almacenar 2 posibles valores
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se encontro Id";
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
        public string BuscarIdAlumno(string alumno)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand comando = new SqlCommand("BuscarIdAlumno", SqlCon);
                //Le indicamos que la instruccion a ejecutar es un procedimiento almacenado
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@Alumno", SqlDbType.VarChar).Value = alumno;
                SqlCon.Open();
                //En esta variable voy a almacenar 2 posibles valores
                Rpta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se encontro Id";
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
        public DataTable SeleccionarIdAlumno()
        {
            //Nota es SqlDataReader no SqlDataAdapter
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SeleccionarIdAlumno", SqlCon);
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
        public DataTable SeleccionarIdMateria()
        {
            //Nota es SqlDataReader no SqlDataAdapter
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Establecemos conexion con la base de datos
                SqlCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("SeleccionarIdMateria", SqlCon);
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
    }
}
