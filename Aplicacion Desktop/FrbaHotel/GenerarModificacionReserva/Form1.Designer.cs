namespace FrbaHotel.GenerarModificacionReserva
{
    partial class Form1
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
            this.tabGenerar = new System.Windows.Forms.TabControl();
            this.tabGenerarReserva = new System.Windows.Forms.TabPage();
            this.tabModificarReserva = new System.Windows.Forms.TabPage();
            this.tabGenerar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGenerar
            // 
            this.tabGenerar.AccessibleName = "tabGenerar";
            this.tabGenerar.Controls.Add(this.tabGenerarReserva);
            this.tabGenerar.Controls.Add(this.tabModificarReserva);
            this.tabGenerar.Location = new System.Drawing.Point(1, 0);
            this.tabGenerar.Name = "tabGenerar";
            this.tabGenerar.SelectedIndex = 0;
            this.tabGenerar.Size = new System.Drawing.Size(282, 255);
            this.tabGenerar.TabIndex = 0;
            // 
            // tabGenerarReserva
            // 
            this.tabGenerarReserva.AccessibleName = "tabGenerarReserva";
            this.tabGenerarReserva.Location = new System.Drawing.Point(4, 22);
            this.tabGenerarReserva.Name = "tabGenerarReserva";
            this.tabGenerarReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerarReserva.Size = new System.Drawing.Size(274, 229);
            this.tabGenerarReserva.TabIndex = 0;
            this.tabGenerarReserva.Text = "Generar Reserva";
            this.tabGenerarReserva.UseVisualStyleBackColor = true;
            this.tabGenerarReserva.Click += new System.EventHandler(this.tabGenerarReserva_Click);
            // 
            // tabModificarReserva
            // 
            this.tabModificarReserva.Location = new System.Drawing.Point(4, 22);
            this.tabModificarReserva.Name = "tabModificarReserva";
            this.tabModificarReserva.Padding = new System.Windows.Forms.Padding(3);
            this.tabModificarReserva.Size = new System.Drawing.Size(274, 229);
            this.tabModificarReserva.TabIndex = 1;
            this.tabModificarReserva.Text = "Modificar Reserva";
            this.tabModificarReserva.UseVisualStyleBackColor = true;
            this.tabModificarReserva.Click += new System.EventHandler(this.tabModificarReserva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabGenerar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabGenerar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabGenerar;
        private System.Windows.Forms.TabPage tabGenerarReserva;
        private System.Windows.Forms.TabPage tabModificarReserva;
    }
}