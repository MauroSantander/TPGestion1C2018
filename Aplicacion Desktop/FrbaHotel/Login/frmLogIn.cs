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
    public partial class frmLogIn : Form
    {

        public frmLogIn()
        {
            InitializeComponent();
            Globals.frmLogInInstance = this;
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {            
            //Usamos tres funciones de verificación. Una para ver si existe usuario, otra si la contraseña es correcta, y otra si el usuario esta habilitado o no
            //En base a estas verificaciones, se logueará o se avisará al usuario lo ocurrido
            SqlCommand verificarUsuario = new SqlCommand("SELECT [PISOS_PICADOS].usuarioValido(@usuario)", Globals.conexionGlobal);
            SqlCommand verificarContraseña = new SqlCommand("SELECT [PISOS_PICADOS].contrasenaValida(@usuario, @contrasena)", Globals.conexionGlobal);
            SqlCommand verificarUsuarioDeshabilitado = new SqlCommand("SELECT [PISOS_PICADOS].empleadoDeshabilitado(@usuario)", Globals.conexionGlobal);

            verificarUsuario.Parameters.Add("@usuario", SqlDbType.VarChar);
            verificarUsuario.Parameters["@usuario"].Value = textBoxUsuario.Text;

            verificarUsuarioDeshabilitado.Parameters.Add("@usuario", SqlDbType.VarChar);
            verificarUsuarioDeshabilitado.Parameters["@usuario"].Value = textBoxUsuario.Text;

            verificarContraseña.Parameters.Add("@usuario", SqlDbType.VarChar);
            verificarContraseña.Parameters.Add("@contrasena", SqlDbType.VarChar);
            verificarContraseña.Parameters["@usuario"].Value = textBoxUsuario.Text;
            verificarContraseña.Parameters["@contrasena"].Value = textBoxContrasena.Text;
            
            int respuestaVerificacionUsuario = (int) verificarUsuario.ExecuteScalar();
            int respuestaVerificacionUsuarioDeshabilitado = (int)verificarUsuarioDeshabilitado.ExecuteScalar();
            int respuestaVerificacionContraseña = (int)verificarContraseña.ExecuteScalar();

            if (respuestaVerificacionUsuario == 0)
            {
                MessageBox.Show("El usuario no existe.", "Error");
            }

            //Verificamos. Si todos los datos están bien y si el usuario está habilitado loguea
            if (respuestaVerificacionUsuario == 1 && respuestaVerificacionContraseña == 1 && respuestaVerificacionUsuarioDeshabilitado == 0)
            {
                //guardo id usuario en Globals
                SqlCommand getId = new SqlCommand("select idUsuario from [PISOS_PICADOS].Empleado where usuario = @username", Globals.conexionGlobal);
                getId.Parameters.Add("@username", SqlDbType.VarChar);
                getId.Parameters["@username"].Value = textBoxUsuario.Text;
                int idUsr = (int)getId.ExecuteScalar();
                Globals.setUsuarioSesion(idUsr);
                Globals.setContraseñaUsuario(textBoxContrasena.Text);
                
                //continua 
                
                //Si loguea bien, reseteamos intentos disponibles del usuario con el siguiente SP
                SqlCommand resetearIntentos = new SqlCommand("[PISOS_PICADOS].resetearIntentos", Globals.conexionGlobal);
                resetearIntentos.CommandType = CommandType.StoredProcedure;
                resetearIntentos.Parameters.Add("@usuarioEmpleado",SqlDbType.VarChar);
                resetearIntentos.Parameters["@usuarioEmpleado"].Value = textBoxUsuario.Text;
                resetearIntentos.ExecuteNonQuery();

                //verificamos si el usuario tiene un solo hotel. Si solo tiene uno, luego no lo mandamos a elegir
                SqlCommand tieneUnSoloHotel = new SqlCommand("SELECT [PISOS_PICADOS].tieneUnSoloHotel(@idUsuario)", Globals.conexionGlobal);
                tieneUnSoloHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
                tieneUnSoloHotel.Parameters["@idUsuario"].Value = idUsr;
                int unHotel = (int)tieneUnSoloHotel.ExecuteScalar();

                //Si el usuario tiene un solo rol, lo mandamos directamente al menu con el mismo, sin llevarlo a la pantalla de elección.
                //Lo verificamos con la siguiente función:
                SqlCommand tieneUnSoloRol = new SqlCommand("SELECT [PISOS_PICADOS].tieneUnSoloRol(@usuario)", Globals.conexionGlobal);
                tieneUnSoloRol.Parameters.Add("@usuario", SqlDbType.VarChar);
                tieneUnSoloRol.Parameters["@usuario"].Value = textBoxUsuario.Text;
                int unRol = (int)tieneUnSoloRol.ExecuteScalar();

                if (unRol == 1)
                {
                    SqlCommand rol = new SqlCommand("SELECT [PISOS_PICADOS].obtenerUnicoRol(@usuario)", Globals.conexionGlobal);
                    rol.Parameters.Add("@usuario", SqlDbType.VarChar);
                    rol.Parameters["@Usuario"].Value = textBoxUsuario.Text;
                    int idRol = (int)rol.ExecuteScalar();
                    frmMenu menuInstance = new frmMenu();
                    menuInstance.asignarRol(idRol);
                    Globals.frmMenuInstance = menuInstance;
                    if (unHotel == 1)
                    {
                        menuInstance.Show();
                    }
                    else
                    {
                        frmElegirHotel instanciafrmElegirHotel = new frmElegirHotel(idUsr, menuInstance);
                        instanciafrmElegirHotel.Show();
                    }
                    Globals.getLogin().Hide();
                    return;
                }
                else
                {
                    Globals.getLogin().Hide();
                    frmElegirRol frmElegirRol = new frmElegirRol(textBoxUsuario.Text);
                    frmElegirRol.ShowDialog();
                    return;
                }
            }

            //Verificamos si el usuario está deshabilitado, en caso de estarlo avisamos y no dejamos loguear
            if (respuestaVerificacionUsuario == 1 && respuestaVerificacionUsuarioDeshabilitado == 1)
            {
                MessageBox.Show("Usuario deshabilitado.", "Error");
                return;
            }

            //Si el usuario existe pero la contraseña está mal, le restamos un intento
            if (respuestaVerificacionUsuario == 1 && respuestaVerificacionContraseña == 0 && respuestaVerificacionUsuarioDeshabilitado == 0)
            {
                SqlCommand sumarIntento = new SqlCommand("[PISOS_PICADOS].sumarIntento", Globals.conexionGlobal);
                sumarIntento.CommandType = CommandType.StoredProcedure;
                sumarIntento.Parameters.Add("@usuarioEmpleado", SqlDbType.VarChar);
                sumarIntento.Parameters["@usuarioEmpleado"].Value = textBoxUsuario.Text;
                sumarIntento.ExecuteNonQuery();

                SqlCommand cantidadIntentosFallidos = new SqlCommand("SELECT [PISOS_PICADOS].cantidadIntentosFallidos(@usuario)", Globals.conexionGlobal);
                cantidadIntentosFallidos.Parameters.Add("@usuario", SqlDbType.VarChar);
                cantidadIntentosFallidos.Parameters["@usuario"].Value = textBoxUsuario.Text;

                int intentosFallidos = (int)cantidadIntentosFallidos.ExecuteScalar();

                //Si llego a 3 intentos fallidos, se deshabilita el usuario
                if (intentosFallidos >= 3) 
                {
                    MessageBox.Show("Ha llegado a la cantidad máxima de intentos fallidos. Su usuario será deshabilitado.","Error");
                    SqlCommand deshabilitarUsuario = new SqlCommand("[PISOS_PICADOS].deshabilitarUsuario", Globals.conexionGlobal);
                    deshabilitarUsuario.CommandType = CommandType.StoredProcedure;
                    deshabilitarUsuario.Parameters.Add("@usuario", SqlDbType.VarChar);
                    deshabilitarUsuario.Parameters["@usuario"].Value = textBoxUsuario.Text;
                    deshabilitarUsuario.ExecuteNonQuery();
                    return;
                }

                MessageBox.Show("Contraseña incorrecta. Le quedan " + (3-intentosFallidos) + " intentos.", "Error");
                return;
            }

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ingresarInvitado_Click(object sender, EventArgs e)
        {
            //Si es invitado se lo manda al menu con rol n° 3, que es el de invitado
            frmMenu menuInstance = new frmMenu();
            menuInstance.asignarRol(3);
            Globals.frmMenuInstance = menuInstance;
            Globals.rolUsuario = "Guest";
            Globals.idUsuarioSesion = -1;
            menuInstance.Show();
            this.Hide();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


    }
}
