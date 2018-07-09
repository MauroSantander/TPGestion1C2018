using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class frmModificarHotel : Form
    {
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
                cmdpais.Parameters.AddWithValue("@paisSelect",comboBoxPAIS.SelectedText);
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
            comandoMod.Parameters.Add("@nombre", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@mail", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@telefono", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@calle", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@nroCalle", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@estrellas", SqlDbType.Int);
            comandoMod.Parameters.Add("@ciudad", SqlDbType.VarChar);
            comandoMod.Parameters.Add("@idPais", SqlDbType.Int);
            comandoMod.Parameters.Add("@fechaCreacion", SqlDbType.Date);

            comandoMod.Parameters["@nombre"].Value = textBoxName.Text;
            comandoMod.Parameters["@mail"].Value = textBoxMail.Text;
            comandoMod.Parameters["@telefono"].Value = textBoxTE.Text;
            comandoMod.Parameters["@calle"].Value = textBoxCalle.Text;
            comandoMod.Parameters["@numeroCalle"].Value = textBoxNroCalle.Text;
            comandoMod.Parameters["@estrellas"].Value = int.Parse(cBestrellas.SelectedText);
            comandoMod.Parameters["@ciudad"].Value = textBoxCIU.Text;
            comandoMod.Parameters["@idPais"].Value = idPAIS;
            comandoMod.Parameters["@fechaCreacion"].Value = dateTimePickerCreacion.Value.ToString("yyyy-MM-dd") ;

            try
            {
                comandoMod.ExecuteReader();
                MessageBox.Show("Modificación correcta");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBoxCIU_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPAIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDIR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
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

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ModificarHotel_Load(object sender, EventArgs e)
        {

        }
       
        public void cargarDatos(int id, String nombre, String mail, String telefono, String calle, int nroCalle, String ciudad, String pais, String fechaCreacion, int estrellas, Hoteles pantallaHoteles)
        {
            textBoxName.Text = nombre;
            textBoxMail.Text = mail;
            textBoxTE.Text = telefono;
            textBoxCalle.Text = calle;
            textBoxNroCalle.Text = nroCalle.ToString();
            comboBoxPAIS.SelectedText = pais;
            textBoxCIU.Text = ciudad;
            cBestrellas.SelectedText = estrellas.ToString();
            dateTimePickerCreacion.Value = DateTime.Parse(fechaCreacion);


            
            SqlCommand cmdBuscarRegimenesHotel = new SqlCommand("SELECT R.descripcion FROM [PISOS_PICADOS].Regimen R join [PISOS_PICADOS].RegimenxHotel H on (R.codigoRegimen = H.codigoRegimen) WHERE idHotel = @id", Globals.conexionGlobal);
    
            cmdBuscarRegimenesHotel.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmdBuscarRegimenesHotel.ExecuteReader();

            while (reader.Read())
            {
                checkedListBoxRegimenes.Items.Add((reader["R.descripcion"]).ToString());
            }

            reader.Close();

            SqlCommand cmdBuscarRegimenesNo = new SqlCommand("select descripcion from [PISOS_PICADOS].Regimen where descripcion not in (SELECT R.descripcion FROM [PISOS_PICADOS].Regimen R join [PISOS_PICADOS].RegimenxHotel H on (R.codigoRegimen = H.codigoRegimen) WHERE idHotel = @id)", Globals.conexionGlobal);
            cmdBuscarRegimenesNo.Parameters.AddWithValue("@id", id);
            SqlDataReader reader2 = cmdBuscarRegimenesNo.ExecuteReader();

            while (reader2.Read())
            {
                checkedListBoxRegimenesAgregar.Items.Add((reader["descripcion"]).ToString());
            }

            reader2.Close();
            
            this.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxRegimenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBoxRegimenesAgregar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            if (String.IsNullOrEmpty(textBoxName.Text)
               || String.IsNullOrEmpty(textBoxMail.Text)
               || String.IsNullOrEmpty(textBoxTE.Text)
               || String.IsNullOrEmpty(textBoxCalle.Text)
               || String.IsNullOrEmpty(textBoxNroCalle.Text)
               || String.IsNullOrEmpty(comboBoxPAIS.SelectedText)
               || String.IsNullOrEmpty(textBoxCIU.Text)
               || String.IsNullOrEmpty(cBestrellas.SelectedText)
               || ((dateTimePickerCreacion.Checked) == false)
                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void comboBoxPAIS_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}