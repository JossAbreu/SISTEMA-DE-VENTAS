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
       (int pidCliente,
        string pNombre,
        string pApellido,
        string pDirección,
        string pTeléfono,
        string pCedula,
       string pEstado)

        {
            CDClienteclass objCliente= new CDClienteclass();
            objCliente.IdCliente= pidCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Dirección = pDirección;
            objCliente.Teléfono = pTeléfono;
            objCliente.Cedula = pCedula;
            objCliente.Estado = pEstado;



            return objCliente.Insertar(objCliente);
        }

        public static string Actualizar
       (int pidCliente,
        string pNombre,
        string pApellido,
        string pDirección,
        string pTeléfono,
        string pCedula,
       string pEstado)

        {
            CDClienteclass objCliente = new CDClienteclass();
            objCliente.IdCliente = pidCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Dirección = pDirección;
            objCliente.Teléfono = pTeléfono;
            objCliente.Cedula = pCedula;
            objCliente.Estado = pEstado;



            return objCliente.Actulizar(objCliente);
        }

        public static string InsertarActualizar(int accion,
        int pidCliente,
        string pNombre,
        string pApellido,
        string pDirección,
        string pTeléfono,
        string pCedula,
       string pEstado)

        {
            CDClienteclass objCliente = new CDClienteclass();
            objCliente.IdCliente = pidCliente;
            objCliente.Nombre = pNombre;
            objCliente.Apellido = pApellido;
            objCliente.Dirección = pDirección;
            objCliente.Teléfono = pTeléfono;
            objCliente.Cedula = pCedula;
            objCliente.Estado = pEstado;

            return objCliente.InsertarActualizar(objCliente, accion);
        }


        public DataTable ObtenerCliente(string miparametro)
        {
            CDClienteclass objSuplidor = new CDClienteclass();
            DataTable dt = new DataTable();


            dt = objSuplidor.ClienteConsultar(miparametro);
            return dt;
        }

    }
}

