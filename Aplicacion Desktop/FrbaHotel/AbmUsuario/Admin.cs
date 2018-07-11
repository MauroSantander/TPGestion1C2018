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
        int idUsrModificar;
        DataTable dataTable;

        public Admin()
        {
            InitializeComponent();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

            this.cargarHoteles();
            this.cargarRoles();
            this.llenarDataGridView();


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
            if (checkedListHoteles.CheckedItems.Count < 1) { MessageBox.Show("Seleccione Hotel/es", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                  
            String user = username.Text;
            
                string query = "Select COUNT(*) from [PISOS_PICADOS].Empleado where  usuario= @user";

                SqlCommand cmd = new SqlCommand(query, Globals.conexionGlobal);

                cmd.Parameters.AddWithValue("@user", user);
                int countNombreUsr = Convert.ToInt32(cmd.ExecuteScalar());

                string queryMail = "Select COUNT(*) from [PISOS_PICADOS].Usuario where  mail= @mail";
                SqlCommand cmdMail = new SqlCommand(queryMail, Globals.conexionGlobal);

                cmdMail.Parameters.AddWithValue("@mail", mail.Text);
                int countMail = Convert.ToInt32(cmdMail.ExecuteScalar());

                SqlCommand verificarId = new SqlCommand("SELECT [PISOS_PICADOS].estaRepetido(@tipo,@numero)", Globals.conexionGlobal);
                verificarId.Parameters.AddWithValue("@tipo", comboBoxTipo.Text);
                verificarId.Parameters.AddWithValue("@numero", numDoc.Text);
                //if (((int)verificarId.ExecuteScalar()) == 1) { MessageBox.Show("Tipo y Nro de Identificación existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
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

                    string unRol = checkedListBoxRoles.CheckedItems[0].ToString();
                    //cargar valores
                    comandoAltaUsuario.Parameters["@username"].Value = username.Text;
                    comandoAltaUsuario.Parameters["@password"].Value = pass.Text;
                    comandoAltaUsuario.Parameters["@rol"].Value = unRol;
                    comandoAltaUsuario.Parameters["@nombre"].Value = nombre.Text;
                    comandoAltaUsuario.Parameters["@apellido"].Value = apellido.Text;
                    comandoAltaUsuario.Parameters["@mail"].Value = mail.Text;
                    comandoAltaUsuario.Parameters["@telefono"].Value = tel.Text;
                    comandoAltaUsuario.Parameters["@calle"].Value = calle.Text;
                    comandoAltaUsuario.Parameters["@numeroCalle"].Value = nroCalle.Text;
                    comandoAltaUsuario.Parameters["@localidad"].Value = localidad.Text;
                    comandoAltaUsuario.Parameters["@pais"].Value = comboBoxPais.Text;
                    comandoAltaUsuario.Parameters["@tipoDocumento"].Value = comboBoxTipo.Text;
                    comandoAltaUsuario.Parameters["@numeroDocumento"].Value = numDoc.Text;
                    comandoAltaUsuario.Parameters["@fechaNacimiento"].Value = dateTimePicker1.Value.ToString("yyyy-MM-dd"); ;
                    comandoAltaUsuario.Parameters["@estado"].Value = 1;

                    comandoAltaUsuario.ExecuteReader();

                    SqlCommand obtenerIdNuevo = new SqlCommand("SELECT [PISOS_PICADOS].obtenerIDUsuarioEmpleado(@usuario,@contrasena)", Globals.conexionGlobal);
                    obtenerIdNuevo.Parameters.AddWithValue("@usuario", username.Text);
                    obtenerIdNuevo.Parameters.AddWithValue("@contrasena", pass.Text);
                    int idNuevoUsr=(int) obtenerIdNuevo.ExecuteScalar();

                // CARGA DE ROLES

                   

                    for (int i = 1; i < (int)checkedListBoxRoles.CheckedItems.Count ; i++)
                    {
                        string nombreRol = checkedListBoxRoles.CheckedItems[i].ToString();

                        SqlCommand agregarRol = new SqlCommand("[PISOS_PICADOS].agregarRolAUsuario", Globals.conexionGlobal);
                        agregarRol.CommandType = CommandType.StoredProcedure;
                        agregarRol.Parameters.AddWithValue("@idUsuario", idNuevoUsr);
                        agregarRol.Parameters.AddWithValue("@nombreRol", checkedListBoxRoles.CheckedItems[i].ToString());
                        agregarRol.ExecuteNonQuery();


                    }

                    for (int i = 0; i <(int)checkedListHoteles.CheckedItems.Count; i++)
                    {

                        SqlCommand agregarHotel = new SqlCommand("[PISOS_PICADOS].agregarHotelAUsuario", Globals.conexionGlobal);
                        agregarHotel.CommandType = CommandType.StoredProcedure;
                        agregarHotel.Parameters.Add("@idUsuario", SqlDbType.Int);
                        agregarHotel.Parameters["@idUsuario"].Value = idNuevoUsr;
                        agregarHotel.Parameters.Add("@nombreHotel", SqlDbType.VarChar);
                        agregarHotel.Parameters["@nombreHotel"].Value =checkedListHoteles.CheckedItems[i].ToString();;
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
                    checkedListHoteles = new CheckedListBox();
                    checkedListBoxRoles = new CheckedListBox();
                    
                    


                
            }
            

 //-----------------------------------------------------------------------------------------------------------------------
 //----------------TAB BAJA-------------------------------------------------------------------------------------------

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
                if (dataGridView1.CurrentRow == null) return;

                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                using (SqlConnection cnn = Globals.conexionGlobal)
                {
                    String cadenaBajaUsuario = "PISOS_PICADOS.bajaUsuario";

                    SqlCommand comandoBajaUsuario = new SqlCommand(cadenaBajaUsuario, Globals.conexionGlobal);
                    comandoBajaUsuario.CommandType = CommandType.StoredProcedure;

                    comandoBajaUsuario.Parameters.AddWithValue("@idUsuario", id);
                    comandoBajaUsuario.ExecuteReader();
                    MessageBox.Show("Usuario dado de baja correctamente");
                    
                }

                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                this.limpiarFiltros();
            }
        }

        private void limpiarFiltros() {
            textBoxUsrNameBorrar.Text = "";
            textBox1.Text = "";
            comboBox2.Text = "Vacío";
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
            comandoAltaUsuario.Parameters.Add("@idAutor", SqlDbType.Int);
            comandoAltaUsuario.Parameters.Add("@idUsuario", SqlDbType.Int);
            comandoAltaUsuario.Parameters.Add("@username", SqlDbType.VarChar);
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
            comandoAltaUsuario.Parameters["@idAutor"].Value = Globals.idUsuarioSesion;
            comandoAltaUsuario.Parameters["@idUsuario"].Value = idUsrModificar;
            comandoAltaUsuario.Parameters["@username"].Value = usernameUPD.Text;
            comandoAltaUsuario.Parameters["@nombre"].Value = nombreUPD.Text;
            comandoAltaUsuario.Parameters["@apellido"].Value = apellidoUPD.Text;
            comandoAltaUsuario.Parameters["@mail"].Value = mailUPD.Text;
            comandoAltaUsuario.Parameters["@telefono"].Value = telUPD.Text;
            comandoAltaUsuario.Parameters["@calle"].Value = calleUPD.Text;
            comandoAltaUsuario.Parameters["@numeroCalle"].Value = int.Parse(nroUPD.Text);
            comandoAltaUsuario.Parameters["@localidad"].Value = localidadUPD.Text;
            comandoAltaUsuario.Parameters["@pais"].Value = comboBoxPaisUPD.Text;
            comandoAltaUsuario.Parameters["@tipoDocumento"].Value = comboBoxTipoUPD.Text;
            comandoAltaUsuario.Parameters["@numeroDocumento"].Value = int.Parse(numIdUPD.Text);
            comandoAltaUsuario.Parameters["@fechaNacimiento"].Value = dateTimePickerUPD.Value.ToString("yyyy-MM-dd") ;

            try
            {
                comandoAltaUsuario.ExecuteReader();
                this.llenarDataGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo modificar");
            }

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
                   

                    String usuarioNombre = textBoxUsrAct.Text;



                    //Trae id por nombre de usuario

                    SqlCommand traerUsr = new SqlCommand("SELECT * FROM [PISOS_PICADOS].Empleado WHERE usuario=@nombre", Globals.conexionGlobal);
                    traerUsr.Parameters.AddWithValue("@nombre", usuarioNombre);
                    SqlDataReader dr = traerUsr.ExecuteReader();


                    if (dr.Read() == true)
                    {
                        //Completa usrName

                        usernameUPD.Text = dr["usuario"].ToString();
                        //TRAE DATOS USUARIO CON ESE ID

                        String id = dr["idUsuario"].ToString();
                        idUsrModificar = Convert.ToInt32(id);
                        
                    }

                    dr.Close();
                    cargarCheckedListBoxHoteles(idUsrModificar);
                    cargarCheckedListBoxRoles(idUsrModificar); 

                        SqlCommand traerUsrInfo = new SqlCommand("SELECT nombre,apellido,mail,telefono,calle,nroCalle,localidad,tipoIdentificacion,numeroIdentificacion,fechaNacimiento,nombrePais FROM [PISOS_PICADOS].Usuario join [PISOS_PICADOS].Pais on (pais=idPais) WHERE idUsuario=@id", Globals.conexionGlobal);
                        traerUsrInfo.Parameters.AddWithValue("@id",idUsrModificar);
                        SqlDataReader dr2 = traerUsrInfo.ExecuteReader();

                        if (dr2.Read() == true)
                        {
                            nombreUPD.Text = dr2["nombre"].ToString();
                            apellidoUPD.Text = dr2["apellido"].ToString();
                            mailUPD.Text = dr2["mail"].ToString();
                            telUPD.Text = dr2["telefono"].ToString();
                            calleUPD.Text = dr2["calle"].ToString();
                            nroUPD.Text = dr2["nroCalle"].ToString();
                            localidadUPD.Text = dr2["localidad"].ToString();
                            comboBoxTipoUPD.Text = dr2["tipoIdentificacion"].ToString();
                            numIdUPD.Text = dr2["numeroIdentificacion"].ToString();
                            String fecha = dr2["fechaNacimiento"].ToString();
                            dateTimePickerUPD.Text = fecha;
                            comboBoxPaisUPD.Text = dr2["nombrePais"].ToString();
                        }
                           
                          
                        
                        dr2.Close();
                        
                        

                          
                }
            }
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

   
        private void numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else{e.Handled = true;}
        }

      
        private void textos_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textoYNros_KeyPress(object sender, KeyPressEventArgs e) {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textosYespacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }

        private void textoNrosYespacios_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetterOrDigit(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
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
               || String.IsNullOrEmpty(comboBoxTipo.Text)
               || String.IsNullOrEmpty(mail.Text)
               || String.IsNullOrEmpty(calle.Text)
               || String.IsNullOrEmpty(localidad.Text)
               || ((dateTimePicker1.Checked) == false)
               || String.IsNullOrEmpty(comboBoxPais.Text)
              
                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

   //------------------------------------------------------------------------------------------------------------------------
   //CHEQUEOS TAB BAJA------------------------------------------------------------------------------------------------
        private void llenarDataGridView()
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



  //------------------------------------------------------------------------------------------------------------------------
  //CHEQUEOS TAB MODIFICAR------------------------------------------------------------------------------------------------
     
       
        private void chequearSiHayCamposIncompletosUPD()
        {
            if (String.IsNullOrEmpty(telUPD.Text)
               || String.IsNullOrEmpty(numIdUPD.Text)
               || String.IsNullOrEmpty(nroUPD.Text)
               || String.IsNullOrEmpty(usernameUPD.Text)
               || String.IsNullOrEmpty(nombreUPD.Text)
               || String.IsNullOrEmpty(apellidoUPD.Text)
               || String.IsNullOrEmpty(comboBoxTipoUPD.Text)
               || String.IsNullOrEmpty(mailUPD.Text)
               || String.IsNullOrEmpty(calleUPD.Text)
               || String.IsNullOrEmpty(localidadUPD.Text)
               || ((dateTimePickerUPD.Checked) == false)
               || String.IsNullOrEmpty(comboBoxPaisUPD.Text)
                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void cargarCheckedListBoxHoteles(int idUsrModificar)
        {

            vaciarCheckedList(checkedListBoxHotelesUPD);
            vaciarCheckedList(checkedListBoxHotelesUPDNo);

            SqlCommand cmdBuscarHotelesUsuario = new SqlCommand("select H.nombre 'NombreHotel' from [PISOS_PICADOS].EmpleadoxHotel E join [PISOS_PICADOS].Hotel H on (E.idHotel = H.idHotel) WHERE E.idUsuario = @idUsuario", Globals.conexionGlobal);
            cmdBuscarHotelesUsuario.Parameters.AddWithValue("@idUsuario", idUsrModificar);
            SqlDataReader reader = cmdBuscarHotelesUsuario.ExecuteReader();

            while (reader.Read())
            {
                checkedListBoxHotelesUPD.Items.Add((reader["NombreHotel"]).ToString());
            }

            reader.Close();

            SqlCommand cmdBuscarHotelesNoUsuario = new SqlCommand("select nombre from [PISOS_PICADOS].Hotel  WHERE nombre  not in (select H.nombre from [PISOS_PICADOS].EmpleadoxHotel E join [PISOS_PICADOS].Hotel H on (E.idHotel = H.idHotel) WHERE E.idUsuario = @idUsuario)", Globals.conexionGlobal);
            cmdBuscarHotelesNoUsuario.Parameters.AddWithValue("@idUsuario", idUsrModificar);
            SqlDataReader reader2 = cmdBuscarHotelesNoUsuario.ExecuteReader();

            while (reader2.Read())
            {
                checkedListBoxHotelesUPDNo.Items.Add((reader2["nombre"]).ToString());
            }

            reader2.Close();

            return;
        }

        private void cargarCheckedListBoxRoles(int idModificar)
        {
           

            SqlCommand cmdBuscarRolesUsuario = new SqlCommand("select distinct (R.nombreRol) 'nomRol' from [PISOS_PICADOS].RolxUsuario U join [PISOS_PICADOS].Rol R on (R.idRol = U.idRol) WHERE U.idUsuario = @idUsuario", Globals.conexionGlobal);
            cmdBuscarRolesUsuario.Parameters.AddWithValue("@idUsuario", idModificar);
            SqlDataReader reader3 = cmdBuscarRolesUsuario.ExecuteReader();

            while (reader3.Read())
            {
                checkedListBoxRolesUPD.Items.Add((reader3["nomRol"]).ToString());
            }

            reader3.Close();

            SqlCommand cmdBuscarRolesNoUsuario = new SqlCommand("select distinct (nombreRol) 'nomRol' from [PISOS_PICADOS].Rol  WHERE nombreRol  not in (select distinct(nombreRol) from [PISOS_PICADOS].RolxUsuario U join [PISOS_PICADOS].Rol R on (R.idRol = U.idRol) WHERE U.idUsuario = @idUsuario)", Globals.conexionGlobal);
            cmdBuscarRolesNoUsuario.Parameters.AddWithValue("@idUsuario", idModificar);
            SqlDataReader reader2 = cmdBuscarRolesNoUsuario.ExecuteReader();

            while (reader2.Read())
            {
                checkedListBoxRolesUPDNo.Items.Add((reader2["nomRol"]).ToString());
            }

            reader2.Close();

            return;
        }







//--------------------------------------------------------------------------------------------------------------------------





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
            this.vaciarCheckedList(checkedListBoxRoles);
            this.vaciarCheckedList(checkedListHoteles);

            
        }
            

        private void vaciarCheckedList(CheckedListBox clb) 
        {   
            for (int i = 0; i < clb.Items.Count; i++)
            {
                clb.Items.RemoveAt(i);
            }

        }
        private void buttonLimpiarUPD_Click(object sender, EventArgs e)
        {
            usernameUPD.ResetText();
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
            this.vaciarCheckedList(checkedListBoxHotelesUPD);
            this.vaciarCheckedList(checkedListBoxHotelesUPDNo);
            this.vaciarCheckedList(checkedListBoxRolesUPD);
            this.vaciarCheckedList(checkedListBoxRolesUPDNo);
        }

        private void buttonRecargarTabla_Click(object sender, EventArgs e)
        {
            this.llenarDataGridView();
        }
    }
}