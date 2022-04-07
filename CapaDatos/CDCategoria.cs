using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using CapaDatos;

namespace CapaDatos
{
    public class CDCategoria
    {
        private int dIdCategoria;
        private string dCategoria, dEstado;

        //Constructor vacío de la clase
        public CDCategoria()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDCategoria(
        int pIdCategoria,
        string pCategoria,
        string pEstado)
        {

        }

        #region para los métodos Get y Set
        public int IdCategoria
        {
            get { return dIdCategoria; }
            set { dIdCategoria = value; }
        }
        public string Categoria
        {
            get { return dCategoria; }
            set { dCategoria = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion


        public String Insertar(CDCategoria objCategoria)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand("CategoriaInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pCategoria", objCategoria.Categoria);
                micomando.Parameters.AddWithValue("@pEstado", objCategoria.Estado);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente" :
                                          "No se pudo Insertar correctamente los datos !";

            }


            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            //Luego de realizar el proceso de forma correcta o no
            finally
            {
                //Cierro la conexion si esta abierta
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
            //Devuelvo el mensaje correspondiente de acuerdo a lo que haya resultado del comando
            return mensaje;
        }



        //método para actualizar los datos del Suplidor. Recibirá el objeto objSuplidor como parámetro
        public string Actualizar(CDCategoria objCategoria)
        {
            string mensaje = "";
            SqlConnection sqlCon = new SqlConnection();
            try
            {
                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand("CategoriaActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIdCategoria", objCategoria.IdCategoria);
                micomando.Parameters.AddWithValue("@pCategoria", objCategoria.Categoria);
                micomando.Parameters.AddWithValue("@pEstado", objCategoria.Estado);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Datos actualizados correctamente!" :
                 "No se pudo actualizar correctamente los datos!";


            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }

            finally
            {

                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }

            return mensaje;
        }

       
        public DataTable CategoriaConsultar(String CDCateclass)
        {
            DataTable dt = new DataTable(); 
            SqlDataReader leerDatos; 
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); 
                sqlCmd.Connection = new Appconexicion().dbconexion; 
                sqlCmd.Connection.Open(); 
                sqlCmd.CommandText = "CategoriaConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure; 
               sqlCmd.Parameters.AddWithValue("@pIdCategoria", CDCateclass);
                sqlCmd.Parameters.AddWithValue("@pCategoria", CDCateclass);
                sqlCmd.Parameters.AddWithValue("@pEstado", CDCateclass);
                leerDatos = sqlCmd.ExecuteReader(); 
                dt.Load(leerDatos); 
                sqlCmd.Connection.Close(); 
            }
            catch (Exception ex)
            {
                dt = null; 
            }
            return dt; 
        }  


        public DataTable CategoriaMostrarTodo()
        {
            DataTable dtCategoria = new DataTable(); //Creamos un DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Se establece el comando
                sqlCmd.Connection = new Appconexicion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "CategoriaMostrarTodo"; //Nombre del Procedimiento Almacenado
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                leerDatos = sqlCmd.ExecuteReader(); //Se llena el SqlDataReader con los datos resultantes
                dtCategoria.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception ex) //Si ocurre algún error se captura
            {
                dtCategoria = null; //Si ocurre algun error se anula el DataTable
            }
            return dtCategoria; //Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método SuplidorMostrarTodo


        public DataTable CategoriaMostrarConFiltro(String miparametro)
        {
            DataTable dtCategoria = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Appconexicion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "CategoriaMostrarFiltrado"; //Nombre del Proc. Almacenado a usar
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); //Se pasa el valor a buscar
                leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                dtCategoria.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception ex)
            {
                dtCategoria = null; //Si ocurre algun error se anula el DataTable

            }
            return dtCategoria; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método SuplidorMostrarConFiltro



      




    }
}


    


