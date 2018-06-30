using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaHotel
{
    public static class Globals
    {
        public static SqlConnection conexionGlobal = new SqlConnection();

        public static void AbrirConexion()
        {
            Globals.conexionGlobal = new SqlConnection("Password=gd2018;Persist Security Info=True;User ID=gdHotel2018;Initial Catalog=GD1C2018;Data Source=localhost\\SQLSERVER2012");
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

    }
}
