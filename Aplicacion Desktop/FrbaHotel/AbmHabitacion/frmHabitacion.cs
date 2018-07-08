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

namespace FrbaHotel.AbmHabitacion
{
    public partial class frmHabitacion : Form
    {
        public frmHabitacion()
        {
            InitializeComponent();
        }

        private void frmHabitacion_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            dataGridViewHabitaciones.DataSource = cargarHabitaciones();
            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            btnModificar.HeaderText = "Modificar";
            btnModificar.Text = "Modificar";
            btnModificar.UseColumnTextForButtonValue = true;
            dataGridViewHabitaciones.Columns.Add(btnModificar);
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private DataTable cargarHabitaciones() 
        {
            DataTable dtHabitaciones = new DataTable();
            string query = "SELECT * FROM [PISOS_PICADOS].listadoHabitaciones()";
            SqlCommand buscarHabitaciones = new SqlCommand(query, Globals.conexionGlobal);
            SqlDataReader reader = buscarHabitaciones.ExecuteReader();
            dtHabitaciones.Load(reader);

            return dtHabitaciones;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            //frmModificarHabitacion modificarHab = new frmModificarHabitacion(,);
            //modificarHab.ShowDialog();

            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearHabitacion crear = new frmCrearHabitacion();
            crear.ShowDialog();
        }

        private void dataGridViewHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8) 
            {
                int idHabitacion =(int)dataGridViewHabitaciones.Rows[e.RowIndex].Cells[0].Value;
                int idHotel = (int)dataGridViewHabitaciones.Rows[e.RowIndex].Cells[1].Value;
                frmModificarHabitacion modificar = new frmModificarHabitacion(idHabitacion, idHotel);
                modificar.ShowDialog();
            }
        }

    }
}
