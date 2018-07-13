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
        public frmModificarUsuario()
        {
            InitializeComponent();
        }
        private void frmModificarUsuario_Load(object sender, EventArgs e)
        {

            this.CenterToScreen();

        }
            //inicializo combobox de paises
            

        public void cargarDatos(int id, String usuario, String nombre, String apell, String mail, String tel, String calle, String nroCalle, String localidad, String pais, String tipoId, String nroident, String fechaNacimiento, Admin pantalla)
        {

            idUsuario = id;
            pantallaUsuario = pantalla;
            usernameUPD.Text = usuario;
            nombreUPD.Text = nombre;
            apellidoUPD.Text = apell;
            mailUPD.Text = mail;
            telUPD.Text = tel;
            calleUPD.Text = calle;
            nroUPD.Text = nroCalle;
            localidadUPD.Text = localidad;

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
            chequearSiHayCamposIncompletosUPD();
            if (!validarEmail(mailUPD.Text)) { MessageBox.Show("Escriba un formato de mail correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }


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
                    agregarRol.Parameters.Add("@nombreRol", SqlDbType.Int);
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

