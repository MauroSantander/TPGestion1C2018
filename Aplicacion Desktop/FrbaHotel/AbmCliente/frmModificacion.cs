using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace FrbaHotel.AbmCliente
{
    public partial class frmModificacion : Form
    {
        public frmModificacion()
        {
            InitializeComponent();
        }

        private void frmModificacion_Load(object sender, EventArgs e)
        {
            //centra el formulario
            this.CenterToScreen();

            cmbTipoId.SelectedItem = "Vacío";

            dataGridViewModificarCliente.DataSource = cargarClientes();
        }

        public void recargarClientes()
        {
            dataGridViewModificarCliente.DataSource = cargarClientes();
        }


        //los siguientes KeyPress limitan la posibilidad de los usuarios de ingresar caracteres incorrectos en los
        //campos que los referencien
        private void soloTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo sólo acepta letras", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void soloNros_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo sólo acepta números", "Error", MessageBoxButtons.OK);
                }
            }
        }

        //valida que el mail ingresado tenga estructura correcta de email
        static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void btnLimpiarModif_Click(object sender, EventArgs e)
        {
            //limpiar los textBox y setea el comboBox de tipoId en "Vacío"
            txtNombre.ResetText();
            txtApellido.ResetText();
            cmbTipoId.SelectedItem = "Vacío";
            txtNroId.ResetText();
            txtMail.ResetText();
        }


        //realiza la consulta sql con los parámetros indicados tomando los valores de los filtros
        public DataTable cargarClientes() {

            //en las siguientes variables guardaremos los valores de los filtros pero con un formato apto
            //para ser llevado a consulta sql
            string cadenaNombre = "";
            string cadenaApellido = "";
            string cadenaTipoId = "";
            string cadenaNroIdentificacion = "";
            string cadenaMail = "";

            string query = "SELECT * FROM [PISOS_PICADOS].mostrarClientes () WHERE 1=1 ";

            if (txtNombre.Text != "")
            {
                cadenaNombre = "AND Nombre LIKE '%" + txtNombre.Text + "%'";
            }
            if (txtApellido.Text != "")
            {
                cadenaApellido = "AND Apellido LIKE '%" + txtApellido.Text + "%'";
            }
            if (txtMail.Text != "")
            {
                cadenaMail = "AND Mail LIKE '%" + txtMail.Text + "%'";
            }
            if (cmbTipoId.SelectedItem != "Vacío")
            {
                cadenaTipoId = "AND [Tipo de Identificacion] = '" + cmbTipoId.Text + "'";
            }
            if (txtNroId.Text != "")
            {
                cadenaNroIdentificacion = "AND [Numero de Identificacion] = " + txtNroId.Text;
            }

            query = query + cadenaNombre + cadenaApellido + cadenaMail + cadenaTipoId + cadenaNroIdentificacion;

            //obtenemos un DataTable con los clientes solicitados
            DataTable dataTableCM = new DataTable();
            SqlCommand cmdMostrarClientes = new SqlCommand(query, Globals.conexionGlobal);
            SqlDataReader reader = cmdMostrarClientes.ExecuteReader();
            dataTableCM.Load(reader);
            reader.Close();
            return dataTableCM;
        }


        //toma los valores de la consulta sql realizada en cargarClientes() y los carga en el dataGrid para mostrarlo
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewModificarCliente.DataSource = null;
            dataGridViewModificarCliente.Columns.Clear();
            dataGridViewModificarCliente.DataSource = cargarClientes();
        }

        //cierra el formulario
        private void btnCancelarModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //esta funcion entra en acción cuando ya encontramos al cliente a modificar y nos permite seleccionarlo
            //en el DataGridView y conocer sus valores que aparecerán por defecto en un formulario especial para la 
            //modificacion de un cliente

            String nombreClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["Nombre"].Value;
            String apellidoClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["Apellido"].Value;
            String tipoIdClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["Tipo de identificacion"].Value;
            int nroIdClienteFila = (int)dataGridViewModificarCliente.CurrentRow.Cells["Numero de identificacion"].Value; //modificado a string para poder usar el contenido
            String mailClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["Mail"].Value;
            //una vez obtenido lo necesario para el form de modificación, lo construyo
            frmModificacionCliente modificacion = new frmModificacionCliente(nombreClienteFila, apellidoClienteFila, nroIdClienteFila, mailClienteFila,this);

            /////////****** antes de seguir obtengo id de usuario para relacionarlo con su nacionalidad que está en la tabla cliente******///////// 
            //busco el id del cliente porque lo necesitaré al buscar su nacionalidad, la cual está en la tabla Cliente 
            string a = "SELECT [PISOS_PICADOS].obtenerIDUsuario (@nombre, @apellido, @numeroIdentificacion)";

            SqlCommand getId = new SqlCommand(a, Globals.conexionGlobal);

            getId.Parameters.Add("@nombre", SqlDbType.VarChar);
            getId.Parameters["@nombre"].Value = nombreClienteFila;

            getId.Parameters.Add("@apellido", SqlDbType.VarChar);
            getId.Parameters["@apellido"].Value = apellidoClienteFila;

            getId.Parameters.Add("@numeroIdentificacion", SqlDbType.Int);
            getId.Parameters["@numeroIdentificacion"].Value = nroIdClienteFila;


            int idUsuario = (int)getId.ExecuteScalar(); //este es el id del cliente que buscabamos


            //usamos el id del cliente obtenido como parametro de la funcion de usuario hecha en sql llamada
            // obtenerNacionalidadCliente, la cual nos permite buscar nacionalidad a partir de un id de cliente
            string b = "SELECT [PISOS_PICADOS].obtenerNacionalidadCliente (@idCliente)";

            SqlCommand getNacionalidad = new SqlCommand(b, Globals.conexionGlobal);

            getNacionalidad.Parameters.Add("@idCliente", SqlDbType.Int);
            getNacionalidad.Parameters["@idCliente"].Value = idUsuario;

            String nacionalidadCliente = (String)getNacionalidad.ExecuteScalar(); //aqui es donde obtenemos la
            //nacionalidad buscada

            String TelefonoClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["Telefono"].FormattedValue.ToString()))
            {
                TelefonoClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["Telefono"].Value;
                modificacion.txtTelefono.Text = TelefonoClienteFila;
            }

            String calleClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["Calle"].Value;

            int NroCalleClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["Numero de calle"].FormattedValue.ToString()))
            {
                NroCalleClienteFila = Convert.ToInt32(dataGridViewModificarCliente.CurrentRow.Cells["Numero de calle"].Value);
                modificacion.txtNroCalle.Text = NroCalleClienteFila.ToString();
            }

            String LocalidadClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["Localidad"].FormattedValue.ToString()))
            {
                LocalidadClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["Localidad"].Value;
                modificacion.txtLocalidad.Text = LocalidadClienteFila;
            }

            String nombrePais = (string)dataGridViewModificarCliente.CurrentRow.Cells["Pais"].Value;

            String nacionalidadClienteFila = nacionalidadCliente;
            DateTime FechaNacimientoClienteFila = (DateTime)dataGridViewModificarCliente.CurrentRow.Cells["Fecha de nacimiento"].Value;
            
            //el form de  modificacion se abrira con los valores del usuario cargados
            modificacion.txtNombre.Text = nombreClienteFila;
            modificacion.txtApellido.Text = apellidoClienteFila;
            modificacion.cbTipoId.Text = tipoIdClienteFila;
            modificacion.txtNroId.Text = nroIdClienteFila.ToString();
            modificacion.txtMail.Text = mailClienteFila;
            modificacion.cbPaises.Text = nombrePais;
            modificacion.txtCalle.Text = calleClienteFila;
            modificacion.txtNacionalidad.Text = nacionalidadClienteFila;
            modificacion.dtpFechaNacimiento.Value = FechaNacimientoClienteFila;

            modificacion.Show();
        }
    }


}
