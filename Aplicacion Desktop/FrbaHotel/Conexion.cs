﻿using System;
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

        public void mostrarClientes(DataGridView dgv)
        {
            try
            {

                adapter = new SqlDataAdapter("SELECT * FROM [PISOS_PICADOS].Cliente", Globals.conexionGlobal);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo llenar el DataGridView");
            }
        }
      
      public void mostrarUsuarios(DataGridView dgv)
        {
            try
            {

                adapter = new SqlDataAdapter("SELECT * FROM [PISOS_PICADOS].Usuario", Globals.conexionGlobal);
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

                adapter = new SqlDataAdapter("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad", Globals.conexionGlobal);
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


            Globals.conexionGlobal.Open();

            SqlCommand verificar = new SqlCommand(prueba, Globals.conexionGlobal);
            verificar.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            verificar.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contrasena;
          


               int result = verificar.ExecuteNonQuery(); 
            //int result = Convert.ToInt32(verificar.ExecuteScalar());
               Globals.conexionGlobal.Close();

                return result;

        }
    }
}
