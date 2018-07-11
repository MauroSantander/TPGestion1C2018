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

namespace FrbaHotel.GenerarModificacionReserva
{
    public partial class frmGenerarReserva : Form
    {
        public frmGenerarReserva()
        {
            InitializeComponent();
        }

        private void frmGenerarReserva_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //busco regímenes
            SqlCommand cmdBuscarRegimenes = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Regimen", Globals.conexionGlobal);

            SqlDataReader reader = cmdBuscarRegimenes.ExecuteReader();

            while (reader.Read())
            {
                comboBoxRegimen.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
