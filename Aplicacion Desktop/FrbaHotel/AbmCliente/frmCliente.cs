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

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {

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
           
            Conexion c = new Conexion();

            c.mostrarClientes(dataGridView2);
               
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {

            String NombreCliente = (String)dataGridViewClientes.CurrentRow.Cells["nombre"].Value;
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

        }

        private void BotonVerClientes_Click(object sender, EventArgs e)
        {

            Conexion c = new Conexion();

            c.mostrarClientes(dataGridViewClientes);
            
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

            if (NombreCliente == ""){MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            if (ApellidoCliente == "") { MessageBox.Show("Completar apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (TipoIdCliente == "") { MessageBox.Show("Completar tipoId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (NroIdCliente < 0) { MessageBox.Show("Completar nroID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (MailCliente == "") { MessageBox.Show("Completar mail correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (!validarEmail(Mail.Text)) { MessageBox.Show("Error en el mail"); }
            if (CalleCliente == "") { MessageBox.Show("Completar calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (NroCalleCliente <0) { MessageBox.Show("Completar nro de calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (LocalidadCliente == "") { MessageBox.Show("Completar localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (cbPaises.SelectedValue == null) { MessageBox.Show("Completar país", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (NacionalidadCliente == "") { MessageBox.Show("Completar nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

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
            comandoAltaCliente.Parameters["@pais"].Value = Convert.ToString(cbPaises.SelectedValue);
            comandoAltaCliente.Parameters["@nacionalidad"].Value = NacionalidadCliente;
            comandoAltaCliente.Parameters["@fechaNacimiento"].Value = FechaNacimientoCliente.ToString("yyyy-MM-dd");
            
            
            //comandoAltaCliente.ExecuteNonQuery();
            comandoAltaCliente.ExecuteReader().Close();
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

            //con.Close();
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
        
    }
}
