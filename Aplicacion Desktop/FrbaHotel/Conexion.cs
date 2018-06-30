using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace FrbaHotel
{
    class Conexion
    {
        SqlCommand comando;
        SqlDataReader lector;

        SqlDataAdapter adapter;
        DataTable dataTable;

        public SqlConnection conexion = new SqlConnection();

        public void mostrarClientes(DataGridView dgv)
        {
            try
            {

                adapter = new SqlDataAdapter("SELECT * FROM [PISOS_PICADOS].Cliente", conexion);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo llenar el DataGridView");
            }
        }

        public void mostrarTodasLasFuncionalidadesDisponibles(DataGridView dgv)
        {
            try
            {

                adapter = new SqlDataAdapter("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad", conexion);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo llenar el DataGridView");
            }

        }

       /* public void mostrarFuncionalidadesPara(Rol unRol, DataGridView dgv) 
        { 
        
        
        
        }*/


        public int verificarUsuario(String usuario, String contrasena)
        {

            //String cadenaVerificarLogIn = "EXECUTE [PISOS_PICADOS].usuarioValido(@usuario, @contraseña)";
//SqlCommand verificar = new SqlCommand(cadenaVerificarLogIn, conexion);
            String prueba = "SELECT usuario FROM [PISOS_PICADOS].Empleado WHERE usuario=@usuario AND contraseña=@contraseña";

            
                           conexion.Open();

            SqlCommand verificar = new SqlCommand(prueba, conexion);
            verificar.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            verificar.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contrasena;
          


               int result = verificar.ExecuteNonQuery(); 
            //int result = Convert.ToInt32(verificar.ExecuteScalar());
                conexion.Close();

                return result;

        }

        public SqlConnection ObtenerConexion()
        {
            conexion = new SqlConnection("Password=gd2018;Persist Security Info=True;User ID=gdHotel2018;Initial Catalog=GD1C2018;Data Source=localhost\\SQLSERVER2012");
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DescargarConexion()
        {
            conexion.Dispose();
            return true;
        }
    }
}