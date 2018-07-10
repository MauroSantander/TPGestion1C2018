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

namespace FrbaHotel.AbmHabitacion
{
    public partial class frmModificarHabitacion : Form
    {
        int habitacionAModificar;
        int hotelDeHabitacion;
        int numeroHab;
        int pisoHab;
        string ubicacionHab;
        Boolean habilitadaHab;
        string descripcionHab;
        frmHabitacion instanciaformHabitaciones;

        public frmModificarHabitacion(int habitacion, int idHotel, int numero, int piso, string ubicacion, Boolean habilitada, string descripcion, frmHabitacion instanciafrmHab)
        {
            InitializeComponent();
            habitacionAModificar = habitacion;
            hotelDeHabitacion = idHotel;
            numeroHab = numero;
            pisoHab = piso;
            ubicacionHab = ubicacion;
            habilitadaHab = habilitada;
            descripcionHab = descripcion;
            instanciaformHabitaciones = instanciafrmHab;
        }

        private void frmModificarHabitacion_Load(object sender, EventArgs e)
        {
            //inicializo objetos con datos para modificar
            this.CenterToScreen();
            comboBoxUbicacion.Items.Add("Frente");
            comboBoxUbicacion.Items.Add("Interno");
            textBoxNumero.Text = numeroHab.ToString();
            textBoxPiso.Text = pisoHab.ToString();
            if (ubicacionHab == "S")
            {
                comboBoxUbicacion.SelectedIndex = 0;
            }
            if (ubicacionHab == "N")
            {
                comboBoxUbicacion.SelectedIndex = 1;
            }
            if (habilitadaHab)
            {
                checkBoxEstado.CheckState = CheckState.Checked;
            }
            else
            {
                checkBoxEstado.CheckState = CheckState.Unchecked;
            }
            textBoxDescripcion.Text = descripcionHab;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //chequeos
            int verificacion = 1;

            if (textBoxNumero.Text == "")
            {
                MessageBox.Show("Ingrese número de habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (textBoxPiso.Text == "")
            {
                MessageBox.Show("Ingrese piso de habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (textBoxDescripcion.Text == "")
            {
                MessageBox.Show("Ingrese descripción de habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (comboBoxUbicacion.Text == "")
            {
                MessageBox.Show("Seleccione una ubicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //fin chequeos

            //creo el comando para ejecutar el SP
            string spModificarHabitacion = "[PISOS_PICADOS].SPModificarHabitacion";
            SqlCommand modificarHab = new SqlCommand(spModificarHabitacion, Globals.conexionGlobal);
            modificarHab.CommandType = CommandType.StoredProcedure;
            //agrego parámetros
            modificarHab.Parameters.Add("@idHabitacion", SqlDbType.Int);
            modificarHab.Parameters.Add("@numeroH", SqlDbType.Int);
            modificarHab.Parameters.Add("@frente",SqlDbType.Char);
            modificarHab.Parameters.Add("@descripcion",SqlDbType.VarChar);
            modificarHab.Parameters.Add("@piso",SqlDbType.Int);
            modificarHab.Parameters.Add("@habilitado",SqlDbType.Bit);

            //doy valor a los parámetros
            modificarHab.Parameters["@idHabitacion"].Value = habitacionAModificar;
            modificarHab.Parameters["@numeroH"].Value = Int32.Parse(textBoxNumero.Text);
            if (comboBoxUbicacion.Text == "Frente")
            {
                modificarHab.Parameters["@frente"].Value = 'S';
            }
            else
            {
                modificarHab.Parameters["@frente"].Value = 'N';
            }
            modificarHab.Parameters["@descripcion"].Value = textBoxDescripcion.Text;
            modificarHab.Parameters["@piso"].Value = Int32.Parse(textBoxPiso.Text);
            if (checkBoxEstado.Checked)
            {
                modificarHab.Parameters["@habilitado"].Value = 1;
            }
            else
            { 
                modificarHab.Parameters["@habilitado"].Value = 0;
            }

            //chequeo si existe la habitación
            SqlCommand cmdExisteHab = new SqlCommand("SELECT [PISOS_PICADOS].existeNumEnHotel(@idHotel, @numero)", Globals.conexionGlobal);
            cmdExisteHab.Parameters.Add("@idHotel", SqlDbType.VarChar);
            cmdExisteHab.Parameters["@idHotel"].Value = hotelDeHabitacion;
            cmdExisteHab.Parameters.Add("@numero", SqlDbType.VarChar);
            cmdExisteHab.Parameters["@numero"].Value = Int32.Parse(textBoxNumero.Text);
            int existeHab = (int)cmdExisteHab.ExecuteScalar();

            //me fijo si el num de habitación que pasa es el mismo de antes. En ese caso si dejo modificar. Si no, y la hab ya existe, no lo dejo
            if (numeroHab != Int32.Parse(textBoxNumero.Text))
            {
                if (existeHab == 0)
                {
                    modificarHab.ExecuteNonQuery();
                    MessageBox.Show("Modificación realizada correctamente.");
                    instanciaformHabitaciones.recargarHabitaciones(null);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya existe ese número de habitación en el hotel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                modificarHab.ExecuteNonQuery();
                MessageBox.Show("Modificación realizada correctamente.");
                instanciaformHabitaciones.recargarHabitaciones(null);
                this.Close();
            }

        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox solo acepta números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox solo acepta números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
