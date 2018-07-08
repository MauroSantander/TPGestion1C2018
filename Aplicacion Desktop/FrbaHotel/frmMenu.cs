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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void labelMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnABMRol_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.AbmRol.frmABMRol()).ShowDialog();
        }

        private void btnABMHotel_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.AbmHotel.frmHoteles()).ShowDialog();
        }

        private void btnGenerarReserva_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.GenerarModificacionReserva.Form1()).ShowDialog();
        }

        private void btnRegistarEstadia_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.RegistrarEstadia.Form1()).ShowDialog();
        }

        private void btnABMUsuario_Click(object sender, EventArgs e)
        {
            //(new FrbaHotel.AbmUsuario.Admin()).ShowDialog();
            MessageBox.Show("falta corregir");
        }

        private void btnABMHabitacion_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.AbmHabitacion.frmHabitacion()).ShowDialog();
        }

        private void btnModificarReserva_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.GenerarModificacionReserva.Form1()/*.tabControl(1)*/).ShowDialog();
        }

        private void btnRegistrarConsumibles_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.RegistrarConsumible.Form1()).ShowDialog();
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.AbmCliente.frmCliente()).ShowDialog();
        }

        private void btnABMRegimenEstadia_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.RegistrarEstadia.Form1()).ShowDialog();
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.CancelarReserva.Form1()).ShowDialog();
        }

        private void btnFacturarEstadia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado");
        }

        private void btnListadoEstadistico_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.ListadoEstadistico.Form1()).ShowDialog();
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
              String querySelect = "SELECT idFuncionalidad FROM [PISOS_PICADOS].RolxFuncionalidad WHERE idRol = @id ";

              SqlCommand commandSelect = new SqlCommand(querySelect, Globals.conexionGlobal);
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
              reader.Close();
              //this.ShowDialog();
          }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Globals.getLogin().Show();
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Globals.getLogin().Show();
        }

        private void btnRegistrarEstadia_Click(object sender, EventArgs e)
        {

        }
    }

}
