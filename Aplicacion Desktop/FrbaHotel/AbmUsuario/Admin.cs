		using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace FrbaHotel.AbmUsuario
{
    public partial class Admin : Form
    {
        DataTable dataTable;
        Conexion c = new Conexion();
        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {



        }

        static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //--------------------TAB Nuevo Usr-------------------------------------------------------------
        private void tabPage1_Click(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e) { }


        //----------------TAB Eliminar----------------------------------------------------------------------

        private void tabPage2_Click(object sender, EventArgs e)
        {
            c.mostrarUsuarios(dataGridView1);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            c.mostrarUsuarios(dataGridView1);
            DataView DV = new DataView(dataTable);
            if (!String.IsNullOrEmpty(textBoxUsrNameBorrar.Text) ){ 
            DV.RowFilter = string.Format("nombre LIKE '%{0}%' ", textBoxUsrNameBorrar.Text);
            dataGridView1.DataSource = DV;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            c.mostrarUsuarios(dataGridView1);
            DataView DV = new DataView(dataTable);
            if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(comboBox2.SelectedText))
            {
                DV.RowFilter = string.Format("tipoIdentificacion LIKE '%{0}%' ", comboBox2.SelectedText);
                DV.RowFilter = string.Format("numeroIdentificacion LIKE '%{0}%' ", textBox1.Text);
                dataGridView1.DataSource = DV;
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {

                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {

                    dr.Selected = false;

                }

                // Para seleccionar

                dataGridView1.Rows[e.RowIndex].Selected = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            {
                if (dataGridView1.CurrentRow == null) return;

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idUsuario"].Value);

                using (SqlConnection cnn = new SqlConnection("server=LENOVO-PC\\SQLSERVER2012; database=GD1C2018;integrated security = true;user=gdHotel2018;password=gd2018"))
                {

                    string query = "delete from Usuario where idUsuario = @id";

                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }



        //----------------TAB Actualizar----------------------------------------------------------------------

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void BuscarUyPass_Click(object sender, EventArgs e)
        {
            try
            {

                 if (!String.IsNullOrEmpty(textBoxUsrAct.Text))
                 {
                     SqlConnection conexion = new SqlConnection("server=LENOVO-PC\\SQLSERVER2012; database=GD1C2018;integrated security = true;");

                     String usuarioNombre = textBoxUsrAct.Text;
                    

                     conexion.Open();

                     //Trae id por nombre de usuario

                     SqlCommand traerUsr = new SqlCommand("SELECT idUsuario FROM [PISOS_PICADOS].Usuario WHERE nombre=@nombre", conexion);
                     traerUsr.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuarioNombre;
                     SqlDataReader dr = traerUsr.ExecuteReader();
                     

                     if (dr.Read() == true)
                     {
                         //Completa usrName y Pass

                         textBox11.Text = dr["usuario"].ToString();
                         textBox12.Text=dr["contraseña"].ToString();
                         //TRAE DATOS USUARIO CON ESE ID
            
                         String id = dr["idUsuario"].ToString();
                         traerUsr = new SqlCommand("SELECT nombre,apellido,mail,telefono,calle,nroCalle,localidad,pais,tipoIdentificacion,numeroIdentificacion,fechaNacimiento FROM [PISOS_PICADOS].Usuario WHERE idUsuario=@id", conexion);
                         traerUsr.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                         SqlDataReader dr2 = traerUsr.ExecuteReader();

                         if (dr2.Read() == true)
                         {
                           textBox6.Text=dr2["nombre"].ToString();
                           textBox7.Text=dr2["apellido"].ToString();
                           textBox3.Text = dr2["mail"].ToString();
                           textBox4.Text = dr2["telefono"].ToString();
                           textBox2.Text = dr2["calle"].ToString();
                           textBox8.Text = dr2["nroCalle"].ToString();
                           textBox9.Text = dr2["localidad"].ToString();
                           comboBox6.SelectedText= dr2["pais"].ToString();
                           comboBox4.SelectedText=dr2["tipoIdentificacion"].ToString();
                           textBox5.Text=dr2["nroIdentificacion"].ToString();
                          /* String fecha=  dr2["fechaNacimiento"].ToString();
                           DateTime f = DateTime.Parse(fecha);
                             dateTimePicker2 = f; */
                         }

                        
                     }
                    
              
            }}
            catch (Exception exc)
            {
                MessageBox.Show("No se encontró Usuario");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAdm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxGuest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void tipoYNum_Click(object sender, EventArgs e)
        {

        }



        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsrNameBorrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label28_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }


    }
}