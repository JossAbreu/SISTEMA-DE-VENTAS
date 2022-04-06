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
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
        
            Form Form2= new sesion();
            this.Hide();  
            Form2.ShowDialog();
            this.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form Empleado = new Empleado();
            this.Hide();
            Empleado.ShowDialog();
            this.Close();
        }

     

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form sesion = new sesion();
            sesion.ShowDialog();
            this.Close();

        }
    }
}
