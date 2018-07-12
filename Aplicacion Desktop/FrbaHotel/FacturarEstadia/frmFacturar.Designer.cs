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
            this.button1 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCodigoReserva = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxNumeroTarjeta);
            this.groupBox1.Controls.Add(this.comboBoxFormaDePago);
            this.groupBox1.Location = new System.Drawing.Point(12, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de pago";
            // 
            // textBoxNumeroTarjeta
            // 
            this.textBoxNumeroTarjeta.Location = new System.Drawing.Point(134, 19);
            this.textBoxNumeroTarjeta.Name = "textBoxNumeroTarjeta";
            this.textBoxNumeroTarjeta.Size = new System.Drawing.Size(120, 20);
            this.textBoxNumeroTarjeta.TabIndex = 1;
            this.textBoxNumeroTarjeta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumeroTarjeta_KeyPress);
            // 
            // comboBoxFormaDePago
            // 
            this.comboBoxFormaDePago.FormattingEnabled = true;
            this.comboBoxFormaDePago.Location = new System.Drawing.Point(6, 19);
            this.comboBoxFormaDePago.Name = "comboBoxFormaDePago";
            this.comboBoxFormaDePago.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFormaDePago.TabIndex = 0;
            this.comboBoxFormaDePago.SelectedIndexChanged += new System.EventHandler(this.comboBoxFormaDePago_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Facturar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(116, 292);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.textBoxCodigoReserva);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Código de reserva";
            // 
            // textBoxCodigoReserva
            // 
            this.textBoxCodigoReserva.Location = new System.Drawing.Point(6, 19);
            this.textBoxCodigoReserva.MaxLength = 8;
            this.textBoxCodigoReserva.Name = "textBoxCodigoReserva";
            this.textBoxCodigoReserva.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoReserva.TabIndex = 0;
            this.textBoxCodigoReserva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodigoReserva_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(179, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // frmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 330);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmFacturar";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.frmFacturar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNumeroTarjeta;
        private System.Windows.Forms.ComboBox comboBoxFormaDePago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCodigoReserva;
        private System.Windows.Forms.Button btnBuscar;
    }
}