using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class frmModificarHotel : Form
    {
        int idHotel;
        frmHoteles pantallaHoteles;

        public frmModificarHotel()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            chequearSiHayCamposIncompletos();
            if (!validarEmail(textBoxMail.Text)) { MessageBox.Show("Escriba un formato de mail correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            int idPAIS;

           
            try
            {
                SqlCommand cmdpais = new SqlCommand("select idPais from [PISOS_PICADOS].Pais where nombrePais = @paisSelect", Globals.conexionGlobal);
                cmdpais.Parameters.AddWithValue("@paisSelect",comboBoxPAIS.Text);
                idPAIS = (int)cmdpais.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            String cadenaMod = "PISOS_PICADOS.modificarHotel";

            SqlCommand comandoMod= new SqlCommand(cadenaMod, Globals.conexionGlobal);
            comandoMod.CommandType = CommandType.StoredProcedure;

            //agregar parametros
            comandoMod.Parameters.Add("@idHotel", SqlDbType.Int);
            comandoMod.Parameters.Add("@nombre", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@mail", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@telefono", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@calle", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@nroCalle", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@estrellas", SqlDbType.Int);
            comandoMod.Parameters.Add("@ciudad", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@idPais", SqlDbType.Int);
            comandoMod.Parameters.Add("@fechaCreacion", SqlDbType.Date);

            comandoMod.Parameters["@idHotel"].Value = idHotel;
            comandoMod.Parameters["@nombre"].Value = textBoxName.Text;
            comandoMod.Parameters["@mail"].Value = textBoxMail.Text;
            comandoMod.Parameters["@telefono"].Value = textBoxTE.Text;
            comandoMod.Parameters["@calle"].Value = textBoxCalle.Text;
            comandoMod.Parameters["@nroCalle"].Value = textBoxNroCalle.Text;
            comandoMod.Parameters["@estrellas"].Value = int.Parse(cBestrellas.Text);
            comandoMod.Parameters["@ciudad"].Value = textBoxCIU.Text;
            comandoMod.Parameters["@idPais"].Value = idPAIS;
            comandoMod.Parameters["@fechaCreacion"].Value = dateTimePickerCreacion.Value.ToString("yyyy-MM-dd") ;

            try
            {
                comandoMod.ExecuteReader();
                pantallaHoteles.actualizarDataGrid();
                MessageBox.Show("Modificación correcta");
              

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        

        private void ModificarHotel_Load(object sender, EventArgs e)
        {

        }
       
        public void cargarDatos(int id, String nombre, String mail, String telefono, String calle, String nroCalle, String ciudad, String pais, String fechaCreacion, int estrellas, frmHoteles pantHoteles)
        {
            idHotel = id;
            textBoxName.Text = nombre;
            textBoxMail.Text = mail;
            textBoxTE.Text = telefono;
            textBoxCalle.Text = calle;
            textBoxNroCalle.Text = nroCalle.ToString();
            comboBoxPAIS.Text = pais;
            textBoxCIU.Text = ciudad;
            cBestrellas.Text = estrellas.ToString();
            pantallaHoteles = pantHoteles;
            if (fechaCreacion != "")
            {
                dateTimePickerCreacion.Text= fechaCreacion;
            }

            
            SqlCommand cmdBuscarRegimenesHotel = new SqlCommand("SELECT R.descripcion 'Desc' FROM [PISOS_PICADOS].Regimen R join [PISOS_PICADOS].RegimenxHotel H on (R.codigoRegimen = H.codigoRegimen) WHERE idHotel = @id", Globals.conexionGlobal);
    
            cmdBuscarRegimenesHotel.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmdBuscarRegimenesHotel.ExecuteReader();

            while (reader.Read())
            {
                checkedListBoxRegimenes.Items.Add((reader["Desc"]).ToString());
            }

            reader.Close();

            SqlCommand cmdBuscarRegimenesNo = new SqlCommand("select descripcion from [PISOS_PICADOS].Regimen where descripcion not in (SELECT R.descripcion FROM [PISOS_PICADOS].Regimen R join [PISOS_PICADOS].RegimenxHotel H on (R.codigoRegimen = H.codigoRegimen) WHERE idHotel = @id)", Globals.conexionGlobal);
            cmdBuscarRegimenesNo.Parameters.AddWithValue("@id", id);
            SqlDataReader reader2 = cmdBuscarRegimenesNo.ExecuteReader();

            while (reader2.Read())
            {
                checkedListBoxRegimenesAgregar.Items.Add((reader2["descripcion"]).ToString());
            }

            reader2.Close();
            
            this.ShowDialog();
        }

        

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        static bool validarEmail(string email)
        {
           
            try
            {
                if (email == null) { return false; }
                else
                {
                    new MailAddress(email);
                    return true;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }
        private void texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsLetter(e.KeyChar) || Char.IsSeparator(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
        private void nro_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)) { e.Handled = false; }
                else { e.Handled = true; }
            }
        }
    
     

        private void chequearSiHayCamposIncompletos()
        {
            if (textBoxName.Text==""
               || textBoxMail.Text==""
               || textBoxTE.Text==""
               || textBoxCalle.Text==""
               || textBoxNroCalle.Text==""
               || comboBoxPAIS.Text==""
               || textBoxCIU.Text==""
               || cBestrellas.Text==""
               || ((dateTimePickerCreacion.Checked) == false)
                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return;

            }
        }

       
    }
}