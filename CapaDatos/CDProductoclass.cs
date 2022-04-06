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
    public class CDProductoclass
    {
        private int dIdProducto;
        private string dNombre, dModelo, dMarca, dImei, dDescripcion, dPrecio, dCosto, dColor, dEstado, dStock,dIdCategoria;

        //Constructor vacío de la clase
        public CDProductoclass()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDProductoclass(int pIdProducto,
        string pNombre,
        string pModelo,
        string pMarca,
        string pImei,
        string pDescripcion,
        string pPrecio,
        string pCosto,
       string pColor,
       string pEstado,
       string pStock,
       string pIdCategoria)
        {

        }

        #region para los métodos Get y Set
        public int IdProducto
        {
            get { return dIdProducto; }
            set { dIdProducto = value; }
        }
        public string Nombre
        {
            get { return dNombre; }
            set { dNombre = value; }
        }
        public string Descripcion
        {
            get { return dDescripcion; }
            set { dDescripcion = value; }
        }
        public string Modelo
        {
            get { return dModelo; }
            set { dModelo = value; }
        }
        public string Marca
        {
            get { return dMarca; }
            set { dMarca = value; }
        }
        public string Imei
        {
            get { return dImei; }
            set { dImei = value; }
        }
        public string Precio
        {
            get { return dPrecio; }
            set { dPrecio = value; }
        }
        public string Costo
        {
            get { return dCosto; }
            set { dCosto = value; }
        }
        public string Color
        {
            get { return dColor; }
            set { dColor = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }
        public string Stock
        {
            get { return dStock; }
            set { dStock = value; }
        }
        public string IdCategoria
        {
            get { return dIdCategoria; }
            set { dIdCategoria = value; }
        }
        #endregion


        public String Insertar(CDProductoclass objProducto)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" ProductoInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@Factura_Detalle", objProducto.dIdProducto);
                micomando.Parameters.AddWithValue("@Nombre", objProducto.dNombre);
                micomando.Parameters.AddWithValue("@Descripcion", objProducto.dDescripcion);
                micomando.Parameters.AddWithValue("@Modelo", objProducto.dModelo);
                micomando.Parameters.AddWithValue("@Marca", objProducto.dMarca);
                micomando.Parameters.AddWithValue("@Imei", objProducto.dImei);
                micomando.Parameters.AddWithValue("@Precio", objProducto.dPrecio);
                micomando.Parameters.AddWithValue("@Costo", objProducto.dCosto);
                micomando.Parameters.AddWithValue("@Color", objProducto.dColor);
                micomando.Parameters.AddWithValue("@Estado", objProducto.dEstado);
                micomando.Parameters.AddWithValue("@Stock", objProducto.dStock);
                micomando.Parameters.AddWithValue("@IdCategoria", objProducto.dIdCategoria);

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

        public String Actualizar(CDProductoclass objProducto)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" ProductoActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@Factura_Detalle", objProducto.dIdProducto);
                micomando.Parameters.AddWithValue("@Nombre", objProducto.dNombre);
                micomando.Parameters.AddWithValue("@Descripcion", objProducto.dDescripcion);
                micomando.Parameters.AddWithValue("@Modelo", objProducto.dModelo);
                micomando.Parameters.AddWithValue("@Marca", objProducto.dMarca);
                micomando.Parameters.AddWithValue("@Imei", objProducto.dImei);
                micomando.Parameters.AddWithValue("@Precio", objProducto.dPrecio);
                micomando.Parameters.AddWithValue("@Costo", objProducto.dCosto);
                micomando.Parameters.AddWithValue("@Color", objProducto.dColor);
                micomando.Parameters.AddWithValue("@Estado", objProducto.dEstado);
                micomando.Parameters.AddWithValue("@Stock", objProducto.dStock);
                micomando.Parameters.AddWithValue("@IdCategoria", objProducto.dIdCategoria);

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