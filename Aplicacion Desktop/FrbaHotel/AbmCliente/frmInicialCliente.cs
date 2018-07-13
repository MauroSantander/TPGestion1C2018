using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmCliente
{
    public partial class frmInicialCliente : Form
    {
        public frmInicialCliente()
        {
            InitializeComponent();
        }

        private void FrmInicial_Load(object sender, EventArgs e)
        {
            //centra el formulario
            this.CenterToScreen();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            //abre el formulario de alta de cliente
            frmAlta fAlta = new frmAlta();
            fAlta.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //abre el formulario de modificar cliente
            frmModificacion fMod = new frmModificacion();
            fMod.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            //abre el formulario de baja de cliente
            frmBaja fBaja = new frmBaja();
            fBaja.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            this.Close();
        }


    }
}
