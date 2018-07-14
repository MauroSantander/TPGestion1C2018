using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmUsuario
{
    public partial class frmNuevoUsuario : Form
    {
        Admin pantallaAdmin;
        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        public void abrirPantalla(Admin pantalla) 
        {
            pantallaAdmin=pantalla;
            this.ShowDialog();
        }
        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            this.cargarHoteles();
            this.cargarRoles();

                this.CenterToScreen();
                //inicializo combobox de paises
                SqlCommand cmd = new SqlCommand("select nombrePais from [PISOS_PICADOS].Pais", Globals.conexionGlobal);


                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxPais.Items.Add((reader["nombrePais"]).ToString());
                }

                reader.Close();
        }


         private void buttonCrear_Click(object sender, EventArgs e)
        {



            /////////////// CHEQUEOS


            chequearSiHayCamposIncompletos();
            if (!validarEmail(mail.Text)) { MessageBox.Show("Escriba un formato de mail correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (checkedListBoxRoles.CheckedItems.Count < 1) { MessageBox.Show("Seleccione Rol/es", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (checkedListHoteles.CheckedItems.Count < 1) { MessageBox.Show("Seleccione Hotel/es", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            String user = username.Text;

            string query = "Select COUNT(*) from [PISOS_PICADOS].Empleado where  usuario= @user";

            SqlCommand cmd = new SqlCommand(query, Globals.conexionGlobal);

            cmd.Parameters.AddWithValue("@user", user);
            int countNombreUsr = Convert.ToInt32(cmd.ExecuteScalar());

            string queryMail = "Select COUNT(*) from [PISOS_PICADOS].Usuario where  mail= @mail";
            SqlCommand cmdMail = new SqlCommand(queryMail, Globals.conexionGlobal);

            cmdMail.Parameters.AddWithValue("@mail", mail.Text);
            int countMail = Convert.ToInt32(cmdMail.ExecuteScalar());

            SqlCommand verificarId = new SqlCommand("SELECT [PISOS_PICADOS].estaRepetido(@tipo,@numero)", Globals.conexionGlobal);
            verificarId.Parameters.AddWithValue("@tipo", comboBoxTipo.Text);
            verificarId.Parameters.AddWithValue("@numero", numDoc.Text);
            if (((int)verificarId.ExecuteScalar()) > 0) { MessageBox.Show("Tipo y Nro de Identificación existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (countNombreUsr > 0) { MessageBox.Show("Nombre de Usuario existente, escriba otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (countMail > 0) { MessageBox.Show("Mail existente, escriba otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }




            ///////////// ALTA USUARIO


            String cadenaAltaUsuario = "PISOS_PICADOS.altaEmpleado";

            SqlCommand comandoAltaUsuario = new SqlCommand(cadenaAltaUsuario, Globals.conexionGlobal);
            comandoAltaUsuario.CommandType = CommandType.StoredProcedure;

            //agregar parametros
            comandoAltaUsuario.Parameters.Add("@username", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@password", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@nombre", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@apellido", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@mail", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@telefono", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@calle", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@numeroCalle", SqlDbType.Int);
            comandoAltaUsuario.Parameters.Add("@localidad", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@pais", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@tipoDocumento", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@numeroDocumento", SqlDbType.Float);
            comandoAltaUsuario.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
            comandoAltaUsuario.Parameters.Add("@estado", SqlDbType.Bit);

            comandoAltaUsuario.Parameters["@username"].Value = username.Text;
            comandoAltaUsuario.Parameters["@password"].Value = pass.Text;
            comandoAltaUsuario.Parameters["@nombre"].Value = nombre.Text;
            comandoAltaUsuario.Parameters["@apellido"].Value = apellido.Text;
            comandoAltaUsuario.Parameters["@mail"].Value = mail.Text;
            comandoAltaUsuario.Parameters["@telefono"].Value = tel.Text;
            comandoAltaUsuario.Parameters["@calle"].Value = calle.Text;
            comandoAltaUsuario.Parameters["@numeroCalle"].Value = int.Parse(nroCalle.Text);
            comandoAltaUsuario.Parameters["@localidad"].Value = localidad.Text;
            comandoAltaUsuario.Parameters["@pais"].Value = comboBoxPais.Text;
            comandoAltaUsuario.Parameters["@tipoDocumento"].Value = comboBoxTipo.Text;
            comandoAltaUsuario.Parameters["@numeroDocumento"].Value = float.Parse(numDoc.Text);
            comandoAltaUsuario.Parameters["@fechaNacimiento"].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd"); ;
            comandoAltaUsuario.Parameters["@estado"].Value = 1;

            comandoAltaUsuario.ExecuteReader();

            SqlCommand obtenerIdNuevo = new SqlCommand("SELECT [PISOS_PICADOS].obtenerIDUsuarioEmpleado(@usuario,@contrasena)", Globals.conexionGlobal);
            obtenerIdNuevo.Parameters.AddWithValue("@usuario", username.Text);
            obtenerIdNuevo.Parameters.AddWithValue("@contrasena", pass.Text);
            int idNuevoUsr = (int)obtenerIdNuevo.ExecuteScalar();

            // CARGA DE ROLES



            for (int i = 0; i < (int)checkedListBoxRoles.CheckedItems.Count; i++)
            {
                
                    SqlCommand agregarRol = new SqlCommand("[PISOS_PICADOS].agregarRolAUsuario", Globals.conexionGlobal);
                    agregarRol.CommandType = CommandType.StoredProcedure;

                    agregarRol.Parameters.Add("@idUsuario", SqlDbType.Int);
                    agregarRol.Parameters["@idUsuario"].Value = idNuevoUsr;
                    agregarRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);
                    agregarRol.Parameters["@nombreRol"].Value = checkedListBoxRoles.CheckedItems[i].ToString();
                    agregarRol.ExecuteNonQuery();
                


            }

            for (int i = 0; i < (int)checkedListHoteles.CheckedItems.Count; i++)
            {

                SqlCommand agregarHotel = new SqlCommand("[PISOS_PICADOS].agregarHotelAUsuario", Globals.conexionGlobal);
                agregarHotel.CommandType = CommandType.StoredProcedure;
                agregarHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
                agregarHotel.Parameters["@idUsuario"].Value = idNuevoUsr;
                agregarHotel.Parameters.Add("@nombreHotel", SqlDbType.VarChar);
                agregarHotel.Parameters["@nombreHotel"].Value = checkedListHoteles.CheckedItems[i].ToString(); 
                agregarHotel.ExecuteNonQuery();

            }


            MessageBox.Show("Usuario creado correctamente");
            pantallaAdmin.llenarDataGridView("");

            this.Close();





        }

         private void buttonCerrar_Click(object sender, EventArgs e)
         {
             this.Close();
         }

        //Carga----------------------------------------------------------------------------------

        public void cargarHoteles()
        {
            SqlCommand cmdBuscarHoteles = new SqlCommand("SELECT nombre FROM [PISOS_PICADOS].Hotel", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarHoteles.ExecuteReader();

            while (reader.Read())
            {
                checkedListHoteles.Items.Add((reader["nombre"]).ToString());
            }

            reader.Close();

            return;
        }

        public void cargarRoles()
        {
            SqlCommand cmdBuscarRoles = new SqlCommand("SELECT nombreRol FROM [PISOS_PICADOS].Rol", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarRoles.ExecuteReader();

            while (reader.Read())
            {
                checkedListBoxRoles.Items.Add((reader["nombreRol"]).ToString());
            }

            reader.Close();

            return;
        }

        //CHEQUEOS------------------------------------------------------------------------------------------------

        static bool validarEmail(string email)
        {
            try
            {
                if (email == "") { return false; }
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private void chequearSiHayCamposIncompletos()
        {
            if (String.IsNullOrEmpty(tel.Text)
               || String.IsNullOrEmpty(numDoc.Text)
               || String.IsNullOrEmpty(nroCalle.Text)
               || String.IsNullOrEmpty(username.Text)
               || String.IsNullOrEmpty(pass.Text)
               || String.IsNullOrEmpty(nombre.Text)
               || String.IsNullOrEmpty(apellido.Text)
               || String.IsNullOrEmpty(comboBoxTipo.Text)
               || String.IsNullOrEmpty(mail.Text)
               || String.IsNullOrEmpty(calle.Text)
               || String.IsNullOrEmpty(localidad.Text)
               || ((dateTimePicker1.Checked) == false)
               || String.IsNullOrEmpty(comboBoxPais.Text)

                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }


        private void textos_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textoYNros_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textosYespacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textoNrosYespacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void buttonCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    

        

      


    }
}
