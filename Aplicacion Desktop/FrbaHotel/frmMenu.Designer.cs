namespace FrbaHotel
{
    partial class frmMenu
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
            this.btnListadoEstadistico = new System.Windows.Forms.Button();
            this.labelMenuPrincipal = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnABMRegimenEstadia = new System.Windows.Forms.Button();
            this.btnABMCliente = new System.Windows.Forms.Button();
            this.btnABMHotel = new System.Windows.Forms.Button();
            this.btnABMHabitacion = new System.Windows.Forms.Button();
            this.btnABMUsuario = new System.Windows.Forms.Button();
            this.btnABMRol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnModificarReserva = new System.Windows.Forms.Button();
            this.btnGenerarReserva = new System.Windows.Forms.Button();
            this.btnRegistrarConsumibles = new System.Windows.Forms.Button();
            this.btnRegistrarEstadia = new System.Windows.Forms.Button();
            this.btnFacturarEstadia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListadoEstadistico
            // 
            this.btnListadoEstadistico.Enabled = false;
            this.btnListadoEstadistico.Location = new System.Drawing.Point(244, 280);
            this.btnListadoEstadistico.Name = "btnListadoEstadistico";
            this.btnListadoEstadistico.Size = new System.Drawing.Size(84, 45);
            this.btnListadoEstadistico.TabIndex = 3;
            this.btnListadoEstadistico.Text = "Listado Estadístico";
            this.btnListadoEstadistico.UseVisualStyleBackColor = true;
            this.btnListadoEstadistico.Click += new System.EventHandler(this.btnListadoEstadistico_Click);
            // 
            // labelMenuPrincipal
            // 
            this.labelMenuPrincipal.AutoSize = true;
            this.labelMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuPrincipal.Location = new System.Drawing.Point(17, 9);
            this.labelMenuPrincipal.Name = "labelMenuPrincipal";
            this.labelMenuPrincipal.Size = new System.Drawing.Size(246, 39);
            this.labelMenuPrincipal.TabIndex = 5;
            this.labelMenuPrincipal.Text = "Menú Principal";
            this.labelMenuPrincipal.Click += new System.EventHandler(this.labelMenuPrincipal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(244, 331);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(84, 45);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnABMRegimenEstadia);
            this.groupBox1.Controls.Add(this.btnABMCliente);
            this.groupBox1.Controls.Add(this.btnABMHotel);
            this.groupBox1.Controls.Add(this.btnABMHabitacion);
            this.groupBox1.Controls.Add(this.btnABMUsuario);
            this.groupBox1.Controls.Add(this.btnABMRol);
            this.groupBox1.Location = new System.Drawing.Point(24, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABMs";
            // 
            // btnABMRegimenEstadia
            // 
            this.btnABMRegimenEstadia.Enabled = false;
            this.btnABMRegimenEstadia.Location = new System.Drawing.Point(6, 274);
            this.btnABMRegimenEstadia.Name = "btnABMRegimenEstadia";
            this.btnABMRegimenEstadia.Size = new System.Drawing.Size(84, 45);
            this.btnABMRegimenEstadia.TabIndex = 5;
            this.btnABMRegimenEstadia.Text = "ABM Regimen de Estadía";
            this.btnABMRegimenEstadia.UseVisualStyleBackColor = true;
            // 
            // btnABMCliente
            // 
            this.btnABMCliente.Enabled = false;
            this.btnABMCliente.Location = new System.Drawing.Point(6, 121);
            this.btnABMCliente.Name = "btnABMCliente";
            this.btnABMCliente.Size = new System.Drawing.Size(84, 45);
            this.btnABMCliente.TabIndex = 2;
            this.btnABMCliente.Text = "ABM Cliente";
            this.btnABMCliente.UseVisualStyleBackColor = true;
            // 
            // btnABMHotel
            // 
            this.btnABMHotel.Enabled = false;
            this.btnABMHotel.Location = new System.Drawing.Point(6, 172);
            this.btnABMHotel.Name = "btnABMHotel";
            this.btnABMHotel.Size = new System.Drawing.Size(84, 45);
            this.btnABMHotel.TabIndex = 3;
            this.btnABMHotel.Text = "ABM Hotel";
            this.btnABMHotel.UseVisualStyleBackColor = true;
            // 
            // btnABMHabitacion
            // 
            this.btnABMHabitacion.Enabled = false;
            this.btnABMHabitacion.Location = new System.Drawing.Point(6, 223);
            this.btnABMHabitacion.Name = "btnABMHabitacion";
            this.btnABMHabitacion.Size = new System.Drawing.Size(84, 45);
            this.btnABMHabitacion.TabIndex = 4;
            this.btnABMHabitacion.Text = "ABM Habitacion";
            this.btnABMHabitacion.UseVisualStyleBackColor = true;
            // 
            // btnABMUsuario
            // 
            this.btnABMUsuario.Enabled = false;
            this.btnABMUsuario.Location = new System.Drawing.Point(6, 70);
            this.btnABMUsuario.Name = "btnABMUsuario";
            this.btnABMUsuario.Size = new System.Drawing.Size(84, 45);
            this.btnABMUsuario.TabIndex = 1;
            this.btnABMUsuario.Text = "ABM Usuario";
            this.btnABMUsuario.UseVisualStyleBackColor = true;
            // 
            // btnABMRol
            // 
            this.btnABMRol.Enabled = false;
            this.btnABMRol.Location = new System.Drawing.Point(6, 19);
            this.btnABMRol.Name = "btnABMRol";
            this.btnABMRol.Size = new System.Drawing.Size(84, 45);
            this.btnABMRol.TabIndex = 0;
            this.btnABMRol.Text = "ABM Rol";
            this.btnABMRol.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancelarReserva);
            this.groupBox2.Controls.Add(this.btnModificarReserva);
            this.groupBox2.Controls.Add(this.btnGenerarReserva);
            this.groupBox2.Location = new System.Drawing.Point(130, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(99, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservas";
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Enabled = false;
            this.btnCancelarReserva.Location = new System.Drawing.Point(6, 121);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(84, 45);
            this.btnCancelarReserva.TabIndex = 2;
            this.btnCancelarReserva.Text = "Cancelar Reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            // 
            // btnModificarReserva
            // 
            this.btnModificarReserva.Enabled = false;
            this.btnModificarReserva.Location = new System.Drawing.Point(6, 70);
            this.btnModificarReserva.Name = "btnModificarReserva";
            this.btnModificarReserva.Size = new System.Drawing.Size(84, 45);
            this.btnModificarReserva.TabIndex = 1;
            this.btnModificarReserva.Text = "Modificar Reserva";
            this.btnModificarReserva.UseVisualStyleBackColor = true;
            // 
            // btnGenerarReserva
            // 
            this.btnGenerarReserva.Enabled = false;
            this.btnGenerarReserva.Location = new System.Drawing.Point(6, 19);
            this.btnGenerarReserva.Name = "btnGenerarReserva";
            this.btnGenerarReserva.Size = new System.Drawing.Size(84, 45);
            this.btnGenerarReserva.TabIndex = 0;
            this.btnGenerarReserva.Text = "Generar Reserva";
            this.btnGenerarReserva.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarConsumibles
            // 
            this.btnRegistrarConsumibles.Enabled = false;
            this.btnRegistrarConsumibles.Location = new System.Drawing.Point(9, 70);
            this.btnRegistrarConsumibles.Name = "btnRegistrarConsumibles";
            this.btnRegistrarConsumibles.Size = new System.Drawing.Size(84, 45);
            this.btnRegistrarConsumibles.TabIndex = 1;
            this.btnRegistrarConsumibles.Text = "Registrar Consumibles";
            this.btnRegistrarConsumibles.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEstadia
            // 
            this.btnRegistrarEstadia.Enabled = false;
            this.btnRegistrarEstadia.Location = new System.Drawing.Point(9, 19);
            this.btnRegistrarEstadia.Name = "btnRegistrarEstadia";
            this.btnRegistrarEstadia.Size = new System.Drawing.Size(84, 45);
            this.btnRegistrarEstadia.TabIndex = 0;
            this.btnRegistrarEstadia.Text = "Registrar Estadía";
            this.btnRegistrarEstadia.UseVisualStyleBackColor = true;
            // 
            // btnFacturarEstadia
            // 
            this.btnFacturarEstadia.Enabled = false;
            this.btnFacturarEstadia.Location = new System.Drawing.Point(9, 121);
            this.btnFacturarEstadia.Name = "btnFacturarEstadia";
            this.btnFacturarEstadia.Size = new System.Drawing.Size(84, 45);
            this.btnFacturarEstadia.TabIndex = 2;
            this.btnFacturarEstadia.Text = "Facturar Estadía";
            this.btnFacturarEstadia.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnFacturarEstadia);
            this.groupBox3.Controls.Add(this.btnRegistrarEstadia);
            this.groupBox3.Controls.Add(this.btnRegistrarConsumibles);
            this.groupBox3.Location = new System.Drawing.Point(235, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(99, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Estadias";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 396);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.labelMenuPrincipal);
            this.Controls.Add(this.btnListadoEstadistico);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMenu";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListadoEstadistico;
        private System.Windows.Forms.Label labelMenuPrincipal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnABMRegimenEstadia;
        private System.Windows.Forms.Button btnABMCliente;
        private System.Windows.Forms.Button btnABMHotel;
        private System.Windows.Forms.Button btnABMHabitacion;
        private System.Windows.Forms.Button btnABMUsuario;
        private System.Windows.Forms.Button btnABMRol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnModificarReserva;
        private System.Windows.Forms.Button btnGenerarReserva;
        private System.Windows.Forms.Button btnRegistrarConsumibles;
        private System.Windows.Forms.Button btnRegistrarEstadia;
        private System.Windows.Forms.Button btnFacturarEstadia;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}