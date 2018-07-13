using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class frmSeleccionarCliente : Form
    {
        public frmSeleccionarCliente()
        {
            InitializeComponent();
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
    }
}
