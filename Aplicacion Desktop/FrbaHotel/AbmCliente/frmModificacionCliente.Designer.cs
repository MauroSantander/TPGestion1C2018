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
            this.Localidad = new System.Windows.Forms.TextBox();
            this.labelLocalidad = new System.Windows.Forms.Label();
            this.NroCalle = new System.Windows.Forms.TextBox();
            this.labelNumeroCalle = new System.Windows.Forms.Label();
            this.TipoId = new System.Windows.Forms.ComboBox();
            this.FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Calle = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Nacionalidad = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.TextBox();
            this.nroId = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
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
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Location = new System.Drawing.Point(176, 355);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(101, 21);
            this.cbPaises.TabIndex = 54;
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
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(176, 315);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(100, 20);
            this.Localidad.TabIndex = 53;
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
            // NroCalle
            // 
            this.NroCalle.Location = new System.Drawing.Point(176, 275);
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.Size = new System.Drawing.Size(100, 20);
            this.NroCalle.TabIndex = 52;
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
            // TipoId
            // 
            this.TipoId.AutoCompleteCustomSource.AddRange(new string[] {
            "L. E/DNI",
            "CARNET EXT.",
            "RUC",
            "PASAPORTE",
            "P. NAC.",
            "OTROS"});
            this.TipoId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TipoId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TipoId.FormattingEnabled = true;
            this.TipoId.Items.AddRange(new object[] {
            "L. E/DNI",
            "CARNET EXT.",
            "PASAPORTE"});
            this.TipoId.Location = new System.Drawing.Point(179, 115);
            this.TipoId.Name = "TipoId";
            this.TipoId.Size = new System.Drawing.Size(100, 21);
            this.TipoId.TabIndex = 47;
            this.TipoId.Text = "Tipo";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacimiento.Location = new System.Drawing.Point(179, 435);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.FechaNacimiento.TabIndex = 56;
            this.FechaNacimiento.Value = new System.DateTime(2018, 6, 28, 0, 0, 0, 0);
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(176, 235);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(100, 20);
            this.Calle.TabIndex = 51;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(177, 195);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(100, 20);
            this.Telefono.TabIndex = 50;
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Location = new System.Drawing.Point(176, 395);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(100, 20);
            this.Nacionalidad.TabIndex = 55;
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(179, 155);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(100, 20);
            this.Mail.TabIndex = 49;
            // 
            // nroId
            // 
            this.nroId.Location = new System.Drawing.Point(317, 115);
            this.nroId.Name = "nroId";
            this.nroId.Size = new System.Drawing.Size(100, 20);
            this.nroId.TabIndex = 48;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(179, 75);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 46;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(179, 35);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 45;
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
            this.btnAceptarModif2.Click += new System.EventHandler(this.button1_Click);
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
            this.Controls.Add(this.Localidad);
            this.Controls.Add(this.labelLocalidad);
            this.Controls.Add(this.NroCalle);
            this.Controls.Add(this.labelNumeroCalle);
            this.Controls.Add(this.TipoId);
            this.Controls.Add(this.FechaNacimiento);
            this.Controls.Add(this.Calle);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Nacionalidad);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.nroId);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.labelFechaNac);
            this.Controls.Add(this.labelNacionalidad);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelNroId);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Name = "frmModificacionCliente";
            this.Text = "frmModificacionCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox NroCalle;
        private System.Windows.Forms.Label labelNumeroCalle;
        private System.Windows.Forms.ComboBox TipoId;
        private System.Windows.Forms.DateTimePicker FechaNacimiento;
        private System.Windows.Forms.TextBox Calle;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Nacionalidad;
        private System.Windows.Forms.TextBox Mail;
        private System.Windows.Forms.TextBox nroId;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Nombre;
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
    }
}