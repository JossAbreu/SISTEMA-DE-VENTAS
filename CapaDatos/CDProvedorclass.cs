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
    public class CDProvedorclass
    {
        private int dIdProvedor;
        private string  dNombre, dApellido, dDirección, dTeléfono, dCedula, dEmail,dEstado;

        //Constructor vacío de la clase
        public CDProvedorclass()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDProvedorclass(int pIdProvedor,
        string pNombre,
        string pApellido,
        string pDirección,
        string pTeléfono,
        string pCedula,
        string pEmail,
        string pEstado)
        {

        }

        #region para los métodos Get y Set
        public int IdProvedor
        {
            get { return dIdProvedor; }
            set { dIdProvedor = value; }
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
        public string Direccion
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


        public String Insertar(CDProvedorclass objProvedor)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" ProvedorclassInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdProvedor", objProvedor.dIdProvedor);
                micomando.Parameters.AddWithValue("@Nombre", objProvedor.dNombre);
                micomando.Parameters.AddWithValue("@Apellido", objProvedor.dApellido);
                micomando.Parameters.AddWithValue("@Direccion", objProvedor.dDirección);
                micomando.Parameters.AddWithValue("@Telefono", objProvedor.dTeléfono);
                micomando.Parameters.AddWithValue("@Cedula", objProvedor.dCedula);
                micomando.Parameters.AddWithValue("@Email", objProvedor.dEmail);
                micomando.Parameters.AddWithValue("@Estado", objProvedor.dEstado);
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

        public String Actualizar(CDProvedorclass objProvedor)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" ProvedorclassActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdProvedor", objProvedor.dIdProvedor);
                micomando.Parameters.AddWithValue("@Nombre", objProvedor.dNombre);
                micomando.Parameters.AddWithValue("@Apellido", objProvedor.dApellido);
                micomando.Parameters.AddWithValue("@Direccion", objProvedor.dDirección);
                micomando.Parameters.AddWithValue("@Telefono", objProvedor.dTeléfono);
                micomando.Parameters.AddWithValue("@Cedula", objProvedor.dCedula);
                micomando.Parameters.AddWithValue("@Email", objProvedor.dEmail);
                micomando.Parameters.AddWithValue("@Estado", objProvedor.dEstado);
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