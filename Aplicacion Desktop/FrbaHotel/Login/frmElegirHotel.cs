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
    public partial class frmElegirHotel : Form
    {
        int noShowLogin = 0;
        frmMenu frmMenuInstancia;
        int idUser;

        public frmElegirHotel(int idUsuario, frmMenu instanciaMenu)
        {
            InitializeComponent();
            frmMenuInstancia = instanciaMenu;
            idUser = idUsuario;
        }

        private void frmElegirHotel_Load(object sender, EventArgs e)
        {
            noShowLogin = 0;
            this.CenterToScreen();
            //inicializo combobox de hoteles
            SqlCommand cmd = new SqlCommand("SELECT nombre FROM [PISOS_PICADOS].Hotel as h JOIN [PISOS_PICADOS].EmpleadoxHotel as e on h.idHotel = e.idHotel WHERE e.idUsuario = @usuario", Globals.conexionGlobal);
            cmd.Parameters.Add("@usuario", SqlDbType.Int);
            cmd.Parameters["@usuario"].Value = idUser;

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxHotel.Items.Add((reader["nombre"]).ToString());
            }

            reader.Close();

            comboBoxHotel.SelectedIndex = 0;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //chequeos
            if (comboBoxHotel.SelectedItem == null)
            {
                MessageBox.Show("Elija un hotel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //busco id del hotel
            SqlCommand cmd = new SqlCommand("SELECT idHotel FROM [PISOS_PICADOS].Hotel WHERE nombre = @nombre", Globals.conexionGlobal);
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar);
            cmd.Parameters["@nombre"].Value = comboBoxHotel.SelectedItem.ToString();
            Globals.idHotelUsuario = (int)cmd.ExecuteScalar();
            Globals.frmMenuInstance = frmMenuInstancia;

            frmMenuInstancia.Show();
            noShowLogin = 1;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (noShowLogin == 0) Globals.getLogin().Show();
        }

    }
}
