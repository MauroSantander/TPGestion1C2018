namespace FrbaHotel
{
    partial class frmCambiarContrasena
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
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.textBoxNueva = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxContraActual = new System.Windows.Forms.TextBox();
            this.textBoxRepetida = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.Location = new System.Drawing.Point(127, 192);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(70, 35);
            this.buttonCambiar.TabIndex = 2;
            this.buttonCambiar.Text = "Cambiar Contraseña";
            this.buttonCambiar.UseVisualStyleBackColor = true;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(12, 192);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(70, 35);
            this.buttonVolver.TabIndex = 3;
            this.buttonVolver.Text = "  Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // textBoxNueva
            // 
            this.textBoxNueva.Location = new System.Drawing.Point(11, 19);
            this.textBoxNueva.MaxLength = 255;
            this.textBoxNueva.Name = "textBoxNueva";
            this.textBoxNueva.PasswordChar = '*';
            this.textBoxNueva.Size = new System.Drawing.Size(168, 20);
            this.textBoxNueva.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxContraActual);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese la contraseña actual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxNueva);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contraseña nueva";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxRepetida);
            this.groupBox3.Location = new System.Drawing.Point(12, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 55);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repita contraseña nueva";
            // 
            // textBoxContraActual
            // 
            this.textBoxContraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraActual.Location = new System.Drawing.Point(11, 19);
            this.textBoxContraActual.MaxLength = 255;
            this.textBoxContraActual.Name = "textBoxContraActual";
            this.textBoxContraActual.PasswordChar = '*';
            this.textBoxContraActual.Size = new System.Drawing.Size(168, 22);
            this.textBoxContraActual.TabIndex = 5;
            // 
            // textBoxRepetida
            // 
            this.textBoxRepetida.Location = new System.Drawing.Point(11, 19);
            this.textBoxRepetida.MaxLength = 255;
            this.textBoxRepetida.Name = "textBoxRepetida";
            this.textBoxRepetida.PasswordChar = '*';
            this.textBoxRepetida.Size = new System.Drawing.Size(168, 20);
            this.textBoxRepetida.TabIndex = 6;
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 238);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonCambiar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCambiarContrasena";
            this.Text = "Cambiar contraseña";
            this.Load += new System.EventHandler(this.frmCambiarContrasena_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCambiar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.TextBox textBoxNueva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxContraActual;
        private System.Windows.Forms.TextBox textBoxRepetida;
    }
}