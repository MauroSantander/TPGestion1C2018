using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;

namespace FrbaHotel
{
    class Utils
    {
     
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

        public void llenarDataGridView(DataGridView dgv, String tabla)
        {
            try
            {

                adapter = new SqlDataAdapter("SELECT * FROM [PISOS_PICADOS]." + tabla, Globals.conexionGlobal);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo llenar el DataGridView");
            }
            
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        /* public void mostrarFuncionalidadesPara(Rol unRol, DataGridView dgv) 
         { 
        
        
         }*/


        public int verificarUsuario(String usuario, String contrasena)
        {

            String stringVerificar = "SELECT usuario FROM [PISOS_PICADOS].Empleado WHERE usuario=@usuario AND contraseña=@contraseña";


            Globals.conexionGlobal.Open();

            SqlCommand verificar = new SqlCommand(stringVerificar, Globals.conexionGlobal);
            verificar.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
            verificar.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contrasena;



            int result = verificar.ExecuteNonQuery();
            //int result = Convert.ToInt32(verificar.ExecuteScalar());
            Globals.conexionGlobal.Close();

            return result;

        }


        public int obtenerIdPais(String unPais)
        {
            SqlCommand queryIdPais = new SqlCommand("SELECT [PISOS_PICADOS].obtenerIDPais (@nombre)", Globals.conexionGlobal);

            queryIdPais.Parameters.Add("@nombre", SqlDbType.VarChar);
            queryIdPais.Parameters["@nombre"].Value = unPais;

            int idPais = (int)queryIdPais.ExecuteScalar();

            return idPais;
        }


        public bool estaRepetidoMail(String mail)
        {

            String cadenaRepMail = "SELECT [PISOS_PICADOS].estaRepetidoMail (@mail)";
            SqlCommand verificarMail = new SqlCommand(cadenaRepMail, Globals.conexionGlobal);

            verificarMail.Parameters.Add("@mail", SqlDbType.VarChar);
            verificarMail.Parameters["@mail"].Value = mail;

            int resultado = (int)verificarMail.ExecuteScalar();

            if (resultado == 1) { return true; }
            else { return false; }
        }

        public bool estaRepetidoIdentificacion(int nroPasaporte, String tipoIdentificacion)
        {
            String cadenaRepID = "SELECT [PISOS_PICADOS].estaRepetido (@tipo, @numero)";
            SqlCommand verificarIdentificacion = new SqlCommand(cadenaRepID, Globals.conexionGlobal);


            verificarIdentificacion.Parameters.Add("@numero", SqlDbType.Int);
            verificarIdentificacion.Parameters["@numero"].Value = nroPasaporte;

            verificarIdentificacion.Parameters.Add("@tipo", SqlDbType.VarChar);
            verificarIdentificacion.Parameters["@tipo"].Value = tipoIdentificacion;

            int resultado = (int)verificarIdentificacion.ExecuteScalar();

            if (resultado == 1) { return true; }
            else { return false; }
        }

        public int obtenerIdUsuario(String nombre, String apellido, int nroIdentificacion)
        {

            string fObtenerId = "SELECT [PISOS_PICADOS].obtenerIDUsuario (@nombre, @apellido, @numeroIdentificacion)";
            SqlCommand obtenerId = new SqlCommand(fObtenerId, Globals.conexionGlobal);
            obtenerId.Parameters.Add("@nombre", SqlDbType.VarChar);
            obtenerId.Parameters.Add("@apellido", SqlDbType.VarChar);
            obtenerId.Parameters.Add("@numeroIdentificacion", SqlDbType.Int);

            obtenerId.Parameters["@nombre"].Value = nombre;
            obtenerId.Parameters["@apellido"].Value = apellido;
            obtenerId.Parameters["@numeroIdentificacion"].Value = nroIdentificacion;

            int idCliente = (int)obtenerId.ExecuteScalar();  //aca es donde falla porque viene con Null

            return idCliente;
        }

        public int obtenerEstadoCliente(int idCliente)
        {
            String cadenaObtenerEstado = "SELECT [PISOS_PICADOS].obtenerEstadoUsuario (@idUsuario)";

            SqlCommand obtenerEstado = new SqlCommand(cadenaObtenerEstado, Globals.conexionGlobal);

            obtenerEstado.Parameters.Add("@idUsuario", SqlDbType.Int);
            obtenerEstado.Parameters["@idUsuario"].Value = idCliente;

            int estadoCliente = (int)obtenerEstado.ExecuteScalar();

            return estadoCliente;

        }

        public static void cargarHoteles(ComboBox comboBoxHotel)
        {
            //cargo los hoteles
            SqlCommand cmdBuscarHoteles = new SqlCommand("SELECT nombre, calle, nroCalle, ciudad FROM [PISOS_PICADOS].Hotel", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarHoteles.ExecuteReader();

            while (reader.Read())
            {
                if ((reader["nombre"]).ToString() != "")
                {
                    comboBoxHotel.Items.Add((reader["nombre"]).ToString());
                }
                else
                {
                    //si no tiene nombre le pongo ciudad, calle y número
                    string item;
                    item = reader["ciudad"].ToString().Trim() + "-" + reader["calle"].ToString().Trim() + "-" + reader["nroCalle"].ToString().Trim();
                    comboBoxHotel.Items.Add(item);
                }
            }

            reader.Close();

            return;
        }

        public static void cargarRegimenes(ComboBox comboBoxRegimen) 
        {
            //busco regímenes
            SqlCommand cmdBuscarRegimenes = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Regimen", Globals.conexionGlobal);

            SqlDataReader reader = cmdBuscarRegimenes.ExecuteReader();

            while (reader.Read())
            {
                comboBoxRegimen.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();
        }

        public static void cargarTiposDeCamas(ComboBox comboBoxTipo)
        {
            //traigo los tipos de habitación
            SqlCommand cmdBuscarTipos = new SqlCommand("SELECT tipoCamas FROM [PISOS_PICADOS].Tipo", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarTipos.ExecuteReader();

            while (reader.Read())
            {
                comboBoxTipo.Items.Add((reader["tipoCamas"]).ToString());
            }

            reader.Close();

            return;
        }

        public static void txtSoloAceptaNumeros(TextBox textbox, object sender, KeyPressEventArgs e)
        {
            //Textbox solo acepta números
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo acepta números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void cargarUbicacion(ComboBox comboBoxUbicacion)
        {
            comboBoxUbicacion.Items.Add("Frente");
            comboBoxUbicacion.Items.Add("Interno");
        }

        public static void cargarRoles(ListBox listRoles)
        {
            SqlCommand cmdBuscarRoles = new SqlCommand("SELECT nombreRol FROM [PISOS_PICADOS].Rol", Globals.conexionGlobal);
            SqlDataReader reader2 = cmdBuscarRoles.ExecuteReader();
            listRoles.Items.Clear();

            while (reader2.Read())
            {
                listRoles.Items.Add((reader2["nombreRol"]).ToString());
            }

            reader2.Close();
            return;
        }

        public static void cargarFuncionalidades(CheckedListBox checkListFuncionalidades)
        {
            SqlCommand cmdBuscarFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarFuncionalidades.ExecuteReader();

            while (reader.Read())
            {
                checkListFuncionalidades.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();

            return;
        }

        public static void cargarConsumibles(ListBox listConsumibles)
        {
            //creo comando para traer consumibles
            SqlCommand cmd = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Consumible", Globals.conexionGlobal);
            SqlDataReader reader = cmd.ExecuteReader();

            listConsumibles.Items.Clear();

            while (reader.Read())
            {
                listConsumibles.Items.Add((reader["descripcion"]).ToString().Trim());
            }

            reader.Close();
            return;
        }
    }
}
