using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_DE_VENTAS
{
    public partial class datos_de_cliente : Form
    {
        public datos_de_cliente()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Lo hara Salir del sistema, Seguro que quiere salir");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se a eliminado Correctamente");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto le permitira editar el usuario esta seguro");
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Lo hara Salir del sistema, Seguro que quiere salir");
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form datos_de_cliente = new datos_de_cliente();
            datos_de_cliente.ShowDialog();
            this.Close();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogo = MessageBox.Show("Desea cerrar la aplicacion", "aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogo == DialogResult.Yes)
                {

                    this.Close();
                }
                else
                    return;
            }
            catch { }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
        }

        private void stockMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
