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
    public class CDFactura_Detalleclass
    {
        private int dIdFactura_Detalle;
        private string dIdProducto, dCantidad, dFecha, dDescripcion, dIdEmpleado;

        //Constructor vacío de la clase
        public CDFactura_Detalleclass()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDFactura_Detalleclass(int pIdFactura_Detalle,
        string pIdProducto,
        string pCantidad,
        string pFecha,
        string pDescripcion,
        string pIdEmpleado)
        {

        }

        #region para los métodos Get y Set
        public int IdFactura_Detalle
        {
            get { return dIdFactura_Detalle; }
            set { dIdFactura_Detalle = value; }
        }
        public string IdProducto
        {
            get { return dIdProducto; }
            set { dIdProducto = value; }
        }
        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        public string Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }
        public string Fecha
        {
            get { return dFecha; }
            set { dFecha = value; }
        }
       
        public string IdEmpleado
        {
            get { return dIdEmpleado; }
            set { dIdEmpleado = value; }
        }
     

        #endregion


        public String Insertar(CDFactura_Detalleclass objFactura_Detalle)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" Factura_DetalleInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdFactura_Detalle", objFactura_Detalle.dIdFactura_Detalle);
                micomando.Parameters.AddWithValue("@IdProducto", objFactura_Detalle.dIdProducto);
                micomando.Parameters.AddWithValue("@Descripcion", objFactura_Detalle.dDescripcion);
                micomando.Parameters.AddWithValue("@Cantidad", objFactura_Detalle.dCantidad);
                micomando.Parameters.AddWithValue("@Fecha", objFactura_Detalle.dFecha);
                micomando.Parameters.AddWithValue("@IdEmpleado", objFactura_Detalle.dIdEmpleado);
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
        public String Actualizar(CDFactura_Detalleclass objFactura_Detalle)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" Factura_DetalleActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdFactura_Detalle", objFactura_Detalle.dIdFactura_Detalle);
                micomando.Parameters.AddWithValue("@IdProducto", objFactura_Detalle.dIdProducto);
                micomando.Parameters.AddWithValue("@Descripcion", objFactura_Detalle.dDescripcion);
                micomando.Parameters.AddWithValue("@Cantidad", objFactura_Detalle.dCantidad);
                micomando.Parameters.AddWithValue("@Fecha", objFactura_Detalle.dFecha);
                micomando.Parameters.AddWithValue("@IdEmpleado", objFactura_Detalle.dIdEmpleado);
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