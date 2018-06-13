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
                conexion = new SqlConnection("server=LENOVO-PC\\SQLSERVER2012; database=GD1C2018;integrated security = true");
                conexion.Open();
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error al conectarse con la base de datos");
            }

        }

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

        public void mostrarFuncionalidadesPara(Rol unRol, DataGridView dgv) 
        { 
        
        
        
        }
            

    }
}