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
    public class CDCompra_Detalleclass
    {
        private int didCompra_Detalle;
        private string  dCantidad, dDescripcion, dIdProducto, dCosto;

        //Constructor vacío de la clase
        public CDCompra_Detalleclass()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDCompra_Detalleclass(int pidCompra_Detalle,
        string pidCompra_Detalles,
        string pCantidad,
        string pDescripcion,
        string pProducto,
        string pCosto)
        {

        }

        #region para los métodos Get y Set
        public int idCompra_Detalle
        {
            get { return didCompra_Detalle; }
            set { didCompra_Detalle = value; }
        }
        public string Cantidad
        {
            get { return dCantidad; }
            set { dCantidad = value; }
        }
        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        public string IdProducto
        {
            get { return dIdProducto; }
            set { dIdProducto = value; }
        }
        public string Costo
        {
            get { return dCosto; }
            set { dCosto = value; }
        }
       
        #endregion


        public String Insertar(CDCompra_Detalleclass objCompra_Detalle)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" Compra_DetalleInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdCompra_Detalle", objCompra_Detalle.didCompra_Detalle);
                micomando.Parameters.AddWithValue("@Cantidad", objCompra_Detalle.dCantidad);
                micomando.Parameters.AddWithValue("@Descripcion", objCompra_Detalle.dDescripcion);
                micomando.Parameters.AddWithValue("@Producto", objCompra_Detalle.dIdProducto);
                micomando.Parameters.AddWithValue("@Costo", objCompra_Detalle.dCosto);
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

        public String Actualizar(CDCompra_Detalleclass objCompra_Detalle)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" Compra_DetalleActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdCompra_Detalle", objCompra_Detalle.didCompra_Detalle);
                micomando.Parameters.AddWithValue("@Cantidad", objCompra_Detalle.dCantidad);
                micomando.Parameters.AddWithValue("@Descripcion", objCompra_Detalle.dDescripcion);
                micomando.Parameters.AddWithValue("@Producto", objCompra_Detalle.dIdProducto);
                micomando.Parameters.AddWithValue("@Costo", objCompra_Detalle.dCosto);
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