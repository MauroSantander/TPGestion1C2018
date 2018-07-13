using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace FrbaHotel.AbmCliente
{
    public partial class frmBaja : Form
    {
        Utils utilizador = new Utils();

        public frmBaja()
        {
            InitializeComponent();
        }

        private void frmBaja_Load(object sender, EventArgs e)
        {
            //centra el formulario
            this.CenterToScreen();

            cmbTipoId.SelectedItem = "Vacío";

            dataGridViewClientes.DataSource = cargarClientes();
        }

        public void recargarClientes()
        {
            dataGridViewClientes.DataSource = cargarClientes();
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

        //limpia los textBox del formulario y setea el comboBox de tipoId en "Vacío"
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            txtApellido.ResetText();
            cmbTipoId.SelectedItem = "Vacío";
            txtNroId.ResetText();
            txtMail.ResetText();
        }

        //realiza la consulta sql con los parámetros indicados tomando los valores de los filtros
        public DataTable cargarClientes()
        {

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

        //
        private void btnBuscar(object sender, EventArgs e)
        {
            //llena el dgv con el resultado de la búsqueda
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.Columns.Clear();
            dataGridViewClientes.DataSource = cargarClientes();
        }

        //
        private void BotonBaja_Click(object sender, EventArgs e)
        {
            //si no se selecciona fila, entonces el botón no realiza acción alguna
            if (dataGridViewClientes.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["Numero de identificacion"].Value);
            string nombre = (string)dataGridViewClientes.CurrentRow.Cells["Nombre"].Value;
            string apellido = (string)dataGridViewClientes.CurrentRow.Cells["Apellido"].Value;

            string a = "SELECT [PISOS_PICADOS].obtenerIDUsuario (@nombre, @apellido, @numeroIdentificacion)";

                SqlCommand getId = new SqlCommand(a, Globals.conexionGlobal);

                getId.Parameters.Add("@nombre", SqlDbType.VarChar);
                getId.Parameters["@nombre"].Value = nombre;

                getId.Parameters.Add("@apellido", SqlDbType.VarChar);
                getId.Parameters["@apellido"].Value = apellido;

                getId.Parameters.Add("@numeroIdentificacion", SqlDbType.Int);
                getId.Parameters["@numeroIdentificacion"].Value = id;


                int idUsuario = (int)getId.ExecuteScalar();

                string cadenaBajaUsuario = "[PISOS_PICADOS].bajaUsuario";

                SqlCommand comandoBajaUsuario = new SqlCommand(cadenaBajaUsuario, Globals.conexionGlobal);
                comandoBajaUsuario.CommandType = CommandType.StoredProcedure;
                comandoBajaUsuario.Parameters.Add("@idUsuario", SqlDbType.Int);
                comandoBajaUsuario.Parameters["@idUsuario"].Value = idUsuario;

                comandoBajaUsuario.ExecuteNonQuery();

                MessageBox.Show("Usuario dado de baja correctamente");
                recargarClientes();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
