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



        public frmCliente()
        {
            InitializeComponent();

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
            this.CenterToScreen();
        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }


        private void Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void BotonModifVerClientes_Click(object sender, EventArgs e)
        {
           
            Utils c = new Utils();

            //c.mostrarClientes(dataGridView2);
               
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {

            /*String NombreCliente = (String)dataGridViewClientes.CurrentRow.Cells["nombre"].Value;
            String ApellidoCliente = (String)dataGridViewClientes.CurrentRow.Cells["apellido"].Value;
            String TipoIdCliente = (String)dataGridViewClientes.CurrentRow.Cells["tipoIdentificacion"].Value;
            int NroIdCliente = (int)dataGridViewClientes.CurrentRow.Cells["numeroIdentificacion"].Value;
            String MailCliente = (String)dataGridViewClientes.CurrentRow.Cells["mail"].Value; ;
            String TelefonoCliente = (String)dataGridViewClientes.CurrentRow.Cells["telefono"].Value;
            String CalleCliente = (String)dataGridViewClientes.CurrentRow.Cells["calle"].Value;
            int NroCalleCliente = (int)dataGridViewClientes.CurrentRow.Cells["nroCalle"].Value; ;
            String LocalidadCliente = (String)dataGridViewClientes.CurrentRow.Cells["localidad"].Value;
            String PaisCliente = (String)dataGridViewClientes.CurrentRow.Cells["pais"].Value;
            String NacionalidadCliente = (String)dataGridViewClientes.CurrentRow.Cells["nacionalidad"].Value;
            */
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

                String cadenaBajaUsuario = "PISOS_PICADOS.bajaUsuario @idUsuario";

                SqlCommand comandoBajaUsuario = new SqlCommand(cadenaBajaUsuario, Globals.conexionGlobal);
                comandoBajaUsuario.CommandType = CommandType.StoredProcedure;


                comandoBajaUsuario.Parameters.Add("@idUsuario", SqlDbType.Int);
                comandoBajaUsuario.Parameters["@idUsuario"].Value = idUsuario;

                comandoBajaUsuario.ExecuteReader().Close();
                MessageBox.Show("Usuario eliminado correctamente");

            }

            dataGridViewClientes.Rows.Remove(dataGridViewClientes.CurrentRow);


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

        public bool estaRepetidoMail(String mail) 
        {

            String cadenaRepMail = "SELECT [PISOS_PICADOS].estaRepetidoMail (@mail)";
            SqlCommand verificarMail = new SqlCommand(cadenaRepMail,Globals.conexionGlobal);

            verificarMail.Parameters.Add("@mail",SqlDbType.VarChar);
            verificarMail.Parameters["@mail"].Value = mail;

            int resultado = (int)verificarMail.ExecuteScalar();

            if (resultado == 1) { return true; }
            else { return false; }
        }

        public bool estaRepetidoIdentificacion(int nroPasaporte, String tipoIdentificacion)
        {
            String cadenaRepPasaporte = "SELECT [PISOS_PICADOS].estaRepetido (@nroPasaporte)";
            SqlCommand verificarIdentificacion = new SqlCommand(cadenaRepPasaporte, Globals.conexionGlobal);

            verificarIdentificacion.Parameters.Add("@tipo",SqlDbType.VarChar);
            verificarIdentificacion.Parameters["@tipo"].Value = tipoIdentificacion;

            verificarIdentificacion.Parameters.Add("@numero", SqlDbType.Int);
            verificarIdentificacion.Parameters["@numero"].Value = nroPasaporte;

            int resultado = (int)verificarIdentificacion.ExecuteScalar();

            if (resultado == 1) { return true; }
            else { return false; }
        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            Utils utilizador = new Utils();

            String NombreCliente = Nombre.Text;
            String ApellidoCliente = Apellido.Text;
            String TipoIdCliente = TipoId.Text;

            if (string.IsNullOrEmpty(nroId.Text)) {MessageBox.Show("Completar numero de id cliente"); return;}
            
            int NroIdCliente = int.Parse(nroId.Text);
            String MailCliente = Mail.Text; //usar la clase Mail para chequeos
            String TelefonoCliente = Telefono.Text;
            String CalleCliente = Calle.Text;

            if (string.IsNullOrEmpty(NroCalle.Text)) {MessageBox.Show("Completar numero de calle");return;}

            int NroCalleCliente = int.Parse(NroCalle.Text);
            String LocalidadCliente = Localidad.Text;

            String NacionalidadCliente = Nacionalidad.Text;
            
            DateTime FechaNacimientoCliente = FechaNacimiento.Value;
        
            string selectDateAsString = FechaNacimiento.Value.ToString("yyyy-MM-dd");

            if (NombreCliente == "") { MessageBox.Show("Complete nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (ApellidoCliente == "") { MessageBox.Show("Complete apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (TipoIdCliente == "") { MessageBox.Show("Complete tipoId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroIdCliente < 0) { MessageBox.Show("Complete nroID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (MailCliente == "") { MessageBox.Show("Complete mail correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!validarEmail(Mail.Text) || estaRepetidoMail(Mail.Text)) { MessageBox.Show("Error en el mail", "Error"); return; }
            if (CalleCliente == "") { MessageBox.Show("Complete calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroCalleCliente < 0) { MessageBox.Show("Complete nro de calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (LocalidadCliente == "") { MessageBox.Show("Complete localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (cbPaises.Text == "") { MessageBox.Show("Complete país", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NacionalidadCliente == "") { MessageBox.Show("Complete nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                if (estaRepetidoIdentificacion(NroIdCliente, TipoIdCliente))
                {
                    MessageBox.Show("Identificación Repetida");
                    return;
                }

            String cadenaAltaCliente = "PISOS_PICADOS.SPAltaCliente";
            
            SqlCommand comandoAltaCliente = new SqlCommand(cadenaAltaCliente, Globals.conexionGlobal);
            comandoAltaCliente.CommandType = CommandType.StoredProcedure;
            
            //agregar parametros
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
            
            //cargar valores
            comandoAltaCliente.Parameters["@nombre"].Value = NombreCliente;
            comandoAltaCliente.Parameters["@apellido"].Value = ApellidoCliente;
            comandoAltaCliente.Parameters["@tipo"].Value = TipoIdCliente;
            comandoAltaCliente.Parameters["@numeroI"].Value = NroIdCliente;
            comandoAltaCliente.Parameters["@mail"].Value = MailCliente;
            comandoAltaCliente.Parameters["@telefono"].Value = TelefonoCliente;
            comandoAltaCliente.Parameters["@calle"].Value = CalleCliente;
            comandoAltaCliente.Parameters["@numeroC"].Value = NroCalleCliente;
            comandoAltaCliente.Parameters["@localidad"].Value = LocalidadCliente;
            
         //   int idPais = utilizador.obtenerIdPais(cbPaises.Text);
            
            comandoAltaCliente.Parameters["@pais"].Value = cbPaises.Text;
            comandoAltaCliente.Parameters["@nacionalidad"].Value = NacionalidadCliente;
            comandoAltaCliente.Parameters["@fechaNacimiento"].Value = FechaNacimientoCliente.ToString("yyyy-MM-dd");
            
            //comandoAltaCliente.ExecuteReader().Close();
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

       /* private void btnBuscarUserName_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Utils utilizador = new Utils();
            
            utilizador.mostrarClientes(dataGridViewClientes);
            DataView DV = new DataView(dt);
            if (!String.IsNullOrEmpty(textBoxUsrNameBorrar.Text))
            {
                DV.RowFilter = string.Format("nombre LIKE '%{0}%' ", textBoxUsrNameBorrar.Text);
                dataGridViewClientes.DataSource = DV;
            }
            else { MessageBox.Show("Completar Username"); return; }
        }*/

        private void cbTipoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nroIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }


        public void mostrarClientesFiltrado(DataGridView dgv)
        {
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
//            else
//            {
/*                if (validarEmail(textBoxMail.Text))*/ { cadenaMail = "mail LIKE '" + textBoxMail.Text + "'"; };
 //           }

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

            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [PISOS_PICADOS].Usuario ", Globals.conexionGlobal);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds, "Usuario");

           

            ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("nombre LIKE '%{0}%' ", txtNombreModif.Text);

            ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("apellido LIKE '%{0}%' ", txtApellidoModif.Text);

            ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("tipoIdentificacion LIKE '%{0}%' ", cmbTipoIdModif.SelectedText);

            //ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("numeroIdentificacion LIKE %{0}% ", (int.Parse(txtNroIdModif.Text)));

            //ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("numeroIdentificacion LIKE %{0}% ", txtNroIdModif.Text);

            ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("mail LIKE '%{0}%' ", txtMailModif.Text);

             dgv.DataSource = ds.Tables["Usuario"];

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }




        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            //Utils utilizador = new Utils();

            mostrarClientesFiltrado(dataGridViewClientes);
            DataView DV = new DataView(dt);
           // if (String.IsNullOrEmpty(cbTipoId.SelectedText)) { MessageBox.Show("Seleccionar Tipo"); return; }
           // if (String.IsNullOrEmpty(textBoxNroId.Text)) { MessageBox.Show("Completar Número Identificación"); return; }

            DV.RowFilter = string.Format("numeroIdentificacion LIKE '%{0}%' ", textBoxNroId.Text);
            DV.RowFilter = string.Format("tipoIdentificacion LIKE '%{0}%' ", cbTipoId.SelectedText);
            dataGridViewClientes.DataSource = DV;
        }

        private void btnBuscarFiltrado(object sender, EventArgs e)
        {
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
            mostrarClientesFiltradoParaModif(dataGridViewModificarCliente);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            frmModificacionCliente modificacion = new frmModificacionCliente(); //fijarme si paso por parametro el formulario que lo invoca para los datos necesarios
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
                else { e.Handled = true; }
            }
        }



        
    }
}
