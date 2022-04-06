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
    public class CDClienteclass
    {
        private int didCliente;
        private string  dNombre, dApellido, dDirección, dTeléfono, dCedula, dEmail,dEstado;

        
        public CDClienteclass()
        {
        }
        
        public CDClienteclass(int pidCliente,
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


        public String Insertar(CDClienteclass objCliente)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" ClienteInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdCliente", objCliente.didCliente);
                micomando.Parameters.AddWithValue("@Nombre", objCliente.dNombre);
                micomando.Parameters.AddWithValue("@Apellido", objCliente.dApellido);
                micomando.Parameters.AddWithValue("@Telefono", objCliente.dTeléfono);
                micomando.Parameters.AddWithValue("@Cedula", objCliente.dCedula);
                micomando.Parameters.AddWithValue("@Email", objCliente.dEmail);
                micomando.Parameters.AddWithValue("@Estado", objCliente.dEstado);
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

        public string InsertarActualizar(CDClienteclass objCliente, int accion)
        {
            throw new NotImplementedException();
        }

        public String Actulizar(CDClienteclass objCliente)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" ClienteActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdCliente", objCliente.didCliente);
                micomando.Parameters.AddWithValue("@Nombre", objCliente.dNombre);
                micomando.Parameters.AddWithValue("@Apellido", objCliente.dApellido);
                micomando.Parameters.AddWithValue("@Telefono", objCliente.dTeléfono);
                micomando.Parameters.AddWithValue("@Cedula", objCliente.dCedula);
                micomando.Parameters.AddWithValue("@Email", objCliente.dEmail);
                micomando.Parameters.AddWithValue("@Estado", objCliente.dEstado);
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

    }

}