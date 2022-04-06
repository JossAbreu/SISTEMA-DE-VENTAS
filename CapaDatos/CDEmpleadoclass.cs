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
    public class CDEmpleadoclass
    {
        private int didEmpleado;
        private string  dNombre, dApellido, dCargo, dSexo, dDirección,dTeléfono, dCedula, dEmail,dEstado;

        //Constructor vacío de la clase
        public CDEmpleadoclass()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDEmpleadoclass(int pidEmpleado,
        string pNombre,
        string pApellido,
        string pCargo,
        string pSexo,
        string pDirección,
        string pTeléfono,
        string pCedula,
        string pEmail,
        string pEstado)
        {

        }

        #region para los métodos Get y Set
        public int idEmpleado
        {
            get { return didEmpleado; }
            set { didEmpleado = value; }
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
        public string Cargo
        {
            get { return dCargo; }
            set { dCargo = value; }
        }
        public string Sexo
        {
            get { return dSexo; }
            set { dSexo = value; }
        }
        public string Dirección
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


        public String Insertar(CDEmpleadoclass objEmpleado)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" EmpleadoInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdEmpleado", objEmpleado.didEmpleado);
                micomando.Parameters.AddWithValue("@Nombre", objEmpleado.dNombre);
                micomando.Parameters.AddWithValue("@Apellido", objEmpleado.dApellido);
                micomando.Parameters.AddWithValue("@Cargo", objEmpleado.dCargo);
                micomando.Parameters.AddWithValue("@Sexo", objEmpleado.dSexo);
                micomando.Parameters.AddWithValue("@Direccion", objEmpleado.dDirección);
                micomando.Parameters.AddWithValue("@Telefono", objEmpleado.dTeléfono);
                micomando.Parameters.AddWithValue("@Cedula", objEmpleado.dCedula);
                micomando.Parameters.AddWithValue("@Email", objEmpleado.dEmail);
                micomando.Parameters.AddWithValue("@Estado", objEmpleado.dEstado);
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

        public String Actualizar(CDEmpleadoclass objEmpleado)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" EmpleadoActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdEmpleado", objEmpleado.didEmpleado);
                micomando.Parameters.AddWithValue("@Nombre", objEmpleado.dNombre);
                micomando.Parameters.AddWithValue("@Apellido", objEmpleado.dApellido);
                micomando.Parameters.AddWithValue("@Cargo", objEmpleado.dCargo);
                micomando.Parameters.AddWithValue("@Sexo", objEmpleado.dSexo);
                micomando.Parameters.AddWithValue("@Direccion", objEmpleado.dDirección);
                micomando.Parameters.AddWithValue("@Telefono", objEmpleado.dTeléfono);
                micomando.Parameters.AddWithValue("@Cedula", objEmpleado.dCedula);
                micomando.Parameters.AddWithValue("@Email", objEmpleado.dEmail);
                micomando.Parameters.AddWithValue("@Estado", objEmpleado.dEstado);
                mensaje = micomando.ExecuteNonQuery() == 1 ? "Actuaizacion de datos completada correctamente" :
                                          "No se pudo Actuualizar  correctamente los datos !";

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