namespace FrbaHotel.RegistrarConsumible
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.labelngreseConsumible = new System.Windows.Forms.Label();
            this.comboBoxConsumibles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(89, 160);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // labelngreseConsumible
            // 
            this.labelngreseConsumible.AutoSize = true;
            this.labelngreseConsumible.Location = new System.Drawing.Point(74, 64);
            this.labelngreseConsumible.Name = "labelngreseConsumible";
            this.labelngreseConsumible.Size = new System.Drawing.Size(102, 13);
            this.labelngreseConsumible.TabIndex = 1;
            this.labelngreseConsumible.Text = "Ingrese Consumible:";
            this.labelngreseConsumible.Click += new System.EventHandler(this.labelngreseConsumible_Click);
            // 
            // comboBoxConsumibles
            // 
            this.comboBoxConsumibles.FormattingEnabled = true;
            this.comboBoxConsumibles.Location = new System.Drawing.Point(77, 102);
            this.comboBoxConsumibles.Name = "comboBoxConsumibles";
            this.comboBoxConsumibles.Size = new System.Drawing.Size(121, 21);
            this.comboBoxConsumibles.TabIndex = 2;
            this.comboBoxConsumibles.SelectedIndexChanged += new System.EventHandler(this.comboBoxConsumibles_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxConsumibles);
            this.Controls.Add(this.labelngreseConsumible);
            this.Controls.Add(this.btnAceptar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label labelngreseConsumible;
        private System.Windows.Forms.ComboBox comboBoxConsumibles;
    }
}