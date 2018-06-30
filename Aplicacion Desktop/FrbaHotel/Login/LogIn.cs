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
    public partial class LogIn : Form
    {
        public LogIn()
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
            String cadenaVerificarLogIn = "SELECT [PISOS_PICADOS].usuarioValido(@usuario, @contraseña)";
            Conexion objConexion = new Conexion();
            SqlConnection conexion = objConexion.ObtenerConexion();
            SqlCommand verificar = new SqlCommand(cadenaVerificarLogIn, conexion);
            
            String usuario = textBoxUsuario.Text;
            String contrasena = textBoxContrasena.Text;
            
            verificar.Parameters.Add("@usuario", SqlDbType.VarChar);
            verificar.Parameters.Add("@contraseña", SqlDbType.VarChar);
            verificar.Parameters["@usuario"].Value = usuario;
            verificar.Parameters["@contraseña"].Value = contrasena;

            String q = "SELECT [PISOS_PICADOS].obtenerRolEmpleado(@usuario, @contraseña)";
            SqlCommand qu = new SqlCommand(q, conexion);
            
            qu.Parameters.Add("@usuario", SqlDbType.VarChar);
            qu.Parameters.Add("@contraseña", SqlDbType.VarChar);
            qu.Parameters["@usuario"].Value = usuario;
            qu.Parameters["@contraseña"].Value = contrasena;

            
            int valor = (int) verificar.ExecuteScalar();
            int rol = (int) qu.ExecuteScalar();

            int intentosFallidos = 0;

            if (valor == 1)
            {
                intentosFallidos = 0;
                (new FrbaHotel.Form2()).asignarRol(rol);

                //Form2.Form2().ShowDialog();

                this.Close();
            }
            else {
                intentosFallidos++;
                MessageBox.Show("Usuario Inválido.");

            }

            conexion.Close();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
         //boton de salida
            this.Close();
   
        }


    }
}
