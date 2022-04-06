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
    public partial class RegistroU : Form
    {
        public RegistroU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es el Mensaje", "Mensaje",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            
           
        }

        private void RegistroU_Load(object sender, EventArgs e)
        {
          
        }


        public void button2_Click(object sender, EventArgs e)
        {
          
        }
       

           


        }
    }