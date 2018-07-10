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

            //Cargar paises en el comboBox cbPaises
            SqlCommand cmdBuscarPaises = new SqlCommand("SELECT nombrePais FROM [PISOS_PICADOS].Pais", Globals.conexionGlobal);

            SqlDataReader reader = cmdBuscarPaises.ExecuteReader();

            while (reader.Read())
            {
                cbPaises.Items.Add((reader["nombrePais"]).ToString());
            }

            reader.Close();

        }

        private void frmModificacionCliente_Load(object sender, EventArgs e)
        {
            this.CenterToScreen(); //centra el Formulario
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
            String TipoIdCliente = cbTipoId.Text;
            if (string.IsNullOrEmpty(txtNroId.Text)) { MessageBox.Show("Completar numero de id cliente"); return; }
            int NroIdCliente = int.Parse(txtNroId.Text);
            String TelefonoCliente = txtTelefono.Text;
            String CalleCliente = txtCalle.Text;

            if (string.IsNullOrEmpty(txtNroCalle.Text)) { MessageBox.Show("Completar numero de calle"); return; }

            int NroCalleCliente = int.Parse(txtNroCalle.Text);
            
            DateTime FechaNacimientoCliente = dtpFechaNacimiento.Value;
            
            string selectDateAsString = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");

            //Validaciones
            if (txtNombre.Text == "") { MessageBox.Show("Complete nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtApellido.Text == "") { MessageBox.Show("Complete apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (TipoIdCliente == "") { MessageBox.Show("Complete tipoId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            //if (NroIdCliente < 0) { MessageBox.Show("Complete nroID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            //if (txtMail.Text == "") { MessageBox.Show("Complete mail correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (!validarEmail(txtMail.Text) || c.estaRepetidoMail(txtMail.Text)) { MessageBox.Show("Error en el mail", "Error"); return; }
            if (txtCalle.Text == "") { MessageBox.Show("Complete calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroCalleCliente < 0) { MessageBox.Show("Complete nro de calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtLocalidad.Text == "") { MessageBox.Show("Complete localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (cbPaises.Text == "") { MessageBox.Show("Complete país", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtNacionalidad.Text == "") { MessageBox.Show("Complete nacionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            /*
            if (c.estaRepetidoIdentificacion(NroIdCliente, TipoIdCliente))
            {
                MessageBox.Show("Identificación Repetida");
                return;
            }
            */

            //En esta secccion se busca obtener el estado del cliente
            //Primero obtenemos su id con el objeto de usarlo para buscar en la BD
            string fObtenerId = "SELECT [PISOS_PICADOS].obtenerIDUsuario (@nombre, @apellido, @numeroIdentificacion)";
            SqlCommand obtenerId = new SqlCommand(fObtenerId, Globals.conexionGlobal);
            obtenerId.Parameters.Add("@nombre", SqlDbType.VarChar);
            obtenerId.Parameters.Add("@apellido", SqlDbType.VarChar);
            obtenerId.Parameters.Add("@numeroIdentificacion", SqlDbType.Int);

            obtenerId.Parameters["@nombre"].Value = txtNombre.Text;
            obtenerId.Parameters["@apellido"].Value = txtApellido.Text;
            obtenerId.Parameters["@numeroIdentificacion"].Value = int.Parse(txtNroId.Text);

            int idUsuario = (int) obtenerId.ExecuteScalar();  //aca es donde falla porque viene con Null
            //Luego de obtener su id, lo usamos como parámetro del sp que devuelve el estado de un cliente a partir
            //de su id

            String cadenaObtenerEstado = "SELECT [PISOS_PICADOS].obtenerEstadoUsuario (@idUsuario)";

            SqlCommand obtenerEstado = new SqlCommand(cadenaObtenerEstado,Globals.conexionGlobal);

            obtenerEstado.Parameters.Add("@idUsuario", SqlDbType.Int);
            obtenerEstado.Parameters["@idUsuario"].Value = idUsuario;

            int estadoCliente = (int) obtenerEstado.ExecuteScalar();
            //fin seccion para obtener el estado del cliente

            //comienza la seccion que utiliza el sp de modificar un usuario en la BD
            String cadenaProcedureModif = "[PISOS_PICADOS].SPModificarCliente";

            SqlCommand cmd = new SqlCommand(cadenaProcedureModif,Globals.conexionGlobal);

            //parametros
            cmd.Parameters.Add("@idUsuario", SqlDbType.Int);
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
            cmd.Parameters["@nombre"].Value = txtNombre.Text;
            cmd.Parameters["@apellido"].Value = txtApellido.Text;
            cmd.Parameters["@tipo"].Value = TipoIdCliente;
            cmd.Parameters["@numeroI"].Value = NroIdCliente;
            cmd.Parameters["@mail"].Value = txtMail.Text;
            cmd.Parameters["@telefono"].Value = TelefonoCliente;
            cmd.Parameters["@calle"].Value = CalleCliente;
            cmd.Parameters["@numeroC"].Value = NroCalleCliente;
            cmd.Parameters["@localidad"].Value = txtLocalidad.Text;
            cmd.Parameters["@pais"].Value = cbPaises.Text;
            cmd.Parameters["@nacionalidad"].Value = txtNacionalidad.Text;
            cmd.Parameters["@fechaNacimiento"].Value = dtpFechaNacimiento.Value; //ver porque es DATE
            cmd.Parameters["@estado"].Value = estadoCliente;

            cmd.ExecuteNonQuery();

            MessageBox.Show("Modificación realizada","Aceptar",MessageBoxButtons.OK);

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

        private void cbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
