using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Mail;


namespace FrbaHotel.AbmCliente
{
    public partial class frmModificacionCliente : Form
    {

        Utils c = new Utils();

        public frmModificacionCliente()
        {
            InitializeComponent();

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



        private void btnAceptarModif(object sender, EventArgs e)
        {

            String NombreCliente = txtNombre.Text;
            String ApellidoCliente = txtApellido.Text;
            String TipoIdCliente = cbTipoId.Text;

            if (string.IsNullOrEmpty(txtNroId.Text)) { MessageBox.Show("Completar numero de id cliente"); return; }

            int NroIdCliente = int.Parse(txtNroId.Text);
            String MailCliente = txtMail.Text; //usar la clase Mail para chequeos
            String TelefonoCliente = txtTelefono.Text;
            String CalleCliente = txtCalle.Text;

            if (string.IsNullOrEmpty(txtNroCalle.Text)) { MessageBox.Show("Completar numero de calle"); return; }

            int NroCalleCliente = int.Parse(txtNroCalle.Text);
            String LocalidadCliente = txtLocalidad.Text;

            String NacionalidadCliente = txtNacionalidad.Text;

            DateTime FechaNacimientoCliente = dtpFechaNacimiento.Value;

            string selectDateAsString = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");

            string fObtenerId = "SELECT [PISOS_PICADOS].obtenerIDUsuario (@nombre, @apellido, @numeroIdentificacion)";

            SqlCommand getId = new SqlCommand(fObtenerId, Globals.conexionGlobal);

            int idUsuario = (int)getId.ExecuteScalar();

            //chequeos

            if (NombreCliente == "") { MessageBox.Show("Complete nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (ApellidoCliente == "") { MessageBox.Show("Complete apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (TipoIdCliente == "") { MessageBox.Show("Complete tipoId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroIdCliente < 0) { MessageBox.Show("Complete nroID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (MailCliente == "") { MessageBox.Show("Complete mail correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!validarEmail(MailCliente) || c.estaRepetidoMail(MailCliente)) { MessageBox.Show("Error en el mail", "Error"); return; }
            if (CalleCliente == "") { MessageBox.Show("Complete calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroCalleCliente < 0) { MessageBox.Show("Complete nro de calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (LocalidadCliente == "") { MessageBox.Show("Complete localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (cbPaises.Text == "") { MessageBox.Show("Complete país", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NacionalidadCliente == "") { MessageBox.Show("Complete nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (c.estaRepetidoIdentificacion(NroIdCliente, TipoIdCliente))
            {
                MessageBox.Show("Identificación Repetida");
                return;
            }

            String cadenaObtenerEstado = "SELECT [PISOS_PICADOS].obtenerEstadoUsuario (@idUsuario)";

            SqlCommand obtenerEstado = new SqlCommand(cadenaObtenerEstado,Globals.conexionGlobal);

            obtenerEstado.Parameters.Add("@idUsuario", SqlDbType.Int);
            obtenerEstado.Parameters["@idUsuario"].Value = idUsuario;

            int estadoCliente = (int)obtenerEstado.ExecuteScalar();

            String cadenaProcedureModif = "[PISOS_PICADOS].SPModificarCliente";

            SqlCommand cmd = new SqlCommand(cadenaProcedureModif,Globals.conexionGlobal);

            //parametros
            cmd.Parameters.Add("@idUsuario", SqlDbType.VarChar);
            cmd.Parameters.Add("@nombre",SqlDbType.VarChar);
            cmd.Parameters.Add("@apellido", SqlDbType.VarChar);
            cmd.Parameters.Add("@tipo", SqlDbType.VarChar);
            cmd.Parameters.Add("@numeroI", SqlDbType.Int);
            cmd.Parameters.Add("@mail", SqlDbType.VarChar);
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar);
            cmd.Parameters.Add("@calle", SqlDbType.VarChar);
            cmd.Parameters.Add("@numeroC", SqlDbType.Int);
            cmd.Parameters.Add("@localidad", SqlDbType.VarChar);
            cmd.Parameters.Add("@pais", SqlDbType.VarChar);
            cmd.Parameters.Add("@nacionalidad", SqlDbType.VarChar);
            cmd.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
            cmd.Parameters.Add("@estado", SqlDbType.Int);


            //valores de los parametros
            cmd.Parameters["@idUsuario"].Value = idUsuario;
            cmd.Parameters["@nombre"].Value = NombreCliente;
            cmd.Parameters["@apellido"].Value = ApellidoCliente;
            cmd.Parameters["@tipo"].Value = TipoIdCliente;
            cmd.Parameters["@numeroI"].Value = NroIdCliente;
            cmd.Parameters["@mail"].Value = MailCliente;
            cmd.Parameters["@telefono"].Value = TelefonoCliente;
            cmd.Parameters["@calle"].Value = CalleCliente;
            cmd.Parameters["@numeroC"].Value = int.Parse(txtCalle.Text);
            cmd.Parameters["@localidad"].Value = LocalidadCliente;
            cmd.Parameters["@pais"].Value = cbPaises.Text;
            cmd.Parameters["@nacionalidad"].Value = NacionalidadCliente;
            cmd.Parameters["@fechaNacimiento"].Value = dtpFechaNacimiento.Value; //ver porque es DATE
            cmd.Parameters["@estado"].Value = estadoCliente;
          
        }

        private void btnCancelarModif2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
