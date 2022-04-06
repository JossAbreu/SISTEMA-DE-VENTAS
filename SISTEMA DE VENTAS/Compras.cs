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
    public partial class Compras : Form
    {
        public Compras()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Lo hara Salir del sistema, Seguro que quiere salir");
            this.Close();
        }

        private void datos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Lo hara Salir del sistema, Seguro que quiere salir");
            this.Close();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
        }

        private void Compras_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Lo hara Salir del sistema, Seguro que quiere salir");
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
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
    }
}
