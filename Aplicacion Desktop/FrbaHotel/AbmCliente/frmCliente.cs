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

            int id = Convert.ToInt32(dataGridViewClientes.CurrentRow.Cells["idUsuario"].Value);

            using (SqlConnection cnn = Globals.conexionGlobal)
            {
                String cadenaBajaUsuario = "PISOS_PICADOS.bajaUsuario";

                SqlCommand comandoBajaUsuario = new SqlCommand(cadenaBajaUsuario, Globals.conexionGlobal);
                comandoBajaUsuario.CommandType = CommandType.StoredProcedure;

                comandoBajaUsuario.Parameters.AddWithValue("@id", id);
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

        public bool estaRepetidoPasaporte(int nroPasaporte)
        {
            String cadenaRepPasaporte = "SELECT [PISOS_PICADOS].estaRepetidoPasaporte (@nroPasaporte)";
            SqlCommand verificarMail = new SqlCommand(cadenaRepPasaporte, Globals.conexionGlobal);

            verificarMail.Parameters.Add("@nroPasaporte", SqlDbType.Int);
            verificarMail.Parameters["@nroPasaporte"].Value = nroPasaporte;

            int resultado = (int)verificarMail.ExecuteScalar();

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

            if (TipoIdCliente == "PASAPORTE") {
                if (estaRepetidoPasaporte(NroIdCliente))
                {
                    MessageBox.Show("Pasaporte Repetido");
                    return;
                }
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
            /*
            String consultaCliente = "SELECT * FROM [PISOS_PICADOS].Usuario ";

            //if que agrega el where 
            if (
                !String.IsNullOrEmpty(textBoxNombre.Text) || 
                !String.IsNullOrEmpty(textBoxApellido.Text) ||
                !String.IsNullOrEmpty(cbTipoId.SelectedText) ||
                !String.IsNullOrEmpty(textBoxNroId.Text) || 
                !String.IsNullOrEmpty(textBoxMail.Text)
                ) 
            
            {
                string.Concat(consultaCliente, "WHERE ");

                ///ifs para agregar lo que corresponde
                if (!String.IsNullOrEmpty(textBoxNombre.Text))
                {
                    String.Concat(consultaCliente, "nombre LIKE '%{0}%' ", textBoxNombre.Text);
                }

                if (!String.IsNullOrEmpty(textBoxApellido.Text))
                {
                    String.Concat(consultaCliente, "apellido LIKE '%{0}%' AND ", textBoxApellido.Text);
                }

                if (!String.IsNullOrEmpty(cbTipoId.SelectedText))
                {
                    String.Concat(consultaCliente, "tipoIdentificacion LIKE '%{0}%' AND ", cbTipoId.SelectedText);
                    //if (!String.IsNullOrEmpty(textBoxNroId.Text)) { string.Concat(consultaCliente, "AND "); };
                }

                if (!String.IsNullOrEmpty(textBoxNroId.Text))
                {
                    String.Concat(consultaCliente, "numeroIdentificacion LIKE '%{0}%' AND ", int.Parse(textBoxNroId.Text));
                    //if (!String.IsNullOrEmpty(textBoxNroId.Text)) { string.Concat(consultaCliente, "AND "); };
                }

                if (!String.IsNullOrEmpty(textBoxMail.Text))
                {
                    String.Concat(consultaCliente, "mail LIKE '%{0}%' ", textBoxMail.Text);
                }

            }

            Console.WriteLine(consultaCliente);

            //SqlCommand clienteFiltro = new SqlCommand(consultaCliente, Globals.conexionGlobal);

           SqlDataAdapter da = new SqlDataAdapter(consultaCliente, Globals.conexionGlobal);


           DataTable dataTable = new DataTable();
           da.Fill(dataTable);
           dgv.DataSource = dataTable;
            */
            //////////////////////////////////////////////////////////////////////////////////

            DataSet ds = new DataSet();

            SqlCommand cmd = new SqlCommand("SELECT * FROM [PISOS_PICADOS].Usuario ",Globals.conexionGlobal);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(ds,"Usuario");

            


            ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("nombre LIKE '%{0}%' ", textBoxNombre.Text);

            ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("apellido LIKE '%{0}%' ", textBoxApellido.Text);

            ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("tipoIdentificacion LIKE '%{0}%' ", cbTipoId.SelectedText);

            //ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("numeroIdentificacion LIKE %{0}% ", (int.Parse(textBoxNroId.Text)));

            //ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("numeroIdentificacion LIKE %{0}% ", textBoxNroId.Text);

            ds.Tables["Usuario"].DefaultView.RowFilter = string.Format("mail LIKE '%{0}%' ", textBoxMail.Text);

            dgv.DataSource = ds.Tables["Usuario"];

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
            /*

            Utils c = new Utils();
            DataTable dataTable = new DataTable();
            
                c.llenarDataGridView(dataGridViewClientes, "Usuario");
                DataView DV = new DataView(dataTable);

                if (!String.IsNullOrEmpty(textBoxNombre.Text))
                {
                    DV.RowFilter = string.Format("nombre LIKE '%{0}%' ", textBoxNombre.Text);
                    dataGridViewClientes.DataSource = DV;
                }
                if (!String.IsNullOrEmpty(textBoxApellido.Text))
                {
                    DV.RowFilter = string.Format("apellido LIKE '%{0}%' ", textBoxApellido.Text);
                    dataGridViewClientes.DataSource = DV;
                }
                if (!String.IsNullOrEmpty(cbTipoId.SelectedText))
                {
                    DV.RowFilter = string.Format("tipoIdentificacion LIKE '%{0}%' ", cbTipoId.SelectedText);
                    dataGridViewClientes.DataSource = DV;
                }
                if (!String.IsNullOrEmpty(textBoxNroId.Text))
                {

                    DV.RowFilter = string.Format("numeroIdentificacion LIKE %{0}% ", (int.Parse(textBoxNroId.Text)));
                    dataGridViewClientes.DataSource = DV;
                }

                if (!String.IsNullOrEmpty(textBoxMail.Text))
                {

                    DV.RowFilter = string.Format("mail LIKE '%{0}%' ", textBoxMail.Text);
                    dataGridViewClientes.DataSource = DV;
                }
*/            
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



        
    }
}
