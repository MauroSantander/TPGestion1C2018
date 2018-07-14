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
    public partial class frmModificarReserva : Form
    {
        string codigoReserva;
        int idCliente;
        public void setCliente(int id)
        {
            idCliente = id;
        }

        public frmModificarReserva()
        {
            InitializeComponent();
        }

        public frmModificarReserva(string _codigoReserva)
        {
            InitializeComponent();
            codigoReserva = _codigoReserva;
        }

        private void frmModificarReserva_Load(object sender, EventArgs e)
        {

            dtpFinReserva.Value = Globals.FechaDelSistema;
            dtpInicioReserva.Value = Globals.FechaDelSistema;

            idCliente = Globals.idUsuarioSesion;
            labelCodigoReserva.Text = codigoReserva;
            this.CenterToScreen();

            //cargo hotel
            SqlCommand cargarHotelReserva = new SqlCommand("SELECT nombre FROM [PISOS_PICADOS].Hotel WHERE idHotel IN (SELECT [PISOS_PICADOS].hotelDeReserva (@codigoReserva))", Globals.conexionGlobal);
            cargarHotelReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cargarHotelReserva.Parameters["@codigoReserva"].Value = Int64.Parse(labelCodigoReserva.Text);
            //recibo nombre hotel
            try
            {
                string nombreHotel = cargarHotelReserva.ExecuteScalar().ToString();
                labelHotel.Text = nombreHotel;
                }
            catch
            {
                MessageBox.Show("Error al cargar el hotel de la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            //cargo régimen
            SqlCommand cargarRegimenReserva = new SqlCommand("SELECT [PISOS_PICADOS].consultarRegimen (@idReserva)", Globals.conexionGlobal);
            cargarRegimenReserva.Parameters.Add("@idReserva", SqlDbType.Int);
            cargarRegimenReserva.Parameters["@idReserva"].Value = Int64.Parse(labelCodigoReserva.Text);
            string regimen = (string)cargarRegimenReserva.ExecuteScalar();

            //cargo fechaInicio
            SqlCommand cargarFechaInicioReserva = new SqlCommand("SELECT fechaInicio FROM [PISOS_PICADOS].Reserva WHERE codigoReserva = @idReserva", Globals.conexionGlobal);
            cargarFechaInicioReserva.Parameters.Add("@idReserva", SqlDbType.Int);
            cargarFechaInicioReserva.Parameters["@idReserva"].Value = Int64.Parse(labelCodigoReserva.Text);
            string fechaInicio = cargarFechaInicioReserva.ExecuteScalar().ToString();
            dtpInicioReserva.Value = DateTime.Parse(fechaInicio);

            //cargo fechaFin
            SqlCommand cargarFechaFinReserva = new SqlCommand("SELECT fechaFin FROM [PISOS_PICADOS].Reserva WHERE codigoReserva = @idReserva", Globals.conexionGlobal);
            cargarFechaFinReserva.Parameters.Add("@idReserva", SqlDbType.Int);
            cargarFechaFinReserva.Parameters["@idReserva"].Value = Int64.Parse(labelCodigoReserva.Text);
            string fechaFin = cargarFechaFinReserva.ExecuteScalar().ToString();
            dtpFinReserva.Value = DateTime.Parse(fechaFin);
            
            //cargo cantidad de habitaciones
            SqlCommand cargarCantHabitacionesSimples = new SqlCommand("SELECT [PISOS_PICADOS].cantHabitacionesReserva (@codigoReserva, 1)", Globals.conexionGlobal);
            cargarCantHabitacionesSimples.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cargarCantHabitacionesSimples.Parameters["@codigoReserva"].Value = Int64.Parse(codigoReserva);
            numSimple.Value = (int)cargarCantHabitacionesSimples.ExecuteScalar();

            SqlCommand cargarCantHabitacionesDobles = new SqlCommand("SELECT [PISOS_PICADOS].cantHabitacionesReserva (@codigoReserva, 2)", Globals.conexionGlobal);
            cargarCantHabitacionesDobles.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cargarCantHabitacionesDobles.Parameters["@codigoReserva"].Value = Int64.Parse(codigoReserva);
            numDoble.Value = (int)cargarCantHabitacionesDobles.ExecuteScalar();

            SqlCommand cargarCantHabitacionesTriples = new SqlCommand("SELECT [PISOS_PICADOS].cantHabitacionesReserva (@codigoReserva, 3)", Globals.conexionGlobal);
            cargarCantHabitacionesTriples.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cargarCantHabitacionesTriples.Parameters["@codigoReserva"].Value = Int64.Parse(codigoReserva);
            numTriple.Value = (int)cargarCantHabitacionesTriples.ExecuteScalar();

            SqlCommand cargarCantHabitacionesCuadruples = new SqlCommand("SELECT [PISOS_PICADOS].cantHabitacionesReserva (@codigoReserva, 4)", Globals.conexionGlobal);
            cargarCantHabitacionesCuadruples.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cargarCantHabitacionesCuadruples.Parameters["@codigoReserva"].Value = Int64.Parse(codigoReserva);
            numCuadruple.Value = (int)cargarCantHabitacionesCuadruples.ExecuteScalar();

            SqlCommand cargarCantHabitacionesKing = new SqlCommand("SELECT [PISOS_PICADOS].cantHabitacionesReserva (@codigoReserva, 5)", Globals.conexionGlobal);
            cargarCantHabitacionesKing.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cargarCantHabitacionesKing.Parameters["@codigoReserva"].Value = Int64.Parse(codigoReserva);
            numKing.Value = (int)cargarCantHabitacionesKing.ExecuteScalar();

            //agrego item por si no sabe el régimen que quiere
            comboBoxRegimen.Items.Add("Vacío");

            //busco regímenes
            Utils.cargarRegimenes(comboBoxRegimen);
            comboBoxRegimen.SelectedItem = regimen;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numSimple.Value = 0;
            numDoble.Value = 0;
            numTriple.Value = 0;
            numCuadruple.Value = 0;
            numKing.Value = 0;
            dtpInicioReserva.ResetText();
            dtpFinReserva.ResetText();
            comboBoxRegimen.SelectedIndex = 0;
        }

        private void cargarPrecios()
        {
            int idHotel = 0;

            SqlCommand buscarIdHotel = new SqlCommand("SELECT idHotel FROM [PISOS_PICADOS].Hotel WHERE nombre = @nombreHotel", Globals.conexionGlobal);
            buscarIdHotel.Parameters.Add("@nombreHotel", SqlDbType.VarChar);
            buscarIdHotel.Parameters["@nombreHotel"].Value = labelHotel.Text;

            idHotel = (int)buscarIdHotel.ExecuteScalar();

            //si no eligió régimen traigo todos los precios. Si eligió, solo para ese régimen
            string query;
            if (comboBoxRegimen.Text == "Vacío")
            {
                query = "SELECT * FROM [PISOS_PICADOS].precioHabitacionesHotel (@idHotel)";
            }
            else
            {
                query = "SELECT * FROM [PISOS_PICADOS].precioHabitacionesHotel (@idHotel) WHERE [Tipo Regimen] = " + "'" + comboBoxRegimen.Text + "'";
            }

            SqlCommand preciosHotel = new SqlCommand(query, Globals.conexionGlobal);
            preciosHotel.Parameters.Add("@idHotel", SqlDbType.VarChar);
            preciosHotel.Parameters["@idHotel"].Value = idHotel;

            DataTable dtPrecios = new DataTable();
            SqlDataReader reader = preciosHotel.ExecuteReader();
            dtPrecios.Load(reader);
            reader.Close();
            dgvPrecios.DataSource = dtPrecios;
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPrecios();
        }

        private void comboBoxRegimen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarPrecios();
        }

        public void volver(frmSeleccionarCliente instanciaSeleccionarCliente)
        {

            //solo puede cancelar el usuario que la hizo, admins o recepcionistas

            if (Globals.rolUsuario == "Guest")
            {
                SqlCommand buscarClienteReserva = new SqlCommand("SELECT idCliente FROM [PISOS_PICADOS].Reserva WHERE codigoReserva = @codigo", Globals.conexionGlobal);
                buscarClienteReserva.Parameters.Add("@codigo", SqlDbType.Int);
                buscarClienteReserva.Parameters["@codigo"].Value = codigoReserva;
                int clienteDeReserva = (int)buscarClienteReserva.ExecuteScalar();
                if (idCliente != clienteDeReserva)
                {
                    MessageBox.Show("Solo administradores y recepcionistas logueados o el cliente que generó la reserva pueden cancelarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            instanciaSeleccionarCliente.Close();
            MessageBox.Show("Gracias por identificarse. Ya puede modificar la reserva.", "Reserva", MessageBoxButtons.OK);
            this.Show();
        }

        private void dtpInicioReserva_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFinReserva.Value < dtpInicioReserva.Value) dtpFinReserva.Value = dtpInicioReserva.Value;
            if (dtpInicioReserva.Value < Globals.FechaDelSistema) dtpInicioReserva.Value = Globals.FechaDelSistema;
        }

        private void dtpFinReserva_ValueChanged(object sender, EventArgs e)
        {
            if (dtpInicioReserva.Value > dtpFinReserva.Value) dtpInicioReserva.Value = dtpFinReserva.Value;
            if (dtpFinReserva.Value < Globals.FechaDelSistema) dtpFinReserva.Value = Globals.FechaDelSistema;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            {
                //chequeos
                int verificacion = 1;
                if (comboBoxRegimen.Text == "Vacío")
                {
                    MessageBox.Show("Debe elegir un régimen.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificacion = 0;
                }

                if (numSimple.Value == 0 && numDoble.Value == 0 && numTriple.Value == 0 && numCuadruple.Value == 0 && numKing.Value == 0)
                {
                    MessageBox.Show("Debe elegir por lo menos una habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificacion = 0;
                }

                if (txtMotivo.Text == "")
                {
                    MessageBox.Show("Debe indicar el motivo por el cual realiza esta modificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificacion = 0;
                }

                if (verificacion == 0)
                {
                    return;
                }

                if (Globals.rolUsuario != "Guest")
                {
                    //verifico si el usuario tiene permiso para tocar esta estadía
                    SqlCommand cmdBuscarHotelDeReserva = new SqlCommand("SELECT [PISOS_PICADOS].hotelDeReserva (@codigoReserva)", Globals.conexionGlobal);
                    cmdBuscarHotelDeReserva.Parameters.Add("@codigoReserva", SqlDbType.Int);
                    cmdBuscarHotelDeReserva.Parameters["@codigoReserva"].Value = codigoReserva;
                    int hotelDeLaReserva;
                    try
                    {
                        hotelDeLaReserva = (int)cmdBuscarHotelDeReserva.ExecuteScalar();
                    }
                    catch
                    {
                        //si rompe es porque no existe la estadia
                        MessageBox.Show("No existe estadía que se corresponda a esa reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (hotelDeLaReserva != Globals.idHotelUsuario)
                    {
                        MessageBox.Show("El código que ingresó pertenece a un hotel diferente del que seleccionó cuando inicio sesión. Si usted trabaja en dicho hotel, debe iniciar sesión escogiéndolo para completar esta operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                //fin chequeos

                if (idCliente == -1)
                {
                    DialogResult dialogResult = MessageBox.Show("Debe identificarse en el sistema para poder modificar una reserva. ¿Desea hacerlo?", "Estimado cliente", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        procesoInicioSesion();
                        return;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }

                //ejecuto función para ver si cumple lo demandado
                SqlCommand cmdPuedeModificarReserva = new SqlCommand("[PISOS_PICADOS].puedeModificarReserva", Globals.conexionGlobal);
                cmdPuedeModificarReserva.CommandType = CommandType.StoredProcedure;
                cmdPuedeModificarReserva.Parameters.Add("@fechaInicio", SqlDbType.Date);
                cmdPuedeModificarReserva.Parameters.Add("@fechaFin", SqlDbType.Date);
                cmdPuedeModificarReserva.Parameters.Add("@idReserva", SqlDbType.Int);
                cmdPuedeModificarReserva.Parameters.Add("@cantSimple", SqlDbType.Int);
                cmdPuedeModificarReserva.Parameters.Add("@cantDoble", SqlDbType.Int);
                cmdPuedeModificarReserva.Parameters.Add("@cantTriple", SqlDbType.Int);
                cmdPuedeModificarReserva.Parameters.Add("@cantCuadru", SqlDbType.Int);
                cmdPuedeModificarReserva.Parameters.Add("@cantKing", SqlDbType.Int);
                var retorno = cmdPuedeModificarReserva.Parameters.Add("@respuesta", SqlDbType.Int);
                retorno.Direction = ParameterDirection.ReturnValue;

                cmdPuedeModificarReserva.Parameters["@fechaInicio"].Value = dtpInicioReserva.Value.ToString("yyyy-MM-dd");
                cmdPuedeModificarReserva.Parameters["@fechaFin"].Value = dtpFinReserva.Value.ToString("yyyy-MM-dd");
                cmdPuedeModificarReserva.Parameters["@idReserva"].Value = Int64.Parse(labelCodigoReserva.Text);
                cmdPuedeModificarReserva.Parameters["@cantSimple"].Value = numSimple.Value;
                cmdPuedeModificarReserva.Parameters["@cantDoble"].Value = numDoble.Value;
                cmdPuedeModificarReserva.Parameters["@cantTriple"].Value = numTriple.Value;
                cmdPuedeModificarReserva.Parameters["@cantCuadru"].Value = numCuadruple.Value;
                cmdPuedeModificarReserva.Parameters["@cantKing"].Value = numKing.Value;
                
                //ejecuto y recibo resultado
                cmdPuedeModificarReserva.ExecuteNonQuery();
                int resultadoBusqueda = (int)retorno.Value;

                //según resultado aviso al usuario
                if (resultadoBusqueda == 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Existe disponibilidad para la modificación solicitada. ¿Desea concretarla?", "Disponibilidad", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //calculo cantidad huéspedes
                        int cantHuespedes = (int)numSimple.Value + (int)numDoble.Value * 2 + (int)numTriple.Value * 3 + (int)numCuadruple.Value * 4 + (int)numKing.Value * 5;
                        //efectúo la reserva
                        string spModificarReserva = "[PISOS_PICADOS].modificarReserva";
                        SqlCommand modificarReserva = new SqlCommand(spModificarReserva, Globals.conexionGlobal);
                        modificarReserva.CommandType = CommandType.StoredProcedure;

                        modificarReserva.Parameters.Add("@fechaActual", SqlDbType.Date);
                        modificarReserva.Parameters.Add("@fechaInicio", SqlDbType.Date);
                        modificarReserva.Parameters.Add("@fechaFin", SqlDbType.Date);
                        modificarReserva.Parameters.Add("@cantHuespedes", SqlDbType.Int);
                        modificarReserva.Parameters.Add("@nombreRegimen", SqlDbType.VarChar);
                        modificarReserva.Parameters.Add("@idReserva", SqlDbType.Int);
                        modificarReserva.Parameters.Add("@idAutor", SqlDbType.Int);
                        modificarReserva.Parameters.Add("@cantSimple", SqlDbType.Int);
                        modificarReserva.Parameters.Add("@cantDoble", SqlDbType.Int);
                        modificarReserva.Parameters.Add("@cantTriple", SqlDbType.Int);
                        modificarReserva.Parameters.Add("@cantCuadru", SqlDbType.Int);
                        modificarReserva.Parameters.Add("@cantKing", SqlDbType.Int);
                        modificarReserva.Parameters.Add("@motivo", SqlDbType.VarChar);

                        modificarReserva.Parameters["@fechaActual"].Value = Globals.FechaDelSistema;
                        modificarReserva.Parameters["@fechaInicio"].Value = dtpInicioReserva.Value.ToString("yyyy-MM-dd");
                        modificarReserva.Parameters["@fechaFin"].Value = dtpFinReserva.Value.ToString("yyyy-MM-dd");
                        modificarReserva.Parameters["@cantHuespedes"].Value = cantHuespedes;
                        modificarReserva.Parameters["@nombreRegimen"].Value = comboBoxRegimen.Text;
                        modificarReserva.Parameters["@idReserva"].Value = Int64.Parse(labelCodigoReserva.Text);
                        modificarReserva.Parameters["@idAutor"].Value = idCliente;
                        modificarReserva.Parameters["@cantSimple"].Value = numSimple.Value;
                        modificarReserva.Parameters["@cantDoble"].Value = numDoble.Value;
                        modificarReserva.Parameters["@cantTriple"].Value = numTriple.Value;
                        modificarReserva.Parameters["@cantCuadru"].Value = numCuadruple.Value;
                        modificarReserva.Parameters["@cantKing"].Value = numKing.Value;
                        modificarReserva.Parameters["@motivo"].Value = txtMotivo.Text;

                        try
                        {
                            modificarReserva.ExecuteNonQuery();
                            MessageBox.Show("Reserva modificada correctamente.", "Reserva", MessageBoxButtons.OK);
                        }
                        catch
                        {
                            MessageBox.Show("Error al modificar la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                else if (resultadoBusqueda == 1)
                {
                    MessageBox.Show("No hay disponibilidad de esa cantidad de habitaciones simples.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (resultadoBusqueda == 2)
                {
                    MessageBox.Show("No hay disponibilidad de esa cantidad de habitaciones dobles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (resultadoBusqueda == 3)
                {
                    MessageBox.Show("No hay disponibilidad de esa cantidad de habitaciones triples.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (resultadoBusqueda == 4)
                {
                    MessageBox.Show("No hay disponibilidad de esa cantidad de habitaciones cuádruples.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (resultadoBusqueda == 5)
                {
                    MessageBox.Show("No hay disponibilidad de esa cantidad de habitaciones king.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void procesoInicioSesion()
        {
            frmSeleccionarCliente seleccionarCliente = new frmSeleccionarCliente(this);
            seleccionarCliente.Show();
        }
    }
}
