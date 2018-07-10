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

namespace FrbaHotel.AbmHotel
{
    public partial class frmBajaHotel : Form
    {
        int idHotel;
        frmHoteles pantallaHoteles;

        public void asignarId(int id, frmHoteles pantalla)
        {
            idHotel = id;
            pantallaHoteles = pantalla;
            this.ShowDialog();
        }

        public frmBajaHotel()
        {
            InitializeComponent();
        }

        private void frmBajaHotel_Load(object sender, EventArgs e)
        {
            textBoxId.Text = idHotel.ToString();
        }

       

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cnn = Globals.conexionGlobal)
                {
                    String cadenaBajaHotel = "PISOS_PICADOS.bajaHotel";

                    if (dateTimeDesde.Value == null && dateTimeHasta.Value == null && String.IsNullOrEmpty(razon.Text)) { MessageBox.Show("Complete todos los campos"); }
                    if (dateTimeDesde.Value > dateTimeHasta.Value) { MessageBox.Show("Coloque un rango de fechas correcto"); }

                    SqlCommand comandoBajaHotel = new SqlCommand(cadenaBajaHotel, Globals.conexionGlobal);
                    comandoBajaHotel.CommandType = CommandType.StoredProcedure;

                    comandoBajaHotel.Parameters.AddWithValue("@id", idHotel);
                    comandoBajaHotel.Parameters.AddWithValue("@fechaInicio", dateTimeDesde.Value.ToString("yyyy-MM-dd"));
                    comandoBajaHotel.Parameters.AddWithValue("@fechaFin", dateTimeDesde.Value.ToString("yyyy-MM-dd"));
                    comandoBajaHotel.Parameters.AddWithValue("@razon", razon.Text);
                    comandoBajaHotel.ExecuteReader().Close();
                    MessageBox.Show("Hotel dado de baja correctamente");
                    pantallaHoteles.eliminarRowHotel();
                    this.Close();

                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

       
    }
}
