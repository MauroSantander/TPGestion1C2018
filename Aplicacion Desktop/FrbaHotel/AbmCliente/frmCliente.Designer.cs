namespace FrbaHotel.AbmCliente
{
    partial class frmCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabCliente = new System.Windows.Forms.TabControl();
            this.Alta = new System.Windows.Forms.TabPage();
            this.Pais = new System.Windows.Forms.TextBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BotonModifVerClientes = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BotonBaja = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.BotonVerClientes = new System.Windows.Forms.Button();
            this.tabCliente.SuspendLayout();
            this.Alta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del cliente:";
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.Alta);
            this.tabCliente.Controls.Add(this.tabPage2);
            this.tabCliente.Controls.Add(this.tabPage3);
            this.tabCliente.Location = new System.Drawing.Point(14, 12);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(522, 437);
            this.tabCliente.TabIndex = 21;
            // 
            // Alta
            // 
            this.Alta.BackColor = System.Drawing.Color.Transparent;
            this.Alta.Controls.Add(this.Pais);
            this.Alta.Controls.Add(this.labelPais);
            this.Alta.Controls.Add(this.Localidad);
            this.Alta.Controls.Add(this.labelLocalidad);
            this.Alta.Controls.Add(this.NroCalle);
            this.Alta.Controls.Add(this.labelNumeroCalle);
            this.Alta.Controls.Add(this.TipoId);
            this.Alta.Controls.Add(this.FechaNacimiento);
            this.Alta.Controls.Add(this.Calle);
            this.Alta.Controls.Add(this.Telefono);
            this.Alta.Controls.Add(this.Nacionalidad);
            this.Alta.Controls.Add(this.Mail);
            this.Alta.Controls.Add(this.nroId);
            this.Alta.Controls.Add(this.Apellido);
            this.Alta.Controls.Add(this.Nombre);
            this.Alta.Controls.Add(this.BotonCancelar);
            this.Alta.Controls.Add(this.BotonCrear);
            this.Alta.Controls.Add(this.labelFechaNac);
            this.Alta.Controls.Add(this.labelNacionalidad);
            this.Alta.Controls.Add(this.labelCalle);
            this.Alta.Controls.Add(this.labelTelefono);
            this.Alta.Controls.Add(this.labelMail);
            this.Alta.Controls.Add(this.labelNroId);
            this.Alta.Controls.Add(this.labelApellido);
            this.Alta.Controls.Add(this.labelNombre);
            this.Alta.Location = new System.Drawing.Point(4, 22);
            this.Alta.Name = "Alta";
            this.Alta.Padding = new System.Windows.Forms.Padding(3);
            this.Alta.Size = new System.Drawing.Size(514, 411);
            this.Alta.TabIndex = 0;
            this.Alta.Text = "Alta";
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // Pais
            // 
            this.Pais.Location = new System.Drawing.Point(155, 236);
            this.Pais.Name = "Pais";
            this.Pais.Size = new System.Drawing.Size(100, 20);
            this.Pais.TabIndex = 10;
            this.Pais.TextChanged += new System.EventHandler(this.Pais_TextChanged);
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(23, 243);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(32, 13);
            this.labelPais.TabIndex = 44;
            this.labelPais.Text = "País:";
            // 
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(155, 210);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(100, 20);
            this.Localidad.TabIndex = 9;
            this.Localidad.TextChanged += new System.EventHandler(this.Localidad_TextChanged);
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(20, 217);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(56, 13);
            this.labelLocalidad.TabIndex = 42;
            this.labelLocalidad.Text = "Localidad:";
            this.labelLocalidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // NroCalle
            // 
            this.NroCalle.Location = new System.Drawing.Point(155, 184);
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.Size = new System.Drawing.Size(100, 20);
            this.NroCalle.TabIndex = 8;
            this.NroCalle.TextChanged += new System.EventHandler(this.NroCalle_TextChanged);
            // 
            // labelNumeroCalle
            // 
            this.labelNumeroCalle.AutoSize = true;
            this.labelNumeroCalle.Location = new System.Drawing.Point(20, 191);
            this.labelNumeroCalle.Name = "labelNumeroCalle";
            this.labelNumeroCalle.Size = new System.Drawing.Size(47, 13);
            this.labelNumeroCalle.TabIndex = 40;
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
            "RUC",
            "PASAPORTE",
            "P. NAC.",
            "OTROS"});
            this.TipoId.Location = new System.Drawing.Point(156, 78);
            this.TipoId.Name = "TipoId";
            this.TipoId.Size = new System.Drawing.Size(100, 21);
            this.TipoId.TabIndex = 3;
            this.TipoId.Text = "Tipo";
            this.TipoId.SelectedIndexChanged += new System.EventHandler(this.TipoId_SelectedIndexChanged);
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacimiento.Location = new System.Drawing.Point(155, 310);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.FechaNacimiento.TabIndex = 12;
            this.FechaNacimiento.Value = new System.DateTime(2018, 6, 28, 0, 0, 0, 0);
            this.FechaNacimiento.ValueChanged += new System.EventHandler(this.FechaNacimiento_ValueChanged);
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(155, 158);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(100, 20);
            this.Calle.TabIndex = 7;
            this.Calle.TextChanged += new System.EventHandler(this.Calle_TextChanged);
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(156, 132);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(100, 20);
            this.Telefono.TabIndex = 6;
            this.Telefono.TextChanged += new System.EventHandler(this.Telefono_TextChanged);
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Location = new System.Drawing.Point(155, 270);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(100, 20);
            this.Nacionalidad.TabIndex = 11;
            this.Nacionalidad.TextChanged += new System.EventHandler(this.Nacionalidad_TextChanged);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(155, 105);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(100, 20);
            this.Mail.TabIndex = 5;
            this.Mail.TextChanged += new System.EventHandler(this.Mail_TextChanged);
            // 
            // nroId
            // 
            this.nroId.Location = new System.Drawing.Point(262, 77);
            this.nroId.Name = "nroId";
            this.nroId.Size = new System.Drawing.Size(100, 20);
            this.nroId.TabIndex = 4;
            this.nroId.TextChanged += new System.EventHandler(this.nroId_TextChanged);
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(156, 53);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 2;
            this.Apellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(156, 27);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 1;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(382, 369);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotonCancelar.TabIndex = 14;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonCrear
            // 
            this.BotonCrear.Location = new System.Drawing.Point(285, 369);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(75, 23);
            this.BotonCrear.TabIndex = 13;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = true;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaNac.Location = new System.Drawing.Point(22, 310);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(109, 13);
            this.labelFechaNac.TabIndex = 28;
            this.labelFechaNac.Text = "Fecha de nacimiento:";
            this.labelFechaNac.Click += new System.EventHandler(this.labelFechaNac_Click);
            // 
            // labelNacionalidad
            // 
            this.labelNacionalidad.AutoSize = true;
            this.labelNacionalidad.Location = new System.Drawing.Point(22, 270);
            this.labelNacionalidad.Name = "labelNacionalidad";
            this.labelNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.labelNacionalidad.TabIndex = 27;
            this.labelNacionalidad.Text = "Nacionalidad:";
            this.labelNacionalidad.Click += new System.EventHandler(this.labelNacionalidad_Click);
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(20, 165);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(33, 13);
            this.labelCalle.TabIndex = 26;
            this.labelCalle.Text = "Calle:";
            this.labelCalle.Click += new System.EventHandler(this.labelCalle_Click);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(20, 132);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 25;
            this.labelTelefono.Text = "Teléfono:";
            this.labelTelefono.Click += new System.EventHandler(this.labelTelefono_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(22, 104);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 24;
            this.labelMail.Text = "Mail:";
            this.labelMail.Click += new System.EventHandler(this.labelMail_Click);
            // 
            // labelNroId
            // 
            this.labelNroId.AutoSize = true;
            this.labelNroId.Location = new System.Drawing.Point(20, 77);
            this.labelNroId.Name = "labelNroId";
            this.labelNroId.Size = new System.Drawing.Size(127, 13);
            this.labelNroId.TabIndex = 23;
            this.labelNroId.Text = "Número de identificación:";
            this.labelNroId.Click += new System.EventHandler(this.labelNroId_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(22, 52);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 22;
            this.labelApellido.Text = "Apellido:";
            this.labelApellido.Click += new System.EventHandler(this.labelApellido_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(20, 27);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.BotonModifVerClientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(514, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 69);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(495, 156);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // BotonModifVerClientes
            // 
            this.BotonModifVerClientes.Location = new System.Drawing.Point(3, 9);
            this.BotonModifVerClientes.Name = "BotonModifVerClientes";
            this.BotonModifVerClientes.Size = new System.Drawing.Size(75, 23);
            this.BotonModifVerClientes.TabIndex = 5;
            this.BotonModifVerClientes.Text = "Ver Clientes";
            this.BotonModifVerClientes.UseVisualStyleBackColor = true;
            this.BotonModifVerClientes.Click += new System.EventHandler(this.BotonModifVerClientes_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.BotonBaja);
            this.tabPage3.Controls.Add(this.dataGridViewClientes);
            this.tabPage3.Controls.Add(this.BotonVerClientes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(514, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Baja";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // BotonBaja
            // 
            this.BotonBaja.Location = new System.Drawing.Point(146, 251);
            this.BotonBaja.Name = "BotonBaja";
            this.BotonBaja.Size = new System.Drawing.Size(75, 37);
            this.BotonBaja.TabIndex = 5;
            this.BotonBaja.Text = "Dar de Baja";
            this.BotonBaja.UseVisualStyleBackColor = true;
            this.BotonBaja.Click += new System.EventHandler(this.BotonBaja_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(3, 70);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(483, 150);
            this.dataGridViewClientes.TabIndex = 4;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // BotonVerClientes
            // 
            this.BotonVerClientes.Location = new System.Drawing.Point(3, 10);
            this.BotonVerClientes.Name = "BotonVerClientes";
            this.BotonVerClientes.Size = new System.Drawing.Size(75, 23);
            this.BotonVerClientes.TabIndex = 3;
            this.BotonVerClientes.Text = "Ver Clientes";
            this.BotonVerClientes.UseVisualStyleBackColor = true;
            this.BotonVerClientes.Click += new System.EventHandler(this.BotonVerClientes_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 482);
            this.Controls.Add(this.tabCliente);
            this.Controls.Add(this.label1);
            this.Name = "frmCliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCliente.ResumeLayout(false);
            this.Alta.ResumeLayout(false);
            this.Alta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabCliente;
        private System.Windows.Forms.TabPage Alta;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BotonModifVerClientes;
        private System.Windows.Forms.Button BotonBaja;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button BotonVerClientes;
        private System.Windows.Forms.TextBox Pais;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox NroCalle;
        private System.Windows.Forms.Label labelNumeroCalle;
    }
}