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
   public class CNCliente
    {
        public static string Insertar
       (int pIdCliente,
        string pNombre,
        string pApellido,
        string pDirección,
        string pTeléfono,
        string pCedula,
       string  pEmail,
       string pEstado)

        {
            CDCliente objCliente= new CDCliente();
            objCliente.IdCliente= pIdCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Dirección = pDirección;
            objCliente.Teléfono = pTeléfono;
            objCliente.Cedula = pCedula;
            objCliente.Email = pEmail;
            objCliente.Estado = pEstado;



            return objCliente.Insertar(objCliente);
        }

        public static string Actualizar
       (int pIdCliente,
        string pNombre,
        string pApellido,
        string pDirección,
        string pTeléfono,
        string pCedula,
        string pEmail,
       string pEstado)

        {
            CDCliente objCliente = new CDCliente();
            objCliente.IdCliente = pIdCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Dirección = pDirección;
            objCliente.Teléfono = pTeléfono;
            objCliente.Cedula = pCedula;
            objCliente.Email = pEmail;
            objCliente.Estado = pEstado;



            return objCliente.Actulizar(objCliente);
        }


        public DataTable ObtenerCliente()
        {
            string msg = "";
            CDCliente objCliente = new CDCliente(); //creamos un nuevo objeto de la clase suplidor
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = objCliente.ClienteMostrarTodo(); //El DataTable se llena con todos los datos devueltos
            return dt;
        } //Fin del método ObtenerSuplidor



        public DataTable ObtenerClienteConFiltro(int TieneParametro, String Parametro)
        {
            string msg = "";
            CDCliente objCliente = new CDCliente(); //creamos un nuevo objeto suplidor
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = objCliente.ClienteMostrarConFiltro(Parametro); //Llenamos el DataTable
            return dt; //Retornamos el DataTable con los datos adquiridos
        }//Fin del método ObtenerSuplidorConFiltro



    }
}

