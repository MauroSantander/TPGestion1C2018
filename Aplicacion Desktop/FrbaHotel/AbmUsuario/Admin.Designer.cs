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
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBaja = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxLocalidad = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxNroId = new System.Windows.Forms.TextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.comboBoxTipoId = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxNroCalle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCrearUsr
            // 
            this.buttonCrearUsr.Location = new System.Drawing.Point(658, 487);
            this.buttonCrearUsr.Name = "buttonCrearUsr";
            this.buttonCrearUsr.Size = new System.Drawing.Size(90, 40);
            this.buttonCrearUsr.TabIndex = 4;
            this.buttonCrearUsr.Text = "Crear Usuario";
            this.buttonCrearUsr.UseVisualStyleBackColor = true;
            this.buttonCrearUsr.Click += new System.EventHandler(this.buttonCrearUsr_Click);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(850, 487);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(90, 40);
            this.buttonActualizar.TabIndex = 2;
            this.buttonActualizar.Text = "Modificar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(12, 175);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(927, 306);
            this.dataGridViewUsuarios.TabIndex = 5;
            this.dataGridViewUsuarios.TabStop = false;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(830, 73);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(90, 40);
            this.buttonLimpiar.TabIndex = 10;
            this.buttonLimpiar.Text = "Limpiar y recargar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBaja
            // 
            this.buttonBaja.Location = new System.Drawing.Point(754, 487);
            this.buttonBaja.Name = "buttonBaja";
            this.buttonBaja.Size = new System.Drawing.Size(90, 40);
            this.buttonBaja.TabIndex = 3;
            this.buttonBaja.Text = "Dar de baja";
            this.buttonBaja.UseVisualStyleBackColor = true;
            this.buttonBaja.Click += new System.EventHandler(this.buttonBaja_Click);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(830, 27);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(90, 40);
            this.buttonFiltrar.TabIndex = 9;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.buttonLimpiar);
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonFiltrar);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(926, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxCalle);
            this.groupBox4.Location = new System.Drawing.Point(334, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 50);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Calle";
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(6, 19);
            this.textBoxCalle.MaxLength = 255;
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(123, 20);
            this.textBoxCalle.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxLocalidad);
            this.groupBox5.Location = new System.Drawing.Point(173, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(134, 50);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Localidad";
            // 
            // textBoxLocalidad
            // 
            this.textBoxLocalidad.Location = new System.Drawing.Point(6, 19);
            this.textBoxLocalidad.MaxLength = 255;
            this.textBoxLocalidad.Name = "textBoxLocalidad";
            this.textBoxLocalidad.Size = new System.Drawing.Size(123, 20);
            this.textBoxLocalidad.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxPais);
            this.groupBox6.Location = new System.Drawing.Point(15, 75);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(134, 50);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "País";
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Items.AddRange(new object[] {
            ""});
            this.comboBoxPais.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(123, 21);
            this.comboBoxPais.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxNroId);
            this.groupBox7.Location = new System.Drawing.Point(662, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(134, 50);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Identificación";
            // 
            // textBoxNroId
            // 
            this.textBoxNroId.Location = new System.Drawing.Point(6, 19);
            this.textBoxNroId.MaxLength = 9;
            this.textBoxNroId.Name = "textBoxNroId";
            this.textBoxNroId.Size = new System.Drawing.Size(123, 20);
            this.textBoxNroId.TabIndex = 0;
            this.textBoxNroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.comboBoxTipoId);
            this.groupBox10.Location = new System.Drawing.Point(497, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(134, 50);
            this.groupBox10.TabIndex = 3;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tipo de identificación";
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
            "Seleccionar"});
            this.comboBoxTipoId.Location = new System.Drawing.Point(6, 19);
            this.comboBoxTipoId.Name = "comboBoxTipoId";
            this.comboBoxTipoId.Size = new System.Drawing.Size(123, 21);
            this.comboBoxTipoId.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxApellido);
            this.groupBox9.Location = new System.Drawing.Point(334, 19);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(134, 50);
            this.groupBox9.TabIndex = 2;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(6, 19);
            this.textBoxApellido.MaxLength = 255;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(123, 20);
            this.textBoxApellido.TabIndex = 0;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textos_KeyPress);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxNombre);
            this.groupBox8.Location = new System.Drawing.Point(173, 19);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(134, 50);
            this.groupBox8.TabIndex = 1;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(6, 19);
            this.textBoxNombre.MaxLength = 255;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(123, 20);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textos_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxNroCalle);
            this.groupBox3.Location = new System.Drawing.Point(497, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Número de calle";
            // 
            // textBoxNroCalle
            // 
            this.textBoxNroCalle.Location = new System.Drawing.Point(6, 19);
            this.textBoxNroCalle.MaxLength = 9;
            this.textBoxNroCalle.Name = "textBoxNroCalle";
            this.textBoxNroCalle.Size = new System.Drawing.Size(123, 20);
            this.textBoxNroCalle.TabIndex = 0;
            this.textBoxNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxUsuario);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 50);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Username";
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(6, 19);
            this.textBoxUsuario.MaxLength = 255;
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(123, 20);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoYNros_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione usuario";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 536);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCrearUsr);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.dataGridViewUsuarios);
            this.Controls.Add(this.buttonBaja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Admin";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearUsr;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBaja;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxLocalidad;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxNroId;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ComboBox comboBoxTipoId;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxNroCalle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label label1;
    }
}