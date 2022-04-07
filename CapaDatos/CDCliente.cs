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
    public class CDCliente
    {
        private int didCliente;
        private string  dNombre, dApellido, dDirección, dTeléfono, dCedula, dEmail,dEstado;

        
        public CDCliente()
        {
        }
        
        public CDCliente(int pIdCliente,
        string pNombre,
        string pApellido,
        string pDirección,
        string pTeléfono,
        string pCedula,
       string pEstado)
        {

        }

        #region para los métodos Get y Set
        public int IdCliente
        {
            get { return didCliente; }
            set { didCliente = value; }
        }
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Apellido
        {
            get { return dApellido; }
            set { dApellido = value; }
        }
        public string Dirección
        {
            get { return dDirección; }
            set { dDirección = value; }
        }
        public string Teléfono
        {
            get { return dTeléfono; }
            set { dTeléfono = value; }
        }
        public string Cedula
        {
            get { return dCedula; }
            set { dCedula = value; }
        }
        public string Email
        {
            get { return dEmail; }
            set { dEmail = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        #endregion


        public String Insertar(CDCliente objCliente)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pNombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objCliente.Apellido);
                micomando.Parameters.AddWithValue("@pDirección", objCliente.Dirección);
                micomando.Parameters.AddWithValue("@pTeléfono", objCliente.Teléfono);
                micomando.Parameters.AddWithValue("@pCedula", objCliente.Cedula);
                micomando.Parameters.AddWithValue("@pEmail", objCliente.Email);
                micomando.Parameters.AddWithValue("@pEstado", objCliente.Estado);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Inserción de datos completada correctamente" :
                                          "No se pudo Insertar correctamente los datos!";

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

       

        public String Actulizar(CDCliente objCliente)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand("ClienteActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@pIdCliente", objCliente.IdCliente);
                micomando.Parameters.AddWithValue("@pNombre", objCliente.Nombre);
                micomando.Parameters.AddWithValue("@pApellido", objCliente.Apellido);
                micomando.Parameters.AddWithValue("@pDirección", objCliente.Dirección);
                micomando.Parameters.AddWithValue("@pTeléfono", objCliente.Teléfono);
                micomando.Parameters.AddWithValue("@pCedula", objCliente.Cedula);
                micomando.Parameters.AddWithValue("@pEmail", objCliente.Email);
                micomando.Parameters.AddWithValue("@pEstado", objCliente.Estado);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Actualizacion de datos completada correctamente" :
                                          "No se pudo Actualizar correctamente los datos!";

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
        public DataTable ClienteConsultar(String CDCateclass)
        {
            DataTable dt = new DataTable();
            SqlDataReader leerDatos;
            try
            {
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.Connection = new Appconexicion().dbconexion;
                sqlCmd.Connection.Open();
                sqlCmd.CommandText = "ClienteConsultar";
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@IdCliente", CDCateclass);
                sqlCmd.Parameters.AddWithValue("@Nombre", CDCateclass);
                sqlCmd.Parameters.AddWithValue("@Apellido", CDCateclass);
                sqlCmd.Parameters.AddWithValue("@Telefono", CDCateclass);
                sqlCmd.Parameters.AddWithValue("@Cedula", CDCateclass);
                sqlCmd.Parameters.AddWithValue("@Email", CDCateclass);
                sqlCmd.Parameters.AddWithValue("@Estado", CDCateclass);
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


        public DataTable ClienteMostrarTodo()
        {
            DataTable dtCliente = new DataTable(); //Creamos un DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Se establece el comando
                sqlCmd.Connection = new Appconexicion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "ClienteMostrarTodo"; //Nombre del Procedimiento Almacenado
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                leerDatos = sqlCmd.ExecuteReader(); //Se llena el SqlDataReader con los datos resultantes
                dtCliente.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception ex) //Si ocurre algún error se captura
            {
                dtCliente = null; //Si ocurre algun error se anula el DataTable
            }
            return dtCliente; //Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método SuplidorMostrarTodo


        public DataTable ClienteMostrarConFiltro(String miparametro)
        {
            DataTable dtCliente = new DataTable(); //Se Crea DataTable que tomará los datos de los Suplidores
            SqlDataReader leerDatos; //Creamos el DataReader
            try
            {
                SqlCommand sqlCmd = new SqlCommand(); //Establecer el comando
                sqlCmd.Connection = new Appconexicion().dbconexion; //Conexión que va a usar el comando
                sqlCmd.Connection.Open(); //Se abre la conexión
                sqlCmd.CommandText = "ClienteMostrarFiltrado"; //Nombre del Proc. Almacenado a usar
                sqlCmd.CommandType = CommandType.StoredProcedure; //Se trata de un proc. almacenado
                sqlCmd.Parameters.AddWithValue("@pvalor", miparametro); //Se pasa el valor a buscar
                leerDatos = sqlCmd.ExecuteReader(); //Llenamos el SqlDataReader con los datos resultantes
                dtCliente.Load(leerDatos); //Se cargan los registros devueltos al DataTable
                sqlCmd.Connection.Close(); //Se cierra la conexión
            }
            catch (Exception ex)
            {
                dtCliente = null; //Si ocurre algun error se anula el DataTable

            }
            return dtCliente; ////Se retorna el DataTable segun lo ocurrido arriba
        } //Fin del método SuplidorMostrarConFiltro
    }

}