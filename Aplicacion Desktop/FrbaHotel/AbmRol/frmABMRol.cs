﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaHotel.AbmRol
{
    public partial class frmABMRol : Form
    {
        public frmABMRol()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxNoActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tabPageCrearRol_Click(object sender, EventArgs e)
        {

        }

        private void labelNombreRol_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            //abrir pantalla de modificacion
            //podemos agregar funcionalidades, quitarlas y modificarRol (funciondes de sql)
        }

        private void buttonBaja_Click(object sender, EventArgs e)
        {

            //chequeos
            if (cbRol.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un rol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string spBajaRol = "[PISOS_PICADOS].bajaRol";

            SqlCommand bajaRol = new SqlCommand(spBajaRol, Globals.conexionGlobal);
            bajaRol.CommandType = CommandType.StoredProcedure;

            //Agrego parametros
            bajaRol.Parameters.Add("@nombreRol", SqlDbType.VarChar);

            //Cargo valores en parametros
            bajaRol.Parameters["@nombreRol"].Value = cbRol.SelectedItem.ToString();

            if (bajaRol.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Baja realizada correctamente");
            }

        }

        private void buttonCrearRol_Click_1(object sender, EventArgs e)
        {
            
            //chequeos
            if (txtNombreRol.Text == "")
            {
                MessageBox.Show("Complete el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkListFuncionalidades.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una funcionalidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string spAltaRol = "[PISOS_PICADOS].altaRol";
            string spAgregarFuncionalidad = "[PISOS_PICADOS].agregarFuncionalidad";

            SqlCommand crearRol = new SqlCommand(spAltaRol, Globals.conexionGlobal);
            crearRol.CommandType = CommandType.StoredProcedure;

            //Agrego parametros
            crearRol.Parameters.Add("@nombre", SqlDbType.VarChar);
            crearRol.Parameters.Add("@estado", SqlDbType.Bit);

            //Cargo valores en parametros
            crearRol.Parameters["@nombre"].Value = txtNombreRol.Text;

            if (checkActivo.Checked)
            {
                crearRol.Parameters["@estado"].Value = 1;
            }
            else
            {
                crearRol.Parameters["@estado"].Value = 0;
            }

            for (int i = 0; i < (int)checkListFuncionalidades.Items.Count; i++)
            {
                if (checkListFuncionalidades.GetItemChecked(i))
                {
                    SqlCommand agregarFuncionalidad = new SqlCommand(spAgregarFuncionalidad, Globals.conexionGlobal);
                    agregarFuncionalidad.CommandType = CommandType.StoredProcedure;

                    //Agrego parametros
                    agregarFuncionalidad.Parameters.Add("@nombre", SqlDbType.VarChar);
                    agregarFuncionalidad.Parameters.Add("@funcionalidad", SqlDbType.VarChar);

                    //Cargo valores en parametros
                    agregarFuncionalidad.Parameters["@nombre"].Value = txtNombreRol.Text;
                    agregarFuncionalidad.Parameters["@funcionalidad"].Value = checkListFuncionalidades.Items[i];

                    agregarFuncionalidad.ExecuteNonQuery();
                    MessageBox.Show("Alta realizada correctamente");
                }
            }

            crearRol.ExecuteNonQuery();
            this.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMRol_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            SqlCommand cmdBuscarFuncionalidades = new SqlCommand("SELECT descripcion FROM [PISOS_PICADOS].Funcionalidad", Globals.conexionGlobal);
            SqlDataReader reader = cmdBuscarFuncionalidades.ExecuteReader();

            while (reader.Read())
            {
                checkListFuncionalidades.Items.Add((reader["descripcion"]).ToString());
            }

            reader.Close();

            SqlCommand cmdBuscarRoles = new SqlCommand("SELECT nombreRol FROM [PISOS_PICADOS].Rol", Globals.conexionGlobal);
            SqlDataReader reader2 = cmdBuscarRoles.ExecuteReader();

            while (reader2.Read())
            {
                cbRol.Items.Add((reader2["nombreRol"]).ToString());
                cbRol.SelectedItem = cbRol.Items[0];
            }

        }

    }
}
