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

namespace FrbaHotel.AbmUsuario
{
    public partial class Admin : Form
    {
        AutoCompleteStringCollection usernameColeccion = new AutoCompleteStringCollection();
        AutoCompleteStringCollection nombreColeccion = new AutoCompleteStringCollection();
        AutoCompleteStringCollection apColeccion = new AutoCompleteStringCollection();
        AutoCompleteStringCollection locColeccion = new AutoCompleteStringCollection();
        AutoCompleteStringCollection calleColeccion = new AutoCompleteStringCollection();
            
        Utils utils = new Utils();
      
        DataTable dataTable;

        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            
            this.llenarDataGridView("");

            //inicializo combobox de paises
            SqlCommand cmd = new SqlCommand("select nombrePais from [PISOS_PICADOS].Pais", Globals.conexionGlobal);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxPais.Items.Add((reader["nombrePais"]).ToString());
            }
            comboBoxPais.Items.Add("Seleccionar");

            reader.Close();
            
            this.cargarAutocomplete("e.usuario", "Usuario", textBoxUsuario, usernameColeccion);
            this.cargarAutocomplete("u.nombre","Nombre", textBoxNombre, nombreColeccion);
            this.cargarAutocomplete("u.apellido","Apellido" ,textBoxApellido, apColeccion);
            this.cargarAutocomplete("u.localidad","Localidad", textBoxLocalidad, locColeccion);
            this.cargarAutocomplete("u.calle","Calle", textBoxCalle, calleColeccion);

            comboBoxTipoId.Text = "Seleccionar";
            comboBoxPais.Text = "Seleccionar";
    
        }

        private void buttonCrearUsr_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.AbmUsuario.frmNuevoUsuario()).abrirPantalla(this);
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione usuario de la tabla"); return;
            }
          
            int id = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells["Id"].Value);
            String usuario = dataGridViewUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
            String nombre= dataGridViewUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
            String apell = dataGridViewUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
            String mail = dataGridViewUsuarios.CurrentRow.Cells["Mail"].Value.ToString();
            String tel = dataGridViewUsuarios.CurrentRow.Cells["Teléfono"].Value.ToString();
            String calle = dataGridViewUsuarios.CurrentRow.Cells["Calle"].Value.ToString();
            String nroCalle = dataGridViewUsuarios.CurrentRow.Cells["NroCalle"].Value.ToString();
            String localidad = dataGridViewUsuarios.CurrentRow.Cells["Localidad"].Value.ToString();
            String pais = dataGridViewUsuarios.CurrentRow.Cells["Pais"].Value.ToString();
            String tipoId = dataGridViewUsuarios.CurrentRow.Cells["TipoIdentificacion"].Value.ToString();
            String nroident =dataGridViewUsuarios.CurrentRow.Cells["NroIdentificacion"].Value.ToString();
            String fechaNacimiento = dataGridViewUsuarios.CurrentRow.Cells["Fecha Nacimiento"].Value.ToString();

            (new FrbaHotel.AbmUsuario.frmModificarUsuario()).cargarDatos(id, usuario,nombre,apell, mail, tel, calle, nroCalle, localidad, pais, tipoId, nroident,fechaNacimiento, this);

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {

                foreach (DataGridViewRow dr in dataGridViewUsuarios.SelectedRows)
                {
                    dr.Selected = false;
                }
                // Para seleccionar
                dataGridViewUsuarios.Rows[e.RowIndex].Selected = true;
            }

        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            {
                if (dataGridViewUsuarios.CurrentRow == null){
                    MessageBox.Show("Seleccione usuario de la tabla"); return;}

                int id = Convert.ToInt32(dataGridViewUsuarios.CurrentRow.Cells["Id"].Value);
                
                String cadenaBajaUsuario = "PISOS_PICADOS.bajaUsuario";

                SqlCommand comandoBajaUsuario = new SqlCommand(cadenaBajaUsuario, Globals.conexionGlobal);
                comandoBajaUsuario.CommandType = CommandType.StoredProcedure;

                comandoBajaUsuario.Parameters.AddWithValue("@idUsuario", id);
                comandoBajaUsuario.ExecuteReader();
                MessageBox.Show("Usuario dado de baja correctamente");

                dataGridViewUsuarios.Rows.Remove(dataGridViewUsuarios.CurrentRow);
            }
        }
       
        public void llenarDataGridView(String agregar)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter("select e.idUsuario 'Id',e.usuario 'Usuario', u.nombre 'Nombre', u.apellido 'Apellido',u.mail 'Mail',u.telefono 'Teléfono',u.calle 'Calle',u.nroCalle 'NroCalle',u.localidad 'Localidad',p.nombrePais 'Pais',u.tipoIdentificacion 'TipoIdentificacion',u.numeroIdentificacion 'NroIdentificacion',u.fechaNacimiento 'Fecha Nacimiento' from [PISOS_PICADOS].Empleado E join [PISOS_PICADOS].Usuario U on (E.idUsuario = U.idUsuario) join [PISOS_PICADOS].Pais p on u.pais = p.idPais where u.estado = 1" + agregar, Globals.conexionGlobal);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsuarios.DataSource = dataTable;
            }
            catch
            {
                MessageBox.Show("No se pudo llenar el DataGridView");
            }

            this.cargarAutocomplete("e.usuario", "Usuario", textBoxUsuario, usernameColeccion);
            this.cargarAutocomplete("u.nombre", "Nombre", textBoxNombre, nombreColeccion);
            this.cargarAutocomplete("u.apellido", "Apellido", textBoxApellido, apColeccion);
            this.cargarAutocomplete("u.localidad", "Localidad", textBoxLocalidad, locColeccion);
            this.cargarAutocomplete("u.calle", "Calle", textBoxCalle, calleColeccion);

        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            String cadenaFiltro = "";

            if (textBoxNombre.Text != "") { cadenaFiltro = cadenaFiltro + " and Nombre = '" + textBoxNombre.Text + "'"; }

            if (textBoxLocalidad.Text != "") { cadenaFiltro = cadenaFiltro + " and Localidad = '" + textBoxLocalidad.Text + "'"; }

            if (textBoxCalle.Text != "") { cadenaFiltro = cadenaFiltro + " and Calle = '" + textBoxCalle.Text + "'"; }

            if (textBoxApellido.Text != "") { cadenaFiltro = cadenaFiltro + " and Apellido = '" + textBoxApellido.Text + "'"; }
            if (textBoxUsuario.Text != "") { cadenaFiltro = cadenaFiltro + " and Usuario = '" + textBoxUsuario.Text + "'"; }
            if (textBoxNroCalle.Text != "") { cadenaFiltro = cadenaFiltro + " and NroCalle = " + textBoxNroCalle.Text; }
            if (comboBoxTipoId.Text != "" && comboBoxTipoId.Text != "Seleccionar") { cadenaFiltro = cadenaFiltro + " and TipoIdentificacion = '" + comboBoxTipoId.Text+"'"; }

            if (textBoxNroId.Text != "") { cadenaFiltro = cadenaFiltro + " and u.numeroIdentificacion = " + textBoxNroId.Text ; }
            if (comboBoxPais.Text != "" && comboBoxPais.Text != "Seleccionar")
            {
                SqlCommand cmdBuscaridPais = new SqlCommand("Select idPais from [PISOS_PICADOS].Pais where nombrePais = @nombrePais", Globals.conexionGlobal);
                cmdBuscaridPais.Parameters.AddWithValue("@nombrePais", comboBoxPais.Text);
                int idpais = (int)cmdBuscaridPais.ExecuteScalar();

                cadenaFiltro = cadenaFiltro + " and Pais = " + idpais.ToString();

            }

            this.llenarDataGridView(cadenaFiltro);

        }

        private void cargarAutocomplete(String columna,String nombre, TextBox textbox, AutoCompleteStringCollection coleccion)
        {
            string query = "Select "+ columna +" '"+nombre+"'  from [PISOS_PICADOS].Empleado E join [PISOS_PICADOS].Usuario U on (E.idUsuario = U.idUsuario) where u.estado = 1";
            SqlCommand llenarColeccion = new SqlCommand(query, Globals.conexionGlobal);
            SqlDataReader dr = llenarColeccion.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                    coleccion.Add(dr[nombre].ToString());
            }

            dr.Close();

            textbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textbox.AutoCompleteCustomSource = coleccion;
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
                else { e.Handled = true; MessageBox.Show("Este campo solo acepta letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = ""; textBoxNombre.Text = ""; textBoxCalle.Text = "";
            textBoxLocalidad.Text = ""; textBoxNroCalle.Text = ""; textBoxApellido.Text = ""; textBoxNroId.Text = "";
            comboBoxTipoId.Text = "Seleccionar"; comboBoxPais.Text = "Seleccionar";


            this.llenarDataGridView("");
        }

    }
}


