using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace FrbaHotel
{
    public partial class Form2 : Form
    {
        int rol;
        public Form2()
        {
            InitializeComponent();

        }

        private void labelMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {

        }

        private void btnABMHotel_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerarReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistarEstadia_Click(object sender, EventArgs e)
        {

        }

        private void btnABMUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnABMHabitacion_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarConsumibles_Click(object sender, EventArgs e)
        {

        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.AbmCliente.Form1()).ShowDialog();
        }

        private void btnABMRegimenEstadia_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {

        }

        private void btnFacturarEstadia_Click(object sender, EventArgs e)
        {

        }

        private void btnListadoEstadistico_Click(object sender, EventArgs e)
        {

        }

        private void habilitarBoton(int id)
        {
            if (id == 1)
            {
                btnABMRol.Enabled = true;
            }
            if (id == 2)
            {
                btnABMUsuario.Enabled = true;
            }
            if (id == 3)
            {
                btnABMCliente.Enabled = true;
            }
            if (id == 4)
            {
                btnABMHotel.Enabled = true;
            }
            if (id == 5)
            {
                btnABMHabitacion.Enabled = true;
            }
            if (id == 6)
            {
                btnABMRegimenEstadia.Enabled = true;
            }
            if (id == 7)
            {
                btnGenerarReserva.Enabled = true;
            }
            if (id == 8)
            {
                btnModificarReserva.Enabled = true;
            }
            if (id == 9)
            {
                btnCancelarReserva.Enabled = true;
            }
            if (id == 10)
            {
                btnRegistrarEstadia.Enabled = true;
            }
            if (id == 11)
            {
                btnRegistrarConsumibles.Enabled = true;
            }
            if (id == 12)
            {
                btnFacturarEstadia.Enabled = true;
            }
            if (id == 13)
            {
                btnListadoEstadistico.Enabled = true;
            }
        }

        public void asignarRol(int idRol)
        {

              SqlConnection conexion = new SqlConnection("server=LENOVO-PC\\SQLSERVER2012; database=GD1C2018;integrated security = true;");
              String querySelect = "SELECT idFuncionalidad FROM [PISOS_PICADOS].RolxFuncionalidad WHERE idRol = @id ";

              conexion.Open();
              SqlCommand commandSelect = new SqlCommand(querySelect, conexion);
              commandSelect.Parameters.Add("@id", SqlDbType.Int);
              commandSelect.Parameters["@id"].Value = idRol;
              
              SqlDataReader reader = commandSelect.ExecuteReader();

              List<int> funcionalidades = new List<int>();
              while (reader.Read())
              {
                  int id = (int) reader["idFuncionalidad"];
                  habilitarBoton(id);
                  //String lectura = reader["idFuncionalidad"].ToString();
                  //MessageBox.Show(lectura);
                  //funcionalidades.Add(Convert.ToInt32(reader["idFuncionalidad"]));
              }

              //String cadena = funcionalidades.ToString();
            
              /*foreach (int id in funcionalidades)
              {
                  habilitarBoton(id);
              }*/

              conexion.Close();
              this.ShowDialog();
          }

        }

}
