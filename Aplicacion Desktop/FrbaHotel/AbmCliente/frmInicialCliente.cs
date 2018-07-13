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
            this.CenterToScreen();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta fAlta = new frmAlta();
            fAlta.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmModificacion fMod = new frmModificacion();
            fMod.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmBaja fBaja = new frmBaja();
            fBaja.Show();
        }


    }
}
