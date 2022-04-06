﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form datos_de_cliente = new datos_de_cliente();
            datos_de_cliente.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esto Lo hara Salir del sistema, Seguro que quiere salir");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Empleado = new Empleado();
            Empleado.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ventas= new ventas ();
            ventas.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Provedor = new Provedor();
            Provedor.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Registro_de_productos = new Registro_de_productos();
            Registro_de_productos.ShowDialog();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void stockMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form StockMinimo = new StockMinimo();
            StockMinimo.ShowDialog();
        }

        private void ventasPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalRecaudacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ventasDeProductoPorFechaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void comprasPorFerchaConDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Form comprasporfechacondetalle = new comprasporfechacondetalle();
            comprasporfechacondetalle.ShowDialog();
        }

        private void comprasDeProductosPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form comprasdeproductosporfecha = new comprasdeproductosporfecha();
            comprasdeproductosporfecha.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form datos_de_cliente = new datos_de_cliente();
            datos_de_cliente.ShowDialog();
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Empleado = new Empleado();
            Empleado.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Factura = new Caja();
            Factura.ShowDialog();
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

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Compras = new Compras();
            Compras.ShowDialog();
            this.Close();
        }
        // menu 
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesion Cerrada");
            this.Hide();
            Form sesion = new sesion();
            sesion.ShowDialog();
            this.Close();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Categorias = new Categorias();
            Categorias.ShowDialog();
            
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Registro_de_productos = new Registro_de_productos();
            Registro_de_productos.ShowDialog();
            this.Close();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ventas = new ventas();
            ventas.ShowDialog();
            this.Close();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Compras = new Compras();
            Compras.ShowDialog();
            this.Close();
        }

        private void provedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Provedor = new Provedor();
            Provedor.ShowDialog();
            this.Close();
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Factura = new Caja();
            Factura.ShowDialog();
            this.Close();
        }

        private void ventasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
                
            Form consultasventas = new consultasventas();
            consultasventas.ShowDialog();
           
        }

        private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form consultascompras = new ConsultasCompras();
            consultascompras.ShowDialog();
        }

        private void cuentasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultascuentasPagar = new CuentasPagar();
            consultascuentasPagar.ShowDialog();
        }

        private void cuentasACobrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form consultascuentascobrar = new cuentasCobrar();
            consultascuentascobrar.ShowDialog();
        }

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form consultasproducto = new consultaproducto();
            consultasproducto.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
                Form consultasclientes= new consultaclientes();
            consultasclientes.ShowDialog();
        }

        private void proovedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form consultasproveedores = new consultaproveedores();
            consultasproveedores.ShowDialog();
        }

        private void historialCierreDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form    HistorialCierreCaja = new cierredecaja();
            HistorialCierreCaja.ShowDialog();
        }

        private void ventasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form reportesventasporfecha = new ventasporfecha();
            reportesventasporfecha.ShowDialog();
        }

        private void ventasPorUsuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form reportesventasporusuario = new ventasporusuario();
            reportesventasporusuario.ShowDialog();
        }

        private void ventasDeProductoPorFechaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
          
                 Form reportesproductosporfecha = new ventasproductosporfecha();
            reportesproductosporfecha.ShowDialog();
        }

      

        private void ventasPorFormasDePagoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
                 Form ventasporformadepago = new ventasporformadepago();
            ventasporformadepago.ShowDialog();
        }

        private void ventasPorTarjetasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form ventascontarjeta = new ventascontarjeta();
            ventascontarjeta.ShowDialog();
        }

        private void graficoDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form inventariototal = new inventariototal();
            inventariototal.ShowDialog();
        }

        private void comprasPoreFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Form compraporfecha = new compraporfecha();
            compraporfecha.ShowDialog();
        }

        private void comprasConTarjetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form comprascontarjeta = new comprascontarjeta();
            comprascontarjeta.ShowDialog();
        }

        private void comprasPorFormaDeFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form compraformapago = new compraformapago();
            compraformapago.ShowDialog();
        }

        private void cinfiguracionGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Configuracion = new Configuracion();
            Configuracion.ShowDialog();
        }

        private void impresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form impresoras = new impresoras();
            impresoras.ShowDialog();
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            Form informacion = new informacion();
            informacion.ShowDialog();
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form respaldo = new backup();
            respaldo.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form RegistroU = new RegistroU();
            RegistroU.ShowDialog();
        }
    }
}