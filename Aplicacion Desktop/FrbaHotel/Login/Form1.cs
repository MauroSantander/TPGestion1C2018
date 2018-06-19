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

            SqlConnection conexion = new SqlConnection("server=LENOVO-PC\\SQLSERVER2012; database=GD1C2018;integrated security = true;");

            String usuario = textBoxUsuario.Text;
            String contrasena = textBoxContrasena.Text;

            conexion.Open();

            SqlCommand verificar = new SqlCommand("SELECT usuario FROM [PISOS_PICADOS].Empleado WHERE usuario=@usuario AND contraseña=@contrasena ", conexion);
            verificar.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            verificar.Parameters.Add("@contrasena", SqlDbType.VarChar).Value = contrasena;

            SqlDataReader dr = verificar.ExecuteReader();

            int rows = 0;

            if (dr.HasRows)
                while (dr.Read())
                    rows++;

            conexion.Close();
            
            if (rows > 0)
            {
                (new FrbaHotel.AbmCliente.Form1()).ShowDialog();
            }
            else
            {
                MessageBox.Show("usuario no valido");
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
         //boton de salida
            this.Close();
   
        }


    }
}
