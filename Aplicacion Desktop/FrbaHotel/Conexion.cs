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
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;

        SqlDataAdapter adapter;
        DataTable dataTable;

        public Conexion()
        {

            try
            {
                conexion = new SqlConnection("server=LENOVO-PC\\SQLSERVER2012; database=GD1C2018;integrated security = true;");
              //  conexion.Open();
            // MessageBox.Show("Conexion exitosa");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al conectarse con la base de datos");
            }

        }

 /*       public void conectar()
        {
            this.Open(); quizas no sea necesario
        }
        */

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

            String cadenaVerificarLogIn = "EXECUTE [PISOS_PICADOS].usuarioValido(@usuario, @contraseña)";
         
            SqlCommand verificar = new SqlCommand(cadenaVerificarLogIn, conexion);
                        verificar.Parameters.AddWithValue("@usuario", usuario);
            verificar.Parameters.AddWithValue("@contrasena", contrasena);
          
            
            
            // verificar.CommandType = CommandType.StoredProcedure;
           /* verificar.Parameters.Add("@usuario", SqlDbType.VarChar);
            verificar.Parameters.Add("@contraseña", SqlDbType.VarChar);
            verificar.Parameters["@usuario"].Value = usuario;
            verificar.Parameters["@contraseña"].Value = contrasena;

            */
            

            

         ///   verificar.ExecuteNonQuery();
           /// verificar.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
            ///int valor = (int) verificar.Parameters["@resultado"].Value;
           
            
            /*valor =*/ //verificar.ExecuteNonQuery();
            //var result = (int)cmd.Parameters["RetVal"].Value;
            //SqlDataReader lector = verificar.ExecuteReader();
            ///conexion.Close();
            ///return valor;

            
               conexion.Open();
            int result = Convert.ToInt32(verificar.ExecuteScalar());
                conexion.Close();

                return result;

        }
        
    }
}