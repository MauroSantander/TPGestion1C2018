using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrbaHotel
{
    public partial class Form1 : Form
    {

        //SqlConnection conexion = new SqlConnection("server=LENOVO-PC\\SQLSERVER2012; database=GD1C2018;integrated security = true");

        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();

            /*
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion exitosa");
                (new FrbaHotel.Login.Form1()).ShowDialog();
                this.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error");

            }*/

            
           // Application.Run(new FrbaHotel.Login.Form1());
            (new FrbaHotel.Login.Form1()).ShowDialog();
            this.Close();
            
           
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}

