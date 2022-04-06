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
    public class CDFacturaclass
    {
        private int dIdFactura;
        private string   dIdCliente, dDescripcion, dDireccion, dDescuento, dItebis, dRNS, dTotal, dFecha;

        //Constructor vacío de la clase
        public CDFacturaclass()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDFacturaclass(int pIdFactura,
        string pIdcliente,
        string pDescripcion,
        string pDescuento,
        string pItebis,
        string pDirección,
        string pRNS,
        string pTotal,
        string pFecha)
        {

        }

        #region para los métodos Get y Set
        public int IdFactura
        {
            get { return dIdFactura; }
            set { dIdFactura = value; }
        }
        public string IdCliente
        {
            get { return dIdCliente; }
            set { dIdCliente = value; }
        }
        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        public string Descuento
        {
            get { return dDescuento; }
            set { dDescuento = value; }
        }
        public string Itebis
        {
            get { return dItebis; }
            set { dItebis = value; }
        }
        public string Dirección
        {
            get { return dDireccion; }
            set { dDireccion = value; }
        }
        public string RNS
        {
            get { return dRNS; }
            set { dRNS = value; }
        }
        public string Total
        {
            get { return dTotal; }
            set { dTotal = value; }
        }
        public string Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }

        #endregion


        public String Insertar(CDFacturaclass objFactura)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" FacturaInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdFactura", objFactura.dIdFactura);
                micomando.Parameters.AddWithValue("@IdCliente", objFactura.dIdCliente);
                micomando.Parameters.AddWithValue("@Descripcion", objFactura.dDescripcion);
                micomando.Parameters.AddWithValue("@Descuento", objFactura.dDescuento);
                micomando.Parameters.AddWithValue("@Itebis", objFactura.dItebis);
                micomando.Parameters.AddWithValue("@RNS", objFactura.dIdFactura);
                micomando.Parameters.AddWithValue("@Total", objFactura.dTotal);
                micomando.Parameters.AddWithValue("@Fecha", objFactura.dFecha);
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

        public String Actualizar(CDFacturaclass objFactura)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" FacturaActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdFactura", objFactura.dIdFactura);
                micomando.Parameters.AddWithValue("@IdCliente", objFactura.dIdCliente);
                micomando.Parameters.AddWithValue("@Descripcion", objFactura.dDescripcion);
                micomando.Parameters.AddWithValue("@Descuento", objFactura.dDescuento);
                micomando.Parameters.AddWithValue("@Itebis", objFactura.dItebis);
                micomando.Parameters.AddWithValue("@RNS", objFactura.dIdFactura);
                micomando.Parameters.AddWithValue("@Total", objFactura.dTotal);
                micomando.Parameters.AddWithValue("@Fecha", objFactura.dFecha);
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
    }

}