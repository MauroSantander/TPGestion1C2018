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
    public partial class Form1 : Form
    {
        public Form1()
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
            //boton de inicio de sesion
            
            String cadenaVerificarLogIn = "SELECT [PISOS_PICADOS].usuarioValido(@usuario, @contraseña)";
            SqlConnection conexion = new SqlConnection("server=LENOVO-PC\\SQLSERVER2012; database=GD1C2018;integrated security = true;");
            conexion.Open();
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

            if (valor == 1)
            {

                (new FrbaHotel.Form2()).asignarRol(rol);

                //Form2.Form2().ShowDialog();

                this.Close();
            }
            else {
                MessageBox.Show("Usuario Inválido");
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
