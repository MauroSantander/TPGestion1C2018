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
    public partial class frmModificacionRol : Form
    {

        string RolAModificar;
        frmABMRol instanciaABMRol;

        public frmModificacionRol(string Rol, frmABMRol instanciaLlamante)
        {
            InitializeComponent();

            instanciaABMRol = instanciaLlamante;

            RolAModificar = Rol;

            txtNombre.Text = Rol;

            SqlCommand cmdFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad as f JOIN [PISOS_PICADOS].RolxFuncionalidad as rf on f.idFuncionalidad = rf.idFuncionalidad JOIN [PISOS_PICADOS].Rol as r on rf.idRol = r.idRol WHERE r.nombreRol = @rol", Globals.conexionGlobal);
            cmdFuncionalidades.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmdFuncionalidades.Parameters["@Rol"].Value = Rol;
            SqlDataReader reader = cmdFuncionalidades.ExecuteReader();
            checkListFuncionalidades.Items.Clear();

            while (reader.Read())
            {
                checkListFuncionalidades.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();

            for (int i = 0; i < checkListFuncionalidades.Items.Count; i++)
            {
                checkListFuncionalidades.SetItemChecked(i, true);
            }

            SqlCommand cmdNoFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad WHERE descripcion NOT IN (SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad as f JOIN [PISOS_PICADOS].RolxFuncionalidad as rf on f.idFuncionalidad = rf.idFuncionalidad JOIN [PISOS_PICADOS].Rol as r on rf.idRol = r.idRol WHERE r.nombreRol = @Rol)", Globals.conexionGlobal);
            cmdNoFuncionalidades.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmdNoFuncionalidades.Parameters["@Rol"].Value = Rol;
            SqlDataReader reader2 = cmdNoFuncionalidades.ExecuteReader();

            while (reader2.Read())
            {
                checkListFuncionalidades.Items.Add((reader2["descripcion"]).ToString());
            }

            reader2.Close();

            SqlCommand cmdEstadoRol = new SqlCommand("SELECT estado FROM [PISOS_PICADOS].Rol WHERE nombreRol = @Rol", Globals.conexionGlobal);
            cmdEstadoRol.Parameters.Add("@Rol", SqlDbType.VarChar);
            cmdEstadoRol.Parameters["@Rol"].Value = Rol;

            long respuesta = Convert.ToInt64(cmdEstadoRol.ExecuteScalar());

            if (respuesta == 1)
            {
                checkBoxEstado.Checked = true;
            }
            else
            {
                checkBoxEstado.Checked = false;
            }

        }

        private void frmModificacionRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //chequeos
            int verificacion = 1;
            
            if (txtNombre.Text == "")
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

            string spModificarRol = "[PISOS_PICADOS].modificarRol";
            SqlCommand modificarRol = new SqlCommand(spModificarRol, Globals.conexionGlobal);
            modificarRol.CommandType = CommandType.StoredProcedure;

            modificarRol.Parameters.Add("@nombreRolViejo", SqlDbType.VarChar);
            modificarRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);
            modificarRol.Parameters.Add("@estado", SqlDbType.Bit);

            if (checkBoxEstado.Checked)
            {
                modificarRol.Parameters["@estado"].Value = 1;
            }
            else
            {
                modificarRol.Parameters["@estado"].Value = 0;
            }

            modificarRol.Parameters["@nombreRolViejo"].Value = RolAModificar;
            modificarRol.Parameters["@nombreRol"].Value = txtNombre.Text;

            string spQuitarFuncionalidad = "[PISOS_PICADOS].quitarFuncionalidad";
            SqlCommand quitarFuncionalidad = new SqlCommand(spQuitarFuncionalidad, Globals.conexionGlobal);
            quitarFuncionalidad.CommandType = CommandType.StoredProcedure;
            quitarFuncionalidad.Parameters.Add("@nombreRol", SqlDbType.VarChar);
            quitarFuncionalidad.Parameters["@nombreRol"].Value = RolAModificar;
            quitarFuncionalidad.ExecuteNonQuery();

            for (int i = 0; i < checkListFuncionalidades.CheckedItems.Count; i++)
            {
                string spAgregarFuncionalidad = "[PISOS_PICADOS].agregarFuncionalidad";
                SqlCommand agregarFuncionalidad = new SqlCommand(spAgregarFuncionalidad, Globals.conexionGlobal);
                agregarFuncionalidad.CommandType = CommandType.StoredProcedure;

                //agrego parametros
                agregarFuncionalidad.Parameters.Add("@nombre", SqlDbType.VarChar);
                agregarFuncionalidad.Parameters.Add("@funcionalidad", SqlDbType.VarChar);

                //agrego valores
                agregarFuncionalidad.Parameters["@nombre"].Value = RolAModificar;
                agregarFuncionalidad.Parameters["@funcionalidad"].Value = checkListFuncionalidades.CheckedItems[i].ToString();

                //ejecuto el SP
                agregarFuncionalidad.ExecuteNonQuery();

            }

            modificarRol.ExecuteNonQuery();
            MessageBox.Show("Modificación realizada correctamente");
            instanciaABMRol.cargarRoles();
            this.Close();
        }

    }
}
