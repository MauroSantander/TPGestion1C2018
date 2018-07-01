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

namespace FrbaHotel.Login
{
    public partial class frmElegirRol : Form
    {
        public frmElegirRol()
        {
            InitializeComponent();
        }

        public frmElegirRol(string usuario)
        {
            InitializeComponent();

            SqlCommand cmdBuscarRolesUsuario = new SqlCommand("SELECT r.nombreRol FROM [PISOS_PICADOS].Empleado AS em JOIN [PISOS_PICADOS].RolxUsuario AS rxu ON em.idUsuario = rxu.idUsuario JOIN [PISOS_PICADOS].Rol AS r ON  r.idRol = rxu.idRol WHERE em.usuario = @usuario", Globals.conexionGlobal);
            cmdBuscarRolesUsuario.Parameters.Add("@usuario", SqlDbType.VarChar);
            cmdBuscarRolesUsuario.Parameters["@usuario"].Value = usuario;

            SqlDataReader reader = cmdBuscarRolesUsuario.ExecuteReader();

            while (reader.Read())
            {
                cbRol.Items.Add((reader["nombreRol"]).ToString());
            }

            reader.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlCommand cmdBuscarIdRol = new SqlCommand("SELECT idRol FROM [PISOS_PICADOS].Rol WHERE nombreRol = @nombreRol", Globals.conexionGlobal);
            cmdBuscarIdRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);
            if (cbRol.SelectedItem == null)
            {
                MessageBox.Show("Elija un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmdBuscarIdRol.Parameters["@nombreRol"].Value = cbRol.SelectedItem.ToString();
            int idRol = (int) cmdBuscarIdRol.ExecuteScalar();

            frmMenu frmMenuInstance = new frmMenu();
            frmMenuInstance.asignarRol(idRol);
            frmMenuInstance.Show();
            this.Close();
            Globals.getLogin().Hide();
            return;
        }

        private void ElegirRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
