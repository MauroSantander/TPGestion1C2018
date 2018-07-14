namespace FrbaHotel.AbmHotel
{
    partial class frmModificarHotel
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBestrellas = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListBoxRegimenes = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBoxRegimenesAgregar = new System.Windows.Forms.CheckedListBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBoxTE = new System.Windows.Forms.TextBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.textBoxNroCalle = new System.Windows.Forms.TextBox();
            this.textBoxCIU = new System.Windows.Forms.TextBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerCreacion = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(333, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 12;
            this.button1.Text = "Modificar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBestrellas);
            this.groupBox2.Location = new System.Drawing.Point(239, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(179, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estrellas";
            // 
            // cBestrellas
            // 
            this.cBestrellas.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBestrellas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cBestrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBestrellas.FormattingEnabled = true;
            this.cBestrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBestrellas.Location = new System.Drawing.Point(6, 19);
            this.cBestrellas.Name = "cBestrellas";
            this.cBestrellas.Size = new System.Drawing.Size(167, 21);
            this.cBestrellas.TabIndex = 0;
            this.cBestrellas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nro_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkedListBoxRegimenes);
            this.groupBox1.Location = new System.Drawing.Point(12, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 155);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regímenes actuales del hotel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Marque regímenes que quiera quitar:";
            // 
            // checkedListBoxRegimenes
            // 
            this.checkedListBoxRegimenes.FormattingEnabled = true;
            this.checkedListBoxRegimenes.Location = new System.Drawing.Point(9, 52);
            this.checkedListBoxRegimenes.Name = "checkedListBoxRegimenes";
            this.checkedListBoxRegimenes.Size = new System.Drawing.Size(188, 94);
            this.checkedListBoxRegimenes.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.checkedListBoxRegimenesAgregar);
            this.groupBox3.Location = new System.Drawing.Point(221, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 155);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regímenes posibles de agregar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Marque Regímenes que quiera agregar:";
            // 
            // checkedListBoxRegimenesAgregar
            // 
            this.checkedListBoxRegimenesAgregar.FormattingEnabled = true;
            this.checkedListBoxRegimenesAgregar.Location = new System.Drawing.Point(6, 52);
            this.checkedListBoxRegimenesAgregar.Name = "checkedListBoxRegimenesAgregar";
            this.checkedListBoxRegimenesAgregar.Size = new System.Drawing.Size(191, 94);
            this.checkedListBoxRegimenesAgregar.TabIndex = 1;
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(245, 418);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(84, 29);
            this.buttonCerrar.TabIndex = 11;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBoxCIU);
            this.groupBox8.Location = new System.Drawing.Point(239, 123);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(179, 50);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ciudad";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.textBoxMail);
            this.groupBox9.Location = new System.Drawing.Point(239, 68);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(179, 50);
            this.groupBox9.TabIndex = 3;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Mail";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.textBoxName);
            this.groupBox10.Location = new System.Drawing.Point(21, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(179, 50);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Nombre";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(6, 19);
            this.textBoxName.MaxLength = 255;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(167, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(6, 19);
            this.textBoxMail.MaxLength = 255;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(167, 20);
            this.textBoxMail.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxNroCalle);
            this.groupBox4.Location = new System.Drawing.Point(239, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 50);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Número de calle";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxCalle);
            this.groupBox5.Location = new System.Drawing.Point(21, 179);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(179, 50);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Calle";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxPais);
            this.groupBox6.Location = new System.Drawing.Point(21, 124);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(179, 50);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "País";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBoxTE);
            this.groupBox7.Location = new System.Drawing.Point(21, 68);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(179, 50);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Teléfono";
            // 
            // textBoxTE
            // 
            this.textBoxTE.Location = new System.Drawing.Point(6, 19);
            this.textBoxTE.MaxLength = 255;
            this.textBoxTE.Name = "textBoxTE";
            this.textBoxTE.Size = new System.Drawing.Size(167, 20);
            this.textBoxTE.TabIndex = 0;
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.AutoCompleteCustomSource.AddRange(new string[] {
            "Afganistán",
            "Albania",
            "Alemania",
            "Andorra",
            "Angola",
            "Antigua y Barbuda",
            "Arabia Saudita",
            "Argelia",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Azerbaiyán",
            "Bahamas",
            "Bangladés",
            "Barbados",
            "Baréin",
            "Bélgica",
            "Belice",
            "Benín",
            "Bielorrusia",
            "Birmania",
            "Bolivia",
            "Bosnia y Herzegovina",
            "Botsuana",
            "Brasil",
            "Brunéi",
            "Bulgaria",
            "Burkina Faso",
            "Burundi",
            "Bután",
            "Cabo Verde",
            "Camboya",
            "Camerún",
            "Canadá",
            "Catar",
            "Chad",
            "Chile",
            "China",
            "Chipre",
            "Ciudad del Vaticano",
            "Colombia",
            "Comoras",
            "Corea del Norte",
            "Corea del Sur",
            "Costa de Marfil",
            "Costa Rica",
            "Croacia",
            "Cuba",
            "Dinamarca",
            "Dominica",
            "Ecuador",
            "Egipto",
            "El Salvador",
            "Emiratos Árabes Unidos",
            "Eritrea",
            "Eslovaquia",
            "Eslovenia",
            "España",
            "Estados Unidos",
            "Estonia",
            "Etiopía",
            "Filipinas",
            "Finlandia",
            "Fiyi",
            "Francia",
            "Gabón",
            "Gambia",
            "Georgia",
            "Ghana",
            "Granada",
            "Grecia",
            "Guatemala",
            "Guyana",
            "Guinea",
            "Guinea ecuatorial",
            "Guinea-Bisáu",
            "Haití",
            "Honduras",
            "Hungría",
            "India",
            "Indonesia",
            "Irak",
            "Irán",
            "Irlanda",
            "Islandia",
            "Islas Marshall",
            "Islas Salomón",
            "Israel",
            "Italia",
            "Jamaica",
            "Japón",
            "Jordania",
            "Kazajistán",
            "Kenia",
            "Kirguistán",
            "Kiribati",
            "Kuwait",
            "Laos",
            "Lesoto",
            "Letonia",
            "Líbano",
            "Liberia",
            "Libia",
            "Liechtenstein",
            "Lituania",
            "Luxemburgo",
            "Madagascar",
            "Malasia",
            "Malaui",
            "Maldivas",
            "Malí",
            "Malta",
            "Marruecos",
            "Mauricio",
            "Mauritania",
            "México",
            "Micronesia",
            "Moldavia",
            "Mónaco",
            "Mongolia",
            "Montenegro",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Nepal",
            "Nicaragua",
            "Níger",
            "Nigeria",
            "Noruega",
            "Nueva Zelanda",
            "Omán",
            "Países Bajos",
            "Pakistán",
            "Palaos",
            "Panamá",
            "Papúa Nueva Guinea",
            "Paraguay",
            "Perú",
            "Polonia",
            "Portugal",
            "Reino Unido",
            "República Centroafricana",
            "República Checa",
            "República de Macedonia",
            "República del Congo",
            "República Democrática del Congo",
            "República Dominicana",
            "República Sudafricana",
            "Ruanda",
            "Rumanía",
            "Rusia",
            "Samoa",
            "San Cristóbal y Nieves",
            "San Marino",
            "San Vicente y las Granadinas",
            "Santa Lucía",
            "Santo Tomé y Príncipe",
            "Senegal",
            "Serbia",
            "Seychelles",
            "Sierra Leona",
            "Singapur",
            "Siria",
            "Somalia",
            "Sri Lanka",
            "Suazilandia",
            "Sudán",
            "Sudán del Sur",
            "Suecia",
            "Suiza",
            "Surinam",
            "Tailandia",
            "Tanzania",
            "Tayikistán",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinidad y Tobago",
            "Túnez",
            "Turkmenistán",
            "Turquía",
            "Tuvalu",
            "Ucrania",
            "Uganda",
            "Uruguay",
            "Uzbekistán",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Yemen",
            "Yibuti",
            "Zambia",
            "Zimbabue"});
            this.comboBoxPais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(6, 19);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(164, 21);
            this.comboBoxPais.TabIndex = 0;
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(6, 19);
            this.textBoxCalle.MaxLength = 255;
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(164, 20);
            this.textBoxCalle.TabIndex = 0;
            // 
            // textBoxNroCalle
            // 
            this.textBoxNroCalle.Location = new System.Drawing.Point(6, 16);
            this.textBoxNroCalle.MaxLength = 9;
            this.textBoxNroCalle.Name = "textBoxNroCalle";
            this.textBoxNroCalle.Size = new System.Drawing.Size(167, 20);
            this.textBoxNroCalle.TabIndex = 0;
            // 
            // textBoxCIU
            // 
            this.textBoxCIU.Location = new System.Drawing.Point(6, 19);
            this.textBoxCIU.MaxLength = 255;
            this.textBoxCIU.Name = "textBoxCIU";
            this.textBoxCIU.Size = new System.Drawing.Size(167, 20);
            this.textBoxCIU.TabIndex = 0;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.dateTimePickerCreacion);
            this.groupBox11.Location = new System.Drawing.Point(21, 401);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(215, 50);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Fecha de creación";
            // 
            // dateTimePickerCreacion
            // 
            this.dateTimePickerCreacion.Location = new System.Drawing.Point(6, 19);
            this.dateTimePickerCreacion.Name = "dateTimePickerCreacion";
            this.dateTimePickerCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCreacion.TabIndex = 0;
            // 
            // frmModificarHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 460);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModificarHotel";
            this.Text = "Modificar hotel";
            this.Load += new System.EventHandler(this.ModificarHotel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBestrellas;
        private System.Windows.Forms.CheckedListBox checkedListBoxRegimenes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBoxRegimenesAgregar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBoxCIU;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxNroCalle;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBoxTE;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreacion;
    }
}