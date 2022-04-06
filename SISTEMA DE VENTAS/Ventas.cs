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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se a eliminado Correctamente");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
