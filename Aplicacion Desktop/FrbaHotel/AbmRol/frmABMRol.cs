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

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNoActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPageCrearRol_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreRol_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            string spModificarRol = "[PISOS_PICADOS].modificarRol";
            SqlCommand modificarRol = new SqlCommand(spModificarRol, Globals.conexionGlobal);
            modificarRol.CommandType = CommandType.StoredProcedure;

            modificarRol.Parameters.Add("@nombreRolViejo", SqlDbType.VarChar);
            modificarRol.Parameters.Add("@nombreRol",SqlDbType.VarChar);
            modificarRol.Parameters.Add("@estado",SqlDbType.Bit);

            modificarRol.Parameters["@nombreRolViejo"].Value = cbRol.Text;
            modificarRol.Parameters["@nombreRol"].Value = txtNuevoNombre.Text;

            if (checkBoxEstado.Checked) 
            {
                modificarRol.Parameters["@estado"].Value = 1;
            }
            else
            {
                modificarRol.Parameters["@estado"].Value = 0;
            }

            for (int i = 0; i < checkListFuncionalidades2.Items.Count; i++) 
            {
                if (!checkListFuncionalidades2.GetItemChecked(i))
                {
                    string spQuitarFuncionalidad = "[PISOS_PICADOS].quitarFuncionalidad";
                    SqlCommand quitarFuncionalidad = new SqlCommand(spQuitarFuncionalidad, Globals.conexionGlobal);
                    quitarFuncionalidad.CommandType = CommandType.StoredProcedure;

                    //agrego parametros
                    quitarFuncionalidad.Parameters.Add("@nombreRol", SqlDbType.VarChar);
                    quitarFuncionalidad.Parameters.Add("@funcionalidad", SqlDbType.VarChar);

                    //agrego valores
                    quitarFuncionalidad.Parameters["@nombreRol"].Value = cbRol.Text;
                    quitarFuncionalidad.Parameters["@funcionalidad"].Value = checkListFuncionalidades2.Items[i].ToString();

                    //ejecuto el SP
                    quitarFuncionalidad.ExecuteNonQuery();

                }

                modificarRol.ExecuteNonQuery();
            }

        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {

            //chequeos
            if (cbRol.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string spBajaRol = "[PISOS_PICADOS].bajaRol";

            SqlCommand bajaRol = new SqlCommand(spBajaRol, Globals.conexionGlobal);
            bajaRol.CommandType = CommandType.StoredProcedure;

            //Agrego parametros
            bajaRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);

            //Cargo valores en parametros
            bajaRol.Parameters["@nombreRol"].Value = cbRol.SelectedItem.ToString();

            int respuesta = bajaRol.ExecuteNonQuery();

            if (respuesta > 0)
            {
                MessageBox.Show("Baja realizada correctamente");
                cbRol.Items.Clear();
                cargarRoles();
            }

        }

        private void buttonCrearRol_Click_1(object sender, EventArgs e)
        {
            
            //chequeos
            if (txtNombreRol.Text == "")
            {
                MessageBox.Show("Complete el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkListFuncionalidades.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una funcionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string spAltaRol = "[PISOS_PICADOS].altaRol";
            string spAgregarFuncionalidad = "[PISOS_PICADOS].agregarFuncionalidad";
            string funcionExisteRol = "[PISOS_PICADOS].existeRol(@nombreRol)";

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
            existeRol.Parameters["@nombreRol"].Value = txtNombreRol.Text;

            if ((int)existeRol.ExecuteScalar() == 0)
            {
                for (int i = 0; i < (int)checkListFuncionalidades.Items.Count; i++)
                {
                    if (checkListFuncionalidades.GetItemChecked(i))
                    {
                        SqlCommand agregarFuncionalidad = new SqlCommand(spAgregarFuncionalidad, Globals.conexionGlobal);
                        agregarFuncionalidad.CommandType = CommandType.StoredProcedure;

                        //Agrego parametros
                        agregarFuncionalidad.Parameters.Add("@nombre", SqlDbType.VarChar);
                        agregarFuncionalidad.Parameters.Add("@funcionalidad", SqlDbType.VarChar);

                        //Cargo valores en parametros
                        agregarFuncionalidad.Parameters["@nombre"].Value = txtNombreRol.Text;
                        agregarFuncionalidad.Parameters["@funcionalidad"].Value = checkListFuncionalidades.Items[i];

                        agregarFuncionalidad.ExecuteNonQuery();
                        MessageBox.Show("Alta realizada correctamente");
                    }
                }
            }

            crearRol.ExecuteNonQuery();
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            cargarFuncionalidades();
            cargarRoles();
        }

        public void cargarRoles() 
        {
            SqlCommand cmdBuscarRoles = new SqlCommand("SELECT nombreRol FROM [PISOS_PICADOS].Rol WHERE estado = 1", Globals.conexionGlobal);
            SqlDataReader reader2 = cmdBuscarRoles.ExecuteReader();

            while (reader2.Read())
            {
                cbRol.Items.Add((reader2["nombreRol"]).ToString());
            }

            reader2.Close();
            cbRol.SelectedItem = cbRol.Items[0];
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

        private void cbRol_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand cmdFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad as f JOIN [PISOS_PICADOS].RolxFuncionalidad as rf on f.idFuncionalidad = rf.idFuncionalidad JOIN [PISOS_PICADOS].Rol as r on rf.idRol = r.idRol WHERE r.nombreRol = @rol", Globals.conexionGlobal);
            cmdFuncionalidades.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmdFuncionalidades.Parameters["@Rol"].Value = cbRol.SelectedItem.ToString();
            SqlDataReader reader = cmdFuncionalidades.ExecuteReader();
            checkListFuncionalidades2.Items.Clear();

            while (reader.Read())
            {
                checkListFuncionalidades2.Items.Add((reader["descripcion"]).ToString());
            }

            for (int i = 0; i < checkListFuncionalidades2.Items.Count; i++)
            {
                checkListFuncionalidades2.SetItemChecked(i, true);
            }

            reader.Close();

        }

    }
}
