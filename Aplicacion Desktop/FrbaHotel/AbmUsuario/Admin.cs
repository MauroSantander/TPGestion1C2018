using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Globalization;

namespace FrbaHotel.AbmUsuario
{
    public partial class Admin : Form
    {

        Utils utils = new Utils();
      
        DataTable dataTable;

        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

            
            this.llenarDataGridView();


        }


        //----------------------------------------------------------------------------------------------------
        //Boton Crear


        private void buttonCrearUsr_Click(object sender, EventArgs e)
        {
            (new FrbaHotel.AbmUsuario.frmNuevoUsuario()).ShowDialog();
        }


        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione usuario de la tabla"); return;
            }
          
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
            String usuario = dataGridView1.CurrentRow.Cells["Usuario"].Value.ToString();
            String nombre= dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            String apell = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
            String mail = dataGridView1.CurrentRow.Cells["Mail"].Value.ToString();
            String tel = dataGridView1.CurrentRow.Cells["Teléfono"].Value.ToString();
            String calle = dataGridView1.CurrentRow.Cells["Calle"].Value.ToString();
            String nroCalle = dataGridView1.CurrentRow.Cells["Nro Calle"].Value.ToString();
            String localidad = dataGridView1.CurrentRow.Cells["Localidad"].Value.ToString();
            String pais = dataGridView1.CurrentRow.Cells["Pais"].Value.ToString();
            String tipoId = dataGridView1.CurrentRow.Cells["Tipo id"].Value.ToString();
            String nroident =dataGridView1.CurrentRow.Cells["Nro Identificación"].Value.ToString();
            String fechaNacimiento = dataGridView1.CurrentRow.Cells["Fecha Nacimiento"].Value.ToString();

            int idPais = int.Parse(pais);

            SqlCommand cmdBuscarNombrePais = new SqlCommand("Select nombrePais from [PISOS_PICADOS].Pais where idPais = @idPais", Globals.conexionGlobal);
            cmdBuscarNombrePais.Parameters.AddWithValue("@idPais", idPais);
            SqlDataReader reader = cmdBuscarNombrePais.ExecuteReader();

            while (reader.Read())
            {
                pais = (reader["nombrePais"]).ToString();
            }


            (new FrbaHotel.AbmUsuario.frmModificarUsuario()).cargarDatos(id, usuario,nombre,apell, mail, tel, calle, nroCalle, localidad, pais, tipoId, nroident,fechaNacimiento, this);

        }
       


    
        private void tabPage2_Click(object sender, EventArgs e)
        {

            this.llenarDataGridView();

        }

        //Filtro

        private void button5_Click(object sender, EventArgs e)
        {

            this.llenarDataGridView();
            string cadenaUsuario;
            string cadenaTipoId;
            string cadenaNroId;
            if (textBoxUsrNameBorrar.Text == "") { cadenaUsuario = "e.usuario LIKE '%'"; }
            else { cadenaUsuario = "e.usuario LIKE '" + textBoxUsrNameBorrar.Text + "'"; };

            if (comboBox2.Text == "" || comboBox2.Text == "Vacío") { cadenaTipoId = "u.tipoIdentificacion LIKE '%'"; }
            else { cadenaTipoId = "u.tipoIdentificacion LIKE '" + comboBox2.Text + "'"; };

            if (textBox1.Text == "") { cadenaNroId = "u.numeroIdentificacion LIKE '%'"; }
            else { cadenaNroId = "u.numeroIdentificacion LIKE '" + textBox1.Text + "'"; };



            string compuesto = "select e.idUsuario 'Id',e.usuario 'Usuario', e.contrasena 'Contraseña', u.nombre 'Nombre', u.apellido 'Apellido',u.mail 'Mail',u.telefono 'Teléfono',u.calle 'Calle',u.nroCalle 'Nro Calle',u.localidad 'Localidad',u.pais 'Pais',u.tipoIdentificacion 'Tipo id',u.numeroIdentificacion 'Nro Identificación',u.fechaNacimiento 'Fecha Nacimiento' from [PISOS_PICADOS].Empleado E join [PISOS_PICADOS].Usuario U on (E.idUsuario = U.idUsuario) WHERE u.estado = 1 AND  " + cadenaUsuario
               + " AND " + cadenaTipoId + " AND " + cadenaNroId;


            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            SqlDataAdapter adapter = new SqlDataAdapter(compuesto, Globals.conexionGlobal);
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;





        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.RowIndex > -1)
            {

                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {

                    dr.Selected = false;

                }

                // Para seleccionar

                dataGridView1.Rows[e.RowIndex].Selected = true;

            }

        }


        //Boton dar de baja 

        private void button2_Click(object sender, EventArgs e)
        {

            {
                if (dataGridView1.CurrentRow == null){
                    MessageBox.Show("Seleccione usuario de la tabla"); return;}

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

             
                    String cadenaBajaUsuario = "PISOS_PICADOS.bajaUsuario";

                    SqlCommand comandoBajaUsuario = new SqlCommand(cadenaBajaUsuario, Globals.conexionGlobal);
                    comandoBajaUsuario.CommandType = CommandType.StoredProcedure;

                    comandoBajaUsuario.Parameters.AddWithValue("@idUsuario", id);
                    comandoBajaUsuario.ExecuteReader();
                    MessageBox.Show("Usuario dado de baja correctamente");

                

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                this.limpiarFiltros();
            }
        }

        private void limpiarFiltros()
        {
            textBoxUsrNameBorrar.Text = "";
            textBox1.Text = "";
            comboBox2.Text = "Vacío";
        }

       

       

       
        public void llenarDataGridView()
        {
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter("select e.idUsuario 'Id',e.usuario 'Usuario', e.contrasena 'Contraseña', u.nombre 'Nombre', u.apellido 'Apellido',u.mail 'Mail',u.telefono 'Teléfono',u.calle 'Calle',u.nroCalle 'Nro Calle',u.localidad 'Localidad',u.pais 'Pais',u.tipoIdentificacion 'Tipo id',u.numeroIdentificacion 'Nro Identificación',u.fechaNacimiento 'Fecha Nacimiento' from [PISOS_PICADOS].Empleado E join [PISOS_PICADOS].Usuario U on (E.idUsuario = U.idUsuario) where u.estado = 1", Globals.conexionGlobal);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo llenar el DataGridView");
            }
        }





    


      

        private void buttonRecargarTabla_Click(object sender, EventArgs e)
        {
            this.llenarDataGridView();
        }

        

       
    }
}