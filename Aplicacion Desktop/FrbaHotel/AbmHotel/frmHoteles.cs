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
        AutoCompleteStringCollection nombreColeccion = new AutoCompleteStringCollection();
        AutoCompleteStringCollection idColeccion = new AutoCompleteStringCollection();
        AutoCompleteStringCollection ciudadColeccion = new AutoCompleteStringCollection();

        int filaSeleccionada;
        Utils utils = new Utils();

        public frmHoteles()
        {
            InitializeComponent();

        }

        private void frmHoteles_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SqlCommand command = new SqlCommand("SELECT h.idHotel Hotel, h.nombre Nombre, h.mail Mail, h.telefono Telefono, h.calle Calle, h.nroCalle [Numero de calle], h.ciudad Ciudad, p.nombrePais Pais, h.fechaCreacion Creación, h.estrellas Estrellas FROM [PISOS_PICADOS].Hotel h JOIN [PISOS_PICADOS].Pais p on h.Pais = p.idPais", Globals.conexionGlobal);
            DataTable dataTable = new DataTable();
            SqlDataReader reader2 = command.ExecuteReader();
            dataTable.Load(reader2);
            dataGridViewHoteles.DataSource = dataTable;
            reader2.Close();

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
            this.cargarAutocomplete("nombre", textBoxNombre, nombreColeccion);
            this.cargarAutocomplete("idHotel", textBoxID, idColeccion);

            //Autocomplete Ciudad
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

            SqlCommand command = new SqlCommand("SELECT h.idHotel Hotel, h.nombre Nombre, h.mail Mail, h.telefono Telefono, h.calle Calle, h.nroCalle [Numero de calle], h.ciudad Ciudad, p.nombrePais Pais, h.fechaCreacion Creación, h.estrellas Estrellas FROM [PISOS_PICADOS].Hotel h JOIN [PISOS_PICADOS].Pais p on h.Pais = p.idPais", Globals.conexionGlobal);
            DataTable dataTable = new DataTable();
            SqlDataReader reader2 = command.ExecuteReader();
            dataTable.Load(reader2);
            dataGridViewHoteles.DataSource = dataTable;
            reader2.Close();

            //Autocompletes
            this.cargarAutocomplete("nombre", textBoxNombre, nombreColeccion);
            this.cargarAutocomplete("idHotel", textBoxID, idColeccion);

            //Autocomplete Ciudad
            string query = "select LTRIM(RTRIM(ciudad)) 'ciudad' from [PISOS_PICADOS].Hotel ";
            SqlCommand llenarColeccion = new SqlCommand(query, Globals.conexionGlobal);
            SqlDataReader dr2 = llenarColeccion.ExecuteReader();
            if (dr2.HasRows == true)
            {
                while (dr2.Read())
                    ciudadColeccion.Add(dr2["ciudad"].ToString());
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoteles.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["Hotel"].Value);
            string nombre = dataGridViewHoteles.CurrentRow.Cells["Nombre"].Value.ToString();
            string mail = dataGridViewHoteles.CurrentRow.Cells["Mail"].Value.ToString();
            string telefono = dataGridViewHoteles.CurrentRow.Cells["Telefono"].Value.ToString();
            string calle = dataGridViewHoteles.CurrentRow.Cells["Calle"].Value.ToString();
            string nroCalle = dataGridViewHoteles.CurrentRow.Cells["Numero de calle"].Value.ToString();
            string ciudad = dataGridViewHoteles.CurrentRow.Cells["Ciudad"].Value.ToString();
            string pais = dataGridViewHoteles.CurrentRow.Cells["Pais"].Value.ToString();
            string fechaCreacion = dataGridViewHoteles.CurrentRow.Cells["Creación"].Value.ToString();
            int estrellas = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["Estrellas"].Value);            

            (new FrbaHotel.AbmHotel.frmModificarHotel()).cargarDatos(id, nombre, mail, telefono, calle, nroCalle, ciudad, pais, fechaCreacion, estrellas, this);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridViewHoteles.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["Hotel"].Value);

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
            else { e.Handled = true; MessageBox.Show("Este campo solo acepta números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        private void textos_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; MessageBox.Show("Este campo solo acepta letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
                else { e.Handled = true; MessageBox.Show("Este campo solo acepta letras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
            textBoxID.Text = ""; textBoxCiudad.Text = ""; 
            textBoxNombre.Text = "";
            estrellas.Text = "Seleccionar"; comboBoxPais.Text = "Seleccionar";
            SqlCommand command = new SqlCommand("SELECT h.idHotel Hotel, h.nombre Nombre, h.mail Mail, h.telefono Telefono, h.calle Calle, h.nroCalle [Numero de calle], h.ciudad Ciudad, p.nombrePais Pais, h.fechaCreacion Creación, h.estrellas Estrellas FROM [PISOS_PICADOS].Hotel h JOIN [PISOS_PICADOS].Pais p on h.Pais = p.idPais", Globals.conexionGlobal);
            DataTable dataTable = new DataTable();
            SqlDataReader reader2 = command.ExecuteReader();
            dataTable.Load(reader2);
            dataGridViewHoteles.DataSource = dataTable;
            reader2.Close();
        }



        //FILTRAR -----------------------------------------------------------------------------

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            String cadenaFiltro = " where (1=1) ";

            if (textBoxID.Text != "") { cadenaFiltro = cadenaFiltro + " and idHotel = " + textBoxID.Text; }
            if (textBoxNombre.Text != "") { cadenaFiltro = cadenaFiltro + " and nombre = '" + textBoxNombre.Text + "'"; }

            if (textBoxCiudad.Text != "") { cadenaFiltro = cadenaFiltro + " and ciudad = '" + textBoxCiudad.Text + "'"; }

            
            
            if (estrellas.Text != "" && estrellas.Text != "Seleccionar") { cadenaFiltro = cadenaFiltro + " and estrellas = " + estrellas.Text; }

          

            if (comboBoxPais.Text != "" && comboBoxPais.Text != "Seleccionar")
            {
                SqlCommand cmdBuscaridPais = new SqlCommand("Select idPais from [PISOS_PICADOS].Pais where nombrePais = @nombrePais", Globals.conexionGlobal);
                cmdBuscaridPais.Parameters.AddWithValue("@nombrePais", comboBoxPais.Text);
                int idpais = (int)cmdBuscaridPais.ExecuteScalar();

                cadenaFiltro = cadenaFiltro + " and pais = " + idpais.ToString();

            }

            SqlCommand command = new SqlCommand("SELECT h.idHotel Hotel, h.nombre Nombre, h.mail Mail, h.telefono Telefono, h.calle Calle, h.nroCalle [Numero de calle], h.ciudad Ciudad, p.nombrePais Pais, h.fechaCreacion Creación, h.estrellas Estrellas FROM [PISOS_PICADOS].Hotel h JOIN [PISOS_PICADOS].Pais p on h.Pais = p.idPais" + cadenaFiltro, Globals.conexionGlobal);
            DataTable dataTable = new DataTable();
            SqlDataReader reader2 = command.ExecuteReader();
            dataTable.Load(reader2);
            dataGridViewHoteles.DataSource = dataTable;
            reader2.Close();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        

    }
}
