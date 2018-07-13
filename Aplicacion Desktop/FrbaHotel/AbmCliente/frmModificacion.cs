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

            cmbTipoIdModif.SelectedItem = "Vacío";

            cargarClientes();

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
            txtNombreModif.ResetText();
            txtApellidoModif.ResetText();
            cmbTipoIdModif.SelectedItem = "Vacío";
            txtNroIdModif.ResetText();
            txtMailModif.ResetText();
        }


        //realiza la consulta sql con los parámetros indicados tomando los valores de los filtros
        public DataTable cargarClientes() {

            //en las siguientes variables guardaremos los valores de los filtros pero con un formato apto
            //para ser llevado a consulta sql
            string cadenaNombre;
            string cadenaApellido;
            string cadenaTipoId;
            string cadenaNroIdentificacion;
            string cadenaMail;

            if (txtNombreModif.Text == "") { cadenaNombre = "nombre LIKE '%'"; }
            else { cadenaNombre = "nombre LIKE '" + txtNombreModif.Text + "'"; };

            if (txtApellidoModif.Text == "") { cadenaApellido = "apellido LIKE '%'"; }
            else { cadenaApellido = "apellido LIKE '" + txtApellidoModif.Text + "'"; };

            if (cmbTipoIdModif.SelectedItem.ToString() == "Vacío") { cadenaTipoId = "tipoIdentificacion LIKE '%'"; }
            else { cadenaTipoId = "tipoIdentificacion LIKE '" + cmbTipoIdModif.SelectedItem.ToString() + "'"; };

            if (txtNroIdModif.Text == "") { cadenaNroIdentificacion = "numeroIdentificacion LIKE '%'"; }
            else { cadenaNroIdentificacion = "numeroIdentificacion LIKE '" + int.Parse(txtNroIdModif.Text) + "'"; };

            if (txtMailModif.Text == "") { cadenaMail = "mail LIKE '%'"; }
            else { cadenaMail = "mail LIKE '" + txtMailModif.Text + "'"; };

            if (txtMailModif.Text != "")
            {
                if (validarEmail(txtMailModif.Text))
                {
                    cadenaMail = "mail LIKE '" + txtMailModif.Text + "'";
                }
                else
                {
                    MessageBox.Show("La dirección de e-mail ingresada no es válida");
                    throw new Exception("Mail no válido");
                }
            }
            else { cadenaMail = "mail LIKE '%'"; };


            //este string es la consulta sql con todos los valores de los filtros de búsqueda
            String compuesto = " SELECT * FROM [PISOS_PICADOS].Usuario WHERE " + cadenaNombre
                + " AND " + cadenaApellido + " AND " + cadenaTipoId + " AND "
                + cadenaNroIdentificacion + " AND " + cadenaMail;

            //obtenemos un DataTable con los clientes solicitados
            DataTable dataTableCM = new DataTable();
            SqlCommand comandoClientesModificado = new SqlCommand(compuesto, Globals.conexionGlobal);
            SqlDataReader readerClienteModificado = comandoClientesModificado.ExecuteReader();
            dataTableCM.Load(readerClienteModificado);
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

            String nombreClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["nombre"].Value;
            String apellidoClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["apellido"].Value;
            String tipoIdClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["tipoIdentificacion"].Value;
            int nroIdClienteFila = (int)dataGridViewModificarCliente.CurrentRow.Cells["numeroIdentificacion"].Value; //modificado a string para poder usar el contenido
            String mailClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["mail"].Value;
            //una vez obtenido lo necesario para el form de modificación, lo construyo
            frmModificacionCliente modificacion = new frmModificacionCliente(nombreClienteFila, apellidoClienteFila, nroIdClienteFila, mailClienteFila);

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
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["telefono"].FormattedValue.ToString()))
            {
                TelefonoClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["telefono"].Value;
                modificacion.txtTelefono.Text = TelefonoClienteFila;
            }

            String calleClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["calle"].Value;

            int NroCalleClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["nroCalle"].FormattedValue.ToString()))
            {
                NroCalleClienteFila = Convert.ToInt32(dataGridViewModificarCliente.CurrentRow.Cells["nroCalle"].Value);
                modificacion.txtNroCalle.Text = NroCalleClienteFila.ToString();
            }

            String LocalidadClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["localidad"].FormattedValue.ToString()))
            {
                LocalidadClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["localidad"].Value;
                modificacion.txtLocalidad.Text = LocalidadClienteFila;
            }


            int nroPaisClienteFila = Convert.ToInt32(dataGridViewModificarCliente.CurrentRow.Cells["pais"].Value);

            String cadenaObtenerNombrePais = "SELECT [PISOS_PICADOS].obtenerNombrePais (@idPais)";

            SqlCommand cmdObtenerNombrePais = new SqlCommand(cadenaObtenerNombrePais, Globals.conexionGlobal);

            cmdObtenerNombrePais.Parameters.Add("@idPais", SqlDbType.Int);
            cmdObtenerNombrePais.Parameters["@idPais"].Value = nroPaisClienteFila;

            String nombrePais = (String)cmdObtenerNombrePais.ExecuteScalar();

            String nacionalidadClienteFila = nacionalidadCliente;
            DateTime FechaNacimientoClienteFila = (DateTime)dataGridViewModificarCliente.CurrentRow.Cells["fechaNacimiento"].Value;
            
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
