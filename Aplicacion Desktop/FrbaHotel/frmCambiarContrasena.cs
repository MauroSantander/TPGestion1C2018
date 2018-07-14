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

namespace FrbaHotel
{
    public partial class frmCambiarContrasena : Form
    {
        public frmCambiarContrasena()
        {
            InitializeComponent();
        }

        private void frmCambiarContrasena_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            //chequeos
            if (textBoxContraActual.Text == "" || textBoxNueva.Text == "" || textBoxRepetida.Text == "")
            {
                MessageBox.Show("Complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxContraActual.Text != Globals.contrasenaUsuario)
            {
                MessageBox.Show("Contraseña actual incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxNueva.Text != textBoxRepetida.Text)
            {
                MessageBox.Show("Los campos de nueva contraseña no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Creo sp actualización de contaseña
            SqlCommand cmdActualizarPass = new SqlCommand("PISOS_PICADOS.actualizarContrasena", Globals.conexionGlobal);
            cmdActualizarPass.CommandType = CommandType.StoredProcedure;

            //Agrego parámetros
            cmdActualizarPass.Parameters.AddWithValue("@idUsuario", Globals.idUsuarioSesion);
            cmdActualizarPass.Parameters.AddWithValue("@contrasena", textBoxNueva.Text);

            //Ejecuto
            cmdActualizarPass.ExecuteNonQuery();
            MessageBox.Show("Contraseña actualizada correctamente");
            this.Close();
                
        }

        private void textoYNros_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

    }
}
