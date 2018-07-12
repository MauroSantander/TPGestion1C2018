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
            //agrego item por si no sabe el régimen que quiere
            comboBoxRegimen.Items.Add("Vacío");

            //busco regímenes
            Utils.cargarRegimenes(comboBoxRegimen);
            comboBoxRegimen.SelectedIndex = 0;

            //cargo hoteles
            //si es recepción solo cargo el hotel donde trabaja
            if (Globals.rolUsuario == "Guest" || Globals.rolUsuario == "Administrador")
            {
                Utils.cargarHoteles(comboBoxHotel);
                comboBoxHotel.SelectedIndex = 0;
            }
            else
            {
                SqlCommand cargarHotelUsuario = new SqlCommand("SELECT nombre FROM [PISOS_PICADOS].Hotel WHERE idHotel = @id", Globals.conexionGlobal);
                cargarHotelUsuario.Parameters.Add("@id", SqlDbType.Int);
                cargarHotelUsuario.Parameters["@id"].Value = Globals.idHotelUsuario;
                //recibo nombre hotel
                try
                {
                    string nombreHotel = cargarHotelUsuario.ExecuteScalar().ToString();
                    comboBoxHotel.Items.Add(nombreHotel);
                    comboBoxHotel.SelectedIndex = 0;
                }
                catch
                {
                    MessageBox.Show("Error al cargar el hotel del usuario. Reinicie sesión y vuelva a intentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            numSimple.Value = 0;
            numDoble.Value = 0;
            numTriple.Value = 0;
            numCuadruple.Value = 0;
            numKing.Value = 0;
            dtpInicioReserva.ResetText();
            dtpFinReserva.ResetText();
            comboBoxRegimen.SelectedIndex = 0;
        }
    }
}
