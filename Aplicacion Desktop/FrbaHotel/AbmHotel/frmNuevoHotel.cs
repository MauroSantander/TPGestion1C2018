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
    public partial class frmNuevoHotel : Form
    {
        frmHoteles pantallaHoteles;
        public frmNuevoHotel()
        {
            InitializeComponent();
        
        }
        
        public void abrirPantalla(frmHoteles pantHotel){
            pantallaHoteles = pantHotel;
            this.ShowDialog();
        }

        private void NuevoHotel_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SqlCommand cmdBuscarRegimenes = new SqlCommand("select descripcion from [PISOS_PICADOS].Regimen", Globals.conexionGlobal);
            SqlDataReader reader2 = cmdBuscarRegimenes.ExecuteReader();

            while (reader2.Read())
            {
                checkedListRegimenes.Items.Add((reader2["descripcion"]).ToString());
            }

            reader2.Close();

            //inicializo combobox de paises
            SqlCommand cmd = new SqlCommand("select nombrePais from [PISOS_PICADOS].Pais", Globals.conexionGlobal);


            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBoxPais.Items.Add((reader["nombrePais"]).ToString());
            }

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                chequearSiHayCamposIncompletos();
                if (textBoxMail.Text != "")
                {
                    if (!validarEmail(textBoxMail.Text)) { MessageBox.Show("Escriba un formato de mail correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
                if (checkedListRegimenes.CheckedItems.Count == 0) { MessageBox.Show("Seleccione Regimen/es", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            int idPAIS;
            try
            {
                SqlCommand cmdpais = new SqlCommand("select idPais from [PISOS_PICADOS].Pais where nombrePais = @paisSelect", Globals.conexionGlobal);
                cmdpais.Parameters.AddWithValue("@paisSelect", comboBoxPais.Text);
                idPAIS = (int)cmdpais.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            String cadenaMod = "PISOS_PICADOS.crearHotel";

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
            comandoMod.Parameters.Add("@pais", SqlDbType.Int);
            comandoMod.Parameters.Add("@fechaCreacion", SqlDbType.Date);
            comandoMod.Parameters.Add("@autorId", SqlDbType.Int);

            comandoMod.Parameters["@nombre"].Value = textBoxName.Text;
            comandoMod.Parameters["@mail"].Value = textBoxMail.Text;
            comandoMod.Parameters["@telefono"].Value = textBoxTE.Text;
            comandoMod.Parameters["@calle"].Value = textBoxCalle.Text;
            comandoMod.Parameters["@nroCalle"].Value = textBoxNroCalle.Text;
            comandoMod.Parameters["@estrellas"].Value = int.Parse(cBestrellas.Text);
            comandoMod.Parameters["@ciudad"].Value = textBoxCIU.Text;
            comandoMod.Parameters["@pais"].Value = idPAIS;
            comandoMod.Parameters["@fechaCreacion"].Value = dateTimePickerCreacion.Value.ToString("yyyy-MM-dd") ;
            comandoMod.Parameters["@autorId"].Value = Globals.idUsuarioSesion;

            

            try
            {
                comandoMod.ExecuteReader();
                SqlCommand idNuevoHotel= new SqlCommand("select idHotel from [PISOS_PICADOS].Hotel where nombre = @nombreNuevo" , Globals.conexionGlobal);
                idNuevoHotel.Parameters.AddWithValue("@nombreNuevo", textBoxName.Text );
                int idNuevo = (int)idNuevoHotel.ExecuteScalar();

                for (int i = 0; i < checkedListRegimenes.CheckedItems.Count; i++) 
                {
                    string nombreRegimen = checkedListRegimenes.CheckedItems[i].ToString();
                    SqlCommand GETidRegimen = new SqlCommand("select codigoRegimen from [PISOS_PICADOS].Regimen where descripcion = @nombreRegimen", Globals.conexionGlobal);
                    GETidRegimen.Parameters.AddWithValue("@nombreRegimen", nombreRegimen);
                    int idRegimen = (int)GETidRegimen.ExecuteScalar();

                    SqlCommand agregarRegimen = new SqlCommand("[PISOS_PICADOS].agregarRegimen", Globals.conexionGlobal);
                    agregarRegimen.CommandType = CommandType.StoredProcedure;
                    agregarRegimen.Parameters.Add("@idHotel", SqlDbType.Int);
                    agregarRegimen.Parameters["@idHotel"].Value = idNuevo;
                    agregarRegimen.Parameters.Add("@idRegimen", SqlDbType.Int);
                    agregarRegimen.Parameters["@idRegimen"].Value = idRegimen;
                    agregarRegimen.ExecuteNonQuery();
                }
                    pantallaHoteles.actualizarDataGrid();
                MessageBox.Show("Creación correcta");
                this.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

        private void textoYNros_KeyPress(object sender, KeyPressEventArgs e)
        {
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

        private void chequearSiHayCamposIncompletos()
        {
            if (String.IsNullOrEmpty(textBoxName.Text)
               || String.IsNullOrEmpty(textBoxMail.Text)
               || String.IsNullOrEmpty(textBoxTE.Text)
               || String.IsNullOrEmpty(textBoxCalle.Text)
               || String.IsNullOrEmpty(textBoxNroCalle.Text)
               || String.IsNullOrEmpty(comboBoxPais.Text)
               || String.IsNullOrEmpty(textBoxCIU.Text)
               || String.IsNullOrEmpty(cBestrellas.Text)
               || ((dateTimePickerCreacion.Checked) == false)
                )
            {
                MessageBox.Show("Faltan completar campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        }
    }
