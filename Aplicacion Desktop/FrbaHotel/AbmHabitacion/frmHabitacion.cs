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
            //Inicializo formulario con valores de combos, dataGridView con todas las habitaciones y valores iniciales
            this.CenterToScreen();
            dataGridViewHabitaciones.DataSource = cargarHabitaciones(null);
            dataGridViewHabitaciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ajustarColumnas();
            cargarBotonModificacion();
            Utils.cargarHoteles(comboBoxHotel);
            Utils.cargarTiposDeCamas(comboBoxTipo);
            comboBoxEstado.Items.Add("Vacío");
            comboBoxEstado.Items.Add("Habilitada");
            comboBoxEstado.Items.Add("Deshabilitada");
            comboBoxUbicacion.Items.Add("Vacío");
            comboBoxUbicacion.Items.Add("Frente");
            comboBoxUbicacion.Items.Add("Interno");
            comboBoxEstado.SelectedIndex = 0;
            comboBoxHotel.SelectedIndex = 0;
            comboBoxUbicacion.SelectedIndex = 0;
            comboBoxTipo.SelectedIndex = 0;
        }

        private void ajustarColumnas()
        {
            //le doy otro tamaño a las columnas para que quede mejor visualmente
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

        private DataTable cargarHabitaciones(List<string> filtros) 
        {
            DataTable dtHabitaciones = new DataTable();

            string query;

            //implemento los filtros sumandole a la cadena de la query condiciones en el WHERE
            if (filtros != null)
            {
                string cadenaFiltros = "";
                if (filtros[0] != "Vacío")
                {
                    cadenaFiltros = cadenaFiltros + "and Hotel = '" + filtros[0] + "'";
                }
                if (filtros[1] != "Vacío")
                {
                    cadenaFiltros = cadenaFiltros + "and Tipo = '" + filtros[1] + "'";
                }
                if (filtros[2] != "")
                {
                    cadenaFiltros = cadenaFiltros + "and Piso = " + filtros[2];
                }
                if (filtros[3] != "")
                {
                    cadenaFiltros = cadenaFiltros + "and Numero = " + filtros[3];
                }
                if (filtros[4] != "Vacío")
                {
                    if (filtros[4] == "Frente")
                    {
                        cadenaFiltros = cadenaFiltros + "and Frente = 'S'";
                    }
                    else if (filtros[4] == "Interno")
                    {
                        cadenaFiltros = cadenaFiltros + "and Frente = 'N'";
                    }
                }
                if (filtros[5] != "Vacío")
                {
                    if (filtros[5] == "Habilitada")
                    {
                        cadenaFiltros = cadenaFiltros + "and + Habilitada = 1";
                    }
                    else if (filtros[5] == "Deshabilitada")
                    {
                        cadenaFiltros = cadenaFiltros + "and Habilitada = 0";
                    }
                }

                if (cadenaFiltros != "")
                {
                    //si tiene filtros los agrego
                    query = "SELECT * FROM [PISOS_PICADOS].listadoHabitaciones() WHERE 1=1" + cadenaFiltros;
                }
                else
                {
                    //si el usuario no uso filtro llamo a la función sin condiciones
                    query = "SELECT * FROM [PISOS_PICADOS].listadoHabitaciones()";
                }

            }
            else
            {
                //si llamé a la funcion sin enviar filtros, llamo sin condiciones. Sirve por ej. para cuando recien abro el formulario
                query = "SELECT * FROM [PISOS_PICADOS].listadoHabitaciones()";
            }


            //ejecuto comando y retorno datatable para llenar el dataGridView
            SqlCommand buscarHabitaciones = new SqlCommand(query, Globals.conexionGlobal);
            SqlDataReader reader = buscarHabitaciones.ExecuteReader();
            dtHabitaciones.Load(reader);

            return dtHabitaciones;
        }

        private void cargarBotonModificacion() 
        {
            //Agrego la columna con el botón "modificar" 
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
            //Si apreto el botón modificar, abro el formulario de modificación con los datos de la habitación a modificar
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

        public void recargarHabitaciones(List<string> filtros)
        {
            //recargo el dataGridView
            dataGridViewHabitaciones.DataSource = null;
            dataGridViewHabitaciones.Columns.Clear();
            dataGridViewHabitaciones.DataSource = cargarHabitaciones(filtros);
            cargarBotonModificacion();
            ajustarColumnas();
            dataGridViewHabitaciones.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            //Agrego filtros a lista y llamo al a función de recarga con dichos filtros
            List<string> filtros = new List<string>();
            filtros.Add(comboBoxHotel.Text.ToString());
            filtros.Add(comboBoxTipo.Text.ToString());
            filtros.Add(textBoxPiso.Text.ToString());
            filtros.Add(textBoxNumero.Text.ToString());
            filtros.Add(comboBoxUbicacion.Text.ToString());
            filtros.Add(comboBoxEstado.Text.ToString());
            recargarHabitaciones(filtros);
        }

        private void textBoxPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(textBoxPiso, sender, e);
        }

        private void textBoxNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.txtSoloAceptaNumeros(textBoxNumero, sender, e);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Dejo todos los campos vacíos
            comboBoxEstado.SelectedIndex = 0;
            comboBoxHotel.SelectedIndex = 0;
            comboBoxTipo.SelectedIndex = 0;
            comboBoxUbicacion.SelectedIndex = 0;
            textBoxNumero.Text = "";
            textBoxPiso.Text = "";
            return;
        }

    }
}
