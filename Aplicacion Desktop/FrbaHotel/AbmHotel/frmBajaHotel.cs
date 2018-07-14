using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmHotel
{
    public partial class frmBajaHotel : Form
    {
        int idHotel;
        frmHoteles pantallaHoteles;

        public void asignarId(int id, frmHoteles pantalla)
        {
            idHotel = id;
            pantallaHoteles = pantalla;
            this.ShowDialog();
        }

        public frmBajaHotel()
        {
            InitializeComponent();
        }

        private void frmBajaHotel_Load(object sender, EventArgs e)
        {
            dateTimeDesde.Value = Globals.FechaDelSistema;
            dateTimeHasta.Value = Globals.FechaDelSistema;

            this.CenterToScreen();
            textBoxId.Text = idHotel.ToString();
            SqlCommand cmdNombreHotel = new SqlCommand("select nombre from [PISOS_PICADOS].Hotel where idHotel= @id", Globals.conexionGlobal);
            cmdNombreHotel.Parameters.AddWithValue("@id", idHotel);
            SqlDataReader reader = cmdNombreHotel.ExecuteReader();

            while (reader.Read())
            {
                textBoxNombre.Text=reader["nombre"].ToString();
            }

            reader.Close();
           
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {
            
            //chequeos

                    if ( razon.Text=="") { MessageBox.Show("Informe el motivo de la baja."); return;}
                    if (dateTimeDesde.Value > dateTimeHasta.Value) { MessageBox.Show("Coloque un rango de fechas correcto."); return; }
                    SqlCommand tieneReservas = new SqlCommand("select [PISOS_PICADOS].HotelTieneReservas(@idHotel, @fechaInicio, @fechaFin)", Globals.conexionGlobal);
                    tieneReservas.Parameters.AddWithValue("@idHotel", idHotel);
                    tieneReservas.Parameters.AddWithValue("@fechaInicio", dateTimeDesde.Value.ToString("yyyy-MM-dd"));
                    tieneReservas.Parameters.AddWithValue("@fechaFin", dateTimeHasta.Value.ToString("yyyy-MM-dd"));
                    Boolean  poseeReservas = (bool)tieneReservas.ExecuteScalar();
            //
      
                    if (!poseeReservas)
                    {
                        //PASO CHEQUEOS, SE DA LA BAJA

                        SqlCommand comandoBajaHotel = new SqlCommand("PISOS_PICADOS.bajaDeHotel", Globals.conexionGlobal);
                        comandoBajaHotel.CommandType = CommandType.StoredProcedure;

                        comandoBajaHotel.Parameters.AddWithValue("@idHotel", idHotel);
                        comandoBajaHotel.Parameters.AddWithValue("@fechaInicio", dateTimeDesde.Value.ToString("yyyy-MM-dd"));
                        comandoBajaHotel.Parameters.AddWithValue("@fechaFin", dateTimeHasta.Value.ToString("yyyy-MM-dd"));
                        comandoBajaHotel.Parameters.AddWithValue("@razon", razon.Text);

                        comandoBajaHotel.ExecuteNonQuery();
                        MessageBox.Show("Hotel dado de baja correctamente.");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hay reservas y/o huéspedes en el hotel entre esas fechas.");
                    }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimeDesde_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeHasta.Value < dateTimeDesde.Value) dateTimeHasta.Value = dateTimeDesde.Value;
            if (dateTimeDesde.Value < Globals.FechaDelSistema) dateTimeDesde.Value = Globals.FechaDelSistema;
        }

        private void dateTimeHasta_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimeDesde.Value > dateTimeHasta.Value) dateTimeDesde.Value = dateTimeHasta.Value;
            if (dateTimeHasta.Value < Globals.FechaDelSistema) dateTimeHasta.Value = Globals.FechaDelSistema;
        }

       
    }
}
