namespace FrbaHotel.AbmHotel
{
    partial class frmNuevoHotel
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
            this.textBoxCIU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerCreacion = new System.Windows.Forms.DateTimePicker();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTE = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListRegimenes = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNroCalle = new System.Windows.Forms.TextBox();
            this.textBoxCalle = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(411, 574);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 75;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBestrellas);
            this.groupBox2.Location = new System.Drawing.Point(58, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 41);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estrellas";
            // 
            // cBestrellas
            // 
            this.cBestrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBestrellas.FormattingEnabled = true;
            this.cBestrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cBestrellas.Location = new System.Drawing.Point(78, 13);
            this.cBestrellas.Name = "cBestrellas";
            this.cBestrellas.Size = new System.Drawing.Size(88, 21);
            this.cBestrellas.TabIndex = 6;
            this.cBestrellas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nro_KeyPress);
            // 
            // textBoxCIU
            // 
            this.textBoxCIU.Location = new System.Drawing.Point(130, 268);
            this.textBoxCIU.Name = "textBoxCIU";
            this.textBoxCIU.Size = new System.Drawing.Size(178, 20);
            this.textBoxCIU.TabIndex = 72;
            this.textBoxCIU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoNrosYespacios_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "País:";
            // 
            // dateTimePickerCreacion
            // 
            this.dateTimePickerCreacion.Location = new System.Drawing.Point(160, 530);
            this.dateTimePickerCreacion.Name = "dateTimePickerCreacion";
            this.dateTimePickerCreacion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerCreacion.TabIndex = 68;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(130, 106);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(178, 20);
            this.textBoxMail.TabIndex = 66;
            // 
            // textBoxTE
            // 
            this.textBoxTE.Location = new System.Drawing.Point(130, 152);
            this.textBoxTE.Name = "textBoxTE";
            this.textBoxTE.Size = new System.Drawing.Size(178, 20);
            this.textBoxTE.TabIndex = 65;
            this.textBoxTE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nro_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 64;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoNrosYespacios_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 532);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "Fecha de creación:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "Mail:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(55, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 60;
            this.label21.Text = "Teléfono:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(55, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 59;
            this.label24.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Registrar un nuevo hotel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListRegimenes);
            this.groupBox1.Location = new System.Drawing.Point(58, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 169);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regímenes";
            // 
            // checkedListRegimenes
            // 
            this.checkedListRegimenes.FormattingEnabled = true;
            this.checkedListRegimenes.Location = new System.Drawing.Point(44, 26);
            this.checkedListRegimenes.Name = "checkedListRegimenes";
            this.checkedListRegimenes.Size = new System.Drawing.Size(329, 124);
            this.checkedListRegimenes.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 98;
            this.label4.Text = "Nro:";
            // 
            // textBoxNroCalle
            // 
            this.textBoxNroCalle.Location = new System.Drawing.Point(395, 189);
            this.textBoxNroCalle.Name = "textBoxNroCalle";
            this.textBoxNroCalle.Size = new System.Drawing.Size(98, 20);
            this.textBoxNroCalle.TabIndex = 97;
            this.textBoxNroCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nro_KeyPress);
            // 
            // textBoxCalle
            // 
            this.textBoxCalle.Location = new System.Drawing.Point(130, 189);
            this.textBoxCalle.Name = "textBoxCalle";
            this.textBoxCalle.Size = new System.Drawing.Size(178, 20);
            this.textBoxCalle.TabIndex = 96;
            this.textBoxCalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textoNrosYespacios_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 196);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 13);
            this.label19.TabIndex = 95;
            this.label19.Text = "Calle:";
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
            this.comboBoxPais.Location = new System.Drawing.Point(130, 233);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(197, 21);
            this.comboBoxPais.TabIndex = 99;
            this.comboBoxPais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texto_KeyPress);
            // 
            // frmNuevoHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 624);
            this.Controls.Add(this.comboBoxPais);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNroCalle);
            this.Controls.Add(this.textBoxCalle);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxCIU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerCreacion);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTE);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNuevoHotel";
            this.Text = "Nuevo Hotel";
            this.Load += new System.EventHandler(this.NuevoHotel_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCIU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerCreacion;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTE;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cBestrellas;
        private System.Windows.Forms.CheckedListBox checkedListRegimenes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNroCalle;
        private System.Windows.Forms.TextBox textBoxCalle;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBoxPais;

    }
}