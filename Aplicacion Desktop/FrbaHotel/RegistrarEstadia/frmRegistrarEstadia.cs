using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.RegistrarEstadia
{
    public partial class frmRegistrarEstadia : Form
    {
        public frmRegistrarEstadia()
        {
            InitializeComponent();
        }

        private void frmRegistrarEstadia_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void textBoxCodigoReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Textbox solo acepta números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //chequeos
            int verificacion = 1;

            if (textBoxCodigoReserva.Text == "")
            {
                MessageBox.Show("Ingrese el código de la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //fin chequeos
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            //chequeos
            int verificacion = 1;

            if (textBoxCodigoReserva.Text == "")
            {
                MessageBox.Show("Ingrese el código de la reserva.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //fin chequeos
        }
    }
}
