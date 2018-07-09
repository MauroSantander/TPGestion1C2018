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

namespace FrbaHotel.ListadoEstadistico
{
    public partial class frmListadoEstadistico : Form
    {
        public frmListadoEstadistico()
        {
            InitializeComponent();
        }

        private void frmListadoEstadistico_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            comboBoxTops.Items.Add("Hoteles con mayor cantidad de reservas canceladas");
            comboBoxTops.Items.Add("Hoteles con mayor cantidad de consumibles facturados");
            comboBoxTops.Items.Add("Hoteles con mayor cantidad de días fuera de servicio");
            comboBoxTops.Items.Add("Habitaciones con mayor cantidad de días que fueron ocupadas");
            comboBoxTops.Items.Add("Habitaciones con mayor cantidad de veces que fueron ocupadas");
            comboBoxTops.Items.Add("Cliente con mayor cantidad de puntos");
            comboBoxTops.SelectedIndex = 0;

            comboBoxAño.Text = Globals.FechaDelSistema.Year.ToString();

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string query = "";
            SqlCommand cmd;
            int consulta = comboBoxTops.SelectedIndex;

            if (consulta == 0) 
            {
                query = "SELECT * FROM [PISOS_PICADOS].hotelesConMasCancelaciones (@año, @trimestre)";
            }
            else if (consulta == 1)
            {
                query = "SELECT * FROM [PISOS_PICADOS].hotelesConMasConsumiblesFacturados (@año, @trimestre)";
            }
            else if (consulta == 2)
            {
                query = "SELECT * FROM [PISOS_PICADOS].hotelesConMasDiasDeBaja (@año, @trimestre, @fechaActual)";
            }
            else if (consulta == 3)
            {
                query = "SELECT * FROM [PISOS_PICADOS].topHabitacionesOcupadasDias (@año, @trimestre)";
            }
            else if (consulta == 4)
            {
                query = "SELECT * FROM [PISOS_PICADOS].topHabitacionesOcupadasDias (@año, @trimestre)";
            }
            else if (consulta == 5)
            {
                query = "SELECT * FROM [PISOS_PICADOS].topClientesPorPuntos (@año, @trimestre, @fechaActual)";
            }

            cmd = new SqlCommand(query, Globals.conexionGlobal);
            cmd.Parameters.Add("@año", SqlDbType.Int);
            cmd.Parameters.Add("@trimestre", SqlDbType.Int);
            cmd.Parameters["@año"].Value = Int32.Parse(comboBoxAño.Text);
            cmd.Parameters["@trimestre"].Value = Int32.Parse(Trimestre.Text);
            if (consulta == 2 || consulta == 5)
            {
                cmd.Parameters.Add("@fechaActual", SqlDbType.Date);
                cmd.Parameters["@fechaActual"].Value = Globals.FechaDelSistema.ToString("yyyy-MM-dd");
            }
            cmd.Parameters["@año"].Value = Int32.Parse(comboBoxAño.Text);
            cmd.Parameters["@trimestre"].Value = Int32.Parse(Trimestre.Text);

            DataTable dt = new DataTable();
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);
            dataGridResultados.DataSource = null;
            dataGridResultados.Columns.Clear();
            dataGridResultados.Rows.Clear();
            dataGridResultados.DataSource = dt;

        }

    }
}
