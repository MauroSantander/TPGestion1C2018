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
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewModificarCliente = new System.Windows.Forms.DataGridView();
            this.btnCancelarModif = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailModif = new System.Windows.Forms.TextBox();
            this.txtApellidoModif = new System.Windows.Forms.TextBox();
            this.txtNombreModif = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtNroIdModif = new System.Windows.Forms.TextBox();
            this.cmbTipoIdModif = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCancelarBaja = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNroId = new System.Windows.Forms.TextBox();
            this.cbTipoId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.BotonBaja = new System.Windows.Forms.Button();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.tabCliente.SuspendLayout();
            this.Alta.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCliente)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los datos del cliente:";
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.Alta);
            this.tabCliente.Controls.Add(this.tabPage2);
            this.tabCliente.Controls.Add(this.tabPage3);
            this.tabCliente.Location = new System.Drawing.Point(0, 12);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.SelectedIndex = 0;
            this.tabCliente.Size = new System.Drawing.Size(586, 621);
            this.tabCliente.TabIndex = 21;
            // 
            // Alta
            // 
            this.Alta.BackColor = System.Drawing.Color.Transparent;
            this.Alta.Controls.Add(this.cbPaises);
            this.Alta.Controls.Add(this.label1);
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
            this.Alta.Size = new System.Drawing.Size(578, 595);
            this.Alta.TabIndex = 0;
            this.Alta.Text = "Alta";
            this.Alta.Click += new System.EventHandler(this.Alta_Click);
            // 
            // cbPaises
            // 
            this.cbPaises.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPaises.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaises.FormattingEnabled = true;
            this.cbPaises.Location = new System.Drawing.Point(155, 380);
            this.cbPaises.Name = "cbPaises";
            this.cbPaises.Size = new System.Drawing.Size(101, 21);
            this.cbPaises.TabIndex = 10;
            this.cbPaises.SelectedIndexChanged += new System.EventHandler(this.cbPaises_SelectedIndexChanged);
            // 
            // labelPais
            // 
            this.labelPais.AutoSize = true;
            this.labelPais.Location = new System.Drawing.Point(20, 383);
            this.labelPais.Name = "labelPais";
            this.labelPais.Size = new System.Drawing.Size(32, 13);
            this.labelPais.TabIndex = 44;
            this.labelPais.Text = "País:";
            // 
            // Localidad
            // 
            this.Localidad.Location = new System.Drawing.Point(155, 340);
            this.Localidad.Name = "Localidad";
            this.Localidad.Size = new System.Drawing.Size(100, 20);
            this.Localidad.TabIndex = 9;
            this.Localidad.TextChanged += new System.EventHandler(this.Localidad_TextChanged);
            this.Localidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Localidad_KeyPress);
            // 
            // labelLocalidad
            // 
            this.labelLocalidad.AutoSize = true;
            this.labelLocalidad.Location = new System.Drawing.Point(20, 343);
            this.labelLocalidad.Name = "labelLocalidad";
            this.labelLocalidad.Size = new System.Drawing.Size(56, 13);
            this.labelLocalidad.TabIndex = 42;
            this.labelLocalidad.Text = "Localidad:";
            this.labelLocalidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // NroCalle
            // 
            this.NroCalle.Location = new System.Drawing.Point(155, 300);
            this.NroCalle.Name = "NroCalle";
            this.NroCalle.Size = new System.Drawing.Size(100, 20);
            this.NroCalle.TabIndex = 8;
            this.NroCalle.TextChanged += new System.EventHandler(this.NroCalle_TextChanged);
            this.NroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NroCalle_KeyPress);
            // 
            // labelNumeroCalle
            // 
            this.labelNumeroCalle.AutoSize = true;
            this.labelNumeroCalle.Location = new System.Drawing.Point(20, 303);
            this.labelNumeroCalle.Name = "labelNumeroCalle";
            this.labelNumeroCalle.Size = new System.Drawing.Size(47, 13);
            this.labelNumeroCalle.TabIndex = 40;
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
            this.TipoId.Location = new System.Drawing.Point(158, 140);
            this.TipoId.Name = "TipoId";
            this.TipoId.Size = new System.Drawing.Size(100, 21);
            this.TipoId.TabIndex = 3;
            this.TipoId.SelectedIndexChanged += new System.EventHandler(this.TipoId_SelectedIndexChanged);
            this.TipoId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoId_KeyPress);
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.CustomFormat = "yyyy-MM-dd";
            this.FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaNacimiento.Location = new System.Drawing.Point(158, 460);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.FechaNacimiento.TabIndex = 12;
            this.FechaNacimiento.Value = new System.DateTime(2018, 6, 28, 0, 0, 0, 0);
            this.FechaNacimiento.ValueChanged += new System.EventHandler(this.FechaNacimiento_ValueChanged);
            // 
            // Calle
            // 
            this.Calle.Location = new System.Drawing.Point(155, 260);
            this.Calle.Name = "Calle";
            this.Calle.Size = new System.Drawing.Size(100, 20);
            this.Calle.TabIndex = 7;
            this.Calle.TextChanged += new System.EventHandler(this.Calle_TextChanged);
            this.Calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calle_KeyPress);
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(156, 220);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(100, 20);
            this.Telefono.TabIndex = 6;
            this.Telefono.TextChanged += new System.EventHandler(this.Telefono_TextChanged);
            this.Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefono_KeyPress);
            // 
            // Nacionalidad
            // 
            this.Nacionalidad.Location = new System.Drawing.Point(155, 420);
            this.Nacionalidad.Name = "Nacionalidad";
            this.Nacionalidad.Size = new System.Drawing.Size(100, 20);
            this.Nacionalidad.TabIndex = 11;
            this.Nacionalidad.TextChanged += new System.EventHandler(this.Nacionalidad_TextChanged);
            this.Nacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nacionalidad_KeyPress);
            // 
            // Mail
            // 
            this.Mail.Location = new System.Drawing.Point(158, 180);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(100, 20);
            this.Mail.TabIndex = 5;
            this.Mail.TextChanged += new System.EventHandler(this.Mail_TextChanged);
            // 
            // nroId
            // 
            this.nroId.Location = new System.Drawing.Point(296, 140);
            this.nroId.Name = "nroId";
            this.nroId.Size = new System.Drawing.Size(100, 20);
            this.nroId.TabIndex = 4;
            this.nroId.TextChanged += new System.EventHandler(this.nroId_TextChanged);
            this.nroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nroId_KeyPress);
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(158, 100);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(100, 20);
            this.Apellido.TabIndex = 2;
            this.Apellido.TextChanged += new System.EventHandler(this.Apellido_TextChanged);
            this.Apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellido_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(158, 60);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 1;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // BotonCancelar
            // 
            this.BotonCancelar.Location = new System.Drawing.Point(396, 506);
            this.BotonCancelar.Name = "BotonCancelar";
            this.BotonCancelar.Size = new System.Drawing.Size(99, 48);
            this.BotonCancelar.TabIndex = 14;
            this.BotonCancelar.Text = "Cancelar";
            this.BotonCancelar.UseVisualStyleBackColor = true;
            this.BotonCancelar.Click += new System.EventHandler(this.BotonCancelar_Click);
            // 
            // BotonCrear
            // 
            this.BotonCrear.Location = new System.Drawing.Point(265, 506);
            this.BotonCrear.Name = "BotonCrear";
            this.BotonCrear.Size = new System.Drawing.Size(109, 48);
            this.BotonCrear.TabIndex = 13;
            this.BotonCrear.Text = "Crear";
            this.BotonCrear.UseVisualStyleBackColor = true;
            this.BotonCrear.Click += new System.EventHandler(this.BotonCrear_Click);
            // 
            // labelFechaNac
            // 
            this.labelFechaNac.AutoSize = true;
            this.labelFechaNac.BackColor = System.Drawing.Color.Transparent;
            this.labelFechaNac.Location = new System.Drawing.Point(20, 463);
            this.labelFechaNac.Name = "labelFechaNac";
            this.labelFechaNac.Size = new System.Drawing.Size(109, 13);
            this.labelFechaNac.TabIndex = 28;
            this.labelFechaNac.Text = "Fecha de nacimiento:";
            this.labelFechaNac.Click += new System.EventHandler(this.labelFechaNac_Click);
            // 
            // labelNacionalidad
            // 
            this.labelNacionalidad.AutoSize = true;
            this.labelNacionalidad.Location = new System.Drawing.Point(20, 423);
            this.labelNacionalidad.Name = "labelNacionalidad";
            this.labelNacionalidad.Size = new System.Drawing.Size(72, 13);
            this.labelNacionalidad.TabIndex = 27;
            this.labelNacionalidad.Text = "Nacionalidad:";
            this.labelNacionalidad.Click += new System.EventHandler(this.labelNacionalidad_Click);
            // 
            // labelCalle
            // 
            this.labelCalle.AutoSize = true;
            this.labelCalle.Location = new System.Drawing.Point(20, 263);
            this.labelCalle.Name = "labelCalle";
            this.labelCalle.Size = new System.Drawing.Size(33, 13);
            this.labelCalle.TabIndex = 26;
            this.labelCalle.Text = "Calle:";
            this.labelCalle.Click += new System.EventHandler(this.labelCalle_Click);
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(20, 223);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 25;
            this.labelTelefono.Text = "Teléfono:";
            this.labelTelefono.Click += new System.EventHandler(this.labelTelefono_Click);
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(20, 183);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 24;
            this.labelMail.Text = "Mail:";
            this.labelMail.Click += new System.EventHandler(this.labelMail_Click);
            // 
            // labelNroId
            // 
            this.labelNroId.AutoSize = true;
            this.labelNroId.Location = new System.Drawing.Point(20, 143);
            this.labelNroId.Name = "labelNroId";
            this.labelNroId.Size = new System.Drawing.Size(127, 13);
            this.labelNroId.TabIndex = 23;
            this.labelNroId.Text = "Número de identificación:";
            this.labelNroId.Click += new System.EventHandler(this.labelNroId_Click);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(20, 103);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(47, 13);
            this.labelApellido.TabIndex = 22;
            this.labelApellido.Text = "Apellido:";
            this.labelApellido.Click += new System.EventHandler(this.labelApellido_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(20, 63);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 21;
            this.labelNombre.Text = "Nombre:";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridViewModificarCliente);
            this.tabPage2.Controls.Add(this.btnCancelarModif);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtMailModif);
            this.tabPage2.Controls.Add(this.txtApellidoModif);
            this.tabPage2.Controls.Add(this.txtNombreModif);
            this.tabPage2.Controls.Add(this.btnSeleccionar);
            this.tabPage2.Controls.Add(this.txtNroIdModif);
            this.tabPage2.Controls.Add(this.cmbTipoIdModif);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.lblBuscarPor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 595);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Modificar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Filtrar por:";
            // 
            // dataGridViewModificarCliente
            // 
            this.dataGridViewModificarCliente.AllowUserToOrderColumns = true;
            this.dataGridViewModificarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarCliente.Location = new System.Drawing.Point(15, 209);
            this.dataGridViewModificarCliente.Name = "dataGridViewModificarCliente";
            this.dataGridViewModificarCliente.ReadOnly = true;
            this.dataGridViewModificarCliente.Size = new System.Drawing.Size(552, 294);
            this.dataGridViewModificarCliente.TabIndex = 76;
            // 
            // btnCancelarModif
            // 
            this.btnCancelarModif.Location = new System.Drawing.Point(469, 542);
            this.btnCancelarModif.Name = "btnCancelarModif";
            this.btnCancelarModif.Size = new System.Drawing.Size(94, 33);
            this.btnCancelarModif.TabIndex = 75;
            this.btnCancelarModif.Text = "Cancelar";
            this.btnCancelarModif.UseVisualStyleBackColor = true;
            this.btnCancelarModif.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(220, 154);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(103, 38);
            this.btnBuscar.TabIndex = 62;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nombre";
            // 
            // txtMailModif
            // 
            this.txtMailModif.Location = new System.Drawing.Point(459, 65);
            this.txtMailModif.Name = "txtMailModif";
            this.txtMailModif.Size = new System.Drawing.Size(91, 20);
            this.txtMailModif.TabIndex = 58;
            // 
            // txtApellidoModif
            // 
            this.txtApellidoModif.Location = new System.Drawing.Point(89, 98);
            this.txtApellidoModif.Name = "txtApellidoModif";
            this.txtApellidoModif.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoModif.TabIndex = 57;
            this.txtApellidoModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellido_KeyPress);
            // 
            // txtNombreModif
            // 
            this.txtNombreModif.Location = new System.Drawing.Point(89, 66);
            this.txtNombreModif.Name = "txtNombreModif";
            this.txtNombreModif.Size = new System.Drawing.Size(100, 20);
            this.txtNombreModif.TabIndex = 56;
            this.txtNombreModif.TextChanged += new System.EventHandler(this.txtNombreModif_TextChanged);
            this.txtNombreModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionar.Location = new System.Drawing.Point(207, 509);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(127, 51);
            this.btnSeleccionar.TabIndex = 55;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtNroIdModif
            // 
            this.txtNroIdModif.Location = new System.Drawing.Point(312, 101);
            this.txtNroIdModif.Name = "txtNroIdModif";
            this.txtNroIdModif.Size = new System.Drawing.Size(80, 20);
            this.txtNroIdModif.TabIndex = 45;
            this.txtNroIdModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nro_IdKeyPress);
            // 
            // cmbTipoIdModif
            // 
            this.cmbTipoIdModif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIdModif.FormattingEnabled = true;
            this.cmbTipoIdModif.Items.AddRange(new object[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.cmbTipoIdModif.Location = new System.Drawing.Point(312, 65);
            this.cmbTipoIdModif.Name = "cmbTipoIdModif";
            this.cmbTipoIdModif.Size = new System.Drawing.Size(80, 21);
            this.cmbTipoIdModif.TabIndex = 46;
            this.cmbTipoIdModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoId_KeyPress);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(204, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 13);
            this.label31.TabIndex = 51;
            this.label31.Text = "N° de Identificación";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(204, 73);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(28, 13);
            this.label30.TabIndex = 50;
            this.label30.Text = "Tipo";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(12, 10);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(280, 15);
            this.lblBuscarPor.TabIndex = 7;
            this.lblBuscarPor.Text = "Seleccione el cliente que desea modificar:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCancelarBaja);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.textBoxMail);
            this.tabPage3.Controls.Add(this.textBoxApellido);
            this.tabPage3.Controls.Add(this.textBoxNombre);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.textBoxNroId);
            this.tabPage3.Controls.Add(this.cbTipoId);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.BotonBaja);
            this.tabPage3.Controls.Add(this.dataGridViewClientes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(578, 595);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Baja";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCancelarBaja
            // 
            this.btnCancelarBaja.Location = new System.Drawing.Point(440, 537);
            this.btnCancelarBaja.Name = "btnCancelarBaja";
            this.btnCancelarBaja.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBaja.TabIndex = 74;
            this.btnCancelarBaja.Text = "Cancelar";
            this.btnCancelarBaja.UseVisualStyleBackColor = true;
            this.btnCancelarBaja.Click += new System.EventHandler(this.btnCancelarBaja_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Apellido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Nombre:";
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(459, 65);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(91, 20);
            this.textBoxMail.TabIndex = 70;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(89, 98);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellido.TabIndex = 69;
            this.textBoxApellido.TextChanged += new System.EventHandler(this.textBoxApellido_TextChanged);
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellido_KeyPress);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(89, 66);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 68;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 38);
            this.button2.TabIndex = 66;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBuscarFiltrado);
            // 
            // textBoxNroId
            // 
            this.textBoxNroId.Location = new System.Drawing.Point(312, 101);
            this.textBoxNroId.Name = "textBoxNroId";
            this.textBoxNroId.Size = new System.Drawing.Size(80, 20);
            this.textBoxNroId.TabIndex = 62;
            this.textBoxNroId.TextChanged += new System.EventHandler(this.textBoxNroId_TextChanged);
            this.textBoxNroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nroId_KeyPress);
            // 
            // cbTipoId
            // 
            this.cbTipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoId.FormattingEnabled = true;
            this.cbTipoId.Items.AddRange(new object[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.cbTipoId.Location = new System.Drawing.Point(312, 65);
            this.cbTipoId.Name = "cbTipoId";
            this.cbTipoId.Size = new System.Drawing.Size(80, 21);
            this.cbTipoId.TabIndex = 63;
            this.cbTipoId.SelectedIndexChanged += new System.EventHandler(this.cbTipoId_SelectedIndexChanged_1);
            this.cbTipoId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TipoId_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "N° de Identificación:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Tipo ID:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(279, 15);
            this.label15.TabIndex = 57;
            this.label15.Text = "Seleccione Cliente que desea dar de baja:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Filtrar por:";
            // 
            // BotonBaja
            // 
            this.BotonBaja.Location = new System.Drawing.Point(207, 509);
            this.BotonBaja.Name = "BotonBaja";
            this.BotonBaja.Size = new System.Drawing.Size(127, 51);
            this.BotonBaja.TabIndex = 5;
            this.BotonBaja.Text = "Dar de Baja";
            this.BotonBaja.UseVisualStyleBackColor = true;
            this.BotonBaja.Click += new System.EventHandler(this.BotonBaja_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(15, 209);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(552, 294);
            this.dataGridViewClientes.TabIndex = 4;
            this.dataGridViewClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellContentClick);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 621);
            this.Controls.Add(this.tabCliente);
            this.Name = "frmCliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCliente.ResumeLayout(false);
            this.Alta.ResumeLayout(false);
            this.Alta.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCliente)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button BotonBaja;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label labelPais;
        private System.Windows.Forms.TextBox Localidad;
        private System.Windows.Forms.Label labelLocalidad;
        private System.Windows.Forms.TextBox NroCalle;
        private System.Windows.Forms.Label labelNumeroCalle;
        private System.Windows.Forms.ComboBox cbPaises;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.TextBox txtNroIdModif;
        private System.Windows.Forms.ComboBox cmbTipoIdModif;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMailModif;
        private System.Windows.Forms.TextBox txtApellidoModif;
        private System.Windows.Forms.TextBox txtNombreModif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNroId;
        private System.Windows.Forms.ComboBox cbTipoId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelarBaja;
        private System.Windows.Forms.Button btnCancelarModif;
        private System.Windows.Forms.DataGridView dataGridViewModificarCliente;
        private System.Windows.Forms.Label label10;
    }
}