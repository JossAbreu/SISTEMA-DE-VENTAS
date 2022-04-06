using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;


namespace CapaDatos
{
    public class CDCompra_Cabeceraclass
    {
        private int dIdCompra_Cabecera;
        private string dIdEmpleado, dIdProveedor, dDescripcion, dTipo_de_compra, dFecha, dEstado_de_Compra, dInicial;

        //Constructor vacío de la clase
        public CDCompra_Cabeceraclass()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDCompra_Cabeceraclass(int pidCompra_Cabecera,
        string pCompra_Cabecera,
         string pIdEmpleado,
         string pIdProveedor,
        string pDescripcion,
        string pTipo_de_compra,
        string pFecha,
        string pEstado_de_Compra,
        string pInicial)
        {

        }

        #region para los métodos Get y Set
        public int IdCompra_Cabecera
        {
            get { return dIdCompra_Cabecera; }
            set { dIdCompra_Cabecera = value; }
        }
        public string IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }
        public string IdProveedor
        {
            get { return dIdProveedor; }
            set { dIdProveedor = value; }
        }
        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        public string Tipo_de_compra
        {
            get { return dTipo_de_compra; }
            set { dTipo_de_compra = value; }
        }
        public string Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }
        public string Estado_de_Compra
        {
            get { return dEstado_de_Compra; }
            set { dEstado_de_Compra = value; }
        }
        public string Inicial
        {
            get { return dInicial; }
            set { dInicial = value; }
        }
        #endregion


        public String Insertar(CDCompra_Cabeceraclass objCompra_Cabecera)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" Compra_CabeceraInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdCompra_Cabecera", objCompra_Cabecera.IdCompra_Cabecera);
                micomando.Parameters.AddWithValue("@IdEmpleado", objCompra_Cabecera.IdEmpleado);
                micomando.Parameters.AddWithValue("@IdProveedor", objCompra_Cabecera.IdProveedor);
                micomando.Parameters.AddWithValue("@Descripcion", objCompra_Cabecera.Descripcion);
                micomando.Parameters.AddWithValue("@Tipo_de_compra", objCompra_Cabecera.Tipo_de_compra);
                micomando.Parameters.AddWithValue("@Fecha", objCompra_Cabecera.Fecha);
                micomando.Parameters.AddWithValue("@Estado_de_Compra", objCompra_Cabecera.Estado_de_Compra);
                micomando.Parameters.AddWithValue("@Inicial", objCompra_Cabecera.Inicial);
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
        public String Actualizar(CDCompra_Cabeceraclass objCompra_Cabecera)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" Compra_CabeceraActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdCompra_Cabecera", objCompra_Cabecera.IdCompra_Cabecera);
                micomando.Parameters.AddWithValue("@IdEmpleado", objCompra_Cabecera.IdEmpleado);
                micomando.Parameters.AddWithValue("@IdProveedor", objCompra_Cabecera.dIdProveedor);
                micomando.Parameters.AddWithValue("@Descripcion", objCompra_Cabecera.dDescripcion);
                micomando.Parameters.AddWithValue("@Tipo_de_compra", objCompra_Cabecera.dTipo_de_compra);
                micomando.Parameters.AddWithValue("@Fecha", objCompra_Cabecera.dFecha);
                micomando.Parameters.AddWithValue("@Estado_de_Compra", objCompra_Cabecera.dEstado_de_Compra);
                micomando.Parameters.AddWithValue("@Inicial", objCompra_Cabecera.dInicial);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Actualizacion de datos completada correctamente" :
                                          "No se pudo Actualizar correctamente los datos !";

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

        public DataTable Compra_CabeceraConsultar(String CDCompra_Cabeceraclass)
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
                sqlCmd.Parameters.AddWithValue("@IdCompra_Cabecera", CDCompra_Cabeceraclass);
                sqlCmd.Parameters.AddWithValue("@IdEmpleado", CDCompra_Cabeceraclass);
                sqlCmd.Parameters.AddWithValue("@IdProveedor", CDCompra_Cabeceraclass);
                sqlCmd.Parameters.AddWithValue("@Descripcion", CDCompra_Cabeceraclass);
                sqlCmd.Parameters.AddWithValue("@Tipo_de_compra", CDCompra_Cabeceraclass);
                sqlCmd.Parameters.AddWithValue("@Fecha", CDCompra_Cabeceraclass);
                sqlCmd.Parameters.AddWithValue("@Estado_de_Compra", CDCompra_Cabeceraclass);
                sqlCmd.Parameters.AddWithValue("@Inicial", CDCompra_Cabeceraclass);
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