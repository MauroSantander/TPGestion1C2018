using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaHotel.Properties;
using System.Configuration;

namespace FrbaHotel
{
    public static class Globals
    {
        public static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public static AppSettingsSection app = config.AppSettings;
        public static DateTime FechaDelSistema = DateTime.Parse(app.Settings["FechaDelSistema"].Value);

        public static SqlConnection conexionGlobal = new SqlConnection();
        public static Login.frmLogIn frmLogInInstance;
        
        public static int idUsuarioSesion = 0;
        public static int idHotelUsuario = 0;

        public static void setUsuarioSesion(int id) 
        {
            idUsuarioSesion = id;
        }

        public static string obtenerStringConexion()
        {
            return ConfigurationManager.ConnectionStrings["DBGDD"].ConnectionString;     
        }

        public static void AbrirConexion()
        {
            Globals.conexionGlobal = new SqlConnection(obtenerStringConexion());
            try
            {
                Globals.conexionGlobal.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool DescargarConexion()
        {
            Globals.conexionGlobal.Dispose();
            return true;
        }

        public static Login.frmLogIn getLogin()
        {
            if (frmLogInInstance == null)
            {
                frmLogInInstance = new Login.frmLogIn();
            }
            return frmLogInInstance;
        }

    }
}
