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
        int noShowLogin = 0;
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

            //chequeos
            if (cbRol.SelectedItem == null)
            {
                MessageBox.Show("Elija un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmdBuscarIdRol.Parameters["@nombreRol"].Value = cbRol.SelectedItem.ToString();
            int idRol = (int) cmdBuscarIdRol.ExecuteScalar();

            frmMenu menuInstance = new frmMenu();
            menuInstance.asignarRol(idRol);
            Globals.frmMenuInstance = menuInstance;


            //verificamos si el usuario tiene un solo hotel. Si solo tiene uno, luego no lo mandamos a elegir
            SqlCommand tieneUnSoloHotel = new SqlCommand("SELECT [PISOS_PICADOS].tieneUnSoloHotel(@idUsuario)", Globals.conexionGlobal);
            tieneUnSoloHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
            tieneUnSoloHotel.Parameters["@idUsuario"].Value = Globals.idUsuarioSesion;
            int unHotel = (int)tieneUnSoloHotel.ExecuteScalar();

            if (unHotel == 1)
            {
                menuInstance.Show();
            }
            else
            {
                frmElegirHotel instanciafrmElegirHotel = new frmElegirHotel(Globals.idUsuarioSesion, menuInstance);
                instanciafrmElegirHotel.Show();
            }

            noShowLogin = 1;
            this.Close();
            return;
        }

        private void ElegirRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cbRol.SelectedItem = cbRol.Items[0];
            noShowLogin = 0;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (noShowLogin == 0) Globals.getLogin().Show();
        }
    }
}
