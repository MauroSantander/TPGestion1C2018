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

        private void buttonIniciar_Click(object sender, EventArgs e)
        {

            (new FrbaHotel.Login.Form1()).ShowDialog();
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}

