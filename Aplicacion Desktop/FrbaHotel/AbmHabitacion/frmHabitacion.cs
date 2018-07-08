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
            ajustarColumnas();
            cargarBotonModificacion();
        }

        private void ajustarColumnas()
        {
            DataGridViewColumn column = dataGridViewHabitaciones.Columns[0];
            column.Width = 55;
            column = dataGridViewHabitaciones.Columns[1];
            column.Width = 55;
            column = dataGridViewHabitaciones.Columns[3];
            column.Width = 50;
            column = dataGridViewHabitaciones.Columns[4];
            column.Width = 48;
            column = dataGridViewHabitaciones.Columns[6];
            column.Width = 45;
            column = dataGridViewHabitaciones.Columns[8];
            column.Width = 45;
            column = dataGridViewHabitaciones.Columns[2];
            column.Width = 170;
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

        private void cargarBotonModificacion() 
        {
            DataGridViewButtonColumn btnModificar = new DataGridViewButtonColumn();
            btnModificar.HeaderText = "Modificar";
            btnModificar.Text = "Modificar";
            btnModificar.UseColumnTextForButtonValue = true;
            dataGridViewHabitaciones.Columns.Add(btnModificar);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            frmCrearHabitacion crear = new frmCrearHabitacion(this);
            crear.ShowDialog();
        }

        private void dataGridViewHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9) 
            {
                int idHabitacion = (int)(dataGridViewHabitaciones.Rows[e.RowIndex].Cells[0].Value);
                int idHotel = (int)dataGridViewHabitaciones.Rows[e.RowIndex].Cells[1].Value;
                int numero = (int)dataGridViewHabitaciones.Rows[e.RowIndex].Cells[4].Value;
                int piso = (int)(dataGridViewHabitaciones.Rows[e.RowIndex].Cells[3].Value);
                string frente = (dataGridViewHabitaciones.Rows[e.RowIndex].Cells[6].Value.ToString());
                string descripcion;
                if (dataGridViewHabitaciones.Rows[e.RowIndex].Cells[7].Value == DBNull.Value)
                {
                    descripcion = "";
                }
                else
                {
                    descripcion = (string)(dataGridViewHabitaciones.Rows[e.RowIndex].Cells[7].Value);
                }
                Boolean habilitada;
                if ((bool)dataGridViewHabitaciones.Rows[e.RowIndex].Cells[8].Value)
                {
                    habilitada = true;
                }
                else
                {
                    habilitada = false;
                }
                
                frmModificarHabitacion modificar = new frmModificarHabitacion(idHabitacion, idHotel, numero, piso, frente, habilitada, descripcion, this);
                modificar.ShowDialog();
            }
        }

        public void recargarHabitaciones()
        {
            dataGridViewHabitaciones.DataSource = null;
            dataGridViewHabitaciones.Columns.Clear();
            dataGridViewHabitaciones.DataSource = cargarHabitaciones();
            cargarBotonModificacion();
            ajustarColumnas();
        }

    }
}
