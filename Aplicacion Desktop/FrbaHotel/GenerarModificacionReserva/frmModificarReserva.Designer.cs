namespace FrbaHotel.GenerarModificacionReserva
{
    partial class frmModificarReserva
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCodigoReserva = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelHotel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxRegimen = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFinReserva = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtpInicioReserva = new System.Windows.Forms.DateTimePicker();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.numKing = new System.Windows.Forms.NumericUpDown();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.numCuadruple = new System.Windows.Forms.NumericUpDown();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.numTriple = new System.Windows.Forms.NumericUpDown();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.numDoble = new System.Windows.Forms.NumericUpDown();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.numSimple = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKing)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCuadruple)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTriple)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDoble)).BeginInit();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSimple)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCodigoReserva);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 47);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Código de reserva";
            // 
            // labelCodigoReserva
            // 
            this.labelCodigoReserva.AutoSize = true;
            this.labelCodigoReserva.Location = new System.Drawing.Point(9, 19);
            this.labelCodigoReserva.Name = "labelCodigoReserva";
            this.labelCodigoReserva.Size = new System.Drawing.Size(43, 13);
            this.labelCodigoReserva.TabIndex = 0;
            this.labelCodigoReserva.Text = "000000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPrecios);
            this.groupBox4.Location = new System.Drawing.Point(514, 16);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 177);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precios";
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.AllowUserToAddRows = false;
            this.dgvPrecios.AllowUserToDeleteRows = false;
            this.dgvPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPrecios.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Location = new System.Drawing.Point(6, 15);
            this.dgvPrecios.MultiSelect = false;
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrecios.Size = new System.Drawing.Size(313, 156);
            this.dgvPrecios.TabIndex = 0;
            this.dgvPrecios.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(341, 263);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelHotel);
            this.groupBox5.Location = new System.Drawing.Point(12, 65);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 50);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hotel";
            // 
            // labelHotel
            // 
            this.labelHotel.AutoSize = true;
            this.labelHotel.Location = new System.Drawing.Point(12, 20);
            this.labelHotel.Name = "labelHotel";
            this.labelHotel.Size = new System.Drawing.Size(115, 13);
            this.labelHotel.TabIndex = 0;
            this.labelHotel.Text = "Hotel Nicolás Domingo";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxRegimen);
            this.groupBox3.Location = new System.Drawing.Point(9, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(149, 53);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Régimen";
            // 
            // comboBoxRegimen
            // 
            this.comboBoxRegimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegimen.FormattingEnabled = true;
            this.comboBoxRegimen.Location = new System.Drawing.Point(15, 19);
            this.comboBoxRegimen.Name = "comboBoxRegimen";
            this.comboBoxRegimen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegimen.TabIndex = 0;
            this.comboBoxRegimen.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegimen_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(260, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(422, 263);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 6;
            this.btnCrear.Text = "Modificar";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFinReserva);
            this.groupBox2.Location = new System.Drawing.Point(9, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 53);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hasta";
            // 
            // dtpFinReserva
            // 
            this.dtpFinReserva.Location = new System.Drawing.Point(15, 19);
            this.dtpFinReserva.Name = "dtpFinReserva";
            this.dtpFinReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpFinReserva.TabIndex = 0;
            this.dtpFinReserva.ValueChanged += new System.EventHandler(this.dtpFinReserva_ValueChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtpInicioReserva);
            this.groupBox6.Location = new System.Drawing.Point(9, 121);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(230, 53);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Desde";
            // 
            // dtpInicioReserva
            // 
            this.dtpInicioReserva.Location = new System.Drawing.Point(15, 19);
            this.dtpInicioReserva.Name = "dtpInicioReserva";
            this.dtpInicioReserva.Size = new System.Drawing.Size(200, 20);
            this.dtpInicioReserva.TabIndex = 0;
            this.dtpInicioReserva.ValueChanged += new System.EventHandler(this.dtpInicioReserva_ValueChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.groupBox12);
            this.groupBox11.Controls.Add(this.groupBox13);
            this.groupBox11.Controls.Add(this.groupBox14);
            this.groupBox11.Controls.Add(this.groupBox16);
            this.groupBox11.Controls.Add(this.groupBox17);
            this.groupBox11.Location = new System.Drawing.Point(249, 12);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(248, 221);
            this.groupBox11.TabIndex = 5;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Habitaciones";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.numKing);
            this.groupBox12.Location = new System.Drawing.Point(23, 142);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(102, 53);
            this.groupBox12.TabIndex = 2;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "King";
            // 
            // numKing
            // 
            this.numKing.Location = new System.Drawing.Point(27, 19);
            this.numKing.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numKing.Name = "numKing";
            this.numKing.ReadOnly = true;
            this.numKing.Size = new System.Drawing.Size(45, 20);
            this.numKing.TabIndex = 0;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.numCuadruple);
            this.groupBox13.Location = new System.Drawing.Point(137, 83);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(102, 53);
            this.groupBox13.TabIndex = 4;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Base cuádruple";
            // 
            // numCuadruple
            // 
            this.numCuadruple.Location = new System.Drawing.Point(24, 19);
            this.numCuadruple.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numCuadruple.Name = "numCuadruple";
            this.numCuadruple.ReadOnly = true;
            this.numCuadruple.Size = new System.Drawing.Size(45, 20);
            this.numCuadruple.TabIndex = 0;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.numTriple);
            this.groupBox14.Location = new System.Drawing.Point(23, 83);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(102, 53);
            this.groupBox14.TabIndex = 1;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Base triple";
            // 
            // numTriple
            // 
            this.numTriple.Location = new System.Drawing.Point(27, 19);
            this.numTriple.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numTriple.Name = "numTriple";
            this.numTriple.ReadOnly = true;
            this.numTriple.Size = new System.Drawing.Size(45, 20);
            this.numTriple.TabIndex = 0;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.numDoble);
            this.groupBox16.Location = new System.Drawing.Point(137, 24);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(102, 53);
            this.groupBox16.TabIndex = 3;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Base doble";
            // 
            // numDoble
            // 
            this.numDoble.Location = new System.Drawing.Point(24, 19);
            this.numDoble.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numDoble.Name = "numDoble";
            this.numDoble.ReadOnly = true;
            this.numDoble.Size = new System.Drawing.Size(45, 20);
            this.numDoble.TabIndex = 0;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.numSimple);
            this.groupBox17.Location = new System.Drawing.Point(23, 24);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(102, 53);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Base simple";
            // 
            // numSimple
            // 
            this.numSimple.Location = new System.Drawing.Point(27, 19);
            this.numSimple.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numSimple.Name = "numSimple";
            this.numSimple.ReadOnly = true;
            this.numSimple.Size = new System.Drawing.Size(45, 20);
            this.numSimple.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtMotivo);
            this.groupBox7.Location = new System.Drawing.Point(514, 203);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(325, 89);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Motivo de modificación";
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(6, 19);
            this.txtMotivo.MaxLength = 255;
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(313, 64);
            this.txtMotivo.TabIndex = 0;
            // 
            // frmModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 301);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModificarReserva";
            this.Text = "Modificar reserva";
            this.Load += new System.EventHandler(this.frmModificarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numKing)).EndInit();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numCuadruple)).EndInit();
            this.groupBox14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numTriple)).EndInit();
            this.groupBox16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDoble)).EndInit();
            this.groupBox17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numSimple)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxRegimen;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFinReserva;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DateTimePicker dtpInicioReserva;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.NumericUpDown numKing;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.NumericUpDown numCuadruple;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.NumericUpDown numTriple;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.NumericUpDown numDoble;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.NumericUpDown numSimple;
        private System.Windows.Forms.Label labelCodigoReserva;
        private System.Windows.Forms.Label labelHotel;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtMotivo;
    }
}