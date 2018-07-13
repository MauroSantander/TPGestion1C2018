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
            this.textBoxContraActual.Text = Globals.contrasenaUsuario;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            if (textBoxNueva.Text != "")
            {
                //PASO CHEQUEOS
                DialogResult result = MessageBox.Show("Su contraseña sera actualizada a:  ´"+textBoxNueva.Text+"´  . ¿Quiere confirmar el cambio?", "Confirmación de cambio", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SqlCommand comandoBajaHotel = new SqlCommand("PISOS_PICADOS.actualizarContrasena", Globals.conexionGlobal);
                    comandoBajaHotel.CommandType = CommandType.StoredProcedure;

                    comandoBajaHotel.Parameters.AddWithValue("@idUsuario", Globals.idUsuarioSesion);
                    comandoBajaHotel.Parameters.AddWithValue("@contrasena", textBoxNueva.Text);

                    comandoBajaHotel.ExecuteNonQuery();
                    MessageBox.Show("Contraseña actualizada correctamente");
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    textBoxNueva.Text = "";
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Escriba una nueva contraseña");
            }
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
