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

namespace FrbaHotel.AbmHotel
{
    public partial class frmHoteles : Form
    {


        int filaSeleccionada;
        Utils utils = new Utils();

        public frmHoteles()
        {
            InitializeComponent();

        }

        private void frmHoteles_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            utils.llenarDataGridView(dataGridViewHoteles, "Hotel");
            //inicializo combobox de paises
            SqlCommand cmd = new SqlCommand("select nombrePais from [PISOS_PICADOS].Pais", Globals.conexionGlobal);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxPais.Items.Add((reader["nombrePais"]).ToString());
            }
            comboBoxPais.Items.Add("Seleccionar");

            reader.Close();

            //Autocompletes
            
            AutoCompleteStringCollection nombreColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("nombre", textBoxNombre, nombreColeccion);

            AutoCompleteStringCollection idColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("idHotel", textBoxID, idColeccion);

            AutoCompleteStringCollection calleColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("calle", textBoxCalle, calleColeccion);

            AutoCompleteStringCollection mailColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("mail", textBoxMail, mailColeccion);

            AutoCompleteStringCollection nroCalleColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("nroCalle", textBoxNroCalle, nroCalleColeccion);

            AutoCompleteStringCollection telColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("telefono", textBoxTelefono, telColeccion);

            //Autocomplete Ciudad

            AutoCompleteStringCollection ciudadColeccion = new AutoCompleteStringCollection();
            string query = "select LTRIM(RTRIM(ciudad)) 'ciudad' from [PISOS_PICADOS].Hotel ";
            SqlCommand llenarColeccion = new SqlCommand(query, Globals.conexionGlobal);
            SqlDataReader dr2 = llenarColeccion.ExecuteReader();
            if (dr2.HasRows == true)
            {
                while (dr2.Read())
                    ciudadColeccion.Add(dr2["ciudad"].ToString());

            }

            dr2.Close();
            textBoxCiudad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxCiudad.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxCiudad.AutoCompleteCustomSource = ciudadColeccion;
        }

        

        public void actualizarDataGrid() {
            utils.llenarDataGridView(dataGridViewHoteles, "Hotel");
        }

        public void eliminarRowHotel()
        {
            dataGridViewHoteles.Rows.Remove(dataGridViewHoteles.Rows[filaSeleccionada]);
        }


        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoteles.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["idHotel"].Value);
            String nombre = dataGridViewHoteles.CurrentRow.Cells["nombre"].Value.ToString();
            String mail = dataGridViewHoteles.CurrentRow.Cells["mail"].Value.ToString();
            String telefono = dataGridViewHoteles.CurrentRow.Cells["telefono"].Value.ToString();
            String calle = dataGridViewHoteles.CurrentRow.Cells["calle"].Value.ToString();
            String nroCalle = dataGridViewHoteles.CurrentRow.Cells["nroCalle"].Value.ToString();
            String ciudad = dataGridViewHoteles.CurrentRow.Cells["ciudad"].Value.ToString();
            String pais = dataGridViewHoteles.CurrentRow.Cells["pais"].Value.ToString();
            String fechaCreacion = dataGridViewHoteles.CurrentRow.Cells["fechaCreacion"].Value.ToString();
            int estrellas = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["estrellas"].Value);

            int idPais = int.Parse(pais);

            SqlCommand cmdBuscarNombrePais = new SqlCommand("Select nombrePais from [PISOS_PICADOS].Pais where idPais = @idPais", Globals.conexionGlobal);
            cmdBuscarNombrePais.Parameters.AddWithValue("@idPais", idPais);
            SqlDataReader reader = cmdBuscarNombrePais.ExecuteReader();

            while (reader.Read())
            {
                pais = (reader["nombrePais"]).ToString();
            }
            

            (new FrbaHotel.AbmHotel.frmModificarHotel()).cargarDatos(id, nombre, mail, telefono, calle, nroCalle, ciudad, pais, fechaCreacion, estrellas, this);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridViewHoteles.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["idHotel"].Value);

            (new FrbaHotel.AbmHotel.frmBajaHotel()).asignarId(id, this);

        }




       

        private void buttonNew_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.AbmHotel.frmNuevoHotel()).abrirPantalla(this);
        }


      

        //-------------------------------------------------------------------------------------------------------
        //KEYPRESS-------------------------------------------------------------------------------------------------

        private void numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }


        private void textos_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textoYNros_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textosYespacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textoNrosYespacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        //Limpiar y recargar

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = ""; textBoxCiudad.Text = ""; textBoxCalle.Text = ""; 
            textBoxNombre.Text = ""; textBoxNroCalle.Text = ""; textBoxMail.Text = ""; textBoxTelefono.Text = "";
            estrellas.Text = "Seleccionar"; comboBoxPais.Text = "Seleccionar";


            utils.llenarDataGridView(dataGridViewHoteles, "Hotel");
        }



        //FILTRAR -----------------------------------------------------------------------------

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            String cadenaFiltro = " where (1=1) ";

            if (textBoxID.Text != "") { cadenaFiltro = cadenaFiltro + " and idHotel = " + textBoxID.Text; }
            if (textBoxNombre.Text != "") { cadenaFiltro = cadenaFiltro + " and nombre = '" + textBoxNombre.Text + "'"; }

            if (textBoxCiudad.Text != "") { cadenaFiltro = cadenaFiltro + " and ciudad = '" + textBoxCiudad.Text + "'"; }

            if (textBoxCalle.Text != "") { cadenaFiltro = cadenaFiltro + " and calle = '" + textBoxCalle.Text + "'"; }

            if (textBoxMail.Text != "") { cadenaFiltro = cadenaFiltro + " and mail = '" + textBoxMail.Text + "'"; }
            if (textBoxTelefono.Text != "") { cadenaFiltro = cadenaFiltro + " and telefono = '" + textBoxTelefono.Text + "'"; }

            if (estrellas.Text != "" && estrellas.Text != "Seleccionar") { cadenaFiltro = cadenaFiltro + " and estrellas = " + estrellas.Text; }

            if (textBoxNroCalle.Text != "") { cadenaFiltro = cadenaFiltro + " and nroCalle = " + textBoxNroCalle.Text; }


            if (comboBoxPais.Text != "" && comboBoxPais.Text != "Seleccionar")
            {
                SqlCommand cmdBuscaridPais = new SqlCommand("Select idPais from [PISOS_PICADOS].Pais where nombrePais = @nombrePais", Globals.conexionGlobal);
                cmdBuscaridPais.Parameters.AddWithValue("@nombrePais", comboBoxPais.Text);
                int idpais = (int)cmdBuscaridPais.ExecuteScalar();

                cadenaFiltro = cadenaFiltro + " and pais = " + idpais.ToString();

            }

            utils.llenarDataGridView(dataGridViewHoteles, "Hotel" + cadenaFiltro);

        }
        private void cargarAutocomplete(String columna, TextBox textbox, AutoCompleteStringCollection coleccion)
        {
            string query = "Select " + columna + " from [PISOS_PICADOS].Hotel";
            SqlCommand llenarColeccion = new SqlCommand(query, Globals.conexionGlobal);
            SqlDataReader dr = llenarColeccion.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    coleccion.Add(dr["" + columna + ""].ToString());

            }

            dr.Close();
            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textbox.AutoCompleteCustomSource = coleccion;
        }

        private void dataGridViewHoteles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {

                foreach (DataGridViewRow dr in dataGridViewHoteles.SelectedRows)
                {

                    dr.Selected = false;

                }

                // Para seleccionar

                dataGridViewHoteles.Rows[e.RowIndex].Selected = true;
                filaSeleccionada = e.RowIndex;

            }

        }
        

    }
}
