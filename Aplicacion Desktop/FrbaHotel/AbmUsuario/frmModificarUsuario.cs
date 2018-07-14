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
    public partial class frmModificarUsuario : Form
    {
        private Admin pantallaUsuario;
        private int idUsuario;
        private String usernameAnterior;
        private String mailAnterior;
        private String tipoIdentificacionAnterior;
        private String nroIdentificacionAnterior;
        public frmModificarUsuario()
        {
            InitializeComponent();
        }
        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

        }
            

        public void cargarDatos(int id, String usuario, String nombre, String apell, String mail, String tel, String calle, String nroCalle, String localidad, String pais, String tipoId, String nroident, String fechaNacimiento, Admin pantalla)
        {

            idUsuario = id;
            pantallaUsuario = pantalla;
            usernameUPD.Text = usuario;
            nombreUPD.Text = nombre;
            apellidoUPD.Text = apell;
            comboBoxTipoUPD.Text=tipoId;
            numIdUPD.Text=nroident;
            mailUPD.Text = mail;
            telUPD.Text = tel;
            calleUPD.Text = calle;
            nroUPD.Text = nroCalle;
            localidadUPD.Text = localidad;
            usernameAnterior=usuario;
            mailAnterior=mail;
            tipoIdentificacionAnterior=tipoId;
            nroIdentificacionAnterior=nroident;

            SqlCommand cmd = new SqlCommand("select nombrePais from [PISOS_PICADOS].Pais", Globals.conexionGlobal);
      

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxPaisUPD.Items.Add((reader["nombrePais"]).ToString());
            }

            reader.Close();

        
            comboBoxPaisUPD.Text = pais;
            comboBoxTipoUPD.Text = tipoId;
            numIdUPD.Text = nroident;
            dateTimePickerUPD.Text = fechaNacimiento;
            cargarCheckedListBoxHoteles(id);
            cargarCheckedListBoxRoles(id);

            this.ShowDialog();


        }


        //Boton Actualizar empleado

           private void buttonActualizar_Click(object sender, EventArgs e)
        {

            //Chequeos------------------------------------------------------------------------------------------------

            chequearSiHayCamposIncompletosUPD();
            if (!validarEmail(mailUPD.Text)) { MessageBox.Show("Escriba un formato de mail correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if(checkedListBoxHotelesUPD.CheckedItems.Count == checkedListBoxHotelesUPD.Items.Count && checkedListBoxHotelesUPDNo.CheckedItems.Count==0){MessageBox.Show("Tiene que dejarle al Usuario al menos un Hotel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (checkedListBoxRolesUPD.CheckedItems.Count == checkedListBoxRolesUPD.Items.Count && checkedListBoxRolesUPDNo.CheckedItems.Count == 0) { MessageBox.Show("Tiene que dejarle al Usuario al menos un Rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (usernameAnterior != usernameUPD.Text)
            {
                String user = usernameUPD.Text;

                string query = "Select COUNT(*) from [PISOS_PICADOS].Empleado where  usuario= @user";

                SqlCommand cmd = new SqlCommand(query, Globals.conexionGlobal);

                cmd.Parameters.AddWithValue("@user", user);
                int countNombreUsr = Convert.ToInt32(cmd.ExecuteScalar());
                if (countNombreUsr > 0) { MessageBox.Show("Escribió un Nombre de Usuario ya existente, no se puede modificar por ese valor, escriba otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            }

               if(mailAnterior != mailUPD.Text)
               
               {

                string queryMail = "Select COUNT(*) from [PISOS_PICADOS].Usuario where  mail= @mail";
                SqlCommand cmdMail = new SqlCommand(queryMail, Globals.conexionGlobal);

                cmdMail.Parameters.AddWithValue("@mail", mailUPD.Text);
                int countMail = Convert.ToInt32(cmdMail.ExecuteScalar());


                if (countMail > 0) { MessageBox.Show("Escribió un Mail ya existente, no se puede modificar por ese valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
               
               }

               if (tipoIdentificacionAnterior != comboBoxTipoUPD.Text && nroIdentificacionAnterior != numIdUPD.Text )
               {
               SqlCommand verificarId = new SqlCommand("SELECT [PISOS_PICADOS].estaRepetido(@tipo,@numero)", Globals.conexionGlobal);
                verificarId.Parameters.AddWithValue("@tipo", comboBoxTipoUPD.Text);
                verificarId.Parameters.AddWithValue("@numero", numIdUPD.Text);
                if (((int)verificarId.ExecuteScalar()) > 0) { MessageBox.Show("Escribió un nuevo Tipo y Nro de Identificación ya existentes, no se pueden modificar por ese valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                

            }
            String cadenaModificacionUsuario = "PISOS_PICADOS.modificarEmpleado";

            SqlCommand comandoUpdUsuario = new SqlCommand(cadenaModificacionUsuario, Globals.conexionGlobal);
            comandoUpdUsuario.CommandType = CommandType.StoredProcedure;

            //agregar parametros
            comandoUpdUsuario.Parameters.Add("@idAutor", SqlDbType.Int);
            comandoUpdUsuario.Parameters.Add("@idUsuario", SqlDbType.Int);
            comandoUpdUsuario.Parameters.Add("@username", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@nombre", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@apellido", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@mail", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@telefono", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@calle", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@numeroCalle", SqlDbType.Int);
            comandoUpdUsuario.Parameters.Add("@localidad", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@pais", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@tipoDocumento", SqlDbType.VarChar);
            comandoUpdUsuario.Parameters.Add("@numeroDocumento", SqlDbType.Int);
            comandoUpdUsuario.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);

            //cargar valores
            comandoUpdUsuario.Parameters["@idAutor"].Value = Globals.idUsuarioSesion;
            comandoUpdUsuario.Parameters["@idUsuario"].Value = idUsuario;
            comandoUpdUsuario.Parameters["@username"].Value = usernameUPD.Text;
            comandoUpdUsuario.Parameters["@nombre"].Value = nombreUPD.Text;
            comandoUpdUsuario.Parameters["@apellido"].Value = apellidoUPD.Text;
            comandoUpdUsuario.Parameters["@mail"].Value = mailUPD.Text;
            comandoUpdUsuario.Parameters["@telefono"].Value = telUPD.Text;
            comandoUpdUsuario.Parameters["@calle"].Value = calleUPD.Text;
            comandoUpdUsuario.Parameters["@numeroCalle"].Value = int.Parse(nroUPD.Text);
            comandoUpdUsuario.Parameters["@localidad"].Value = localidadUPD.Text;
            comandoUpdUsuario.Parameters["@pais"].Value = comboBoxPaisUPD.Text;
            comandoUpdUsuario.Parameters["@tipoDocumento"].Value = comboBoxTipoUPD.Text;
            comandoUpdUsuario.Parameters["@numeroDocumento"].Value = int.Parse(numIdUPD.Text);
            comandoUpdUsuario.Parameters["@fechaNacimiento"].Value = dateTimePickerUPD.Value.ToString("yyyy-MM-dd");

            try
            {
                comandoUpdUsuario.ExecuteReader();

                /// AGREGAR  ROLES Y HOTELES QUE EL USUARIO NO TIENE
                /// 

                for (int i = 0; i <= checkedListBoxRolesUPDNo.CheckedItems.Count - 1; i++)
                {
                    string nombreRol = checkedListBoxRolesUPDNo.CheckedItems[i].ToString();

                    SqlCommand agregarRol = new SqlCommand("[PISOS_PICADOS].agregarRolAUsuario", Globals.conexionGlobal);
                    agregarRol.CommandType = CommandType.StoredProcedure;
                    agregarRol.Parameters.Add("@idUsuario", SqlDbType.Int);
                    agregarRol.Parameters["@idUsuario"].Value = idUsuario;
                    agregarRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);
                    agregarRol.Parameters["@nombreRol"].Value = nombreRol;
                    agregarRol.ExecuteNonQuery();


                }

                for (int i = 0; i <= checkedListBoxHotelesUPDNo.CheckedItems.Count - 1; i++)
                {
                    string nombreHotel = checkedListBoxHotelesUPDNo.CheckedItems[i].ToString();

                    SqlCommand agregarHotel = new SqlCommand("[PISOS_PICADOS].agregarHotelAUsuario", Globals.conexionGlobal);
                    agregarHotel.CommandType = CommandType.StoredProcedure;
                    agregarHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
                    agregarHotel.Parameters["@idUsuario"].Value = idUsuario;
                    agregarHotel.Parameters.Add("@nombreHotel", SqlDbType.VarChar);
                    agregarHotel.Parameters["@nombreHotel"].Value = nombreHotel;
                    agregarHotel.ExecuteNonQuery();

                }


                /// SACAR  ROLES Y HOTELES QUE EL USUARIO TIENE
                /// 


                for (int i = 0; i <= checkedListBoxRolesUPD.CheckedItems.Count - 1; i++)
                {
                    string nombreRol = checkedListBoxRolesUPD.CheckedItems[i].ToString();

                    SqlCommand quitarRol = new SqlCommand("[PISOS_PICADOS].quitarRolAUsuario", Globals.conexionGlobal);
                    quitarRol.CommandType = CommandType.StoredProcedure;
                    quitarRol.Parameters.Add("@idUsuario", SqlDbType.Int);
                    quitarRol.Parameters["@idUsuario"].Value = idUsuario;
                    quitarRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);
                    quitarRol.Parameters["@nombreRol"].Value = nombreRol;
                    quitarRol.ExecuteNonQuery();


                }

                for (int i = 0; i <= checkedListBoxHotelesUPD.CheckedItems.Count - 1; i++)
                {
                    string nombreHotel = checkedListBoxHotelesUPD.CheckedItems[i].ToString();

                    SqlCommand eliminarHotel = new SqlCommand("[PISOS_PICADOS].quitarHotelAUsuario", Globals.conexionGlobal);
                    eliminarHotel.CommandType = CommandType.StoredProcedure;
                    eliminarHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
                    eliminarHotel.Parameters["@idUsuario"].Value = idUsuario;
                    eliminarHotel.Parameters.Add("@nombreHotel", SqlDbType.VarChar);
                    eliminarHotel.Parameters["@nombreHotel"].Value = nombreHotel;
                    eliminarHotel.ExecuteNonQuery();

                }
                MessageBox.Show("Usuario Modificado correctamente");
                pantallaUsuario.llenarDataGridView("");
                this.Close();

            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo modificar");
            }

         
        }

           private void buttonVolver_Click(object sender, EventArgs e)
           {
               this.Close();
           }

        //------------------------------------------------------------------------------------------------------------------------
        //CHEQUEOS MODIFICAR------------------------------------------------------------------------------------------------

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

        private void chequearSiHayCamposIncompletosUPD()
        {
            if (String.IsNullOrEmpty(telUPD.Text)
               || String.IsNullOrEmpty(numIdUPD.Text)
               || String.IsNullOrEmpty(nroUPD.Text)
               || String.IsNullOrEmpty(usernameUPD.Text)
               || String.IsNullOrEmpty(nombreUPD.Text)
               || String.IsNullOrEmpty(apellidoUPD.Text)
               || String.IsNullOrEmpty(comboBoxTipoUPD.Text)
               || String.IsNullOrEmpty(mailUPD.Text)
               || String.IsNullOrEmpty(calleUPD.Text)
               || String.IsNullOrEmpty(localidadUPD.Text)
               || ((dateTimePickerUPD.Checked) == false)
               || String.IsNullOrEmpty(comboBoxPaisUPD.Text)
                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

      

        //Carga..............................................................................


        private void cargarCheckedListBoxHoteles(int idUsrModificar)
        {



            SqlCommand cmdBuscarHotelesUsuario = new SqlCommand("select H.nombre 'NombreHotel' from [PISOS_PICADOS].EmpleadoxHotel E join [PISOS_PICADOS].Hotel H on (E.idHotel = H.idHotel) WHERE E.idUsuario = @idUsuario", Globals.conexionGlobal);
            cmdBuscarHotelesUsuario.Parameters.AddWithValue("@idUsuario", idUsrModificar);
            SqlDataReader reader = cmdBuscarHotelesUsuario.ExecuteReader();

            while (reader.Read())
            {
                checkedListBoxHotelesUPD.Items.Add((reader["NombreHotel"]).ToString());
            }

            reader.Close();

            SqlCommand cmdBuscarHotelesNoUsuario = new SqlCommand("select nombre from [PISOS_PICADOS].Hotel  WHERE nombre  not in (select H.nombre from [PISOS_PICADOS].EmpleadoxHotel E join [PISOS_PICADOS].Hotel H on (E.idHotel = H.idHotel) WHERE E.idUsuario = @idUsuario)", Globals.conexionGlobal);
            cmdBuscarHotelesNoUsuario.Parameters.AddWithValue("@idUsuario", idUsrModificar);
            SqlDataReader reader2 = cmdBuscarHotelesNoUsuario.ExecuteReader();

            while (reader2.Read())
            {
                checkedListBoxHotelesUPDNo.Items.Add((reader2["nombre"]).ToString());
            }

            reader2.Close();

            return;
        }

        private void cargarCheckedListBoxRoles(int idModificar)
        {


            SqlCommand cmdBuscarRolesUsuario = new SqlCommand("select distinct (R.nombreRol) 'nomRol' from [PISOS_PICADOS].RolxUsuario U join [PISOS_PICADOS].Rol R on (R.idRol = U.idRol) WHERE U.idUsuario = @idUsuario", Globals.conexionGlobal);
            cmdBuscarRolesUsuario.Parameters.AddWithValue("@idUsuario", idModificar);
            SqlDataReader reader3 = cmdBuscarRolesUsuario.ExecuteReader();

            while (reader3.Read())
            {
                checkedListBoxRolesUPD.Items.Add((reader3["nomRol"]).ToString());
            }

            reader3.Close();

            SqlCommand cmdBuscarRolesNoUsuario = new SqlCommand("select distinct (nombreRol) 'nomRol' from [PISOS_PICADOS].Rol  WHERE nombreRol  not in (select distinct(nombreRol) from [PISOS_PICADOS].RolxUsuario U join [PISOS_PICADOS].Rol R on (R.idRol = U.idRol) WHERE U.idUsuario = @idUsuario)", Globals.conexionGlobal);
            cmdBuscarRolesNoUsuario.Parameters.AddWithValue("@idUsuario", idModificar);
            SqlDataReader reader2 = cmdBuscarRolesNoUsuario.ExecuteReader();

            while (reader2.Read())
            {
                checkedListBoxRolesUPDNo.Items.Add((reader2["nomRol"]).ToString());
            }

            reader2.Close();

            return;
        }

        //Keypress----------------------------------------------------------------------------------------
        

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

    }
}

