namespace FrbaHotel.AbmUsuario
{
    partial class frmNuevoUsuario
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
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkedListHoteles = new System.Windows.Forms.CheckedListBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.localidad = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.nroCalle = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.calle = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mail = new System.Windows.Forms.TextBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.numDoc = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellido = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxRoles = new System.Windows.Forms.CheckedListBox();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label12);
            this.groupBox11.Controls.Add(this.username);
            this.groupBox11.Controls.Add(this.label5);
            this.groupBox11.Controls.Add(this.pass);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Location = new System.Drawing.Point(12, 37);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(636, 76);
            this.groupBox11.TabIndex = 36;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Datos Sesión";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label12.Location = new System.Drawing.Point(485, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "*Únicamente letras y números";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(68, 28);
            this.username.MaxLength = 255;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(224, 20);
            this.username.TabIndex = 28;
            this.username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoYNros_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(323, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Password*:";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(390, 27);
            this.pass.MaxLength = 255;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(229, 20);
            this.pass.TabIndex = 29;
            this.pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoYNros_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Username*:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkedListHoteles);
            this.groupBox10.Location = new System.Drawing.Point(708, 156);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(460, 279);
            this.groupBox10.TabIndex = 38;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Seleccionar Hotel/es";
            // 
            // checkedListHoteles
            // 
            this.checkedListHoteles.FormattingEnabled = true;
            this.checkedListHoteles.Location = new System.Drawing.Point(23, 43);
            this.checkedListHoteles.Name = "checkedListHoteles";
            this.checkedListHoteles.Size = new System.Drawing.Size(415, 169);
            this.checkedListHoteles.TabIndex = 34;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(762, 473);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(100, 33);
            this.buttonCerrar.TabIndex = 37;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click_1);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCrear.Location = new System.Drawing.Point(939, 463);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(229, 52);
            this.buttonCrear.TabIndex = 35;
            this.buttonCrear.Text = "Crear Usuario";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ingrese datos del nuevo Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxPais);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.localidad);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Controls.Add(this.nroCalle);
            this.groupBox2.Controls.Add(this.label39);
            this.groupBox2.Controls.Add(this.calle);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.mail);
            this.groupBox2.Controls.Add(this.tel);
            this.groupBox2.Controls.Add(this.numDoc);
            this.groupBox2.Controls.Add(this.comboBoxTipo);
            this.groupBox2.Controls.Add(this.nombre);
            this.groupBox2.Controls.Add(this.apellido);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 316);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos personales";
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(390, 225);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(229, 21);
            this.comboBoxPais.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 230);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "País:";
            // 
            // localidad
            // 
            this.localidad.Location = new System.Drawing.Point(63, 225);
            this.localidad.MaxLength = 255;
            this.localidad.Name = "localidad";
            this.localidad.Size = new System.Drawing.Size(255, 20);
            this.localidad.TabIndex = 31;
            this.localidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoNrosYespacios_KeyPress);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(6, 230);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(56, 13);
            this.label38.TabIndex = 30;
            this.label38.Text = "Localidad:";
            // 
            // nroCalle
            // 
            this.nroCalle.Location = new System.Drawing.Point(390, 193);
            this.nroCalle.MaxLength = 9;
            this.nroCalle.Name = "nroCalle";
            this.nroCalle.Size = new System.Drawing.Size(133, 20);
            this.nroCalle.TabIndex = 29;
            this.nroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(360, 196);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 13);
            this.label39.TabIndex = 28;
            this.label39.Text = "Nro:";
            // 
            // calle
            // 
            this.calle.Location = new System.Drawing.Point(63, 193);
            this.calle.MaxLength = 255;
            this.calle.Name = "calle";
            this.calle.Size = new System.Drawing.Size(255, 20);
            this.calle.TabIndex = 27;
            this.calle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoNrosYespacios_KeyPress);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(4, 196);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(33, 13);
            this.label40.TabIndex = 26;
            this.label40.Text = "Calle:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 278);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 6, 28, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2018, 6, 28, 0, 0, 0, 0);
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(63, 114);
            this.mail.MaxLength = 255;
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(255, 20);
            this.mail.TabIndex = 16;
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(63, 148);
            this.tel.MaxLength = 255;
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(255, 20);
            this.tel.TabIndex = 15;
            this.tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // numDoc
            // 
            this.numDoc.Location = new System.Drawing.Point(287, 80);
            this.numDoc.Name = "numDoc";
            this.numDoc.Size = new System.Drawing.Size(236, 20);
            this.numDoc.TabIndex = 14;
            this.numDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numeros_KeyPress);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.comboBoxTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.comboBoxTipo.Location = new System.Drawing.Point(144, 80);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(137, 21);
            this.comboBoxTipo.TabIndex = 13;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(63, 19);
            this.nombre.MaxLength = 255;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(255, 20);
            this.nombre.TabIndex = 12;
            this.nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textosYespacios_KeyPress);
            // 
            // apellido
            // 
            this.apellido.Location = new System.Drawing.Point(63, 45);
            this.apellido.MaxLength = 255;
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(255, 20);
            this.apellido.TabIndex = 11;
            this.apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textosYespacios_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 284);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Fecha de nacimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tipo y n° de identificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxRoles);
            this.groupBox1.Location = new System.Drawing.Point(708, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 113);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar Rol/es";
            // 
            // checkedListBoxRoles
            // 
            this.checkedListBoxRoles.FormattingEnabled = true;
            this.checkedListBoxRoles.Location = new System.Drawing.Point(23, 19);
            this.checkedListBoxRoles.Name = "checkedListBoxRoles";
            this.checkedListBoxRoles.Size = new System.Drawing.Size(415, 79);
            this.checkedListBoxRoles.TabIndex = 28;
            // 
            // frmNuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 534);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmNuevoUsuario";
            this.Text = "Nuevo Usuario";
            this.Load += new System.EventHandler(this.frmNuevoUsuario_Load);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.CheckedListBox checkedListHoteles;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox localidad;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox nroCalle;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox calle;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.TextBox numDoc;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBoxRoles;
    }
}