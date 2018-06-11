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


namespace FrbaHotel.AbmCliente
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


        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BotonModifVerClientes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {

        }

        private void BotonVerClientes_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Alta_Click(object sender, EventArgs e)
        {

        }

        private void TipoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nroId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void FechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            SqlCommand comandoAlta = new SqlCommand(String.Format("INSERT INTO PISOS_PICADOS.Cliente VALUES (/*completar con todos los datos*/)"));
            /////////////////////////////
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelApellido_Click(object sender, EventArgs e)
        {

        }

        private void labelNroId_Click(object sender, EventArgs e)
        {

        }

        private void labelMail_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefono_Click(object sender, EventArgs e)
        {

        }

        private void labelDireccion_Click(object sender, EventArgs e)
        {

        }

        private void labelNacionalidad_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaNac_Click(object sender, EventArgs e)
        {

        }
    }
}
