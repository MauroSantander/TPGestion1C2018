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

namespace FrbaHotel.AbmRol
{
    public partial class frmABMRol : Form
    {
        public frmABMRol()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNoActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPageCrearRol_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreRol_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSeleccionDeRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils con = new Utils();

            con.mostrarTodasLasFuncionalidadesDisponibles(FuncionalidadesxRol);

            //aca se tienen que  mostrar solo la del rol seleccionado, por ende usamos la tabla 
            //rolxfuncionalidad
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FuncionalidadesxRol_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           // String cadena = "SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad";
            
          //  SqlCommand comando = new SqlCommand(cadena,Conexion conection = new Conexion());

            
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //abrir pantalla de modificacion
            //podemos agregar funcionalidades, quitarlas y modificarRol (funciondes de sql)
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            //usar la funcion de sql bajaRol
        }

        private void buttonCrearRol_Click_1(object sender, EventArgs e)
        {
            string spAltaRol = "[PISOS_PICADOS].altaRol";

            SqlCommand crearRol = new SqlCommand(spAltaRol, Globals.conexionGlobal);
            crearRol.CommandType = CommandType.StoredProcedure;

            if (txtNombreRol.Text == "") { 
                MessageBox.Show("Complete el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            //Agrego parametros
            crearRol.Parameters.Add("@nombre", SqlDbType.VarChar);
            crearRol.Parameters.Add("@estado", SqlDbType.Bit);

            //Cargo valores en parametros
            crearRol.Parameters["@nombre"].Value = txtNombreRol.Text;

            if (checkActivo.Checked)
            {
                crearRol.Parameters["@estado"].Value = 1;
            }
            else
            {
                crearRol.Parameters["@estado"].Value = 0;
            }



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

    }
}
