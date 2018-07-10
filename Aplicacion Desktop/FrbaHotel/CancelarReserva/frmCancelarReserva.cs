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

namespace FrbaHotel.CancelarReserva
{
    public partial class frmCancelarReserva : Form
    {
        public frmCancelarReserva()
        {
            InitializeComponent();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox solo acepta números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Verifico que la reserva exista y esté activa con la siguiente función:
            SqlCommand verificacionReserva = new SqlCommand("SELECT [PISOS_PICADOS].ObtenerEstadoReserva(@codigoReserva, @fechaActual)");
            //Agrego parámetros a la función
            verificacionReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            verificacionReserva.Parameters.Add("@fechaActual", SqlDbType.Date);
            //Doy valores a los parámetors
            verificacionReserva.Parameters["@codigoReserva"].Value = Int32.Parse(txtCodigo.Text);
            verificacionReserva.Parameters["@fechaActual"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
            //Recibo resultado
            int estadoReserva = (int)verificacionReserva.ExecuteScalar(); 

            //Según el resultado, respondo
            if (estadoReserva == 0) 
            {
                MessageBox.Show("La reserva no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (estadoReserva == 1)
            {
                string query = "[PISOS_PICADOS].cancelarReserva";
                SqlCommand cmd = new SqlCommand(query, Globals.conexionGlobal);
                cmd.CommandType = CommandType.StoredProcedure;
                //Agrego parámetros al SP
                cmd.Parameters.Add("@codigoReserva", SqlDbType.Int);
                cmd.Parameters.Add("@motivo", SqlDbType.VarChar);
                cmd.Parameters.Add("@fecha", SqlDbType.Date);
                cmd.Parameters.Add("@idUsuario", SqlDbType.Int);
                //Doy valor a los parámetros
                cmd.Parameters["@codigoReserva"].Value = Int32.Parse(txtCodigo.Text);
                cmd.Parameters["@motivo"].Value = txtMotivo.Text;
                cmd.Parameters["@fecha"].Value = Globals.FechaDelSistema;
                cmd.Parameters["@idUsuario"].Value = Globals.idUsuarioSesion.ToString("yyyy-MM-dd");
                //Ejecuto SP para cancelar reservas
                cmd.ExecuteNonQuery();
                MessageBox.Show("Reserva cancelada con éxito");
                return;
            }
            else if (estadoReserva == 2)
            {
                MessageBox.Show("La reserva ya está cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (estadoReserva == 3)
            {
                MessageBox.Show("La reserva ya se efectivizó.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (estadoReserva == 4)
            {
                MessageBox.Show("No puede cancelar la reserva el mismo día.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
