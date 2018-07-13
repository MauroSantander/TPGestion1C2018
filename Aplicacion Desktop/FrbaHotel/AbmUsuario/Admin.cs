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
            
            AutoCompleteStringCollection usernameColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("e.usuario", "Usuario", textBoxUsuario, usernameColeccion);

            AutoCompleteStringCollection nombreColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("u.nombre","Nombre", textBoxNombre, nombreColeccion);

            AutoCompleteStringCollection apColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("u.apellido","Apellido" ,textBoxApellido, apColeccion);

            AutoCompleteStringCollection locColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("u.localidad","Localidad", textBoxLocalidad, locColeccion);

            AutoCompleteStringCollection calleColeccion = new AutoCompleteStringCollection();
            this.cargarAutocomplete("u.calle","Calle", textBoxCalle, calleColeccion);


        }


        //----------------------------------------------------------------------------------------------------
        //Boton Crear


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
            String tipoId = dataGridViewUsuarios.CurrentRow.Cells["TipoId"].Value.ToString();
            String nroident =dataGridViewUsuarios.CurrentRow.Cells["NroIdentificación"].Value.ToString();
            String fechaNacimiento = dataGridViewUsuarios.CurrentRow.Cells["Fecha Nacimiento"].Value.ToString();

            int idPais = int.Parse(pais);

            SqlCommand cmdBuscarNombrePais = new SqlCommand("Select nombrePais from [PISOS_PICADOS].Pais where idPais = @idPais", Globals.conexionGlobal);
            cmdBuscarNombrePais.Parameters.AddWithValue("@idPais", idPais);
            SqlDataReader reader = cmdBuscarNombrePais.ExecuteReader();

            while (reader.Read())
            {
                pais = (reader["nombrePais"]).ToString();
            }


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


        //Boton dar de baja 

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

                SqlDataAdapter adapter = new SqlDataAdapter("select e.idUsuario 'Id',e.usuario 'Usuario', e.contrasena 'Contraseña', u.nombre 'Nombre', u.apellido 'Apellido',u.mail 'Mail',u.telefono 'Teléfono',u.calle 'Calle',u.nroCalle 'NroCalle',u.localidad 'Localidad',u.pais 'Pais',u.tipoIdentificacion 'TipoId',u.numeroIdentificacion 'NroIdentificación',u.fechaNacimiento 'Fecha Nacimiento' from [PISOS_PICADOS].Empleado E join [PISOS_PICADOS].Usuario U on (E.idUsuario = U.idUsuario) where u.estado = 1"+agregar, Globals.conexionGlobal);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewUsuarios.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo llenar el DataGridView");
            }
        }

       
        



    


      


        //FILTRAR -----------------------------------------------------------------------------

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            String cadenaFiltro = "";

            if (textBoxNombre.Text != "") { cadenaFiltro = cadenaFiltro + " and Nombre = '" + textBoxNombre.Text + "'"; }

            if (textBoxLocalidad.Text != "") { cadenaFiltro = cadenaFiltro + " and Localidad = '" + textBoxLocalidad.Text + "'"; }

            if (textBoxCalle.Text != "") { cadenaFiltro = cadenaFiltro + " and Calle = '" + textBoxCalle.Text + "'"; }

            if (textBoxApellido.Text != "") { cadenaFiltro = cadenaFiltro + " and Apellido = '" + textBoxApellido.Text + "'"; }
            if (textBoxUsuario.Text != "") { cadenaFiltro = cadenaFiltro + " and Usuario = '" + textBoxUsuario.Text + "'"; }
            if (textBoxNroCalle.Text != "") { cadenaFiltro = cadenaFiltro + " and NroCalle = " + textBoxNroCalle.Text; }
            if (comboBoxTipoId.Text != "" && comboBoxTipoId.Text != "Seleccionar") { cadenaFiltro = cadenaFiltro + " and TipoId = " + comboBoxTipoId.Text; }
            if (textBoxNroId.Text != "") { cadenaFiltro = cadenaFiltro + " and NroIdentificación = " + textBoxNroCalle.Text; }
            if (comboBoxPais.Text != "" && comboBoxPais.Text != "Seleccionar")
            {
                SqlCommand cmdBuscaridPais = new SqlCommand("Select idPais from [PISOS_PICADOS].Pais where nombrePais = @nombrePais", Globals.conexionGlobal);
                cmdBuscaridPais.Parameters.AddWithValue("@nombrePais", comboBoxPais.Text);
                int idpais = (int)cmdBuscaridPais.ExecuteScalar();

                cadenaFiltro = cadenaFiltro + " and pais = " + idpais.ToString();

            }

            this.llenarDataGridView(cadenaFiltro);

        }

        private void cargarAutocomplete(String columna,String nombre, TextBox textbox, AutoCompleteStringCollection coleccion)
        {
            string query = "Select " + columna +" '"+nombre+"'  from [PISOS_PICADOS].Empleado E join [PISOS_PICADOS].Usuario U on (E.idUsuario = U.idUsuario) where u.estado = 1";
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

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxUsuario.Text = ""; textBoxNombre.Text = ""; textBoxCalle.Text = "";
            textBoxLocalidad.Text = ""; textBoxNroCalle.Text = ""; textBoxApellido.Text = ""; textBoxNroId.Text = "";
            comboBoxTipoId.Text = "Seleccionar"; comboBoxPais.Text = "Seleccionar";


            this.llenarDataGridView("");
        }

       
        

       


       

       

    }

    }


