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
        static string nombreOriginalGlobal;
        static string apellidoOriginalGlobal;
        static int nroIdOriginalGlobal;
        static string mailOriginalGlobal;
        static string paisOriginalGlobal;
        frmModificacion frmModificacionInstancia;


        public frmModificacionCliente(string nombreOriginal, string apellidoOriginal, int nroIdOriginal, string mailOriginal, string paisOriginal, frmModificacion instanciaPadre)
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

            nombreOriginalGlobal = nombreOriginal;
            apellidoOriginalGlobal = apellidoOriginal;
            nroIdOriginalGlobal = nroIdOriginal;
            mailOriginalGlobal = mailOriginal;
            frmModificacionInstancia = instanciaPadre;
            paisOriginalGlobal = paisOriginal;

        }

        private void frmModificacionCliente_Load(object sender, EventArgs e)
        {
            //centra el formulario
            this.CenterToScreen();

            txtNombre.Text = nombreOriginalGlobal;
            txtApellido.Text = apellidoOriginalGlobal;
            txtNroId.Text = nroIdOriginalGlobal.ToString();
            cbPaises.SelectedItem = paisOriginalGlobal;
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
            //Validaciones
            int verificacion = 1;

            string selectDateAsString = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd");

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe completar el campo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Debe completar el campo apellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            String tipoIdCliente = cbTipoId.Text;
            if (tipoIdCliente == "" || tipoIdCliente == "Vacío")
            {
                MessageBox.Show("Seleccione el tipo de identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (txtNroId.Text == "")
            {
                MessageBox.Show("Debe completar el número de identificación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (txtMail.Text == "")
            {
                MessageBox.Show("Debe insertar un mail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }
            else
            {
                if (!validarEmail(txtMail.Text))
                {
                    MessageBox.Show("El mail es inválido.", "Error");
                    verificacion = 0;
                }
            }

            if (txtMail.Text != mailOriginalGlobal)
            {
                if (c.estaRepetidoMail(txtMail.Text))
                {
                    MessageBox.Show("El mail está repetido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    verificacion = 0;
                }
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Debe insertar un telefono.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (cbPaises.Text == "" || cbPaises.SelectedItem.ToString() == "Vacío")
            {
                MessageBox.Show("Debe seleccionar un país.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (txtLocalidad.Text == "")
            {
                MessageBox.Show("Debe insertar una localidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (txtCalle.Text == "")
            {
                MessageBox.Show("Debe insertar una calle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (txtNacionalidad.Text == "")
            {
                MessageBox.Show("Debe insertar una nacionalidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            string TipoIdCliente = "";
            int NroIdCliente = 0;

            if (cbTipoId.Text != "" && cbTipoId.Text != "Vacío" && txtNroId.Text != "")
            {
                TipoIdCliente = cbTipoId.Text;
                NroIdCliente = int.Parse(txtNroId.Text);

                if (NroIdCliente != nroIdOriginalGlobal && c.estaRepetidoIdentificacion(NroIdCliente, TipoIdCliente))
                {
                    MessageBox.Show("Identificación repetida");
                    verificacion = 0;
                }
            }

            if (verificacion == 0)
            {
                return;
            }

            int nroCalleCliente = int.Parse(txtNroCalle.Text);
            int nroIdCliente = int.Parse(txtNroId.Text);

            string TelefonoCliente = txtTelefono.Text;
            string CalleCliente = txtCalle.Text;
            int NroCalleCliente = int.Parse(txtNroCalle.Text);
            
            //En esta secccion se busca obtener el estado del cliente
            //Primero obtenemos su id con el objetivo de usarlo para buscar en la BD
            
            int idCliente = c.obtenerIdUsuario(nombreOriginalGlobal, apellidoOriginalGlobal, Convert.ToInt32(txtNroId.Text));
            
            //Luego de obtener su id, lo usamos como parámetro del sp que devuelve el estado de un cliente a partir
            //de su id
            
            int estadoCliente = c.obtenerEstadoCliente(idCliente);
            
            //comienza la seccion que utiliza el sp de modificar un usuario en la BD
            //Comienzo de la modificación en sí
            
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
            cmdModificacion.Parameters["@fechaNacimiento"].Value = dtpFechaNacimiento.Value;
            cmdModificacion.Parameters["@estado"].Value = estadoCliente;

            cmdModificacion.ExecuteNonQuery();
            MessageBox.Show("Modificación realizada","Aceptar",MessageBoxButtons.OK);

            frmModificacionInstancia.recargarClientes();
            this.Close();

        }

        private void btnCancelarModif2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaLetras(txtNombre, sender, e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaLetras(txtApellido, sender, e);
        }

        private void txtNroId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(txtNroId, sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(txtTelefono, sender, e);
        }

        private void txtNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(txtNroCalle, sender, e);
        }

        private void txtNacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaLetras(txtNacionalidad, sender, e);
        }

        private void textosYespacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; MessageBox.Show("Este campo solo acepta letras y espacios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

    }
}
            
           