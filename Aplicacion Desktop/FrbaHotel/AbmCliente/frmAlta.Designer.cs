namespace FrbaHotel.AbmCliente
{
    partial class frmAlta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nroId = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TipoId = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Nacionalidad = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Localidad = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.NroCalle = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Calle = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(154, 344);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 28);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(61, 344);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(87, 28);
            this.BotonCancelar.TabIndex = 14;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonCrear
            // 
            this.BotonCrear.Location = new System.Drawing.Point(247, 344);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(87, 28);
            this.BotonCrear.TabIndex = 13;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = true;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(6, 19);
            this.Nombre.MaxLength = 255;
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(146, 20);
            this.Nombre.TabIndex = 0;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Apellido);
            this.groupBox2.Location = new System.Drawing.Point(176, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 46);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apellido";
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(6, 19);
            this.Apellido.MaxLength = 255;
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(146, 20);
            this.Apellido.TabIndex = 0;
            this.Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellido_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nroId);
            this.groupBox3.Location = new System.Drawing.Point(176, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 47);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Número de identificación";
            // 
            // nroId
            // 
            this.nroId.Location = new System.Drawing.Point(6, 19);
            this.nroId.MaxLength = 9;
            this.nroId.Name = "nroId";
            this.nroId.Size = new System.Drawing.Size(146, 20);
            this.nroId.TabIndex = 0;
            this.nroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nroId_KeyPress);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TipoId);
            this.groupBox4.Location = new System.Drawing.Point(12, 79);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 47);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de identificación";
            // 
            // TipoId
            // 
            this.TipoId.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.TipoId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoId.FormattingEnabled = true;
            this.TipoId.Items.AddRange(new object[] {
            "Vacío",
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.TipoId.Location = new System.Drawing.Point(6, 19);
            this.TipoId.Name = "TipoId";
            this.TipoId.Size = new System.Drawing.Size(146, 21);
            this.TipoId.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Mail);
            this.groupBox5.Location = new System.Drawing.Point(12, 132);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(158, 47);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mail";
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(6, 19);
            this.Mail.MaxLength = 255;
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(146, 20);
            this.Mail.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Nacionalidad);
            this.groupBox6.Location = new System.Drawing.Point(12, 291);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(158, 47);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nacionalidad (Libre)";
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Location = new System.Drawing.Point(6, 19);
            this.Nacionalidad.MaxLength = 255;
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(146, 20);
            this.Nacionalidad.TabIndex = 0;
            this.Nacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nacionalidad_KeyPress);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbPaises);
            this.groupBox7.Location = new System.Drawing.Point(12, 185);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(158, 47);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "País";
            // 
            // cbPaises
            // 
            this.cbPaises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPaises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Location = new System.Drawing.Point(6, 19);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(146, 21);
            this.cbPaises.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Localidad);
            this.groupBox8.Location = new System.Drawing.Point(176, 185);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(158, 47);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Localidad";
            // 
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(6, 19);
            this.Localidad.MaxLength = 255;
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(146, 20);
            this.Localidad.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.NroCalle);
            this.groupBox9.Location = new System.Drawing.Point(176, 238);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(158, 47);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Número de calle";
            this.groupBox9.Enter += new System.EventHandler(this.groupBox9_Enter);
            // 
            // NroCalle
            // 
            this.NroCalle.Location = new System.Drawing.Point(6, 19);
            this.NroCalle.MaxLength = 9;
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.Size = new System.Drawing.Size(146, 20);
            this.NroCalle.TabIndex = 0;
            this.NroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NroCalle_KeyPress);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.Telefono);
            this.groupBox11.Location = new System.Drawing.Point(176, 132);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(158, 47);
            this.groupBox11.TabIndex = 6;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Teléfono";
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(6, 19);
            this.Telefono.MaxLength = 9;
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(146, 20);
            this.Telefono.TabIndex = 0;
            this.Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefono_KeyPress);
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(6, 19);
            this.Calle.MaxLength = 255;
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(146, 20);
            this.Calle.TabIndex = 0;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.Calle);
            this.groupBox10.Location = new System.Drawing.Point(12, 238);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(158, 47);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Calle";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.FechaNacimiento);
            this.groupBox12.Location = new System.Drawing.Point(176, 291);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(158, 47);
            this.groupBox12.TabIndex = 12;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Fecha de nacimiento";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacimiento.Location = new System.Drawing.Point(6, 16);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(146, 20);
            this.FechaNacimiento.TabIndex = 0;
            this.FechaNacimiento.Value = new System.DateTime(2018, 7, 12, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del cliente";
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonCrear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAlta";
            this.Text = "Alta de cliente";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonCrear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nroId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox TipoId;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox Nacionalidad;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox NroCalle;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Calle;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DateTimePicker FechaNacimiento;
        private System.Windows.Forms.Label label1;
    }
}