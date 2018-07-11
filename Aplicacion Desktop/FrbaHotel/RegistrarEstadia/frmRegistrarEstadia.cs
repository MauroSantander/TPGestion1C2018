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

namespace FrbaHotel.RegistrarEstadia
{
    public partial class frmRegistrarEstadia : Form
    {
        public frmRegistrarEstadia()
        {
            InitializeComponent();
        }

        private void frmRegistrarEstadia_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void textBoxCodigoReserva_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnIn_Click(object sender, EventArgs e)
        {
            //chequeos
            int verificacion = 1;

            if (textBoxCodigoReserva.Text == "")
            {
                MessageBox.Show("Ingrese el código de la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //chequeo que check-in ya no se haya realizado
            SqlCommand cmdCheckInYaRealizado = new SqlCommand("SELECT [PISOS_PICADOS].checkInYaRealizado(@codigoReserva)", Globals.conexionGlobal);
            cmdCheckInYaRealizado.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdCheckInYaRealizado.Parameters["@codigoReserva"].Value = textBoxCodigoReserva.Text;
            //ejecuto y recibo resultado
            int yaSeRealizoCheckIn = (int)cmdCheckInYaRealizado.ExecuteScalar();

            if (yaSeRealizoCheckIn == 1)
            {
                MessageBox.Show("El check-in ya fue realizado sobre esta reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //chequeo estado de la reserva
            SqlCommand cmdEstadoReserva = new SqlCommand("SELECT [PISOS_PICADOS].obtenerEstadoReserva(@codigoReserva, @fecha)", Globals.conexionGlobal);
            cmdEstadoReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdEstadoReserva.Parameters["@codigoReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);
            cmdEstadoReserva.Parameters.Add("@fecha", SqlDbType.Date);
            cmdEstadoReserva.Parameters["@fecha"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
            //ejecuto y recibo estado de la reserva
            int estadoReserva = (int)cmdEstadoReserva.ExecuteScalar();
            //reserva ya efectivizada
            if (estadoReserva == 3)
            {
                MessageBox.Show("La reserva ya fue efectivizada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //reservas canceladas
            if (estadoReserva == 2)
            {
                MessageBox.Show("La reserva se encuentra cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //reservas inexistentes
            if (estadoReserva == 0)
            {
                MessageBox.Show("La reserva no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //reservas no efectivizadas
            if (estadoReserva == 4)
            {
                MessageBox.Show("No puede realizar el check-in porque el primer día de la reserva ya pasó y esta fué cancelada. Debe realizar una reserva nueva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            //chequeo si es el dia de comienzo de la reserva
            SqlCommand cmdDiaInicio = new SqlCommand("SELECT [PISOS_PICADOS].esElDiaDeInicio(@fecha, @codReserva)", Globals.conexionGlobal);
            cmdDiaInicio.Parameters.Add("@fecha", SqlDbType.Date);
            cmdDiaInicio.Parameters["@fecha"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
            cmdDiaInicio.Parameters.Add("@codReserva", SqlDbType.Int);
            cmdDiaInicio.Parameters["@codReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);
            //recibo resultado
            int diaInicio;
            try
            {
                diaInicio = (int)cmdDiaInicio.ExecuteScalar();
            }
            catch
            {
                //si rompe es porque el código de reserva no existe
                MessageBox.Show("Código de reserva inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (diaInicio == 0) 
            {
                MessageBox.Show("No puede realizar el check-in porque aún falta para el primer día de la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (diaInicio == 2)
            {
                MessageBox.Show("No puede realizar el check-in porque el primer día de la reserva ya pasó y esta fué cancelada. Debe realizar una reserva nueva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                string query = "[PISOS_PICADOS].EliminarReservasNoEfectivizada";
                SqlCommand cmd = new SqlCommand(query, Globals.conexionGlobal);
                cmd.CommandType = CommandType.StoredProcedure;
                //Agrego parámetros al SP
                cmd.Parameters.Add("@fechaActual", SqlDbType.Date);
                //Doy valor a los parámetros
                cmd.Parameters["@fechaActual"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
                //Ejecuto SP para cancelar reservas
                cmd.ExecuteNonQuery();                
                return;
            }

            //fin chequeos

            //Es el dia de comienzo de la reserva, asi que se acepta el check-in
            if (diaInicio == 1 && estadoReserva == 1)
            {
                //creo estadía
                string queryEstadia = "[PISOS_PICADOS].registrarEstadia";
                SqlCommand cmdRegistrarEstadia = new SqlCommand(queryEstadia, Globals.conexionGlobal);
                cmdRegistrarEstadia.CommandType = CommandType.StoredProcedure;
                //agrego parámetros
                cmdRegistrarEstadia.Parameters.Add("@codReserva", SqlDbType.Int);
                //doy valor a parámetros
                cmdRegistrarEstadia.Parameters["@codReserva"].Value = textBoxCodigoReserva.Text;
                //ejecuto SP
                try
                {
                    cmdRegistrarEstadia.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Error al registrar la estadia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //registro el check-in
                string queryCheckIn = "[PISOS_PICADOS].registrarCheckIn";
                SqlCommand cmdCheckIn = new SqlCommand(queryCheckIn, Globals.conexionGlobal);
                cmdCheckIn.CommandType = CommandType.StoredProcedure;
                //agrego parámetros
                cmdCheckIn.Parameters.Add("@fechaIngreso", SqlDbType.Date);
                cmdCheckIn.Parameters.Add("@idEncargado", SqlDbType.Int);
                cmdCheckIn.Parameters.Add("@codReserva", SqlDbType.Int);
                //doy valor a parámetros
                cmdCheckIn.Parameters["@fechaIngreso"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd"); ;
                cmdCheckIn.Parameters["@idEncargado"].Value = Globals.idUsuarioSesion;
                cmdCheckIn.Parameters["@codReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);
                //ejecuto SP
                try
                {
                    cmdCheckIn.ExecuteNonQuery();
                    MessageBox.Show("Check-in realizado correctamente.");
                    return;
                }
                catch
                {
                    MessageBox.Show("Error al registrar el check-in.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //chequeos
            int verificacion = 1;

            if (textBoxCodigoReserva.Text == "")
            {
                MessageBox.Show("Ingrese el código de la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //chequeo estado de la reserva
            SqlCommand cmdEstadoReserva = new SqlCommand("SELECT [PISOS_PICADOS].obtenerEstadoReserva(@codigoReserva, @fecha)", Globals.conexionGlobal);
            cmdEstadoReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdEstadoReserva.Parameters["@codigoReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);
            cmdEstadoReserva.Parameters.Add("@fecha", SqlDbType.Date);
            cmdEstadoReserva.Parameters["@fecha"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
            //ejecuto y recibo estado de la reserva
            int estadoReserva = (int)cmdEstadoReserva.ExecuteScalar();

            if (estadoReserva == 3)
            {
                MessageBox.Show("La reserva ya fue efectivizada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //reservas canceladas
            if (estadoReserva == 2 || estadoReserva == 4)
            {
                MessageBox.Show("La reserva se encuentra cancelada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //reservas inexistentes
            if (estadoReserva == 0)
            {
                MessageBox.Show("La reserva no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //verifico si se hizo check-in previamente
            SqlCommand cmdCheckInYaRealizado = new SqlCommand("SELECT [PISOS_PICADOS].checkInYaRealizado(@codigoReserva)", Globals.conexionGlobal);
            cmdCheckInYaRealizado.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdCheckInYaRealizado.Parameters["@codigoReserva"].Value = textBoxCodigoReserva.Text;
            //ejecuto y recibo resultado
            int yaSeRealizoCheckIn = (int)cmdCheckInYaRealizado.ExecuteScalar();

            if (yaSeRealizoCheckIn == 0)
            {
                MessageBox.Show("El check-in nunca fué realizado para esta reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //chequeo que check-out ya no se haya realizado
            SqlCommand cmdCheckOutYaRealizado = new SqlCommand("SELECT [PISOS_PICADOS].checkOutYaRealizado(@codigoReserva)", Globals.conexionGlobal);
            cmdCheckOutYaRealizado.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdCheckOutYaRealizado.Parameters["@codigoReserva"].Value = textBoxCodigoReserva.Text;
            //ejecuto y recibo resultado
            int yaSeRealizoCheckOut = (int)cmdCheckOutYaRealizado.ExecuteScalar();

            if (yaSeRealizoCheckOut == 1)
            {
                MessageBox.Show("El check-out ya fue realizado sobre esta reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //fin chequeos

            SqlCommand cmdCheckOut = new SqlCommand("[PISOS_PICADOS].registrarCheckOut", Globals.conexionGlobal);
            cmdCheckOut.CommandType = CommandType.StoredProcedure;
            //agrego parámetros
            cmdCheckOut.Parameters.Add("@fechaEgreso", SqlDbType.Date);
            cmdCheckOut.Parameters.Add("@idEncargado", SqlDbType.Int);
            cmdCheckOut.Parameters.Add("@codReserva", SqlDbType.Int);
            //doy valor a parámetros
            cmdCheckOut.Parameters["@fechaEgreso"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");;
            cmdCheckOut.Parameters["@idEncargado"].Value = Globals.idUsuarioSesion;
            cmdCheckOut.Parameters["@codReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);
            //ejecuto SP
            try
            {
                cmdCheckOut.ExecuteNonQuery();
                MessageBox.Show("Check-out realizado correctamente.");
                return;
            }
            catch
            {
                MessageBox.Show("Error al registrar el check-out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
