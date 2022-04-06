using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using CapaDatos;

namespace CapaNegocio
{
    public class CNCompra_Cabecera
    {
        public static string Insertar
       (int pidCompra_Cabecera,
         string pIdEmpleado,
         string pIdProveedor,
        string pDescripcion,
        string pTipo_de_compra,
        string pFecha,
        string pEstado_de_Compra,
        string pInicial)

        {
            CDCompra_Cabeceraclass objCompra_Cabecera = new CDCompra_Cabeceraclass();
            objCompra_Cabecera.IdCompra_Cabecera = pidCompra_Cabecera;
            objCompra_Cabecera.IdEmpleado = pIdEmpleado;
            objCompra_Cabecera.IdProveedor = pIdProveedor;
            objCompra_Cabecera.Descripcion = pDescripcion;
            objCompra_Cabecera.Tipo_de_compra = pTipo_de_compra;
            objCompra_Cabecera.Fecha = pFecha;
            objCompra_Cabecera.Estado_de_Compra = pEstado_de_Compra;
            objCompra_Cabecera.Inicial = pInicial;
           


            return objCompra_Cabecera.Insertar(objCompra_Cabecera);
        }

        public static string Actualizar
    (int pidCompra_Cabecera,
      string pIdEmpleado,
      string pIdProveedor,
     string pDescripcion,
     string pTipo_de_compra,
     string pFecha,
     string pEstado_de_Compra,
     string pInicial)

        {
            CDCompra_Cabeceraclass objCompra_Cabecera = new CDCompra_Cabeceraclass();
            objCompra_Cabecera.IdCompra_Cabecera = pidCompra_Cabecera;
            objCompra_Cabecera.IdEmpleado = pIdEmpleado;
            objCompra_Cabecera.IdProveedor = pIdProveedor;
            objCompra_Cabecera.Descripcion = pDescripcion;
            objCompra_Cabecera.Tipo_de_compra = pTipo_de_compra;
            objCompra_Cabecera.Fecha = pFecha;
            objCompra_Cabecera.Estado_de_Compra = pEstado_de_Compra;
            objCompra_Cabecera.Inicial = pInicial;



            return objCompra_Cabecera.Actualizar(objCompra_Cabecera);
        }



        public DataTable ObtenerCliente(string miparametro)
        {
            CDCompra_Cabeceraclass objSuplidor = new CDCompra_Cabeceraclass();
            DataTable dt = new DataTable();


            dt = objSuplidor.Compra_CabeceraConsultar(miparametro);
            return dt;
        }

    }
}
