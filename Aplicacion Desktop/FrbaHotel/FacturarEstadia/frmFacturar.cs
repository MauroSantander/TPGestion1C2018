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

namespace FrbaHotel.FacturarEstadia
{
    public partial class frmFacturar : Form
    {

        long codigoReserva = -1;
        public frmFacturar()
        {
            InitializeComponent();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            labelTotal.Text = "$0";
            labelDescuento.Text = "-$0";
            labelRegimen.Text = "";
            label.Text = "";
            this.CenterToScreen();

            //cargo formas de pago
            SqlCommand cmdFormasDePago = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].TipoDePago", Globals.conexionGlobal);

            SqlDataReader reader = cmdFormasDePago.ExecuteReader();

            while (reader.Read())
            {
                comboBoxFormaDePago.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();

            comboBoxFormaDePago.SelectedIndex = 0;
            return;

        }

        private void textBoxNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(textBoxNumeroTarjeta, sender, e);
        }

        private void comboBoxFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si elige efectivo no muestro textbox de número de tarjeta
            if (comboBoxFormaDePago.SelectedIndex == 0)
            {
                textBoxNumeroTarjeta.Visible = false;
            }
            else
            {
                textBoxNumeroTarjeta.Visible = true;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCodigoReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(textBoxCodigoReserva, sender, e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //chequeos

            int verificacion = 1;

            if (textBoxCodigoReserva.Text == "")
            {
                MessageBox.Show("Ingrese un código de reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //fin chequeos

            cargarDataGridHabitaciones();
            cargarDataGridConsumibles();

            SqlCommand cmdBuscarRegimenReserva = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Regimen as r JOIN [PISOS_PICADOS].Reserva as re on r.codigoRegimen = re.codigoRegimen and re.codigoReserva = @codigoReserva", Globals.conexionGlobal);
            cmdBuscarRegimenReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdBuscarRegimenReserva.Parameters["@codigoReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);

            labelRegimen.Text = cmdBuscarRegimenReserva.ExecuteScalar().ToString();
            label.Text = "Régimen de la estadía:";
            codigoReserva = Int64.Parse(textBoxCodigoReserva.Text);

            labelTotalHabitaciones.Text = "$" + calcularTotalHabitaciones();
            labelTotalConsumibles.Text = "$" + netearConsumibles();

            //si tiene régimen all inclusive le resto los consumibles porque estaban incluidos
            if (labelRegimen.Text == "All inclusive")
            {
                labelDescuento.Text = "-$" + netearConsumibles();
                labelTotal.Text = "$" + calcularTotalHabitaciones();
            }
            else
            {
                labelDescuento.Text = "-$0";
                labelTotal.Text = "$" + calcularTotal();
            }


            SqlCommand diasAlojados = new SqlCommand("SELECT [PISOS_PICADOS].diasQueSeAlojo (@codigoReserva)", Globals.conexionGlobal);
            diasAlojados.Parameters.Add("@codigoReserva", SqlDbType.Int);
            diasAlojados.Parameters["@codigoReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);

            labelAlojados.Text = diasAlojados.ExecuteScalar().ToString();

            SqlCommand diasReservados = new SqlCommand("SELECT [PISOS_PICADOS].diasQueReservo (@codigoReserva)", Globals.conexionGlobal);
            diasReservados.Parameters.Add("@codigoReserva", SqlDbType.Int);
            diasReservados.Parameters["@codigoReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);

            labelReservados.Text = diasReservados.ExecuteScalar().ToString();

        }

        private string calcularTotalHabitaciones()
        {
            float total = 0;

            for (int i = 0; i < dgvHabitaciones.Rows.Count; i++) 
            {
                total += (int)dgvHabitaciones.Rows[i].Cells["Precio"].Value;
            }

            return total.ToString();
        }

        private string calcularTotal()
        {
            //Total es total de consumibles + total de habitaciones
            //cargo en variables asi no llamo múltiples veces al método de gusto
            string _netearConsumibles = netearConsumibles();
            string _calcularTotalHabitaciones = calcularTotalHabitaciones();

            return (float.Parse(_netearConsumibles) + float.Parse(_calcularTotalHabitaciones)).ToString();
        }

        private string netearConsumibles()
        {
            float total = 0;
            SqlCommand cmdNetearConsumibles = new SqlCommand("SELECT [PISOS_PICADOS].netearConsumibles (@codigoReserva)", Globals.conexionGlobal);
            cmdNetearConsumibles.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdNetearConsumibles.Parameters["@codigoReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);
            total += float.Parse(cmdNetearConsumibles.ExecuteScalar().ToString());
            return total.ToString();
        }

        private void cargarDataGridHabitaciones()
        {
            //traigo información de la reserva y lleno datagrid
            SqlCommand cmdBuscarHabitacionesReserva = new SqlCommand("SELECT * FROM [PISOS_PICADOS].mostrarHabitaciones (@codigoReserva)", Globals.conexionGlobal);
            cmdBuscarHabitacionesReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdBuscarHabitacionesReserva.Parameters["@codigoReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);
            SqlDataReader reader;
            try
            {
                reader = cmdBuscarHabitacionesReserva.ExecuteReader();
            }
            catch
            {
                //si rompe es porque la reserva no existe
                MessageBox.Show("La reserva no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dtHabitaciones = new DataTable();
            dtHabitaciones.Load(reader);
            dgvHabitaciones.DataSource = dtHabitaciones;
            reader.Close();
        }

        private void cargarDataGridConsumibles() 
        {
            //traigo información de la reserva y lleno datagrid
            SqlCommand cmdBuscarConsumuiblesReserva = new SqlCommand("SELECT * FROM [PISOS_PICADOS].mostrarConsumibles (@codigoReserva)", Globals.conexionGlobal);
            cmdBuscarConsumuiblesReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdBuscarConsumuiblesReserva.Parameters["@codigoReserva"].Value = Int64.Parse(textBoxCodigoReserva.Text);
            SqlDataReader reader;
            try
            {
                reader = cmdBuscarConsumuiblesReserva.ExecuteReader();
            }
            catch
            {
                //si rompe es porque la reserva no existe
                MessageBox.Show("La reserva no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataTable dtConsumibles = new DataTable();
            dtConsumibles.Load(reader);
            dgvConsumibles.DataSource = dtConsumibles;
            reader.Close();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            //chequeos
            int verificacion = 1;

            if (codigoReserva == -1)
            {
                MessageBox.Show("Primero debe buscar una reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (comboBoxFormaDePago.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un medio de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (textBoxNumeroTarjeta.Text == "" && textBoxNumeroTarjeta.Visible)
            {
                MessageBox.Show("Ingrese un número de tarjeta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //verifico si el usuario tiene permiso para tocar esta estadía
            SqlCommand cmdBuscarHotelDeEstadia = new SqlCommand("SELECT [PISOS_PICADOS].hotelDeReserva (@codigoReserva)", Globals.conexionGlobal);
            cmdBuscarHotelDeEstadia.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdBuscarHotelDeEstadia.Parameters["@codigoReserva"].Value = codigoReserva;
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

            //chequeo si ya se facturó
            SqlCommand cmdChequearSiYaSeFacturo = new SqlCommand("SELECT [PISOS_PICADOS].yaSeFacturo (@codigoReserva)", Globals.conexionGlobal);
            //agrego parámetro
            cmdChequearSiYaSeFacturo.Parameters.Add("@codigoReserva", SqlDbType.Int);
            //doy valor a parámetro
            cmdChequearSiYaSeFacturo.Parameters["@codigoReserva"].Value = codigoReserva;
            //ejecuto y recibo resultado
            int yaSeFacturo = (int)cmdChequearSiYaSeFacturo.ExecuteScalar();

            if (yaSeFacturo == 1)
            {
                MessageBox.Show("Ya se facturó esa reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            //fin chequeos

            SqlCommand cmdFacturar = new SqlCommand("[PISOS_PICADOS].FacturarReserva", Globals.conexionGlobal);
            //agrego parámetros
            cmdFacturar.CommandType = CommandType.StoredProcedure;
            cmdFacturar.Parameters.Add("@codReserva", SqlDbType.Int);
            cmdFacturar.Parameters.Add("@fecha", SqlDbType.Date);
            cmdFacturar.Parameters.Add("@formaDePago", SqlDbType.VarChar);
            cmdFacturar.Parameters.Add("@numeroTarjeta", SqlDbType.BigInt);
            //doy valor a parámetros
            cmdFacturar.Parameters["@codReserva"].Value = codigoReserva;
            cmdFacturar.Parameters["@fecha"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
            cmdFacturar.Parameters["@formaDePago"].Value = comboBoxFormaDePago.Text;
            if (comboBoxFormaDePago.SelectedIndex == 0)
            {
                cmdFacturar.Parameters["@numeroTarjeta"].Value = DBNull.Value;
            }
            else
            {
                cmdFacturar.Parameters["@numeroTarjeta"].Value = Int64.Parse(textBoxNumeroTarjeta.Text);
            }

            try
            {
                cmdFacturar.ExecuteNonQuery();
                MessageBox.Show("Facturación realizada correctamente.");
            }
            catch
            {
                MessageBox.Show("Error al facturar. Compruebe los datos e intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
