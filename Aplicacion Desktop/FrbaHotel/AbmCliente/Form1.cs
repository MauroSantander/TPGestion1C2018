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
           
            Conexion c = new Conexion();

            c.mostrarClientes(dataGridView2);
               
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {

            String NombreCliente = (String)dataGridViewClientes.CurrentRow.Cells["nombre"].Value;
            String ApellidoCliente = (String)dataGridViewClientes.CurrentRow.Cells["apellido"].Value;
            String TipoIdCliente = (String)dataGridViewClientes.CurrentRow.Cells["tipoIdentificacion"].Value;
            int NroIdCliente = (int)dataGridViewClientes.CurrentRow.Cells["numeroIdentificacion"].Value;
            String MailCliente = (String)dataGridViewClientes.CurrentRow.Cells["mail"].Value; ;
            String TelefonoCliente = (String)dataGridViewClientes.CurrentRow.Cells["telefono"].Value;
            String CalleCliente = (String)dataGridViewClientes.CurrentRow.Cells["calle"].Value;
            int NroCalleCliente = (int)dataGridViewClientes.CurrentRow.Cells["nroCalle"].Value; ;
            String LocalidadCliente = (String)dataGridViewClientes.CurrentRow.Cells["localidad"].Value;
            String PaisCliente = (String)dataGridViewClientes.CurrentRow.Cells["pais"].Value;
            String NacionalidadCliente = (String)dataGridViewClientes.CurrentRow.Cells["nacionalidad"].Value;
            

            SqlCommand comandoBaja = new SqlCommand(String.Format("EXEC SPBajaCliente '{0}','{1}','{2}', '{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}','{11}'",
               NombreCliente, ApellidoCliente, TipoIdCliente, NroIdCliente.ToString(), MailCliente, TelefonoCliente, CalleCliente, NroCalleCliente.ToString(), LocalidadCliente, PaisCliente, NacionalidadCliente


               ));
        }

        private void BotonVerClientes_Click(object sender, EventArgs e)
        {

            Conexion c = new Conexion();

            c.mostrarClientes(dataGridViewClientes);
            
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void Calle_TextChanged(object sender, EventArgs e)
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
            /*foreach (Control _textbox in this.Controls)
            {
                if (_textbox is TextBox && _textbox.Text == string.Empty)
                {
                    MessageBox.Show("Error de campos incompletos");
                }
            }*/   //puede que sea util para verificar que todos los campos esten llenos


            String NombreCliente = Nombre.Text;
            String ApellidoCliente = Apellido.Text;
            String TipoIdCliente = TipoId.Text;
            int NroIdCliente = int.Parse(nroId.Text);
            String MailCliente = Mail.Text;
            String TelefonoCliente = Telefono.Text;
            String CalleCliente = Calle.Text;
            int NroCalleCliente = int.Parse(NroCalle.Text);
            String LocalidadCliente = Localidad.Text;
            String PaisCliente = Pais.Text;
            String NacionalidadCliente = Nacionalidad.Text;
            
            //String EjecutarProcedure = "EXEC SP ";
            if (NombreCliente == ""){MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            if (ApellidoCliente == "") { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (TipoIdCliente == "") { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (NroIdCliente < 0) { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (MailCliente == "") { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (CalleCliente == "") { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (NroCalleCliente <0) { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (LocalidadCliente == "") { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (PaisCliente == "") { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            if (NacionalidadCliente == "") { MessageBox.Show("Completar nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            SqlCommand comandoAlta = new SqlCommand(String.Format("EXEC SPAltaCliente '{0}','{1}','{2}', '{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}','{11}'",
                NombreCliente,ApellidoCliente,TipoIdCliente, NroIdCliente.ToString(), MailCliente, TelefonoCliente, CalleCliente, NroCalleCliente.ToString(), LocalidadCliente, PaisCliente, NacionalidadCliente
                    
                
                ) );
            /* ***********Otra forma de pasar parametros*************
                private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DIEGO-PC\\SQLEXPRESS ; database=base1 ; integrated security = true");
            conexion.Open();
            string descri = textBox1.Text;
            string precio = textBox2.Text;
            string cadena = "insert into articulos(descripcion,precio) values ('" + descri + "'," + precio + ")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los datos se guardaron correctamente");
            textBox1.Text = "";
            textBox2.Text = "";
            conexion.Close();
        }
             
             */
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void labelCalle_Click(object sender, EventArgs e)
        {

        }

        private void labelNacionalidad_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaNac_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NroCalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void Localidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pais_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
