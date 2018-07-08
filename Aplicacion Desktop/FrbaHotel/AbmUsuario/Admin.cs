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

namespace FrbaHotel.AbmUsuario
{
    public partial class Admin : Form
    {
        DataTable dataTable;
        Utils utils = new Utils();
        int idUsrModificar;
        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

            this.cargarHoteles();
            this.cargarRoles();

        }

        public void cargarHoteles()
        {
            SqlCommand cmdBuscarHoteles = new SqlCommand("SELECT nombre FROM [PISOS_PICADOS].Hotel", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarHoteles.ExecuteReader();

            while (reader.Read())
            {
                checkedListHoteles.Items.Add((reader["nombre"]).ToString());
            }

            reader.Close();

            return;
        }

        public void cargarRoles()
        {
            SqlCommand cmdBuscarRoles = new SqlCommand("SELECT nombreRol FROM [PISOS_PICADOS].Rol", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarRoles.ExecuteReader();

            while (reader.Read())
            {
                checkedListBoxRoles.Items.Add((reader["nombreRol"]).ToString());
            }

            reader.Close();

            return;
        } 
        



        private void label6_Click(object sender, EventArgs e)
        {

        }
 //-----------------------------------------------------------------------------------------------------------------
 //--------------------TAB Nuevo Usr-------------------------------------------------------------------------------
       
        private void tabPage1_Click(object sender, EventArgs e)
        {        }


        //Boton Crear Usr

        private void button1_Click(object sender, EventArgs e)
        {


            /////////////// CHEQUEOS
 

            chequearSiHayCamposIncompletos();
            if (!validarEmail(mail.Text)) { MessageBox.Show("Escriba un formato de mail correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
            if (checkedListBoxRoles.CheckedItems.Count < 1) { MessageBox.Show("Seleccione Rol/es", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                
            String user = username.Text;
            using (SqlConnection cnn = Globals.conexionGlobal)
            {

                string query = "Select COUNT(*) from [PISOS_PICADOS].Empleado where  usuario= @user";

                SqlCommand cmd = new SqlCommand(query, cnn);

                cmd.Parameters.AddWithValue("@user", user);
                int countNombreUsr = Convert.ToInt32(cmd.ExecuteScalar());

                string queryMail = "Select COUNT(*) from [PISOS_PICADOS].Usuario where  mail= @mail";
                SqlCommand cmdMail = new SqlCommand(queryMail, cnn);

                cmdMail.Parameters.AddWithValue("@mail", mail.Text);
                int countMail = Convert.ToInt32(cmdMail.ExecuteScalar());

                SqlCommand verificarId = new SqlCommand("SELECT [PISOS_PICADOS].estaRepetido(@tipo,@numero)", Globals.conexionGlobal);
                verificarId.Parameters.AddWithValue("@tipo", comboBoxTipo.SelectedText);
                verificarId.Parameters.AddWithValue("@numero", numDoc.Text);
                if ((bool)verificarId.ExecuteScalar()) { MessageBox.Show("Tipo y Nro de Identificación existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (countNombreUsr > 0) { MessageBox.Show("Nombre de Usuario existente, escriba otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                if (countMail > 0) { MessageBox.Show("Mail existente, escriba otro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                
               


           ///////////// ALTA USUARIO
      

                    String cadenaAltaUsuario = "PISOS_PICADOS.altaEmpleado";

                    SqlCommand comandoAltaUsuario = new SqlCommand(cadenaAltaUsuario, Globals.conexionGlobal);
                    comandoAltaUsuario.CommandType = CommandType.StoredProcedure;

                    //agregar parametros
                    comandoAltaUsuario.Parameters.Add("@username", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@password", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@rol", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@nombre", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@apellido", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@mail", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@telefono", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@calle", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@numeroCalle", SqlDbType.Int);
                    comandoAltaUsuario.Parameters.Add("@localidad", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@pais", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@tipoDocumento", SqlDbType.VarChar);
                    comandoAltaUsuario.Parameters.Add("@numeroDocumento", SqlDbType.Int);
                    comandoAltaUsuario.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
                    comandoAltaUsuario.Parameters.Add("@estado", SqlDbType.Bit);
                    //cargar valores
                    comandoAltaUsuario.Parameters["@username"].Value = username.Text;
                    comandoAltaUsuario.Parameters["@password"].Value = pass.Text;
                    
                    comandoAltaUsuario.Parameters["@nombre"].Value = nombre.Text;
                    comandoAltaUsuario.Parameters["@apellido"].Value = apellido.Text;
                    comandoAltaUsuario.Parameters["@mail"].Value = mail.Text;
                    comandoAltaUsuario.Parameters["@telefono"].Value = tel.Text;
                    comandoAltaUsuario.Parameters["@calle"].Value = calle.Text;
                    comandoAltaUsuario.Parameters["@numeroCalle"].Value = nroCalle.Text;
                    comandoAltaUsuario.Parameters["@localidad"].Value = localidad.Text;
                    comandoAltaUsuario.Parameters["@pais"].Value = comboBoxPais.SelectedText;
                    comandoAltaUsuario.Parameters["@tipoDocumento"].Value = comboBoxTipo.SelectedText;
                    comandoAltaUsuario.Parameters["@numeroDocumento"].Value = numDoc.Text;
                    comandoAltaUsuario.Parameters["@fechaNacimiento"].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd"); ;
                    comandoAltaUsuario.Parameters["@estado"].Value = 1;

                    comandoAltaUsuario.ExecuteReader();
                    SqlCommand obtenerIdNuevo = new SqlCommand("SELECT [PISOS_PICADOS].obtenerIDUsuarioEmpleado(@usuario,@contraseña)", Globals.conexionGlobal);
                    obtenerIdNuevo.Parameters["@username"].Value = username.Text;
                    obtenerIdNuevo.Parameters["@password"].Value = pass.Text;
                    int idNuevoUsr=(int) obtenerIdNuevo.ExecuteScalar();
                    


                // CARGA DE ROLES

                    for (int i = 0; i <= checkedListBoxRoles.CheckedItems.Count- 1; i++)
                    {
                       string nombreRol= checkedListBoxRoles.CheckedItems[i].ToString();
                       
                    SqlCommand agregarRol = new SqlCommand("[PISOS_PICADOS].agregarRolAUsuario", Globals.conexionGlobal);
                    agregarRol.CommandType = CommandType.StoredProcedure;
                    agregarRol.Parameters.Add("@idUsuario", SqlDbType.Int);
                    agregarRol.Parameters["@idUsuario"].Value = idNuevoUsr;
                    agregarRol.Parameters.Add("@nombreRol", SqlDbType.Int);
                    agregarRol.Parameters["@nombreRol"].Value = nombreRol;
                    agregarRol.ExecuteNonQuery();
                       

                    }

                    for (int i = 0; i <= checkedListBoxRoles.CheckedItems.Count - 1; i++)
                    {
                        string nombreRol = checkedListBoxRoles.CheckedItems[i].ToString();

                        SqlCommand agregarRol = new SqlCommand("[PISOS_PICADOS].agregarRolAUsuario", Globals.conexionGlobal);
                        agregarRol.CommandType = CommandType.StoredProcedure;
                        agregarRol.Parameters.Add("@idUsuario", SqlDbType.Int);
                        agregarRol.Parameters["@idUsuario"].Value = idNuevoUsr;
                        agregarRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);
                        agregarRol.Parameters["@nombreRol"].Value = nombreRol;
                        agregarRol.ExecuteNonQuery();


                    }

                    for (int i = 0; i <= checkedListHoteles.CheckedItems.Count - 1; i++)
                    {
                        string nombreHotel = checkedListHoteles.CheckedItems[i].ToString();

                        SqlCommand agregarHotel = new SqlCommand("[PISOS_PICADOS].agregarHotelAUsuario", Globals.conexionGlobal);
                        agregarHotel.CommandType = CommandType.StoredProcedure;
                        agregarHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
                        agregarHotel.Parameters["@idUsuario"].Value = idNuevoUsr;
                        agregarHotel.Parameters.Add("@nombreHotel", SqlDbType.VarChar);
                        agregarHotel.Parameters["@nombreHotel"].Value = nombreHotel;
                        agregarHotel.ExecuteNonQuery();

                    } 


                    MessageBox.Show("Usuario creado correctamente");

                    //reinicio de los textbox
                    username.ResetText();
                    pass.ResetText();
                    nombre.ResetText();
                    apellido.ResetText();
                    comboBoxTipo.ResetText();
                    comboBoxPais.ResetText();
                    numDoc.ResetText();
                    mail.ResetText();
                    tel.ResetText();
                    calle.ResetText();
                    nroCalle.ResetText();
                    localidad.ResetText();
                    dateTimePicker1.ResetText();

                }
            }
            

 //-----------------------------------------------------------------------------------------------------------------------
 //----------------TAB BAJA-------------------------------------------------------------------------------------------

        private void tabPage2_Click(object sender, EventArgs e)
        {
            utils.mostrarUsuarios(dataGridView1);

        }

        //Filtro por Username

        private void button5_Click(object sender, EventArgs e)
        {
            utils.mostrarUsuarios(dataGridView1);
            DataView DV = new DataView(dataTable);
            if (!String.IsNullOrEmpty(textBoxUsrNameBorrar.Text))
            {
                DV.RowFilter = string.Format("nombre LIKE '%{0}%' ", textBoxUsrNameBorrar.Text);
                dataGridView1.DataSource = DV;
            }
            else { MessageBox.Show("Completar Username"); return; }
        }

        //Filtro por tipo y nro id

        private void button4_Click(object sender, EventArgs e)
        {
            utils.mostrarUsuarios(dataGridView1);
            DataView DV = new DataView(dataTable);         
            if (String.IsNullOrEmpty(textBox1.Text){ MessageBox.Show("Completar Número Identificación"); return;}
            if(String.IsNullOrEmpty(comboBox2.SelectedText)){MessageBox.Show("Seleccionar Tipo"); return;}
            
            DV.RowFilter = string.Format("tipoIdentificacion LIKE '%{0}%' ", comboBox2.SelectedText);
                DV.RowFilter = string.Format("numeroIdentificacion LIKE %{0}% ", int.Parse(textBox1.Text));
                dataGridView1.DataSource = DV;

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
                if (dataGridView1.CurrentRow == null) return;

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idUsuario"].Value);

                using (SqlConnection cnn = Globals.conexionGlobal)
                {
                    String cadenaBajaUsuario = "PISOS_PICADOS.bajaUsuario";

                    SqlCommand comandoBajaUsuario = new SqlCommand(cadenaBajaUsuario, Globals.conexionGlobal);
                    comandoBajaUsuario.CommandType = CommandType.StoredProcedure;

                    comandoBajaUsuario.Parameters.AddWithValue("@id", id);
                    comandoBajaUsuario.ExecuteReader().Close();
                    MessageBox.Show("Usuario eliminado correctamente");
                    
                }

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }


//----------------------------------------------------------------------------------------------------
//----------------TAB Actualizar----------------------------------------------------------------------

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }


        //Boton Actualizar empleado

        private void button3_Click(object sender, EventArgs e)
        {
            chequearSiHayCamposIncompletosUPD();
            if (!validarEmail(mailUPD.Text)) { MessageBox.Show("Escriba un formato de mail correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
           
                
            String cadenaAltaUsuario = "PISOS_PICADOS.modificarEmpleado";

            SqlCommand comandoAltaUsuario = new SqlCommand(cadenaAltaUsuario, Globals.conexionGlobal);
            comandoAltaUsuario.CommandType = CommandType.StoredProcedure;

            //agregar parametros
            comandoAltaUsuario.Parameters.Add("@idUsuario", SqlDbType.Int);
            comandoAltaUsuario.Parameters.Add("@username", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@password", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@rol", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@nombre", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@apellido", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@mail", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@telefono", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@calle", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@numeroCalle", SqlDbType.Int);
            comandoAltaUsuario.Parameters.Add("@localidad", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@pais", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@tipoDocumento", SqlDbType.VarChar);
            comandoAltaUsuario.Parameters.Add("@numeroDocumento", SqlDbType.Int);
            comandoAltaUsuario.Parameters.Add("@fechaNacimiento", SqlDbType.DateTime);
         
            //cargar valores
            comandoAltaUsuario.Parameters["@idUsuario"].Value = idUsrModificar;
            comandoAltaUsuario.Parameters["@username"].Value = usernameUPD.Text;
            comandoAltaUsuario.Parameters["@password"].Value = passUPD.Text;
            comandoAltaUsuario.Parameters["@nombre"].Value = nombreUPD.Text;
            comandoAltaUsuario.Parameters["@apellido"].Value = apellidoUPD.Text;
            comandoAltaUsuario.Parameters["@mail"].Value = mailUPD.Text;
            comandoAltaUsuario.Parameters["@telefono"].Value = telUPD.Text;
            comandoAltaUsuario.Parameters["@calle"].Value = calleUPD.Text;
            comandoAltaUsuario.Parameters["@numeroCalle"].Value = int.Parse(nroUPD.Text);
            comandoAltaUsuario.Parameters["@localidad"].Value = localidadUPD.Text;
            comandoAltaUsuario.Parameters["@pais"].Value = comboBoxPaisUPD.SelectedText;
            comandoAltaUsuario.Parameters["@tipoDocumento"].Value = comboBoxTipoUPD.SelectedText;
            comandoAltaUsuario.Parameters["@numeroDocumento"].Value = int.Parse(numIdUPD.Text);
            comandoAltaUsuario.Parameters["@fechaNacimiento"].Value = dateTimePickerUPD.Value.ToString("yyyy-MM-dd") ;


            comandoAltaUsuario.ExecuteReader();


            /// AGREGAR  ROLES Y HOTELES QUE EL USUARIO NO TIENE
            /// 

            for (int i = 0; i <= checkedListBoxRolesUPDNo.CheckedItems.Count - 1; i++)
            {
                string nombreRol = checkedListBoxRolesUPDNo.CheckedItems[i].ToString();

                SqlCommand agregarRol = new SqlCommand("[PISOS_PICADOS].agregarRolAUsuario", Globals.conexionGlobal);
                agregarRol.CommandType = CommandType.StoredProcedure;
                agregarRol.Parameters.Add("@idUsuario", SqlDbType.Int);
                agregarRol.Parameters["@idUsuario"].Value = idUsrModificar;
                agregarRol.Parameters.Add("@nombreRol", SqlDbType.Int);
                agregarRol.Parameters["@nombreRol"].Value = nombreRol;
                agregarRol.ExecuteNonQuery();


            }

            for (int i = 0; i <= checkedListBoxHotelesUPDNo.CheckedItems.Count - 1; i++)
            {
                string nombreHotel = checkedListBoxHotelesUPDNo.CheckedItems[i].ToString();

                SqlCommand agregarHotel = new SqlCommand("[PISOS_PICADOS].agregarHotelAUsuario", Globals.conexionGlobal);
                agregarHotel.CommandType = CommandType.StoredProcedure;
                agregarHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
                agregarHotel.Parameters["@idUsuario"].Value = idUsrModificar;
                agregarHotel.Parameters.Add("@nombreHotel", SqlDbType.VarChar);
                agregarHotel.Parameters["@nombreHotel"].Value = nombreHotel;
                agregarHotel.ExecuteNonQuery();

            }


            /// SACAR  ROLES Y HOTELES QUE EL USUARIO TIENE
            /// 

            for (int i = 0; i <= checkedListBoxRolesUPD.CheckedItems.Count - 1; i++)
            {
                string nombreRol = checkedListBoxRolesUPD.CheckedItems[i].ToString();

                SqlCommand quitarRol = new SqlCommand("[PISOS_PICADOS].quitarRolAUsuario", Globals.conexionGlobal);
                quitarRol.CommandType = CommandType.StoredProcedure;
                quitarRol.Parameters.Add("@idUsuario", SqlDbType.Int);
                quitarRol.Parameters["@idUsuario"].Value = idUsrModificar;
                quitarRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);
                quitarRol.Parameters["@nombreRol"].Value = nombreRol;
                quitarRol.ExecuteNonQuery();


            }

            for (int i = 0; i <= checkedListBoxHotelesUPD.CheckedItems.Count - 1; i++)
            {
                string nombreHotel = checkedListBoxHotelesUPD.CheckedItems[i].ToString();

                SqlCommand eliminarHotel = new SqlCommand("[PISOS_PICADOS].quitarHotelAUsuario", Globals.conexionGlobal);
                eliminarHotel.CommandType = CommandType.StoredProcedure;
                eliminarHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
                eliminarHotel.Parameters["@idUsuario"].Value = idUsrModificar;
                eliminarHotel.Parameters.Add("@nombreHotel", SqlDbType.VarChar);
                eliminarHotel.Parameters["@nombreHotel"].Value = nombreHotel;
                eliminarHotel.ExecuteNonQuery();

            } 


            MessageBox.Show("Usuario Modificado correctamente");

            //reinicio de los textbox
            usernameUPD.ResetText();
            passUPD.ResetText();
            nombreUPD.ResetText();
            apellidoUPD.ResetText();
            comboBoxTipoUPD.ResetText();
            comboBoxPaisUPD.ResetText();
            numIdUPD.ResetText();
            mailUPD.ResetText();
            telUPD.ResetText();
            calleUPD.ResetText();
            nroUPD.ResetText();
            localidadUPD.ResetText();
            dateTimePickerUPD.ResetText();
        }


        //Buscar por nombre de usuario


        private void BuscarUyPass_Click(object sender, EventArgs e)
        {
            try
            {

                 if (!String.IsNullOrEmpty(textBoxUsrAct.Text))
                 {
                     SqlConnection conexion = Globals.conexionGlobal;

                     String usuarioNombre = textBoxUsrAct.Text;
                    


                     //Trae id por nombre de usuario

                     SqlCommand traerUsr = new SqlCommand("SELECT idUsuario FROM [PISOS_PICADOS].Empleado WHERE nombre=@nombre", conexion);
                     traerUsr.Parameters.Add("@nombre", SqlDbType.VarChar).Value = usuarioNombre;
                     SqlDataReader dr = traerUsr.ExecuteReader();
                     

                     if (dr.Read() == true)
                     {
                         //Completa usrName y Pass

                         usernameUPD.Text = dr["usuario"].ToString();
                         passUPD.Text=dr["contraseña"].ToString();
                         //TRAE DATOS USUARIO CON ESE ID
            
                         String id = dr["idUsuario"].ToString();
                         idUsrModificar = Convert.ToInt32(id);
                         traerUsr = new SqlCommand("SELECT nombre,apellido,mail,telefono,calle,nroCalle,localidad,pais,tipoIdentificacion,numeroIdentificacion,fechaNacimiento FROM [PISOS_PICADOS].Usuario WHERE idUsuario=@id", conexion);
                         traerUsr.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(id);
                         SqlDataReader dr2 = traerUsr.ExecuteReader();

                         if (dr2.Read() == true)
                         {
                           nombreUPD.Text=dr2["nombre"].ToString();
                           apellidoUPD.Text=dr2["apellido"].ToString();
                           mailUPD.Text = dr2["mail"].ToString();
                           telUPD.Text = dr2["telefono"].ToString();
                           calleUPD.Text = dr2["calle"].ToString();
                           nroUPD.Text = dr2["nroCalle"].ToString();
                           localidadUPD.Text = dr2["localidad"].ToString();
                           comboBoxPaisUPD.SelectedText= dr2["pais"].ToString();
                           comboBoxTipoUPD.SelectedText=dr2["tipoIdentificacion"].ToString();
                           numIdUPD.Text=dr2["nroIdentificacion"].ToString();
                           String fecha=  dr2["fechaNacimiento"].ToString();
                           dateTimePickerUPD.Value= DateTime.Parse(fecha);
                           cargarCheckedListBoxHoteles(idUsrModificar);
                           cargarCheckedListBoxRoles(idUsrModificar);

                         }

                        
                     }
                    
              
            }}
            catch (Exception exc)
            {
                MessageBox.Show("No se encontró Usuario");
            }
        }


//--------------------------------------------------------------------------------------------------------------------------
        static bool validarEmail(string email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        

  //------------------------------------------------------------------------------------------------------------------------
  //CHEQUEOS TAB NUEVO USR------------------------------------------------------------------------------------------------

   
        private void numDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else{e.Handled = true;}
        }

        private void textBoxTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void textNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void usernameText_KeyPress(object sender, KeyPressEventArgs e) {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        
        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {

            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }

        }
        private void nombreBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void textBoxCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void textBoxLoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void chequearSiHayCamposIncompletos() {
            if (String.IsNullOrEmpty(tel.Text)
               || String.IsNullOrEmpty(numDoc.Text)
               || String.IsNullOrEmpty(nroCalle.Text)
               || String.IsNullOrEmpty(username.Text)
               || String.IsNullOrEmpty(pass.Text)
               || String.IsNullOrEmpty(nombre.Text)
               || String.IsNullOrEmpty(apellido.Text)
               || String.IsNullOrEmpty(comboBoxTipo.SelectedText)
               || String.IsNullOrEmpty(mail.Text)
               || String.IsNullOrEmpty(calle.Text)
               || String.IsNullOrEmpty(localidad.Text)
               || ((dateTimePicker1.Checked) == false)
               || String.IsNullOrEmpty(comboBoxPais.SelectedText)
              
                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

   //------------------------------------------------------------------------------------------------------------------------
   //CHEQUEOS TAB BAJA------------------------------------------------------------------------------------------------



  //------------------------------------------------------------------------------------------------------------------------
  //CHEQUEOS TAB MODIFICAR------------------------------------------------------------------------------------------------
     
        private void numIdUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }

        private void telUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void nroUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void usernameUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void passUPD_KeyPress(object sender, KeyPressEventArgs e)
        {

            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }

        }
        private void nombreUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void apellidoUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void calleUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void localidadUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void chequearSiHayCamposIncompletosUPD()
        {
            if (String.IsNullOrEmpty(telUPD.Text)
               || String.IsNullOrEmpty(numIdUPD.Text)
               || String.IsNullOrEmpty(nroUPD.Text)
               || String.IsNullOrEmpty(usernameUPD.Text)
               || String.IsNullOrEmpty(passUPD.Text)
               || String.IsNullOrEmpty(nombreUPD.Text)
               || String.IsNullOrEmpty(apellidoUPD.Text)
               || String.IsNullOrEmpty(comboBoxTipoUPD.SelectedText)
               || String.IsNullOrEmpty(mailUPD.Text)
               || String.IsNullOrEmpty(calleUPD.Text)
               || String.IsNullOrEmpty(localidadUPD.Text)
               || ((dateTimePickerUPD.Checked) == false)
               || String.IsNullOrEmpty(comboBoxPaisUPD.SelectedText)
                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void cargarCheckedListBoxHoteles(int idUsrModificar)
        {

            SqlCommand cmdBuscarHotelesUsuario = new SqlCommand("select H.nombre from [PISOS_PICADOS].EmpleadoxHotel E join [PISOS_PICADOS].Hotel H on (E.idHotel = H.idHotel) WHERE E.idUsuario = @idUsuario", Globals.conexionGlobal);
            cmdBuscarHotelesUsuario.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsrModificar;
            SqlDataReader reader = cmdBuscarHotelesUsuario.ExecuteReader();

            while (reader.Read())
            {
                checkedListBoxHotelesUPD.Items.Add((reader["H.nombre"]).ToString());
            }

            reader.Close();

            SqlCommand cmdBuscarHotelesNoUsuario = new SqlCommand("select nombre from [PISOS_PICADOS].Hotel  WHERE nombre  not in (select H.nombre from [PISOS_PICADOS].EmpleadoxHotel E join [PISOS_PICADOS].Hotel H on (E.idHotel = H.idHotel) WHERE E.idUsuario = @idUsuario)", Globals.conexionGlobal);
            cmdBuscarHotelesNoUsuario.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsrModificar;
            SqlDataReader reader2 = cmdBuscarHotelesNoUsuario.ExecuteReader();

            while (reader2.Read())
            {
                checkedListBoxHotelesUPDNo.Items.Add((reader["nombre"]).ToString());
            }

            reader2.Close();

            return;
        }

        private void cargarCheckedListBoxRoles(int idModificar)
        {

            SqlCommand cmdBuscarHotelesUsuario = new SqlCommand("select R.nombreRol from [PISOS_PICADOS].RolxUsuario U join [PISOS_PICADOS].Rol R on (R.idRol = U.idRol) WHERE U.idUsuario = @idUsuario", Globals.conexionGlobal);
            cmdBuscarHotelesUsuario.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idModificar;
            SqlDataReader reader = cmdBuscarHotelesUsuario.ExecuteReader();

            while (reader.Read())
            {
                checkedListBoxHotelesUPD.Items.Add((reader["R.nombreRol"]).ToString());
            }

            reader.Close();

            SqlCommand cmdBuscarHotelesNoUsuario = new SqlCommand("select nombre from [PISOS_PICADOS].Rol  WHERE nombre  not in (select R.nombreRol from [PISOS_PICADOS].RolxUsuario U join [PISOS_PICADOS].Rol R on (R.idRol = U.idRol) WHERE U.idUsuario = @idUsuario)", Globals.conexionGlobal);
            cmdBuscarHotelesNoUsuario.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idModificar;
            SqlDataReader reader2 = cmdBuscarHotelesNoUsuario.ExecuteReader();

            while (reader2.Read())
            {
                checkedListBoxHotelesUPDNo.Items.Add((reader["nombre"]).ToString());
            }

            reader2.Close();

            return;
        }







//--------------------------------------------------------------------------------------------------------------------------

       

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAdm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxGuest_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numDoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nombreBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDir_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tipoYNum_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsrNameBorrar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label28_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void comboBoxRolUpd_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void checkedListHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            username.ResetText();
            pass.ResetText();
            nombre.ResetText();
            apellido.ResetText();
            comboBoxTipo.ResetText();
            comboBoxPais.ResetText();
            numDoc.ResetText();
            mail.ResetText();
            tel.ResetText();
            calle.ResetText();
            nroCalle.ResetText();
            localidad.ResetText();
            dateTimePicker1.ResetText();
            checkedListHoteles = new CheckedListBox();
            checkedListBoxRoles = new CheckedListBox();
        }

        private void buttonLimpiarUPD_Click(object sender, EventArgs e)
        {
            usernameUPD.ResetText();
            passUPD.ResetText();
            nombreUPD.ResetText();
            apellidoUPD.ResetText();
            comboBoxTipoUPD.ResetText();
            comboBoxPaisUPD.ResetText();
            numIdUPD.ResetText();
            mailUPD.ResetText();
            telUPD.ResetText();
            calleUPD.ResetText();
            nroUPD.ResetText();
            localidadUPD.ResetText();
            dateTimePickerUPD.ResetText();
            checkedListBoxHotelesUPD = new CheckedListBox();
            checkedListBoxHotelesUPDNo = new CheckedListBox();
            checkedListBoxRolesUPD = new CheckedListBox();
            checkedListBoxRolesUPDNo = new CheckedListBox();
        }

        private void buttonRecargarTabla_Click(object sender, EventArgs e)
        {
            utils.mostrarUsuarios(dataGridView1);
        }

        private void checkedListBoxRolesUPDNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxRolesUPD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxHotelesUPD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxHotelesUPDNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}