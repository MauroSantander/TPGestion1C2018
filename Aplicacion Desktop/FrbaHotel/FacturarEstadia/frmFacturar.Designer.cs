namespace FrbaHotel.FacturarEstadia
{
    partial class frmFacturar
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
            this.textBoxNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.comboBoxFormaDePago = new System.Windows.Forms.ComboBox();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelRegimen = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.textBoxCodigoReserva = new System.Windows.Forms.TextBox();
            this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
            this.dgvConsumibles = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.labelTotalHabitaciones = new System.Windows.Forms.Label();
            this.labelTotalConsumibles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelAlojados = new System.Windows.Forms.Label();
            this.labelReservados = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumibles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNumeroTarjeta);
            this.groupBox1.Controls.Add(this.comboBoxFormaDePago);
            this.groupBox1.Location = new System.Drawing.Point(12, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 53);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de pago";
            // 
            // textBoxNumeroTarjeta
            // 
            this.textBoxNumeroTarjeta.Location = new System.Drawing.Point(134, 19);
            this.textBoxNumeroTarjeta.MaxLength = 19;
            this.textBoxNumeroTarjeta.Name = "textBoxNumeroTarjeta";
            this.textBoxNumeroTarjeta.Size = new System.Drawing.Size(120, 20);
            this.textBoxNumeroTarjeta.TabIndex = 1;
            this.textBoxNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroTarjeta_KeyPress);
            // 
            // comboBoxFormaDePago
            // 
            this.comboBoxFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaDePago.FormattingEnabled = true;
            this.comboBoxFormaDePago.Location = new System.Drawing.Point(6, 19);
            this.comboBoxFormaDePago.Name = "comboBoxFormaDePago";
            this.comboBoxFormaDePago.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormaDePago.TabIndex = 0;
            this.comboBoxFormaDePago.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormaDePago_SelectedIndexChanged);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(299, 420);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(75, 23);
            this.btnFacturar.TabIndex = 2;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(218, 420);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRegimen);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.textBoxCodigoReserva);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 52);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Código de reserva";
            // 
            // labelRegimen
            // 
            this.labelRegimen.AutoSize = true;
            this.labelRegimen.Location = new System.Drawing.Point(112, 29);
            this.labelRegimen.Name = "labelRegimen";
            this.labelRegimen.Size = new System.Drawing.Size(114, 13);
            this.labelRegimen.TabIndex = 3;
            this.labelRegimen.Text = "All Inclusive Moderado";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(112, 16);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(102, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Regimen de reserva";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(287, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // textBoxCodigoReserva
            // 
            this.textBoxCodigoReserva.Location = new System.Drawing.Point(6, 19);
            this.textBoxCodigoReserva.MaxLength = 9;
            this.textBoxCodigoReserva.Name = "textBoxCodigoReserva";
            this.textBoxCodigoReserva.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoReserva.TabIndex = 0;
            this.textBoxCodigoReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigoReserva_KeyPress);
            // 
            // dgvHabitaciones
            // 
            this.dgvHabitaciones.AllowUserToAddRows = false;
            this.dgvHabitaciones.AllowUserToDeleteRows = false;
            this.dgvHabitaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHabitaciones.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabitaciones.Location = new System.Drawing.Point(13, 72);
            this.dgvHabitaciones.MultiSelect = false;
            this.dgvHabitaciones.Name = "dgvHabitaciones";
            this.dgvHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabitaciones.Size = new System.Drawing.Size(361, 79);
            this.dgvHabitaciones.TabIndex = 4;
            this.dgvHabitaciones.TabStop = false;
            // 
            // dgvConsumibles
            // 
            this.dgvConsumibles.AllowUserToAddRows = false;
            this.dgvConsumibles.AllowUserToDeleteRows = false;
            this.dgvConsumibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsumibles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvConsumibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsumibles.Location = new System.Drawing.Point(12, 208);
            this.dgvConsumibles.MultiSelect = false;
            this.dgvConsumibles.Name = "dgvConsumibles";
            this.dgvConsumibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumibles.Size = new System.Drawing.Size(362, 79);
            this.dgvConsumibles.TabIndex = 5;
            this.dgvConsumibles.TabStop = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(344, 336);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(19, 13);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "$0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descuento por régimen de estadía";
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Location = new System.Drawing.Point(341, 312);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(22, 13);
            this.labelDescuento.TabIndex = 8;
            this.labelDescuento.Text = "-$0";
            // 
            // labelTotalHabitaciones
            // 
            this.labelTotalHabitaciones.AutoSize = true;
            this.labelTotalHabitaciones.Location = new System.Drawing.Point(344, 192);
            this.labelTotalHabitaciones.Name = "labelTotalHabitaciones";
            this.labelTotalHabitaciones.Size = new System.Drawing.Size(19, 13);
            this.labelTotalHabitaciones.TabIndex = 9;
            this.labelTotalHabitaciones.Text = "$0";
            // 
            // labelTotalConsumibles
            // 
            this.labelTotalConsumibles.AutoSize = true;
            this.labelTotalConsumibles.Location = new System.Drawing.Point(344, 290);
            this.labelTotalConsumibles.Name = "labelTotalConsumibles";
            this.labelTotalConsumibles.Size = new System.Drawing.Size(19, 13);
            this.labelTotalConsumibles.TabIndex = 10;
            this.labelTotalConsumibles.Text = "$0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total por consumibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total por habitaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Días alojados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Días reservados (se cobran los días reservados)";
            // 
            // labelAlojados
            // 
            this.labelAlojados.AutoSize = true;
            this.labelAlojados.Location = new System.Drawing.Point(350, 154);
            this.labelAlojados.Name = "labelAlojados";
            this.labelAlojados.Size = new System.Drawing.Size(13, 13);
            this.labelAlojados.TabIndex = 16;
            this.labelAlojados.Text = "0";
            // 
            // labelReservados
            // 
            this.labelReservados.AutoSize = true;
            this.labelReservados.Location = new System.Drawing.Point(350, 173);
            this.labelReservados.Name = "labelReservados";
            this.labelReservados.Size = new System.Drawing.Size(13, 13);
            this.labelReservados.TabIndex = 17;
            this.labelReservados.Text = "0";
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.labelReservados);
            this.Controls.Add(this.labelAlojados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTotalConsumibles);
            this.Controls.Add(this.labelTotalHabitaciones);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.dgvConsumibles);
            this.Controls.Add(this.dgvHabitaciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFacturar";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNumeroTarjeta;
        private System.Windows.Forms.ComboBox comboBoxFormaDePago;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCodigoReserva;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvHabitaciones;
        private System.Windows.Forms.DataGridView dgvConsumibles;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelRegimen;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Label labelTotalHabitaciones;
        private System.Windows.Forms.Label labelTotalConsumibles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAlojados;
        private System.Windows.Forms.Label labelReservados;
    }
}