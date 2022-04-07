using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;



namespace SISTEMA_DE_VENTAS
{
    public partial class Clientes : Form
    {

        public int indice = 0, vtieneparametro = 0;

        public string valorparametro = "", mensaje = "";
        CNCliente objCliente = new CNCliente();

        public Clientes()
        {
            InitializeComponent();
        }
        private void MostrarDatos()
        {
            if (vtieneparametro == 0) //Si el valor de vtieneparametro es cero no hay filtro
            {
                //MessageBox.Show("vtieneparametro"+Convert.ToInt32(vtieneparametro));
                DGVDatos.DataSource = objCliente.ObtenerCliente(); //Se ejecuta el método para mostrar todo
            }
            else //Si el valor de vtieneparametro es 1 se ejecuta el método que filtra datos según el parámetro
            {
                if (objCliente.ObtenerClienteConFiltro(vtieneparametro, valorparametro) != null)
                    DGVDatos.DataSource = objCliente.ObtenerClienteConFiltro(vtieneparametro, valorparametro);

                else
                    MessageBox.Show("No se retornó ningún valor!");
            }
            DGVDatos.Refresh(); //Se refresca el DataGridView
            if (DGVDatos.RowCount <= 0) //Si no se obtienen datos de retorno
            {
                MessageBox.Show("Ningún dato que mostrar!"); //Se muestra un mensaje de error
            }
            else //Asignamos el ancho de las distintas columnas del DataBridView
            {
                DGVDatos.Columns[0].Width = 100; //IdCliente
                DGVDatos.Columns[1].Width = 150; //Nombre
                DGVDatos.Columns[2].Width = 150; //Apellido
                DGVDatos.Columns[3].Width =200 ; //Direccion
                DGVDatos.Columns[4].Width = 130; //Telefono
                DGVDatos.Columns[5].Width = 200; //Cedula
                DGVDatos.Columns[6].Width = 140; //Email
                DGVDatos.Columns[7].Width = 90; //Estado
               
            }
            //else

            // MessageBox.Show("No se retornó ningún valor!");

            DGVDatos.Refresh(); //Se refresca el DataGridView

        }

        public void LimpiaObjetos()
        {
            tbIdCliente.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbDireccion.Clear();
            tbTelefono.Clear();
            tbCedula.Clear();
            tbEmail.Clear();
            cbEstado.SelectedItem = 0; //Establece el valor por defecto del Combobox
        } //Fin del método LimpiaObjetos
        private void HabilitaControles(bool valor)
        {
            tbNombre.ReadOnly = false;
             tbIdCliente.ReadOnly = false; //la propiedad ReadOnly hace de solo lectura un objeto
            tbIdCliente.Clear();                                //la propiedad Enabled habilita o inhabilita un objeto
            cbEstado.Enabled = valor;
            if (Program.Nuevo)
                cbEstado.SelectedIndex = 0;
        } //Fin del método HabilitaControles

        private void HabilitaBotones()
        {
            if (
                Program.Nuevo || Program.Modificar)
            {
                HabilitaControles(true); //Llamada al método para habilitar los objetos
                BNuevo.Enabled = false;
                BGuardar.Enabled = true;
                BEditar.Enabled = false;
                BBuscar.Enabled = false;
                BCancelar.Enabled = true;

            }
            else
            {
                HabilitaControles(false); //Llamada al método para inhabilitar los objetos
                BNuevo.Enabled = true;
                BGuardar.Enabled = false;
                BEditar.Enabled = true;
                BBuscar.Enabled = true;
                BCancelar.Enabled = false;
            }
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
            Form Clientes = new Clientes();
            Clientes.ShowDialog();
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

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esto lo hara Salir del formulario! \n Seguro que desea Hacerlo?", "Mensaje De Mobile Service",

                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                e.Cancel = false;
            else
                e.Cancel = false;
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            //Validamos los datos requeridos entes de Insertar o Actualizar

            // if   (Program.Nuevo) { MessageBox.Show("Nuevo registroo"); }

            // if (Program.Modificar) { MessageBox.Show("Nuevo registroo"); }
            if (tbNombre.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar el nombre del Cliente!");
                tbNombre.Focus();
            }

            else
             if (tbApellido.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar el Apellido del Cliente!");
                tbApellido.Focus();
            }

            else
             if (tbDireccion.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar la Direccion!");
                tbDireccion.Focus();
            }

            else

             if (tbTelefono.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar el Telefono!");
                tbTelefono.Focus();
            }

            else
             if (tbCedula.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar la Cedula del Cliente!");
                tbCedula.Focus();
            }

            else
             if (tbEmail.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar el Email del Cliente!");
                tbEmail.Focus();
            }

            else
             
           if (cbEstado.Text == String.Empty)
            {
                MessageBox.Show("Debe seleccionar el estado de la Categoria!");
                cbEstado.Focus();
            }
            else
            {
                //Si todo es correcto procede a Insertar o actualizar según corresponda, usaremos las

                if (Program.Nuevo) //Si la variable nuevo llega con valor true se van a Insertar nuevo datos
                {
                    //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                    //pasándole como parámetros los valores leídos en los controles del formulario. como:
                    //textbox, combobox, DateTimePicker, etc.
                    //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado

                    mensaje = CNCliente.Insertar(Program.vIdCliente,tbNombre.Text, tbApellido.Text, tbDireccion.Text, tbTelefono.Text, tbCedula.Text, tbEmail.Text,cbEstado.Text);
                }
                else //de lo contrario se Modificarán los datos del registro correspondiente
                {
                    //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                    //pasándole como parámetros los valores leídos en los controles del formulario.
                    // como: textbox, combobox, DateTimePicker, etc.
                    //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado
                    mensaje = CNCliente.Actualizar(Program.vIdCliente, tbNombre.Text, tbApellido.Text, tbDireccion.Text, tbTelefono.Text, tbCedula.Text, tbEmail.Text, cbEstado.Text);
                }
                //Se muestra el mensaje devuelto por la capa de negocio respecto al resultado de la operación
                MessageBox.Show(mensaje, "Mensage de Mobile Service", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                //Se prepara todo para la próxima operación
                Program.Nuevo = false;
                Program.Modificar = false;
                HabilitaBotones(); //Habilita los objetos y botones correspondientes
                LimpiaObjetos(); //Llama al método LimpiaObjetos
                MostrarDatos();
                DGVDatos.Refresh();
            } //Fin del else para valida
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.Nuevo = false;
            Program.Modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos

            Program.Modificar = false; //variable global a toda la solución
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Suplidor no se puede modificar
            if (!tbIdCliente.Equals(""))
            {
                Program.Modificar = true; //el formulaario se prepara para modificar datos
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Suplidor para poder Modificar sus datos!");
            }
        }

        private void Clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (tbBuscar.Text != String.Empty) //Si se introdujo un dato en el textbox
            {
                vtieneparametro = 1; //se indica que se trabajará con parámetros
                                     //Se coloca el signo % para que el dato indicado se busque en cualquier parte del campo
                valorparametro = "%" + tbBuscar.Text.Trim() + "%";
                //valorparametro = tbBuscar.Text.Trim();
            }
            else //si el textbox está vacío
            {
                vtieneparametro = 0; //se indica que no se trabajará con parámetros
                valorparametro = ""; //Se vuelve vacío la variable del parámetro.
            }
            MostrarDatos(); //Se llama al método MostrarDatos 
            tbBuscar.Focus(); //Se le pasa el cursos al textbox
        }
        public void RecuperaDatos()
        {
            string vparametro = Program.vIdCliente.ToString();
            CNCliente CNCliente = new CNCliente();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = CNCliente.ObtenerClienteConFiltro(1, vparametro); //Llenamos el DataTable
                                                                       //Recorremos cada fila del DataTable asignando a los controles de edición los valores de
                                                                       //los campos correspondientes
            foreach (DataRow row in dt.Rows)
            {
                tbIdCliente.Text = row["IdCliente"].ToString();
                tbNombre.Text = row["Nombre"].ToString();
                tbApellido.Text = row["Apellido"].ToString();
                tbDireccion.Text = row["Direccion"].ToString();
                tbTelefono.Text = row["Telefono"].ToString();
                tbCedula.Text = row["Cedula"].ToString();
                tbEmail.Text = row["Email"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }
        } //Fin del metodo RecuperarDatos

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVDatos.CurrentRow.Index;
        }

        private void BPrimero_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1) //Si no estamos al inicio del DataGridView, vamos al inicio
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BSiguiente_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) //Si no estamos al final del DataGridView, avanzamos 1 fila
            {
                indice++;
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BUltimo_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) //Si no estamos al final del DataGridView
            {
                indice = DGVDatos.Rows.Count - 1; //vamos a la última fila del DataGridView
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void BRefrescar_Click(object sender, EventArgs e)
        {
            MostrarDatos();
            DGVDatos.Refresh();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.Nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.Modificar = false;
            HabilitaBotones(); //Se habilitan solo aquellos botones que sean necesarios
            tbNombre.Focus();
        }

        private void stockMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            Program.Nuevo = false; //Valores de las variables globales nuevo y modificar
            Program.Modificar = false;
            HabilitaBotones(); //Se habilitarán los objetos y los botones necesarios.
            valorparametro = "";
            vtieneparametro = 0;
            Program.vIdCliente= 0; //variable global que tomará el valor seleccionado
            MostrarDatos(); //Llamo al Método que llena el DataGrid
            tbBuscar.Focus();
        }
    }
}
