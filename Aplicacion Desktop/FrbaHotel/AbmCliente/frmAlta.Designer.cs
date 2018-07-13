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
            this.cbPaises = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BotonCancelar = new System.Windows.Forms.Button();
            this.BotonCrear = new System.Windows.Forms.Button();
            this.labelFechaNac = new System.Windows.Forms.Label();
            this.labelNacionalidad = new System.Windows.Forms.Label();
            this.labelCalle = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelNroId = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(40, 532);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(87, 28);
            this.btnLimpiar.TabIndex = 72;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbPaises
            // 
            this.cbPaises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPaises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Location = new System.Drawing.Point(172, 396);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(101, 21);
            this.cbPaises.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "Ingrese los datos del cliente:";
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(37, 399);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(32, 13);
            this.labelPais.TabIndex = 71;
            this.labelPais.Text = "País:";
            // 
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(172, 356);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(100, 20);
            this.Localidad.TabIndex = 55;
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(37, 359);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(56, 13);
            this.labelLocalidad.TabIndex = 70;
            this.labelLocalidad.Text = "Localidad:";
            // 
            // NroCalle
            // 
            this.NroCalle.Location = new System.Drawing.Point(172, 316);
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.Size = new System.Drawing.Size(100, 20);
            this.NroCalle.TabIndex = 54;
            this.NroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNros_KeyPress);
            // 
            // labelNumeroCalle
            // 
            this.labelNumeroCalle.AutoSize = true;
            this.labelNumeroCalle.Location = new System.Drawing.Point(37, 319);
            this.labelNumeroCalle.Name = "labelNumeroCalle";
            this.labelNumeroCalle.Size = new System.Drawing.Size(47, 13);
            this.labelNumeroCalle.TabIndex = 69;
            this.labelNumeroCalle.Text = "Número:";
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
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.TipoId.Location = new System.Drawing.Point(175, 156);
            this.TipoId.Name = "TipoId";
            this.TipoId.Size = new System.Drawing.Size(100, 21);
            this.TipoId.TabIndex = 49;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacimiento.Location = new System.Drawing.Point(175, 476);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.FechaNacimiento.TabIndex = 58;
            this.FechaNacimiento.Value = new System.DateTime(2018, 7, 12, 0, 0, 0, 0);
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(172, 276);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(100, 20);
            this.Calle.TabIndex = 53;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(173, 236);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(100, 20);
            this.Telefono.TabIndex = 52;
            this.Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNros_KeyPress);
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Location = new System.Drawing.Point(172, 436);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(100, 20);
            this.Nacionalidad.TabIndex = 57;
            this.Nacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(175, 196);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(100, 20);
            this.Mail.TabIndex = 51;
            // 
            // nroId
            // 
            this.nroId.Location = new System.Drawing.Point(313, 156);
            this.nroId.Name = "nroId";
            this.nroId.Size = new System.Drawing.Size(100, 20);
            this.nroId.TabIndex = 50;
            this.nroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNros_KeyPress);
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(175, 116);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 48;
            this.Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(175, 76);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 47;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(439, 532);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(87, 28);
            this.BotonCancelar.TabIndex = 60;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonCrear
            // 
            this.BotonCrear.Location = new System.Drawing.Point(326, 532);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(87, 28);
            this.BotonCrear.TabIndex = 59;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = true;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaNac.Location = new System.Drawing.Point(37, 479);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(109, 13);
            this.labelFechaNac.TabIndex = 68;
            this.labelFechaNac.Text = "Fecha de nacimiento:";
            // 
            // labelNacionalidad
            // 
            this.labelNacionalidad.AutoSize = true;
            this.labelNacionalidad.Location = new System.Drawing.Point(37, 439);
            this.labelNacionalidad.Name = "labelNacionalidad";
            this.labelNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.labelNacionalidad.TabIndex = 67;
            this.labelNacionalidad.Text = "Nacionalidad:";
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(37, 279);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(33, 13);
            this.labelCalle.TabIndex = 66;
            this.labelCalle.Text = "Calle:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(37, 239);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 65;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(37, 199);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 64;
            this.labelMail.Text = "Mail:";
            // 
            // labelNroId
            // 
            this.labelNroId.AutoSize = true;
            this.labelNroId.Location = new System.Drawing.Point(37, 159);
            this.labelNroId.Name = "labelNroId";
            this.labelNroId.Size = new System.Drawing.Size(127, 13);
            this.labelNroId.TabIndex = 63;
            this.labelNroId.Text = "Número de identificación:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(37, 119);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 62;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(37, 79);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 61;
            this.labelNombre.Text = "Nombre:";
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 621);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.cbPaises);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.BotonCancelar);
            this.Controls.Add(this.BotonCrear);
            this.Controls.Add(this.labelFechaNac);
            this.Controls.Add(this.labelNacionalidad);
            this.Controls.Add(this.labelCalle);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelNroId);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Name = "frmAlta";
            this.Text = "frmAlta";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button BotonCancelar;
        private System.Windows.Forms.Button BotonCrear;
        private System.Windows.Forms.Label labelFechaNac;
        private System.Windows.Forms.Label labelNacionalidad;
        private System.Windows.Forms.Label labelCalle;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelNroId;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
    }
}