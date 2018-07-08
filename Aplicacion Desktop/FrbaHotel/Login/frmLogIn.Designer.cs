namespace FrbaHotel.Login
{
    partial class frmLogIn
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
            this.buttonIniciarSesion = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.ingresarInvitado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIniciarSesion
            // 
            this.buttonIniciarSesion.Location = new System.Drawing.Point(12, 51);
            this.buttonIniciarSesion.Name = "buttonIniciarSesion";
            this.buttonIniciarSesion.Size = new System.Drawing.Size(83, 24);
            this.buttonIniciarSesion.TabIndex = 2;
            this.buttonIniciarSesion.Text = "Iniciar Sesión";
            this.buttonIniciarSesion.UseVisualStyleBackColor = true;
            this.buttonIniciarSesion.Click += new System.EventHandler(this.buttonIniciarSesion_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(201, 51);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(89, 24);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contraseña:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(12, 25);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(128, 20);
            this.textBoxUsuario.TabIndex = 0;
            this.textBoxUsuario.Text = "admin";
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged_1);
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(162, 25);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.PasswordChar = '*';
            this.textBoxContrasena.Size = new System.Drawing.Size(128, 20);
            this.textBoxContrasena.TabIndex = 1;
            this.textBoxContrasena.Text = "w23e";
            this.textBoxContrasena.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // ingresarInvitado
            // 
            this.ingresarInvitado.Location = new System.Drawing.Point(106, 51);
            this.ingresarInvitado.Name = "ingresarInvitado";
            this.ingresarInvitado.Size = new System.Drawing.Size(89, 24);
            this.ingresarInvitado.TabIndex = 3;
            this.ingresarInvitado.Text = "Invitado";
            this.ingresarInvitado.UseVisualStyleBackColor = true;
            this.ingresarInvitado.Click += new System.EventHandler(this.ingresarInvitado_Click);
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 87);
            this.Controls.Add(this.ingresarInvitado);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRBAHotel - LogIn";
            this.Load += new System.EventHandler(this.frmLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIniciarSesion;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button ingresarInvitado;
    }
}