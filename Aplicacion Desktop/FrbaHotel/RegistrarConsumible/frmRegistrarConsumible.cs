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

namespace FrbaHotel.RegistrarConsumible
{
    public partial class frmRegistrarConsumible : Form
    {
        float total = 0;

        public frmRegistrarConsumible()
        {
            InitializeComponent();
        }

        private void frmRegistrarConsumible_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            labelTotal.Text = total.ToString();
            //traigo consumibles
            cargarConsumibles();
            precioConsumible.Text = "0";
        }

        private void cargarConsumibles()
        {
            //creo comando para traer consumibles
            SqlCommand cmd = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Consumible" ,Globals.conexionGlobal);
            SqlDataReader reader = cmd.ExecuteReader();

            listConsumibles.Items.Clear();

            while (reader.Read())
            {
                listConsumibles.Items.Add((reader["descripcion"]).ToString().Trim());
            }

            reader.Close();
            return;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //si no eligió nada no hago nada
            if (listAFacturar.SelectedIndex == -1)
            {
                return;
            }
            //traigo el precio
            SqlCommand cmd = new SqlCommand("SELECT precio FROM [PISOS_PICADOS].Consumible WHERE descripcion = @descripcion", Globals.conexionGlobal);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters["@descripcion"].Value = listAFacturar.SelectedItem.ToString();
            //actualizo total cuando saco
            total = total - float.Parse(cmd.ExecuteScalar().ToString()) * float.Parse(listBoxCantidad.Items[listAFacturar.SelectedIndex].ToString());
            labelTotal.Text = total.ToString();
            //borro también la cantidad
            listBoxCantidad.Items.Remove(listBoxCantidad.Items[listAFacturar.SelectedIndex]);
            listAFacturar.Items.Remove(listAFacturar.SelectedItem);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //si no eligió nada no hago nada
            if (listConsumibles.SelectedIndex == -1)
            {
                return;
            }
            //traigo el precio
            SqlCommand cmd = new SqlCommand("SELECT precio FROM [PISOS_PICADOS].Consumible WHERE descripcion = @descripcion", Globals.conexionGlobal);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters["@descripcion"].Value = listConsumibles.SelectedItem.ToString();
            //si ya agregó el consumible le sumo la cantidad
            if (listAFacturar.Items.Contains(listConsumibles.SelectedItem))
            {
                //busco la posición del item
                int posicionItem = listAFacturar.Items.IndexOf(listConsumibles.SelectedItem);
                //sumo la cantidad
                listBoxCantidad.Items[posicionItem] = Int32.Parse(listBoxCantidad.Items[posicionItem].ToString()) + cantidad.Value;
                //actualizo total cuando agrego
                total = total + float.Parse(cmd.ExecuteScalar().ToString()) * float.Parse(cantidad.Value.ToString());
                labelTotal.Text = total.ToString();
                return;
            }
            //actualizo total cuando agrego
            total = total + float.Parse(cmd.ExecuteScalar().ToString()) * float.Parse(cantidad.Value.ToString());
            labelTotal.Text = total.ToString();
            //agrego también la cantidad
            listBoxCantidad.Items.Add(cantidad.Value.ToString());
            listAFacturar.Items.Add(listConsumibles.SelectedItem);
        }

        private void listConsumibles_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listConsumibles.SelectedIndex == -1)
            {
                return;
            }
            //actualizo label de precio cuando selecciono un consumible
            SqlCommand cmd = new SqlCommand("SELECT precio FROM [PISOS_PICADOS].Consumible WHERE descripcion = @descripcion", Globals.conexionGlobal);
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar);
            cmd.Parameters["@descripcion"].Value = listConsumibles.SelectedItem.ToString();
            precioConsumible.Text = cmd.ExecuteScalar().ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //chequeos

            SqlCommand cmdBuscarHotelDeEstadia = new SqlCommand("SELECT [PISOS_PICADOS].hotelDeReserva (@codigoReserva)", Globals.conexionGlobal);
            cmdBuscarHotelDeEstadia.Parameters.Add("@codigoReserva", SqlDbType.Int);
            cmdBuscarHotelDeEstadia.Parameters["@codigoReserva"].Value = Int64.Parse(txtCodigoReserva.Text);
            int hotelDeLaEstadia = (int)cmdBuscarHotelDeEstadia.ExecuteScalar();

            int verificacion = 1;

            if (listAFacturar.Items.Count < 1)
            {
                MessageBox.Show("Agregue al menos un consumible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (txtCodigoReserva.Text == "")
            {
                MessageBox.Show("Inserte un código de reserva que se corresponda a una estadía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (hotelDeLaEstadia != Globals.idHotelUsuario)
            {
                MessageBox.Show("El código que ingresó pertenece a un hotel diferente del que seleccionó cuando inicio sesión. Si usted trabaja en dicho hotel, debe iniciar sesión escogiéndolo para completar esta operación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //fin chequeos

            //ejecuto el SP para agregar consumibles
            SqlCommand cmd = new SqlCommand("[PISOS_PICADOS].agregarConsumible", Globals.conexionGlobal);
            cmd.CommandType = CommandType.StoredProcedure;
            //busco y agrego estadia
            SqlCommand buscarEstadia = new SqlCommand("SELECT idEstadia FROM [PISOS_PICADOS].Estadia WHERE codigoReserva = @codigo", Globals.conexionGlobal);
            buscarEstadia.Parameters.Add("@codigo", SqlDbType.Int);
            buscarEstadia.Parameters["@codigo"].Value = Int64.Parse(txtCodigoReserva.Text);
            int idEstadia;
            try
            {
                idEstadia = (int)buscarEstadia.ExecuteScalar();
            }
            catch
            {
                //si rompe es porque no existe la estadía
                MessageBox.Show("No existe estadía que se corresponda a esa reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //veo si ya no se registraron los consumibles para esa estadía
            SqlCommand tieneConsumiblesRegistrados = new SqlCommand("SELECT [PISOS_PICADOS].yaSeRegistraronConsumibles (@idEstadia)", Globals.conexionGlobal);
            tieneConsumiblesRegistrados.Parameters.Add("@idEstadia", SqlDbType.Int);
            tieneConsumiblesRegistrados.Parameters["@idEstadia"].Value = idEstadia;
            //ejecuto y recibo resultado
            int yaRegistro = (int)tieneConsumiblesRegistrados.ExecuteScalar();
            //Si ya fueron registrados lanzo error
            if (yaRegistro == 1)
            {
                MessageBox.Show("Ya fueron registrados los consumibles para esta reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmd.Parameters.Add("@idEstadia", SqlDbType.Int);
            cmd.Parameters["@idEstadia"].Value = idEstadia;

            cmd.Parameters.Add("@idConsumible", SqlDbType.Int);
            cmd.Parameters.Add("@cantidad", SqlDbType.Int);

            for (int i = 0; i < listAFacturar.Items.Count; i++) 
            {
                    //busco y agrego idConsumible
                    SqlCommand buscarIdConsumible = new SqlCommand("SELECT idConsumible FROM [PISOS_PICADOS].Consumible WHERE descripcion = @descripcion", Globals.conexionGlobal);
                    buscarIdConsumible.Parameters.Add("@descripcion", SqlDbType.VarChar);
                    buscarIdConsumible.Parameters["@descripcion"].Value = listAFacturar.Items[i].ToString();
                cmd.Parameters["@idConsumible"].Value = (int)buscarIdConsumible.ExecuteScalar();
                //agrego cantidad
                cmd.Parameters["@cantidad"].Value = Int64.Parse(listBoxCantidad.Items[i].ToString());
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Registro de consumibles realizado con éxito.");
            this.Close();
        }

        private void txtCodigoReserva_KeyPress(object sender, KeyPressEventArgs e)
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
