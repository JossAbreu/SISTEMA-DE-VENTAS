using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.Data.SqlClient;


namespace SISTEMA_DE_VENTAS
{
 
    public partial class sesion : Form
    {
  
        
        public sesion()
        {
           
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            logins();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Lo hara Salir del sistema, Seguro que quiere salir");
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, Contraseña FROM Users WHERE usuario='" + txtUser.Text + "' AND Contraseña='" + txtPass.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Bienvenido");
                            this.Hide();
                            Form Menu = new Menu();
                            Menu.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (txtPass.PasswordChar == '*')
            {
                button3.BringToFront();
                txtPass.PasswordChar = '\0';
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            if (txtPass.PasswordChar == '\0')
            {
                button4.BringToFront();
                txtPass.PasswordChar = '*';
            }

        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPass.Focus();
            }
           */
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
           /* if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPass.Focus();
            }
           */
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                logins();
            }
        }
    }
}
