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

namespace FrbaHotel.FacturarEstadia
{
    public partial class frmFacturar : Form
    {
        public frmFacturar()
        {
            InitializeComponent();
        }

        private void frmFacturar_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SqlCommand cmdFormasDePago = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].FormaDePago", Globals.conexionGlobal);

            SqlDataReader reader = cmdFormasDePago.ExecuteReader();

            while (reader.Read())
            {
                comboBoxFormaDePago.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();

            return;

        }

        private void textBoxNumeroTarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(textBoxNumeroTarjeta, sender, e);
        }

        private void comboBoxFormaDePago_SelectedIndexChanged(object sender, EventArgs e)
        {
            //si elige efectivo no muestro textbox de número de tarjeta
            if (comboBoxFormaDePago.SelectedItem != "Efectivo")
            {
                textBoxNumeroTarjeta.Visible = true;
            }
            else
            {
                textBoxNumeroTarjeta.Visible = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCodigoReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(textBoxCodigoReserva, sender, e);
        }
    }
}
