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

    public class CNCategoria
    {

        public static string Insertar
        (int pIdCategoria,
        string pCategoria,
        string pEstado)
        {
            CDCategoria objCategoria = new CDCategoria();
            objCategoria.IdCategoria = pIdCategoria;
            objCategoria.Categoria = pCategoria;
            objCategoria.Estado = pEstado;


      
            return objCategoria.Insertar(objCategoria);
        }

        public static string Actualizar
      
        (int pIdCategoria,
         string pCategoria,
         string pEstado)
        {
            CDCategoria objCategoria = new CDCategoria();
            objCategoria.IdCategoria = pIdCategoria;
            objCategoria.Categoria = pCategoria;
            objCategoria.Estado = pEstado;



            return objCategoria.Actualizar(objCategoria);
        }





        public DataTable ObtenerCategoria()
        {
            string msg = "";
            CDCategoria objCategoria = new CDCategoria(); //creamos un nuevo objeto de la clase suplidor
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = objCategoria.CategoriaMostrarTodo(); //El DataTable se llena con todos los datos devueltos
            return dt; //Se retorna el DataTable con los datos adquiridos
        } //Fin del método ObtenerSuplidor



        public DataTable    ObtenerCategoriaConFiltro(int TieneParametro, String Parametro)
        {
            string msg = "";
            CDCategoria objCategoria = new CDCategoria(); //creamos un nuevo objeto suplidor
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = objCategoria.CategoriaMostrarConFiltro(Parametro); //Llenamos el DataTable
            return dt; //Retornamos el DataTable con los datos adquiridos
        }//Fin del método ObtenerSuplidorConFiltro


    }
}
