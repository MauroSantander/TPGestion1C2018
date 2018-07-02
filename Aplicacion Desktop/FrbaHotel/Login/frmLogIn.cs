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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxUsuario_TextChanged_1(object sender, EventArgs e)
        {
            //box de usuario
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //box de password
        }


         private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {            

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

            if (respuestaVerificacionUsuario == 1 && respuestaVerificacionContraseña == 1 && respuestaVerificacionUsuarioDeshabilitado == 0)
            {
                SqlCommand resetearIntentos = new SqlCommand("[PISOS_PICADOS].resetearIntentos", Globals.conexionGlobal);
                resetearIntentos.CommandType = CommandType.StoredProcedure;
                resetearIntentos.Parameters.Add("@usuarioEmpleado",SqlDbType.VarChar);
                resetearIntentos.Parameters["@usuarioEmpleado"].Value = textBoxUsuario.Text;
                resetearIntentos.ExecuteNonQuery();

                SqlCommand tieneUnSoloRol = new SqlCommand("SELECT [PISOS_PICADOS].tieneUnSoloRol(@usuario)", Globals.conexionGlobal);
                tieneUnSoloRol.Parameters.Add("@usuario", SqlDbType.VarChar);
                tieneUnSoloRol.Parameters["@usuario"].Value = textBoxUsuario.Text;
                int unRol = (int)tieneUnSoloRol.ExecuteScalar();

                if (unRol == 1)
                {
                    SqlCommand rol = new SqlCommand("SELECT [PISOS_PICADOS].obtenerRol(@usuario)", Globals.conexionGlobal);
                    rol.Parameters.Add("@usuario", SqlDbType.VarChar);
                    rol.Parameters["@Usuario"].Value = textBoxUsuario.Text;
                    int idRol = (int)rol.ExecuteScalar();
                    frmMenu frmMenuInstance = new frmMenu();
                    frmMenuInstance.asignarRol(idRol);
                    frmMenuInstance.Show();
                    Globals.getLogin().Hide();
                    return;
                }
                else
                {
                    frmElegirRol frmElegirRol = new frmElegirRol(textBoxUsuario.Text);
                    frmElegirRol.ShowDialog();
                }
            }
            if (respuestaVerificacionUsuario == 1 && respuestaVerificacionUsuarioDeshabilitado == 1)
            {
                MessageBox.Show("Usuario deshabilitado.", "Error");
                return;
            }
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
            frmMenu frmMenuInstance = new frmMenu();
            frmMenuInstance.asignarRol(3);
            frmMenuInstance.Show();
            this.Hide();
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }


    }
}
