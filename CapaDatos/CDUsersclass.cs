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
    public class CDUsersclass
    {
        private int dIdLogin;
        private string  dUsuario, dContraseña,dEstado;

        //Constructor vacío de la clase
        public CDUsersclass()
        {
        }
        //Constructor con parámetros de la clase
        //uso p para referirme a los parámetros
        public CDUsersclass(int pIdLogin,
        string pUsuario,
        string pContraseña,
        string pEstado)
        {

        }

        #region para los métodos Get y Set
        public int IdLogin
        {
            get { return dIdLogin; }
            set { dIdLogin = value; }
        }
        public string Usuario
        {
            get { return dUsuario; }
            set { dUsuario = value; }
        }
        public string Contraseña
        {
            get { return dContraseña; }
            set { dContraseña = value; }
        }
        public string Estado
        {
            get { return dEstado; }
            set { dEstado = value; }
        }



        #endregion


        public String Insertar(CDUsersclass objUsers)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" UsersInsertar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdLogin", objUsers.dIdLogin);
                micomando.Parameters.AddWithValue("@Usuario", objUsers.dUsuario);
                micomando.Parameters.AddWithValue("@Conntraseña", objUsers.dContraseña);
                micomando.Parameters.AddWithValue("@Estado", objUsers.dEstado);
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


        public String   Actualizar(CDUsersclass objUsers)
        {

            String mensaje = "";
            SqlConnection sqlCon = new SqlConnection();


            try
            {

                sqlCon.ConnectionString = Appconexicion.miconexion;
                SqlCommand micomando = new SqlCommand(" UsersActualizar", sqlCon);
                sqlCon.Open();
                micomando.CommandType = CommandType.StoredProcedure;
                micomando.Parameters.AddWithValue("@IdLogin", objUsers.dIdLogin);
                micomando.Parameters.AddWithValue("@Usuario", objUsers.dUsuario);
                micomando.Parameters.AddWithValue("@Conntraseña", objUsers.dContraseña);
                micomando.Parameters.AddWithValue("@Estado", objUsers.dEstado);
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