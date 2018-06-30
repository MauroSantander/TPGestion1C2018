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

namespace FrbaHotel.Login
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged_1(object sender, EventArgs e)
        {
            //box de usuario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //box de password
        }


         private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {            

            SqlCommand verificarUsuario = new SqlCommand("SELECT [PISOS_PICADOS].usuarioValido(@usuario, @contraseña)", Globals.conexionGlobal);

            verificarUsuario.Parameters.Add("@usuario", SqlDbType.VarChar);
            verificarUsuario.Parameters.Add("@contraseña", SqlDbType.VarChar);
            verificarUsuario.Parameters["@usuario"].Value = textBoxUsuario.Text;
            verificarUsuario.Parameters["@contraseña"].Value = textBoxContrasena.Text;
            
            int respuestaVerificacionUsuario = (int) verificarUsuario.ExecuteScalar();

            int intentosFallidos = 0;

            if (respuestaVerificacionUsuario == 1)
            {
                intentosFallidos = 0;
                frmElegirRol frmElegirRol = new frmElegirRol(textBoxUsuario.Text);
                frmElegirRol.ShowDialog();
                this.Close();
            }
            else {
                intentosFallidos++;
                MessageBox.Show("Usuario Inválido.");
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresarInvitado_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.frmMenu()).asignarRol(3);
        }


    }
}
