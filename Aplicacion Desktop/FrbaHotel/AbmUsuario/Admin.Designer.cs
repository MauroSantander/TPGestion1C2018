namespace FrbaHotel.AbmUsuario
{
    partial class Admin
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
            this.buttonCrearUsr = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.textBoxNroId = new System.Windows.Forms.TextBox();
            this.comboBoxTipoId = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNroCalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCrearUsr
            // 
            this.buttonCrearUsr.Location = new System.Drawing.Point(259, 532);
            this.buttonCrearUsr.Name = "buttonCrearUsr";
            this.buttonCrearUsr.Size = new System.Drawing.Size(162, 40);
            this.buttonCrearUsr.TabIndex = 70;
            this.buttonCrearUsr.Text = "Crear Usuario";
            this.buttonCrearUsr.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 188);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Seleccione Usuario:";
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(751, 532);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(165, 41);
            this.buttonActualizar.TabIndex = 73;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(12, 204);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(1158, 270);
            this.dataGridViewUsuarios.TabIndex = 72;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(999, 144);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(165, 47);
            this.buttonLimpiar.TabIndex = 71;
            this.buttonLimpiar.Text = "Limpiar y recargar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(500, 532);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(163, 41);
            this.buttonBaja.TabIndex = 62;
            this.buttonBaja.Text = "Dar de baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(405, 144);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(332, 40);
            this.buttonFiltrar.TabIndex = 69;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // textBoxNroId
            // 
            this.textBoxNroId.Location = new System.Drawing.Point(508, 65);
            this.textBoxNroId.Name = "textBoxNroId";
            this.textBoxNroId.Size = new System.Drawing.Size(171, 20);
            this.textBoxNroId.TabIndex = 63;
            this.textBoxNroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // comboBoxTipoId
            // 
            this.comboBoxTipoId.AutoCompleteCustomSource.AddRange(new string[] {
            "Seleccionar",
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte",
            "Vacío"});
            this.comboBoxTipoId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxTipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoId.FormattingEnabled = true;
            this.comboBoxTipoId.Items.AddRange(new object[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte",
            "Vacío"});
            this.comboBoxTipoId.Location = new System.Drawing.Point(508, 34);
            this.comboBoxTipoId.Name = "comboBoxTipoId";
            this.comboBoxTipoId.Size = new System.Drawing.Size(171, 21);
            this.comboBoxTipoId.TabIndex = 64;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(402, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 68;
            this.label13.Text = "N° de Identificación";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(402, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 67;
            this.label14.Text = "Tipo";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(30, 34);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 13);
            this.label35.TabIndex = 65;
            this.label35.Text = "Username:";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(106, 32);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(171, 20);
            this.textBoxUsuario.TabIndex = 66;
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoYNros_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Filtros:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(106, 63);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(171, 20);
            this.textBoxNombre.TabIndex = 76;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textosYespacios_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Apellido:";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(106, 93);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(171, 20);
            this.textBoxApellido.TabIndex = 78;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textosYespacios_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 81;
            this.label4.Text = "País:";
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(827, 95);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(183, 20);
            this.textBoxCalle.TabIndex = 82;
            this.textBoxCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoNrosYespacios_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 79;
            this.label5.Text = "Localidad:";
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(827, 60);
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(183, 20);
            this.textBoxLocalidad.TabIndex = 80;
            this.textBoxLocalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoNrosYespacios_KeyPress);
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Items.AddRange(new object[] {
            ""});
            this.comboBoxPais.Location = new System.Drawing.Point(827, 29);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(183, 21);
            this.comboBoxPais.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 84;
            this.label6.Text = "Calle:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1022, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "N° Calle:";
            // 
            // textBoxNroCalle
            // 
            this.textBoxNroCalle.Location = new System.Drawing.Point(1076, 95);
            this.textBoxNroCalle.Name = "textBoxNroCalle";
            this.textBoxNroCalle.Size = new System.Drawing.Size(88, 20);
            this.textBoxNroCalle.TabIndex = 86;
            this.textBoxNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 584);
            this.Controls.Add(this.textBoxNroCalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLocalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCrearUsr);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonBaja);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.textBoxNroId);
            this.Controls.Add(this.comboBoxTipoId);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.textBoxUsuario);
            this.Name = "Admin";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearUsr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.TextBox textBoxNroId;
        private System.Windows.Forms.ComboBox comboBoxTipoId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNroCalle;
    }
}