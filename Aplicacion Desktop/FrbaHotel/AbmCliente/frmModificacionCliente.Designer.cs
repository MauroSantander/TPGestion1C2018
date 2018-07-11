namespace FrbaHotel.AbmCliente
{
    partial class frmModificacionCliente
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
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.labelPais = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.TextBox();
            this.labelNumeroCalle = new System.Windows.Forms.Label();
            this.cbTipoId = new System.Windows.Forms.ComboBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNroId = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.labelNacionalidad = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelNroId = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.btnAceptarModif2 = new System.Windows.Forms.Button();
            this.btnCancelarModif2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPaises
            // 
            this.cbPaises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPaises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Location = new System.Drawing.Point(176, 355);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(101, 21);
            this.cbPaises.TabIndex = 54;
            this.cbPaises.SelectedIndexChanged += new System.EventHandler(this.cbPaises_SelectedIndexChanged);
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(41, 358);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(32, 13);
            this.labelPais.TabIndex = 67;
            this.labelPais.Text = "País:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(176, 315);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(100, 20);
            this.txtLocalidad.TabIndex = 53;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(41, 318);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(56, 13);
            this.labelLocalidad.TabIndex = 66;
            this.labelLocalidad.Text = "Localidad:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(176, 275);
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(100, 20);
            this.txtNroCalle.TabIndex = 52;
            this.txtNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_KeyPress);
            // 
            // labelNumeroCalle
            // 
            this.labelNumeroCalle.AutoSize = true;
            this.labelNumeroCalle.Location = new System.Drawing.Point(41, 278);
            this.labelNumeroCalle.Name = "labelNumeroCalle";
            this.labelNumeroCalle.Size = new System.Drawing.Size(47, 13);
            this.labelNumeroCalle.TabIndex = 65;
            this.labelNumeroCalle.Text = "Número:";
            // 
            // cbTipoId
            // 
            this.cbTipoId.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.cbTipoId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoId.FormattingEnabled = true;
            this.cbTipoId.Items.AddRange(new object[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.cbTipoId.Location = new System.Drawing.Point(179, 115);
            this.cbTipoId.Name = "cbTipoId";
            this.cbTipoId.Size = new System.Drawing.Size(100, 21);
            this.cbTipoId.TabIndex = 47;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(179, 435);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.dtpFechaNacimiento.TabIndex = 56;
            this.dtpFechaNacimiento.Value = new System.DateTime(2018, 7, 10, 0, 0, 0, 0);
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(176, 235);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 20);
            this.txtCalle.TabIndex = 51;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(177, 195);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 50;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_KeyPress);
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(176, 395);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(100, 20);
            this.txtNacionalidad.TabIndex = 55;
            this.txtNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(179, 155);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 49;
            // 
            // txtNroId
            // 
            this.txtNroId.Location = new System.Drawing.Point(317, 115);
            this.txtNroId.Name = "txtNroId";
            this.txtNroId.Size = new System.Drawing.Size(100, 20);
            this.txtNroId.TabIndex = 48;
            this.txtNroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros_KeyPress);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(179, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 46;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 45;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaNac.Location = new System.Drawing.Point(41, 438);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(109, 13);
            this.labelFechaNac.TabIndex = 64;
            this.labelFechaNac.Text = "Fecha de nacimiento:";
            // 
            // labelNacionalidad
            // 
            this.labelNacionalidad.AutoSize = true;
            this.labelNacionalidad.Location = new System.Drawing.Point(41, 398);
            this.labelNacionalidad.Name = "labelNacionalidad";
            this.labelNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.labelNacionalidad.TabIndex = 63;
            this.labelNacionalidad.Text = "Nacionalidad:";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(41, 238);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(33, 13);
            this.labelCalle.TabIndex = 62;
            this.labelCalle.Text = "Calle:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(41, 198);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 61;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(41, 158);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 60;
            this.labelMail.Text = "Mail:";
            // 
            // labelNroId
            // 
            this.labelNroId.AutoSize = true;
            this.labelNroId.Location = new System.Drawing.Point(41, 118);
            this.labelNroId.Name = "labelNroId";
            this.labelNroId.Size = new System.Drawing.Size(127, 13);
            this.labelNroId.TabIndex = 59;
            this.labelNroId.Text = "Número de identificación:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(41, 78);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 58;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(41, 38);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 57;
            this.labelNombre.Text = "Nombre:";
            // 
            // btnAceptarModif2
            // 
            this.btnAceptarModif2.Location = new System.Drawing.Point(238, 505);
            this.btnAceptarModif2.Name = "btnAceptarModif2";
            this.btnAceptarModif2.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarModif2.TabIndex = 68;
            this.btnAceptarModif2.Text = "Aceptar";
            this.btnAceptarModif2.UseVisualStyleBackColor = true;
            this.btnAceptarModif2.Click += new System.EventHandler(this.btnAceptarModif);
            // 
            // btnCancelarModif2
            // 
            this.btnCancelarModif2.Location = new System.Drawing.Point(342, 505);
            this.btnCancelarModif2.Name = "btnCancelarModif2";
            this.btnCancelarModif2.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarModif2.TabIndex = 69;
            this.btnCancelarModif2.Text = "Cancelar";
            this.btnCancelarModif2.UseVisualStyleBackColor = true;
            this.btnCancelarModif2.Click += new System.EventHandler(this.btnCancelarModif2_Click);
            // 
            // frmModificacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 540);
            this.Controls.Add(this.btnCancelarModif2);
            this.Controls.Add(this.btnAceptarModif2);
            this.Controls.Add(this.cbPaises);
            this.Controls.Add(this.labelPais);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.labelLocalidad);
            this.Controls.Add(this.txtNroCalle);
            this.Controls.Add(this.labelNumeroCalle);
            this.Controls.Add(this.cbTipoId);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNroId);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelFechaNac);
            this.Controls.Add(this.labelNacionalidad);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelNroId);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModificacionCliente";
            this.Text = "frmModificacionCliente";
            this.Load += new System.EventHandler(this.frmModificacionCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.Label labelNumeroCalle;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.Label labelNacionalidad;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelNroId;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button btnAceptarModif2;
        private System.Windows.Forms.Button btnCancelarModif2;
        public System.Windows.Forms.ComboBox cbPaises;
        public System.Windows.Forms.TextBox txtLocalidad;
        public System.Windows.Forms.TextBox txtNroCalle;
        public System.Windows.Forms.ComboBox cbTipoId;
        public System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        public System.Windows.Forms.TextBox txtCalle;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtNacionalidad;
        public System.Windows.Forms.TextBox txtMail;
        public System.Windows.Forms.TextBox txtNroId;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
    }
}