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
            Utils.txtSoloAceptaNumeros(txtCodigo, sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //chequeos

            int verificacion = 1;

            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Debe insertar un código de reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }
            if (txtMotivo.Text == "")
            {
                MessageBox.Show("Debe insertar un motivo de cancelación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //verifico si el usuario tiene permiso para tocar esta estadía
            SqlCommand cmdBuscarHotelDeEstadia = new SqlCommand("SELECT [PISOS_PICADOS].hotelDeReserva (@codigoReserva)", Globals.conexionGlobal);
            cmdBuscarHotelDeEstadia.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdBuscarHotelDeEstadia.Parameters["@codigoReserva"].Value = Int64.Parse(txtCodigo.Text);
            int hotelDeLaEstadia;
            try
            {
                hotelDeLaEstadia = (int)cmdBuscarHotelDeEstadia.ExecuteScalar();
            }
            catch
            {
                //si rompe es porque no existe la estadia
                MessageBox.Show("No existe estadía que se corresponda a esa reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (hotelDeLaEstadia != Globals.idHotelUsuario)
            {
                MessageBox.Show("El código que ingresó pertenece a un hotel diferente del que seleccionó cuando inicio sesión. Si usted trabaja en dicho hotel, debe iniciar sesión escogiéndolo para completar esta operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //fin chequeos

            //Verifico que la reserva exista y esté activa con la siguiente función:
            SqlCommand verificacionReserva = new SqlCommand("SELECT [PISOS_PICADOS].ObtenerEstadoReserva(@codigoReserva, @fechaActual)", Globals.conexionGlobal);
            //Agrego parámetros a la función
            verificacionReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            verificacionReserva.Parameters.Add("@fechaActual", SqlDbType.Date);
            //Doy valores a los parámetors
            verificacionReserva.Parameters["@codigoReserva"].Value = Int64.Parse(txtCodigo.Text);
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
                cmd.Parameters["@codigoReserva"].Value = Int64.Parse(txtCodigo.Text);
                cmd.Parameters["@motivo"].Value = txtMotivo.Text;
                cmd.Parameters["@fecha"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
                cmd.Parameters["@idUsuario"].Value = Globals.idUsuarioSesion;
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
                MessageBox.Show("Las reservas solo pueden cancelarse hasta un día antes del comienzo de la misma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void frmCancelarReserva_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
