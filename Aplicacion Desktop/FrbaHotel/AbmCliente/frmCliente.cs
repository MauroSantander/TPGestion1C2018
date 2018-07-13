﻿using System;
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

        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            //centra el formulario
            this.CenterToScreen();

            cbPaises.Items.Add("Vacío");

            //carga los paises en el combo box cbPaises, extrayendolos de la tabla Pais hecha en sql;
            SqlCommand cmdBuscarPaises = new SqlCommand("SELECT nombrePais FROM [PISOS_PICADOS].Pais", Globals.conexionGlobal);

            SqlDataReader reader = cmdBuscarPaises.ExecuteReader();

            while (reader.Read())
            {
                cbPaises.Items.Add((reader["nombrePais"]).ToString());
            }

            reader.Close();

            TipoId.Items.Add("Vacío");
            TipoId.SelectedItem = "Vacío";
            cbPaises.SelectedItem = "Vacío";
            cbTipoId.SelectedItem = "Vacío";
            cmbTipoIdModif.SelectedItem = "Vacío";

            dataGridViewClientes.DataSource = cargarClientesBaja();
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewModificarCliente.DataSource = cargarClientesParaModif();
            dataGridViewModificarCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void soloTexto_KeyPress(object sender, KeyPressEventArgs e)
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
                    
                    MessageBox.Show("Usuario dado de baja correctamente");
                }
            }


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
                else { e.Handled = true;
                MessageBox.Show("Este campo solo admite números","Error",MessageBoxButtons.OK);
                }
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
            //Validaciones
            String tipoIdCliente = TipoId.Text;
            if (string.IsNullOrEmpty(nroId.Text)) {MessageBox.Show("Completar numero de id cliente"); return;}
            int nroIdCliente = int.Parse(nroId.Text);
            if (string.IsNullOrEmpty(NroCalle.Text)) {MessageBox.Show("Completar numero de calle");return;}
            int nroCalleCliente = int.Parse(NroCalle.Text);
            DateTime fechaNacimientoCliente = FechaNacimiento.Value;
            string selectDateAsString = FechaNacimiento.Value.ToString("yyyy-MM-dd");            
            
            if (Nombre.Text == "") { MessageBox.Show("Complete nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Apellido.Text == "") { MessageBox.Show("Complete apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (tipoIdCliente == "" || tipoIdCliente == "Vacío") { MessageBox.Show("Complete tipoId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (nroIdCliente < 0) { MessageBox.Show("Complete nroID correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Mail.Text == "") { MessageBox.Show("Complete mail correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!validarEmail(Mail.Text) || utilizador.estaRepetidoMail(Mail.Text)) { MessageBox.Show("mail inválido", "Error"); return; }
            if (Calle.Text == "") { MessageBox.Show("Complete calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (nroCalleCliente < 0) { MessageBox.Show("Complete nro de calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Localidad.Text == "") { MessageBox.Show("Complete localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (cbPaises.Text == "" || cbPaises.SelectedItem.ToString() == "Vacío") { MessageBox.Show("Complete país", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (Nacionalidad.Text == "") { MessageBox.Show("Complete nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (utilizador.estaRepetidoIdentificacion(nroIdCliente, tipoIdCliente))
                {
                    MessageBox.Show("Identificación Repetida");
                    return;
                }

            //comienzo del proceso de dar de alta en sí
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
            comandoAltaCliente.Parameters["@tipo"].Value = tipoIdCliente;
            comandoAltaCliente.Parameters["@numeroI"].Value = nroIdCliente;
            comandoAltaCliente.Parameters["@mail"].Value = Mail.Text;
            comandoAltaCliente.Parameters["@telefono"].Value = Telefono.Text;
            comandoAltaCliente.Parameters["@calle"].Value = Calle.Text;
            comandoAltaCliente.Parameters["@numeroC"].Value = nroCalleCliente;
            comandoAltaCliente.Parameters["@localidad"].Value = Localidad.Text;
            comandoAltaCliente.Parameters["@pais"].Value = cbPaises.Text;
            comandoAltaCliente.Parameters["@nacionalidad"].Value = Nacionalidad.Text;
            comandoAltaCliente.Parameters["@fechaNacimiento"].Value = fechaNacimientoCliente.ToString("yyyy-MM-dd");
            
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


        public DataTable cargarClientesBaja()
        {
            //esta funcion se encarga de filtrar a los clientes segun los criterios ingresados por el menu del
            // tab de dar de baja a un cliente del frmCliente y, posterior a ello, mostrarlos en una grilla que 
            //estará en dicha pantalla

            string cadenaNombre;
            string cadenaApellido;
            string cadenaTipoId;
            string cadenaNroIdentificacion;
            string cadenaMail;

            DataTable dataTableCM = new DataTable();

            if (textBoxNombre.Text == "") { cadenaNombre = "nombre LIKE '%'"; }
            else { cadenaNombre = "nombre LIKE '" + textBoxNombre.Text + "'"; };

            if (textBoxApellido.Text == "") { cadenaApellido = "apellido LIKE '%'"; }
            else { cadenaApellido = "apellido LIKE '" + textBoxApellido.Text + "'"; };

            if ( cbTipoId.SelectedItem.ToString() == "Vacío") { cadenaTipoId = "tipoIdentificacion LIKE '%'"; }
            else { cadenaTipoId = "tipoIdentificacion LIKE '" + cbTipoId.SelectedItem.ToString() + "'"; };

            if (textBoxNroId.Text == "") { cadenaNroIdentificacion = "numeroIdentificacion LIKE '%'"; }
            else { cadenaNroIdentificacion = "numeroIdentificacion LIKE '" + int.Parse(textBoxNroId.Text) + "'"; };

            if (textBoxMail.Text == "") { cadenaMail = "mail LIKE '%'"; }
            else{ cadenaMail = "mail LIKE '" + textBoxMail.Text + "'"; };


            string compuesto = " SELECT * FROM [PISOS_PICADOS].Usuario WHERE " + cadenaNombre 
                + " AND " + cadenaApellido + " AND " + cadenaTipoId + " AND " 
                + cadenaNroIdentificacion + " AND " + cadenaMail;

            
        SqlCommand comandoClientesModificado = new SqlCommand(compuesto,Globals.conexionGlobal);
        SqlDataReader readerClienteModificado = comandoClientesModificado.ExecuteReader();
            
        dataTableCM.Load(readerClienteModificado);

        return dataTableCM;
            
        }


        public void mostrarTodosLosClientes(DataGridView unDgv) {
            DataTable dtLLenadoDeClientes = new DataTable();
            String cadenaLLenadoDeClientes = "SELECT * FROM [PISOS_PICADOS].Usuario";
            SqlCommand comandoLLenadoDeClientes = new SqlCommand(cadenaLLenadoDeClientes,Globals.conexionGlobal);
            unDgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SqlDataReader readerLLenadoDeClientes = comandoLLenadoDeClientes.ExecuteReader();
            dtLLenadoDeClientes.Load(readerLLenadoDeClientes);
            unDgv.DataSource = dtLLenadoDeClientes;
        }


        public DataTable cargarClientesParaModif()
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

            if (cmbTipoIdModif.SelectedItem.ToString() == "Vacío") { cadenaTipoId = "tipoIdentificacion LIKE '%'"; }
            else { cadenaTipoId = "tipoIdentificacion LIKE '" + cmbTipoIdModif.SelectedItem.ToString() + "'"; };

            if (txtNroIdModif.Text == "") { cadenaNroIdentificacion = "numeroIdentificacion LIKE '%'"; }
            else { cadenaNroIdentificacion = "numeroIdentificacion LIKE '" + int.Parse(txtNroIdModif.Text) + "'"; };

            if (txtMailModif.Text == "") { cadenaMail = "mail LIKE '%'"; }
            else { cadenaMail = "mail LIKE '" + txtMailModif.Text + "'"; };

            String compuesto = " SELECT * FROM [PISOS_PICADOS].Usuario WHERE " + cadenaNombre
                + " AND " + cadenaApellido + " AND " + cadenaTipoId + " AND "
                + cadenaNroIdentificacion + " AND " + cadenaMail;

            DataTable dataTableCM = new DataTable();
    
            SqlCommand comandoClientesModificado = new SqlCommand(compuesto, Globals.conexionGlobal);
            SqlDataReader readerClienteModificado = comandoClientesModificado.ExecuteReader();

            dataTableCM.Load(readerClienteModificado);

            return dataTableCM;
        }

        private void btnBuscarFiltrado(object sender, EventArgs e)
        {
            //usa la funcion que muestra a los clientes en la abm de filtrado y 
            //los muestra en una grilla para luego ser seleccionado el cliente que será modificado
            recargarClientes();
        }

        public void recargarClientes() {

            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.Columns.Clear();
            dataGridViewClientes.DataSource = cargarClientesBaja();
            //dataGridViewClientes.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        
        }


        public void recargarClientesModificacion() {
            dataGridViewModificarCliente.DataSource = null;
            dataGridViewModificarCliente.Columns.Clear();
            dataGridViewModificarCliente.DataSource = cargarClientesBaja();
            //dataGridViewModificarCliente.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
            recargarClientesModificacion();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //esta funcion entra en acción cuando ya encontramos al cliente a modificar y nos permite seleccionarlo
            //en el DataGridView y conocer sus valores que aparecerán por defecto en un formulario especial para la 
            //modificacion de un cliente

            String nombreClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["nombre"].Value;
            String apellidoClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["apellido"].Value;
            String tipoIdClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["tipoIdentificacion"].Value;
            int nroIdClienteFila = (int)dataGridViewModificarCliente.CurrentRow.Cells["numeroIdentificacion"].Value; //modificado a string para poder usar el contenido
            String mailClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["mail"].Value;
            //una vez obtenido lo necesario para el form de modificación, lo construyo
            frmModificacionCliente modificacion = new frmModificacionCliente(nombreClienteFila,apellidoClienteFila,nroIdClienteFila, mailClienteFila);

           /////////****** antes de seguir obtengo id de usuario para relacionarlo con su nacionalidad que está en la tabla cliente******///////// 
            //busco el id del cliente porque lo necesitaré al buscar su nacionalidad, la cual está en la tabla Cliente 
            string a = "SELECT [PISOS_PICADOS].obtenerIDUsuario (@nombre, @apellido, @numeroIdentificacion)";

            SqlCommand getId = new SqlCommand(a, Globals.conexionGlobal);

            getId.Parameters.Add("@nombre", SqlDbType.VarChar);
            getId.Parameters["@nombre"].Value = nombreClienteFila;

            getId.Parameters.Add("@apellido", SqlDbType.VarChar);
            getId.Parameters["@apellido"].Value = apellidoClienteFila;

            getId.Parameters.Add("@numeroIdentificacion", SqlDbType.Int);
            getId.Parameters["@numeroIdentificacion"].Value = nroIdClienteFila;


            int idUsuario = (int)getId.ExecuteScalar(); //este es el id del cliente que buscabamos


            //usamos el id del cliente obtenido como parametro de la funcion de usuario hecha en sql llamada
            // obtenerNacionalidadCliente, la cual nos permite buscar nacionalidad a partir de un id de cliente
            string b = "SELECT [PISOS_PICADOS].obtenerNacionalidadCliente (@idCliente)";

            SqlCommand getNacionalidad = new SqlCommand(b,Globals.conexionGlobal);

            getNacionalidad.Parameters.Add("@idCliente",SqlDbType.Int);
            getNacionalidad.Parameters["@idCliente"].Value = idUsuario;

            String nacionalidadCliente = (String) getNacionalidad.ExecuteScalar(); //aqui es donde obtenemos la
                                                                                  //nacionalidad buscada
            
            String TelefonoClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["telefono"].FormattedValue.ToString())) {
                TelefonoClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["telefono"].Value;
                modificacion.txtTelefono.Text = TelefonoClienteFila;
            }
            
            String calleClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["calle"].Value;
            
            int NroCalleClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["nroCalle"].FormattedValue.ToString()))
            {
                NroCalleClienteFila = Convert.ToInt32(dataGridViewModificarCliente.CurrentRow.Cells["nroCalle"].Value);
                modificacion.txtNroCalle.Text = NroCalleClienteFila.ToString();
            }

            String LocalidadClienteFila;
            if (!string.IsNullOrEmpty(dataGridViewModificarCliente.CurrentRow.Cells["localidad"].FormattedValue.ToString()))
            {
                LocalidadClienteFila = (String)dataGridViewModificarCliente.CurrentRow.Cells["localidad"].Value;
                modificacion.txtLocalidad.Text = LocalidadClienteFila;
            }
            
            
            int nroPaisClienteFila = Convert.ToInt32(dataGridViewModificarCliente.CurrentRow.Cells["pais"].Value);

            String cadenaObtenerNombrePais = "SELECT [PISOS_PICADOS].obtenerNombrePais (@idPais)";

            SqlCommand cmdObtenerNombrePais = new SqlCommand(cadenaObtenerNombrePais,Globals.conexionGlobal);

            cmdObtenerNombrePais.Parameters.Add("@idPais", SqlDbType.Int);
            cmdObtenerNombrePais.Parameters["@idPais"].Value = nroPaisClienteFila;

            String nombrePais = (String) cmdObtenerNombrePais.ExecuteScalar();

            String nacionalidadClienteFila = nacionalidadCliente;
            //DateTime FechaNacimientoClienteFila = (DateTime)dataGridViewModificarCliente.CurrentRow.Cells["fechaNacimiento"].Value;
            DateTime FechaNacimientoClienteFila = (DateTime) dataGridViewModificarCliente.CurrentRow.Cells["fechaNacimiento"].Value;
           //el form de  modificacion se abrira con los valores del usuario cargados
           modificacion.txtNombre.Text = nombreClienteFila;
           modificacion.txtApellido.Text = apellidoClienteFila;
           modificacion.cbTipoId.Text = tipoIdClienteFila;
           modificacion.txtNroId.Text = nroIdClienteFila.ToString();
           modificacion.txtMail.Text = mailClienteFila;
           modificacion.cbPaises.Text = nombrePais;



           modificacion.txtCalle.Text = calleClienteFila;
           //modificacion.txtNroCalle.Text = NroCalleClienteFila.ToString();
           //modificacion.txtLocalidad.Text = LocalidadClienteFila;
           modificacion.txtNacionalidad.Text = nacionalidadClienteFila;
           //modificacion.dtpFechaNacimiento.Value = FechaNacimientoClienteFila.ToString();
           modificacion.dtpFechaNacimiento.Value = FechaNacimientoClienteFila;
            
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
                if (Char.IsDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true;
                MessageBox.Show("Este campo sólo acepta números", "Error",MessageBoxButtons.OK);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {   
            //limpiar los campos del tab altaCliente
            Nombre.ResetText();
            Apellido.ResetText();
            TipoId.SelectedItem = "Vacío";
            nroId.ResetText();
            Mail.ResetText();
            Telefono.ResetText();
            Calle.ResetText();
            NroCalle.ResetText();
            cbPaises.SelectedItem = "Vacío";
            Localidad.ResetText();
            Nacionalidad.ResetText();
            FechaNacimiento.ResetText();
        }

        private void btnLimpiarModif_Click(object sender, EventArgs e)
        {
            //limpiar los campos del tab modificarCliente
            txtNombreModif.ResetText();
            txtApellidoModif.ResetText();
            cmbTipoIdModif.SelectedItem = "Vacío";
            txtNroIdModif.ResetText();
            txtMailModif.ResetText();
        }

        private void btnLimpiartab3_Click(object sender, EventArgs e)
        {
            //limpiar los campos del tab bajaCliente
            txtNombreModif.ResetText();
            txtApellidoModif.ResetText();
            cbTipoId.SelectedItem = "Vacío";
            txtNroIdModif.ResetText();
            txtMailModif.ResetText();
        }



        
    }
}
