using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class frmSeleccionarCliente : Form
    {
        frmGenerarReserva generarReservaInstancia;
        frmModificarReserva modificarReservaInstancia;

        public frmSeleccionarCliente(frmGenerarReserva instanciaPadre)
        {
            InitializeComponent();
            generarReservaInstancia = instanciaPadre;
        }

        public frmSeleccionarCliente(frmModificarReserva instanciaPadre)
        {
            InitializeComponent();
            modificarReservaInstancia = instanciaPadre;
        }

        private void frmSeleccionarCliente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cmbTipoId.SelectedItem = "Vacío";
            dataGridViewModificarCliente.DataSource = cargarClientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridViewModificarCliente.DataSource = null;
            dataGridViewModificarCliente.Columns.Clear();
            dataGridViewModificarCliente.DataSource = cargarClientes();
        }

        private void btnLimpiarModif_Click(object sender, EventArgs e)
        {
            txtNombre.ResetText();
            txtApellido.ResetText();
            cmbTipoId.SelectedItem = "Vacío";
            txtNroId.ResetText();
            txtMail.ResetText();
        }

        private void btnCancelarModif_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idCliente = (int)dataGridViewModificarCliente.CurrentRow.Cells["idUsuario"].Value;
            generarReservaInstancia.setCliente(idCliente);
            generarReservaInstancia.volver(this);
        }
    }
}
