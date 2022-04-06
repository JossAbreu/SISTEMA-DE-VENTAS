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


    public partial class Categorias : Form
    {

        public int indice = 0, vtieneparametro = 0;

        public string valorparametro = "", mensaje = "";
        CNCategoria objCategoria = new CNCategoria();

        public Categorias()

        {
            InitializeComponent();
        }

        //Metodoo que mostrara Todo en el Datagriw

       private void MostrarDatos()
        {
            if (vtieneparametro == 0) //Si el valor de vtieneparametro es cero no hay filtro
            {
                //MessageBox.Show("vtieneparametro"+Convert.ToInt32(vtieneparametro));
                DGVDatos.DataSource = objCategoria.ObtenerCategoria(); //Se ejecuta el método para mostrar todo
            }
            else //Si el valor de vtieneparametro es 1 se ejecuta el método que filtra datos según el parámetro
            {
              
                if (objCategoria.ObtenerCategoriaConFiltro(vtieneparametro, valorparametro) != null)
                    DGVDatos.DataSource = objCategoria.ObtenerCategoriaConFiltro(vtieneparametro, valorparametro);

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
                DGVDatos.Columns[0].Width = 80; //IdCategroia
                DGVDatos.Columns[1].Width = 200; //Categria
                DGVDatos.Columns[2].Width = 225; //Estado
            }
              //else

                   // MessageBox.Show("No se retornó ningún valor!");

                    DGVDatos.Refresh(); //Se refresca el DataGridView

        }
    
        
        //Método propio para limpiar los objetos del formulario. Asegúrese de utilizar el nombre
        // correcto de cada objeto
        public void LimpiaObjetos()
        {
            tbCategoria.Clear();
          
            cbEstado.SelectedItem = 0; //Establece el valor por defecto del Combobox
        } //Fin del método LimpiaObjetos

        private void HabilitaControles(bool valor)
        {
            tbCategoria.ReadOnly = false;
           // tbIdCategoria.ReadOnly = false; //la propiedad ReadOnly hace de solo lectura un objeto
           // tbIdCategoria.Clear();                                //la propiedad Enabled habilita o inhabilita un objeto
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




        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Menu = new Menu();
            Menu.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LimpiaObjetos(); //LLama al método LimpiaObjetos para prepararlos para la nueva entrada
            Program.Nuevo = true; //Se especifica que se agregará un nuevo registro
            Program.Modificar = false;
            HabilitaBotones(); //Se habilitan solo aquellos botones que sean necesarios
            tbCategoria.Focus();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Categorias_FormClosing(object sender, FormClosingEventArgs e)
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
            if (tbCategoria.Text == String.Empty) //Si el textbox está vacío mostrar un error y ubicar
            { // el cursor en dicho textbox
                MessageBox.Show("Debe indicar el nombre de la Categoria!");
                tbCategoria.Focus();
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

                    mensaje = CNCategoria.Insertar(Program.vIdCategoria, tbCategoria.Text,cbEstado.Text);
                }
                else //de lo contrario se Modificarán los datos del registro correspondiente
                {
                    //Se llama al método Insertar de la clase CNSuplidor de la capa de negocio
                    //pasándole como parámetros los valores leídos en los controles del formulario.
                    // como: textbox, combobox, DateTimePicker, etc.
                    //Los parámetros se pasan en el orden en que se reciben y con el tipo de dato esperado
                    mensaje = CNCategoria.Actualizar(Program.vIdCategoria, tbCategoria.Text,cbEstado.Text);
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
            } //Fin del else para validar los datos


        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Program.Nuevo = false;
            Program.Modificar = false;
            HabilitaBotones(); //Habilita los objetos y botones correspondientes
            LimpiaObjetos(); //Llama al método LimpiaObjetos

            Program.Modificar = false; //variable global a toda la solución
           
        }

        private void BEditar_Click(object sender, EventArgs e)
        {
            //Si no ha seleccionado un Suplidor no se puede modificar
            if (!tbIdCategoria.Equals(""))
            {
                Program.Modificar = true; //el formulaario se prepara para modificar datos
                HabilitaBotones();
            }
            else
            {
                MessageBox.Show("Debe de buscar un Suplidor para poder Modificar sus datos!");
            }




        }

        private void Categorias_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void BBuscar_Click(object sender, EventArgs e)
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
            string vparametro = Program.vIdCategoria.ToString();
            CNCategoria CNCategoria = new CNCategoria();
            DataTable dt = new DataTable(); //creamos un nuevo DataTable
            dt = CNCategoria.ObtenerCategoriaConFiltro(1, vparametro); //Llenamos el DataTable
                                                                       //Recorremos cada fila del DataTable asignando a los controles de edición los valores de
                                                                       //los campos correspondientes
            foreach (DataRow row in dt.Rows)
            {
                tbIdCategoria.Text = row["IdCategoria"].ToString();
                tbCategoria.Text = row["Categoria"].ToString();
                cbEstado.Text = row["Estado"].ToString();
            }
        } //Fin del metodo RecuperarDatos

        private void DGVDatos_CurrentCellChanged(object sender, EventArgs e)
        {
            if (DGVDatos.CurrentRow != null) //Si el DataGridView no está vacío
                indice = DGVDatos.CurrentRow.Index; //El valor de índice será la fila actual
        }

        private void DGVDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbIdCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DGVDatos.Rows.Count > 1) //Si no estamos al inicio del DataGridView, vamos al inicio
            {
                indice = 0;
                DGVDatos.CurrentCell = DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) //Si no estamos al final del DataGridView
            {
                indice = DGVDatos.Rows.Count - 1; //vamos a la última fila del DataGridView
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (indice < this.DGVDatos.RowCount - 1) //Si no estamos al final del DataGridView, avanzamos 1 fila
            {
                indice++;
                DGVDatos.CurrentCell =
               DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (indice > 0) //Si no estamos al inicio del DataGridView, retrocedemos 1 fila
            {
                indice = indice - 1;
                DGVDatos.CurrentCell =
                DGVDatos.Rows[indice].Cells[DGVDatos.CurrentCell.ColumnIndex];
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            MostrarDatos();
            DGVDatos.Refresh();
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Llamada al formulario para buscar los datos de la tabla correspondiente. Lo pondremos
            //en comentario hasta que creemos dicho formulario.
            //FBuscarDepartamento fBuscarDepto = new FBuscarDepartamento();
            //fBuscarDepto.ShowDialog();
            if (Program.Modificar)
            {
                RecuperaDatos(); //Llamo al método para recuperar el Depto seleccionado
                BEditar_Click(sender, e); //Llamo al método editar
            }
            else

                LimpiaObjetos(); //Llama al método LimpiaObjetos
        
        }

        private void tbIdCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }

        //Fin del método Click del botón Buscar



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        
        
        private void Categorias_Load(object sender, EventArgs e)
        {
            Program.Nuevo = false; //Valores de las variables globales nuevo y modificar
            Program.Modificar = false;
            HabilitaBotones(); //Se habilitarán los objetos y los botones necesarios.
            valorparametro = "";
             vtieneparametro = 0;
             Program.vIdCategoria = 0; //variable global que tomará el valor seleccionado
             MostrarDatos(); //Llamo al Método que llena el DataGrid
             tbBuscar.Focus();
            

            
            
     
            }
            
        }

        
    }

