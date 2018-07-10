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

namespace FrbaHotel.AbmRol
{
    public partial class frmABMRol : Form
    {
        public frmABMRol()
        {
            InitializeComponent();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (listRoles.SelectedItem == null)
            {
                return;
            }
            frmModificacionRol modificacion = new frmModificacionRol(listRoles.SelectedItem.ToString(), this);
            modificacion.Show();
        }

        private void buttonCrearRol_Click_1(object sender, EventArgs e)
        {
            //chequeos
            int verificacion = 1;

            if (txtNombreRol.Text == "")
            {
                MessageBox.Show("Ingrese un nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (checkListFuncionalidades.CheckedItems.Count < 1)
            {
                MessageBox.Show("Seleccione al menos una funcionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificacion = 0;
            }

            if (verificacion == 0)
            {
                return;
            }

            //fin chequeos

            string spAltaRol = "[PISOS_PICADOS].altaRol";
            string spAgregarFuncionalidad = "[PISOS_PICADOS].agregarFuncionalidad";
            string funcionExisteRol = "SELECT [PISOS_PICADOS].existeRol(@nombreRol)";

            SqlCommand crearRol = new SqlCommand(spAltaRol, Globals.conexionGlobal);
            crearRol.CommandType = CommandType.StoredProcedure;

            //Agrego parametros
            crearRol.Parameters.Add("@nombre", SqlDbType.VarChar);
            crearRol.Parameters.Add("@estado", SqlDbType.Bit);

            //Cargo valores en parametros
            crearRol.Parameters["@nombre"].Value = txtNombreRol.Text;

            if (checkActivo.Checked)
            {
                crearRol.Parameters["@estado"].Value = 1;
            }
            else
            {
                crearRol.Parameters["@estado"].Value = 0;
            }

            SqlCommand existeRol = new SqlCommand(funcionExisteRol, Globals.conexionGlobal);
            existeRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);
            string nombreRol = txtNombreRol.Text;
            existeRol.Parameters["@nombreRol"].Value = nombreRol;

            int respuesta = (int)existeRol.ExecuteScalar();

            if (respuesta == 1)
            {
                MessageBox.Show("Ya existe el rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            crearRol.ExecuteNonQuery();

            for (int i = 0; i < (int)checkListFuncionalidades.CheckedItems.Count; i++)
            {
                SqlCommand agregarFuncionalidad = new SqlCommand(spAgregarFuncionalidad, Globals.conexionGlobal);
                agregarFuncionalidad.CommandType = CommandType.StoredProcedure;

                //Agrego parametros
                agregarFuncionalidad.Parameters.Add("@nombre", SqlDbType.VarChar);
                agregarFuncionalidad.Parameters.Add("@funcionalidad", SqlDbType.VarChar);

                //Cargo valores en parametros
                agregarFuncionalidad.Parameters["@nombre"].Value = txtNombreRol.Text;
                agregarFuncionalidad.Parameters["@funcionalidad"].Value = checkListFuncionalidades.CheckedItems[i].ToString();

                agregarFuncionalidad.ExecuteNonQuery();
            }

            cargarRoles();
            MessageBox.Show("Alta realizada correctamente.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listRoles.SelectedItem = 0;
            cargarFuncionalidades();
            cargarRoles();
        }

        public void cargarRoles()
        {
            SqlCommand cmdBuscarRoles = new SqlCommand("SELECT nombreRol FROM [PISOS_PICADOS].Rol", Globals.conexionGlobal);
            SqlDataReader reader2 = cmdBuscarRoles.ExecuteReader();
            listRoles.Items.Clear();

            while (reader2.Read())
            {
                listRoles.Items.Add((reader2["nombreRol"]).ToString());
            }

            reader2.Close();
            return;
        }

        public void cargarFuncionalidades()
        {
            SqlCommand cmdBuscarFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarFuncionalidades.ExecuteReader();

            while (reader.Read())
            {
                checkListFuncionalidades.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();

            return;
        }

        private void listRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listRoles.SelectedItem == null)
            {
                return;
            }

            SqlCommand cmdFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad as f JOIN [PISOS_PICADOS].RolxFuncionalidad as rf on f.idFuncionalidad = rf.idFuncionalidad JOIN [PISOS_PICADOS].Rol as r on rf.idRol = r.idRol WHERE r.nombreRol = @rol", Globals.conexionGlobal);
            cmdFuncionalidades.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmdFuncionalidades.Parameters["@Rol"].Value = listRoles.SelectedItem.ToString();
            SqlDataReader reader = cmdFuncionalidades.ExecuteReader();
            listFuncionalidades.Items.Clear();

            while (reader.Read())
            {
                listFuncionalidades.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();

            SqlCommand cmdEstadoRol = new SqlCommand("SELECT estado FROM [PISOS_PICADOS].Rol WHERE nombreRol = @Rol", Globals.conexionGlobal);
            cmdEstadoRol.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmdEstadoRol.Parameters["@Rol"].Value = listRoles.SelectedItem.ToString();

            long respuesta = Convert.ToInt64(cmdEstadoRol.ExecuteScalar());

            if (respuesta == 1)
            {
                lblEstado.Text = "Activo";
            }
            else
            {
                lblEstado.Text = "No activo";
            }

        }

    }

}
