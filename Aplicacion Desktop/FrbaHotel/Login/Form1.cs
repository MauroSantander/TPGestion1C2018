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

            Conexion conection = new Conexion();

            String usuario = textBoxUsuario.Text;
            String contrasena = textBoxContrasena.Text;
            
            int valor = conection.verificarUsuario(usuario, contrasena);

            if (valor == 1)
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

            this.Close();
            //boton de salida
        }


    }
}
