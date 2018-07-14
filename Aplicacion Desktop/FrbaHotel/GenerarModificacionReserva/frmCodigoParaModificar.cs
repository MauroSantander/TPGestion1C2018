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
    public partial class frmCodigoParaModificar : Form
    {
        public frmCodigoParaModificar()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigoReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(txtCodigoReserva, sender, e);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Verifico que la reserva exista y esté activa con la siguiente función:
            SqlCommand verificacionReserva = new SqlCommand("SELECT [PISOS_PICADOS].ObtenerEstadoReserva(@codigoReserva, @fechaActual)", Globals.conexionGlobal);
            //Agrego parámetros a la función
            verificacionReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            verificacionReserva.Parameters.Add("@fechaActual", SqlDbType.Date);
            //Doy valores a los parámetors
            verificacionReserva.Parameters["@codigoReserva"].Value = Int64.Parse(txtCodigoReserva.Text);
            verificacionReserva.Parameters["@fechaActual"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
            //Recibo resultado
            int estadoReserva = (int)verificacionReserva.ExecuteScalar();

            //Según el resultado, respondo
            if (estadoReserva == 0)
            {
                MessageBox.Show("La reserva no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (estadoReserva == 2)
            {
                MessageBox.Show("La reserva está cancelada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (estadoReserva == 3)
            {
                MessageBox.Show("La reserva ya se efectivizó.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (estadoReserva == 4)
            {
                MessageBox.Show("Las reservas solo pueden modificarse hasta un día antes del comienzo de la misma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            (new FrbaHotel.GenerarModificacionReserva.frmModificarReserva(txtCodigoReserva.Text)).ShowDialog();
            this.Close();
        }

        private void frmCodigoParaModificar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
