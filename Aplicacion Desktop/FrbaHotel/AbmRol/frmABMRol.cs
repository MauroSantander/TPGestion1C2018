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

            string spQuitarFuncionalidad = "[PISOS_PICADOS].quitarFuncionalidad";
            SqlCommand quitarFuncionalidad = new SqlCommand(spQuitarFuncionalidad, Globals.conexionGlobal);
            quitarFuncionalidad.CommandType = CommandType.StoredProcedure;
            quitarFuncionalidad.Parameters.Add("@nombreRol", SqlDbType.VarChar);
            quitarFuncionalidad.Parameters["@nombreRol"].Value = cbRol.Text;
            quitarFuncionalidad.ExecuteNonQuery();

           for (int i = 0; i < checkListFuncionalidades2.CheckedItems.Count; i++) 
           {
               string spAgregarFuncionalidad = "[PISOS_PICADOS].agregarFuncionalidad";
               SqlCommand agregarFuncionalidad = new SqlCommand(spAgregarFuncionalidad, Globals.conexionGlobal);
               agregarFuncionalidad.CommandType = CommandType.StoredProcedure;

               //agrego parametros
               agregarFuncionalidad.Parameters.Add("@nombre", SqlDbType.VarChar);
               agregarFuncionalidad.Parameters.Add("@funcionalidad", SqlDbType.VarChar);

               //agrego valores
               agregarFuncionalidad.Parameters["@nombre"].Value = cbRol.Text;
               agregarFuncionalidad.Parameters["@funcionalidad"].Value = checkListFuncionalidades2.CheckedItems[i].ToString();

               //ejecuto el SP
               agregarFuncionalidad.ExecuteNonQuery();     

           }

            modificarRol.ExecuteNonQuery();
            MessageBox.Show("Modificación realizada correctamente");
            cbRol.Items.Clear();
            cargarRoles();

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

            int respuesta = (int) existeRol.ExecuteScalar();

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
            MessageBox.Show("Alta realizada correctamente");
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
            SqlCommand cmdBuscarRoles = new SqlCommand("SELECT nombreRol FROM [PISOS_PICADOS].Rol", Globals.conexionGlobal);
            SqlDataReader reader2 = cmdBuscarRoles.ExecuteReader();
            cbRol.Items.Clear();

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
            txtNuevoNombre.Text = cbRol.Text;
            SqlCommand cmdFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad as f JOIN [PISOS_PICADOS].RolxFuncionalidad as rf on f.idFuncionalidad = rf.idFuncionalidad JOIN [PISOS_PICADOS].Rol as r on rf.idRol = r.idRol WHERE r.nombreRol = @rol", Globals.conexionGlobal);
            cmdFuncionalidades.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmdFuncionalidades.Parameters["@Rol"].Value = cbRol.SelectedItem.ToString();
            SqlDataReader reader = cmdFuncionalidades.ExecuteReader();
            checkListFuncionalidades2.Items.Clear();

            while (reader.Read())
            {
                checkListFuncionalidades2.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();

            for (int i = 0; i < checkListFuncionalidades2.Items.Count; i++)
            {
                checkListFuncionalidades2.SetItemChecked(i, true);
            }

            SqlCommand cmdNoFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad WHERE descripcion NOT IN (SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad as f JOIN [PISOS_PICADOS].RolxFuncionalidad as rf on f.idFuncionalidad = rf.idFuncionalidad JOIN [PISOS_PICADOS].Rol as r on rf.idRol = r.idRol WHERE r.nombreRol = @Rol)", Globals.conexionGlobal);
            cmdNoFuncionalidades.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmdNoFuncionalidades.Parameters["@Rol"].Value = cbRol.SelectedItem.ToString();
            SqlDataReader reader2 = cmdNoFuncionalidades.ExecuteReader();

            while (reader2.Read())
            {
                checkListFuncionalidades2.Items.Add((reader2["descripcion"]).ToString());
            }

            reader2.Close();

            if (cbRol.SelectedItem != null)
            {
                SqlCommand cmdEstadoRol = new SqlCommand("SELECT estado FROM [PISOS_PICADOS].Rol WHERE nombreRol = @Rol", Globals.conexionGlobal);
                cmdEstadoRol.Parameters.Add("@Rol", SqlDbType.VarChar);
                cmdEstadoRol.Parameters["@Rol"].Value = cbRol.SelectedItem.ToString();

                int respuesta = Convert.ToInt32(cmdEstadoRol.ExecuteScalar());
                
                if (respuesta == 1)
                {
                    checkBoxEstado.Checked = true;
                }
                else
                {
                    checkBoxEstado.Checked = false;
                }
            }
            
        }

    }
}
