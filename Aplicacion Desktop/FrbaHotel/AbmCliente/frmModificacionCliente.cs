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

        //son los valores que voy a necesitar en la funcion de obtener idUsuario
        static String nombreOriginalGlobal;
        static String apellidoOriginalGlobal;
        static int nroIdOriginalGlobal;



        public frmModificacionCliente(String nombreOriginal, String apellidoOriginal, int nroIdOriginal)
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

            txtNombre.Text = nombreOriginal;
            txtApellido.Text = apellidoOriginal;
            txtNroId.Text = nroIdOriginal.ToString();

            nombreOriginalGlobal = nombreOriginal;
            apellidoOriginalGlobal = apellidoOriginal;
            nroIdOriginalGlobal = nroIdOriginal;

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
            //Comienzo de la modificación en sí
            
            //Validaciones
            String TipoIdCliente = cbTipoId.Text;
            if (string.IsNullOrEmpty(txtNroId.Text)) { MessageBox.Show("Completar numero de id cliente"); return; }
            int NroIdCliente = int.Parse(txtNroId.Text);
            String TelefonoCliente = txtTelefono.Text;
            String CalleCliente = txtCalle.Text;
            if (string.IsNullOrEmpty(txtNroCalle.Text)) { MessageBox.Show("Completar numero de calle"); return; }
            int NroCalleCliente = int.Parse(txtNroCalle.Text);
            DateTime FechaNacimientoCliente = dtpFechaNacimiento.Value;            
            string selectDateAsString = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");

            
            if (txtNombre.Text == "") { MessageBox.Show("Complete nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtApellido.Text == "") { MessageBox.Show("Complete apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (TipoIdCliente == "") { MessageBox.Show("Complete tipoId", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroIdCliente < 0) { MessageBox.Show("Complete nroID correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (txtMail.Text == "") { MessageBox.Show("Complete mail correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            //if (!validarEmail(txtMail.Text) || c.estaRepetidoMail(txtMail.Text)) { MessageBox.Show("Error en el mail", "Error"); return; }
            if (!validarEmail(txtMail.Text)) { MessageBox.Show("Mail inválido", "Error"); return; }
            if (txtCalle.Text == "") { MessageBox.Show("Complete calle", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (NroCalleCliente < 0) { MessageBox.Show("Complete nro de calle correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
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
            //Primero obtenemos su id con el objetivo de usarlo para buscar en la BD
            
            int idCliente = c.obtenerIdUsuario(nombreOriginalGlobal, apellidoOriginalGlobal, Convert.ToInt32(txtNroId.Text));
            //Luego de obtener su id, lo usamos como parámetro del sp que devuelve el estado de un cliente a partir
            //de su id

            int estadoCliente = c.obtenerEstadoCliente(idCliente);
            
            //comienza la seccion que utiliza el sp de modificar un usuario en la BD
            String cadenaProcedureModif = "[PISOS_PICADOS].SPModificarCliente";

            SqlCommand cmdModificacion = new SqlCommand(cadenaProcedureModif,Globals.conexionGlobal);

            cmdModificacion.CommandType = CommandType.StoredProcedure;

            //parametros
            cmdModificacion.Parameters.Add("@idUsuario", SqlDbType.Int);
            cmdModificacion.Parameters.Add("@nombre",SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@apellido", SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@tipo", SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@numeroI", SqlDbType.Int);
            cmdModificacion.Parameters.Add("@mail", SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@telefono", SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@calle", SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@numeroC", SqlDbType.Int);
            cmdModificacion.Parameters.Add("@localidad", SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@pais", SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@nacionalidad", SqlDbType.VarChar);
            cmdModificacion.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
            cmdModificacion.Parameters.Add("@estado", SqlDbType.Int);

            //valores de los parametros
            cmdModificacion.Parameters["@idUsuario"].Value = idCliente;
            cmdModificacion.Parameters["@nombre"].Value = txtNombre.Text;
            cmdModificacion.Parameters["@apellido"].Value = txtApellido.Text;
            cmdModificacion.Parameters["@tipo"].Value = TipoIdCliente;
            cmdModificacion.Parameters["@numeroI"].Value = NroIdCliente;
            cmdModificacion.Parameters["@mail"].Value = txtMail.Text;
            cmdModificacion.Parameters["@telefono"].Value = TelefonoCliente;
            cmdModificacion.Parameters["@calle"].Value = CalleCliente;
            cmdModificacion.Parameters["@numeroC"].Value = NroCalleCliente;
            cmdModificacion.Parameters["@localidad"].Value = txtLocalidad.Text;
            cmdModificacion.Parameters["@pais"].Value = cbPaises.Text;
            cmdModificacion.Parameters["@nacionalidad"].Value = txtNacionalidad.Text;
            cmdModificacion.Parameters["@fechaNacimiento"].Value = dtpFechaNacimiento.Value; //ver porque es DATE
            cmdModificacion.Parameters["@estado"].Value = estadoCliente;

            cmdModificacion.ExecuteNonQuery();

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


        //Ambos KeyPress a continuación corroboran en tiempo real que el usuario no ingrese caracteres incorrectos
        private void soloTexto_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo sólo acepta letras", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void soloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Este campo solo admite números", "Error", MessageBoxButtons.OK);
                }
            }
        }




    }
}
