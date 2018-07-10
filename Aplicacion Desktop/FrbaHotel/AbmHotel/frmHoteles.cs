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
    public partial class frmHoteles : Form
    {

        DataTable dataTable;

        int filaSeleccionada;
        Utils utils = new Utils();

        public frmHoteles()
        {
            InitializeComponent();

        }

        private void frmHoteles_Load(object sender, EventArgs e)
        {
            utils.llenarDataGridView(dataGridViewHoteles, "Hotel");
        }

        public void actualizarDataGrid() {
            utils.llenarDataGridView(dataGridViewHoteles, "Hotel");
        }

        public void eliminarRowHotel()
        {
            dataGridViewHoteles.Rows.Remove(dataGridViewHoteles.Rows[filaSeleccionada]);
        }


        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoteles.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["idHotel"].Value);
            String nombre = dataGridViewHoteles.CurrentRow.Cells["nombre"].Value.ToString();
            String mail = dataGridViewHoteles.CurrentRow.Cells["mail"].Value.ToString();
            String telefono = dataGridViewHoteles.CurrentRow.Cells["telefono"].Value.ToString();
            String calle = dataGridViewHoteles.CurrentRow.Cells["calle"].Value.ToString();
            String nroCalle = dataGridViewHoteles.CurrentRow.Cells["nroCalle"].Value.ToString();
            String ciudad = dataGridViewHoteles.CurrentRow.Cells["ciudad"].Value.ToString();
            String pais = dataGridViewHoteles.CurrentRow.Cells["pais"].Value.ToString();
            String fechaCreacion = dataGridViewHoteles.CurrentRow.Cells["fechaCreacion"].Value.ToString();
            int estrellas = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["estrellas"].Value);

            int idPais = int.Parse(pais);

            SqlCommand cmdBuscarNombrePais = new SqlCommand("Select nombrePais from [PISOS_PICADOS].Pais where idPais = @idPais", Globals.conexionGlobal);
            cmdBuscarNombrePais.Parameters.AddWithValue("@idPais", idPais);
            SqlDataReader reader = cmdBuscarNombrePais.ExecuteReader();

            while (reader.Read())
            {
                pais = (reader["nombrePais"]).ToString();
            }
            

            (new FrbaHotel.AbmHotel.frmModificarHotel()).cargarDatos(id, nombre, mail, telefono, calle, nroCalle, ciudad, pais, fechaCreacion, estrellas, this);

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {

            if (dataGridViewHoteles.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewHoteles.CurrentRow.Cells["idHotel"].Value);

            (new FrbaHotel.AbmHotel.frmBajaHotel()).asignarId(id, this);

        }








        //FILTRAR -----------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            utils.llenarDataGridView(dataGridViewHoteles, "Hotel");
            DataView DV = new DataView(dataTable);
            if (!String.IsNullOrEmpty(textBoxNombre.Text))
            {
                DV.RowFilter = string.Format("nombre LIKE '%{0}%' ", textBoxNombre.Text);
                dataGridViewHoteles.DataSource = DV;
            }
            if (!String.IsNullOrEmpty(textBoxPais.Text))
            {
                DV.RowFilter = string.Format("pais LIKE '%{0}%' ", textBoxPais.Text);
                dataGridViewHoteles.DataSource = DV;
            }
            if (!String.IsNullOrEmpty(textBoxCiudad.Text))
            {
                DV.RowFilter = string.Format("ciudad LIKE '%{0}%' ", textBoxCiudad.Text);
                dataGridViewHoteles.DataSource = DV;
            }
            if (!String.IsNullOrEmpty(estrellas.SelectedText))
            {

                DV.RowFilter = string.Format("estrellas LIKE %{0}% ", (int.Parse(estrellas.SelectedText)));
                dataGridViewHoteles.DataSource = DV;
            }

        }

        private void dataGridViewHoteles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {

                foreach (DataGridViewRow dr in dataGridViewHoteles.SelectedRows)
                {

                    dr.Selected = false;

                }

                // Para seleccionar

                dataGridViewHoteles.Rows[e.RowIndex].Selected = true;
                filaSeleccionada = e.RowIndex;

            }

        }
    }
}
