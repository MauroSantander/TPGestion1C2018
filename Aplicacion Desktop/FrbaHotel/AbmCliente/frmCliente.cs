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
using System.Net.Mail;

namespace FrbaHotel.AbmCliente
{
    public partial class frmCliente : Form
    {

        Utils utilizador = new Utils();

        public frmCliente()
        {
            InitializeComponent();

            //carga los paises en el combo box cbPaises, extrayendolos de la tabla Pais hecha en sql;
            SqlCommand cmdBuscarPaises = new SqlCommand("SELECT nombrePais FROM [PISOS_PICADOS].Pais", Globals.conexionGlobal);

            SqlDataReader reader = cmdBuscarPaises.ExecuteReader();

            while (reader.Read())
            {
                cbPaises.Items.Add((reader["nombrePais"]).ToString());
            }

            reader.Close();

        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            //centra el formulario
            this.CenterToScreen();
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true;
                MessageBox.Show("Este campo sólo acepta letras", "Error", MessageBoxButtons.OK);
                }
            }
        }


        private void Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true;
                MessageBox.Show("Este campo sólo acepta letras", "Error", MessageBoxButtons.OK);
                }
            }
        }


        private void BotonBaja_Click(object sender, EventArgs e)
        {

            if (dataGridViewClientes.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["numeroIdentificacion"].Value);
            String nombre = (string) dataGridViewClientes.CurrentRow.Cells["nombre"].Value;
            String apellido = (string) dataGridViewClientes.CurrentRow.Cells["apellido"].Value;

            using (SqlConnection cnn = Globals.conexionGlobal)
            {

                string a ="SELECT [PISOS_PICADOS].obtenerIDUsuario (@nombre, @apellido, @numeroIdentificacion)";

                SqlCommand getId = new SqlCommand(a,Globals.conexionGlobal);

                getId.Parameters.Add("@nombre",SqlDbType.VarChar);
                getId.Parameters["@nombre"].Value = nombre;
                
                getId.Parameters.Add("@apellido",SqlDbType.VarChar);
                getId.Parameters["@apellido"].Value = apellido;
                
                getId.Parameters.Add("@numeroIdentificacion",SqlDbType.Int);
                getId.Parameters["@numeroIdentificacion"].Value= id;


                int idUsuario =(int) getId.ExecuteScalar();

                using (SqlConnection con = Globals.conexionGlobal)
                {
                    String cadenaBajaUsuario = "[PISOS_PICADOS].bajaUsuario";

                    SqlCommand comandoBajaUsuario = new SqlCommand(cadenaBajaUsuario, Globals.conexionGlobal);
                    comandoBajaUsuario.CommandType = CommandType.StoredProcedure;


                    comandoBajaUsuario.Parameters.Add("@idUsuario", SqlDbType.Int);
                    comandoBajaUsuario.Parameters["@idUsuario"].Value = idUsuario;

                    comandoBajaUsuario.ExecuteNonQuery();

                    MessageBox.Show("Usuario eliminado correctamente");
                }
            }

            //dataGridViewClientes.Rows.Remove(dataGridViewClientes.CurrentRow);


        }


        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Alta_Click(object sender, EventArgs e)
        {

        }

        private void TipoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void nroId_TextChanged(object sender, EventArgs e)
        {

        }

        private void nroId_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void Mail_TextChanged(object sender, EventArgs e)
        {
            

        }

        static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        private void Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsSeparator(e.KeyChar) || Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }


        private void Calle_TextChanged(object sender, EventArgs e)
        {

        }


        private void Calle_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void Nacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void FechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        
        private void BotonCrear_Click(object sender, EventArgs e)
        {
             
            String TipoIdCliente = TipoId.Text;
            if (string.IsNullOrEmpty(nroId.Text)) {MessageBox.Show("Completar numero de id cliente"); return;}
            int NroIdCliente = int.Parse(nroId.Text);

            if (string.IsNullOrEmpty(NroCalle.Text)) {MessageBox.Show("Completar numero de calle");return;}

            int NroCalleCliente = int.Parse(NroCalle.Text);
            
            DateTime FechaNacimientoCliente = FechaNacimiento.Value;
        
            string selectDateAsString = FechaNacimiento.Value.ToString("yyyy-MM-dd");


            //Validaciones
            if (Nombre.Text == "") { MessageBox.Show("Complete nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Apellido.Text == "") { MessageBox.Show("Complete apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (TipoIdCliente == "") { MessageBox.Show("Complete tipoId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroIdCliente < 0) { MessageBox.Show("Complete nroID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Mail.Text == "") { MessageBox.Show("Complete mail correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!validarEmail(Mail.Text) || utilizador.estaRepetidoMail(Mail.Text)) { MessageBox.Show("Error en el mail", "Error"); return; }
            if (Calle.Text == "") { MessageBox.Show("Complete calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroCalleCliente < 0) { MessageBox.Show("Complete nro de calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Localidad.Text == "") { MessageBox.Show("Complete localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (cbPaises.Text == "") { MessageBox.Show("Complete país", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Nacionalidad.Text == "") { MessageBox.Show("Complete nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (utilizador.estaRepetidoIdentificacion(NroIdCliente, TipoIdCliente))
                {
                    MessageBox.Show("Identificación Repetida");
                    return;
                }


            String cadenaAltaCliente = "PISOS_PICADOS.SPAltaCliente";
            
            SqlCommand comandoAltaCliente = new SqlCommand(cadenaAltaCliente, Globals.conexionGlobal);
            comandoAltaCliente.CommandType = CommandType.StoredProcedure;
            
            //agregar parametros al sp que se encarga de dar de alta a un cliente
            comandoAltaCliente.Parameters.Add("@nombre", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@apellido", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@tipo", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@numeroI", SqlDbType.Int);
            comandoAltaCliente.Parameters.Add("@mail", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@telefono", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@calle", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@numeroC", SqlDbType.Int);
            comandoAltaCliente.Parameters.Add("@localidad", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@pais", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@nacionalidad", SqlDbType.VarChar);
            comandoAltaCliente.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
            
            //cargar valores a los paramtros agregados en el paso anterior
            comandoAltaCliente.Parameters["@nombre"].Value = Nombre.Text;
            comandoAltaCliente.Parameters["@apellido"].Value = Apellido.Text;
            comandoAltaCliente.Parameters["@tipo"].Value = TipoIdCliente;
            comandoAltaCliente.Parameters["@numeroI"].Value = NroIdCliente;
            comandoAltaCliente.Parameters["@mail"].Value = Mail.Text;
            comandoAltaCliente.Parameters["@telefono"].Value = Telefono.Text;
            comandoAltaCliente.Parameters["@calle"].Value = Calle.Text;
            comandoAltaCliente.Parameters["@numeroC"].Value = NroCalleCliente;
            comandoAltaCliente.Parameters["@localidad"].Value = Localidad.Text;
            comandoAltaCliente.Parameters["@pais"].Value = cbPaises.Text;
            comandoAltaCliente.Parameters["@nacionalidad"].Value = Nacionalidad.Text;
            comandoAltaCliente.Parameters["@fechaNacimiento"].Value = FechaNacimientoCliente.ToString("yyyy-MM-dd");
            
            //ejecuta el sp que da alta al cliente tomando los valores ingresados en el form
            comandoAltaCliente.ExecuteNonQuery();
            MessageBox.Show("Alta realizada correctamente");
            
            //reinicio de los textbox
            Nombre.ResetText();
            Apellido.ResetText();
            TipoId.ResetText();
            nroId.ResetText();
            Mail.ResetText();
            Telefono.ResetText();
            Calle.ResetText();
            NroCalle.ResetText();
            Localidad.ResetText();
            Nacionalidad.ResetText();
            FechaNacimiento.ResetText();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelNroId_Click(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefono_Click(object sender, EventArgs e)
        {

        }

        private void labelCalle_Click(object sender, EventArgs e)
        {

        }

        private void labelNacionalidad_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NroCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void NroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }


        private void Localidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Localidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void cbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void textBoxUsrNameBorrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nroIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }


        public void mostrarClientesFiltrado(DataGridView dgv)
        {
            //esta funcion se encarga de filtrar a los clientes segun los criterios ingresados por el menu del
            // tab de dar de baja a un cliente del frmCliente y, posterior a ello, mostrarlos en una grilla que 
            //estará en dicha pantalla

            string cadenaNombre;
            string cadenaApellido;
            string cadenaTipoId;
            string cadenaNroIdentificacion;
            string cadenaMail;

            if (textBoxNombre.Text == "") { cadenaNombre = "nombre LIKE '%'"; }
            else { cadenaNombre = "nombre LIKE '" + textBoxNombre.Text + "'"; };

            if (textBoxApellido.Text == "") { cadenaApellido = "apellido LIKE '%'"; }
            else { cadenaApellido = "apellido LIKE '" + textBoxApellido.Text + "'"; };

            if ( cbTipoId.SelectedItem == null || cbTipoId.SelectedItem.ToString() == "" ) { cadenaTipoId = "tipoIdentificacion LIKE '%'"; }
            else { cadenaTipoId = "tipoIdentificacion LIKE '" + cbTipoId.SelectedItem.ToString() + "'"; };

            if (textBoxNroId.Text == "") { cadenaNroIdentificacion = "numeroIdentificacion LIKE '%'"; }
            else { cadenaNroIdentificacion = "numeroIdentificacion LIKE '" + int.Parse(textBoxNroId.Text) + "'"; };

            if (textBoxMail.Text == "") { cadenaMail = "mail LIKE '%'"; }
            else{ cadenaMail = "mail LIKE '" + textBoxMail.Text + "'"; };


            string compuesto = " SELECT * FROM [PISOS_PICADOS].Usuario WHERE " + cadenaNombre 
                + " AND " + cadenaApellido + " AND " + cadenaTipoId + " AND " 
                + cadenaNroIdentificacion + " AND " + cadenaMail;


            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            SqlDataAdapter adapter = new SqlDataAdapter(compuesto, Globals.conexionGlobal);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;

        }


        public void mostrarClientesFiltradoParaModif(DataGridView dgv)
        {
            //esta funcion se encarga de filtrar a los clientes segun los criterios ingresados por el menu del
            // tab de modificar a un cliente del frmCliente, grabando dichas modificaciones en la base de datos


            string cadenaNombre;
            string cadenaApellido;
            string cadenaTipoId;
            string cadenaNroIdentificacion;
            string cadenaMail;

            if (txtNombreModif.Text == "") { cadenaNombre = "nombre LIKE '%'"; }
            else { cadenaNombre = "nombre LIKE '" + txtNombreModif.Text + "'"; };

            if (txtApellidoModif.Text == "") { cadenaApellido = "apellido LIKE '%'"; }
            else { cadenaApellido = "apellido LIKE '" + txtApellidoModif.Text + "'"; };

            if (cmbTipoIdModif.SelectedItem == null || cmbTipoIdModif.SelectedItem.ToString() == "") { cadenaTipoId = "tipoIdentificacion LIKE '%'"; }
            else { cadenaTipoId = "tipoIdentificacion LIKE '" + cmbTipoIdModif.SelectedItem.ToString() + "'"; };

            if (txtNroIdModif.Text == "") { cadenaNroIdentificacion = "numeroIdentificacion LIKE '%'"; }
            else { cadenaNroIdentificacion = "numeroIdentificacion LIKE '" + int.Parse(txtNroIdModif.Text) + "'"; };

            if (txtMailModif.Text == "") { cadenaMail = "mail LIKE '%'"; }
            else { cadenaMail = "mail LIKE '" + txtMailModif.Text + "'"; };


            string compuesto = " SELECT * FROM [PISOS_PICADOS].Usuario WHERE " + cadenaNombre
                + " AND " + cadenaApellido + " AND " + cadenaTipoId + " AND "
                + cadenaNroIdentificacion + " AND " + cadenaMail;


            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            SqlDataAdapter adapter = new SqlDataAdapter(compuesto, Globals.conexionGlobal);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv.DataSource = dataTable;

        }

        private void btnBuscarFiltrado(object sender, EventArgs e)
        {
            //usa la funcion que muestra a los clientes en la abm de filtrado y 
            //los muestra en una grilla para luego ser seleccionado el cliente que será modificado
            mostrarClientesFiltrado(dataGridViewClientes);
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarBaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTipoId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBoxNroId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //muestra los clientes segun los filtros solicitados en los campos del form de bajaCliente
            mostrarClientesFiltradoParaModif(dataGridViewModificarCliente);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //esta funcion entra en acción cuando ya encontramos al cliente a modificar y nos permite seleccionarlo
            //en el DataGridView y conocer sus valores que aparecerán por defecto en un formulario especial para la 
            //modificacion de un cliente

            frmModificacionCliente modificacion = new frmModificacionCliente();

            String NombreClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["nombre"].Value;
            String ApellidoClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["apellido"].Value;
            String TipoIdClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["tipoIdentificacion"].Value;
            int NroIdClienteFila = (int)dataGridViewModificarCliente.CurrentRow.Cells["numeroIdentificacion"].Value; //modificado a string para poder usar el contenido
            
           /////////****** antes de seguir obtengo id de usuario para relacionarlo con su nacionalidad que está en la tabla cliente******///////// 
            //busco el id del cliente porque lo necesitaré al buscar su nacionalidad, la cual está en la tabla Cliente 
            string a = "SELECT [PISOS_PICADOS].obtenerIDUsuario (@nombre, @apellido, @numeroIdentificacion)";

            SqlCommand getId = new SqlCommand(a, Globals.conexionGlobal);

            getId.Parameters.Add("@nombre", SqlDbType.VarChar);
            getId.Parameters["@nombre"].Value = NombreClienteFila;

            getId.Parameters.Add("@apellido", SqlDbType.VarChar);
            getId.Parameters["@apellido"].Value = ApellidoClienteFila;

            getId.Parameters.Add("@numeroIdentificacion", SqlDbType.Int);
            getId.Parameters["@numeroIdentificacion"].Value = NroIdClienteFila;


            int idUsuario = (int)getId.ExecuteScalar(); //este es el id del cliente que buscabamos


            //usamos el id del cliente obtenido como parametro de la funcion de usuario hecha en sql llamada
            // obtenerNacionalidadCliente, la cual nos permite buscar nacionalidad a partir de un id de cliente
            string b = "SELECT [PISOS_PICADOS].obtenerNacionalidadCliente (@idCliente)";

            SqlCommand getNacionalidad = new SqlCommand(b,Globals.conexionGlobal);

            getNacionalidad.Parameters.Add("@idCliente",SqlDbType.Int);
            getNacionalidad.Parameters["@idCliente"].Value = idUsuario;

            String nacionalidadCliente = (String) getNacionalidad.ExecuteScalar(); //aqui es donde obtenemos la
                                                                                  //nacionalidad buscada

            String MailClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["mail"].Value; ;
            
            String TelefonoClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["telefono"].FormattedValue.ToString())) {
                TelefonoClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["telefono"].Value;
                modificacion.txtTelefono.Text = TelefonoClienteFila;
            }
            
            String CalleClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["calle"].Value;
            
            int NroCalleClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["nroCalle"].FormattedValue.ToString()))
            {
                NroCalleClienteFila = Convert.ToInt32(dataGridViewModificarCliente.CurrentRow.Cells["nroCalle"].Value);
                modificacion.txtTelefono.Text = NroCalleClienteFila.ToString();
            }

            String LocalidadClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["localidad"].FormattedValue.ToString()))
            {
                LocalidadClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["localidad"].Value;
                modificacion.txtLocalidad.Text = LocalidadClienteFila;
            }
            
            
            int PaisClienteFila = Convert.ToInt32(dataGridViewModificarCliente.CurrentRow.Cells["pais"].Value);
            String NacionalidadClienteFila = nacionalidadCliente;
            DateTime FechaNacimientoClienteFila = (DateTime)dataGridViewModificarCliente.CurrentRow.Cells["fechaNacimiento"].Value;

           //el form de  modificacion se abrira con los valores del usuario cargados
           modificacion.txtNombre.Text = NombreClienteFila;
           modificacion.txtApellido.Text = ApellidoClienteFila;
           modificacion.cbTipoId.Text = TipoIdClienteFila;
           modificacion.txtNroId.Text = NroIdClienteFila.ToString();
           modificacion.txtMail.Text = MailClienteFila;
           
           modificacion.txtCalle.Text = CalleClienteFila;
           //modificacion.txtNroCalle.Text = NroCalleClienteFila.ToString();
           //modificacion.txtLocalidad.Text = LocalidadClienteFila;
           modificacion.txtNacionalidad.Text = NacionalidadClienteFila;
           //modificacion.dtpFechaNacimiento.Value = FechaNacimientoClienteFila.ToString();
            
            modificacion.Show();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreModif_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nro_IdKeyPress(object sender, KeyPressEventArgs e)
        {
            {
                //no ingresa numeros al campo y muestra mensaje que lo informa
                if (Char.IsDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true;
                MessageBox.Show("Este campo sólo acepta números", "Error",MessageBoxButtons.OK);
                }
            }
        }



        
    }
}
