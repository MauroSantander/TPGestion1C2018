namespace FrbaHotel.GenerarModificacionReserva
{
    partial class frmSeleccionarCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarModif = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.btnLimpiarModif = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNroId = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTipoId = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dataGridViewModificarCliente = new System.Windows.Forms.DataGridView();
            this.filtros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione el cliente que desea modificar";
            // 
            // btnCancelarModif
            // 
            this.btnCancelarModif.Location = new System.Drawing.Point(736, 466);
            this.btnCancelarModif.Name = "btnCancelarModif";
            this.btnCancelarModif.Size = new System.Drawing.Size(94, 33);
            this.btnCancelarModif.TabIndex = 8;
            this.btnCancelarModif.Text = "Cancelar";
            this.btnCancelarModif.UseVisualStyleBackColor = true;
            this.btnCancelarModif.Click += new System.EventHandler(this.btnCancelarModif_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAceptar.Location = new System.Drawing.Point(836, 466);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(94, 33);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.btnLimpiarModif);
            this.filtros.Controls.Add(this.groupBox2);
            this.filtros.Controls.Add(this.groupBox3);
            this.filtros.Controls.Add(this.groupBox4);
            this.filtros.Controls.Add(this.groupBox5);
            this.filtros.Controls.Add(this.btnBuscar);
            this.filtros.Controls.Add(this.groupBox1);
            this.filtros.Location = new System.Drawing.Point(12, 26);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(918, 91);
            this.filtros.TabIndex = 6;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // btnLimpiarModif
            // 
            this.btnLimpiarModif.Location = new System.Drawing.Point(718, 32);
            this.btnLimpiarModif.Name = "btnLimpiarModif";
            this.btnLimpiarModif.Size = new System.Drawing.Size(94, 33);
            this.btnLimpiarModif.TabIndex = 5;
            this.btnLimpiarModif.Text = "Limpiar";
            this.btnLimpiarModif.UseVisualStyleBackColor = true;
            this.btnLimpiarModif.Click += new System.EventHandler(this.btnLimpiarModif_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMail);
            this.groupBox2.Location = new System.Drawing.Point(277, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(6, 19);
            this.txtMail.MaxLength = 255;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNroId);
            this.groupBox3.Location = new System.Drawing.Point(531, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 54);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Número identif.";
            // 
            // txtNroId
            // 
            this.txtNroId.Location = new System.Drawing.Point(6, 19);
            this.txtNroId.MaxLength = 9;
            this.txtNroId.Name = "txtNroId";
            this.txtNroId.Size = new System.Drawing.Size(100, 20);
            this.txtNroId.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTipoId);
            this.groupBox4.Location = new System.Drawing.Point(404, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo identificación";
            // 
            // cmbTipoId
            // 
            this.cmbTipoId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoId.FormattingEnabled = true;
            this.cmbTipoId.Items.AddRange(new object[] {
            "Vacío",
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.cmbTipoId.Location = new System.Drawing.Point(6, 19);
            this.cmbTipoId.Name = "cmbTipoId";
            this.cmbTipoId.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoId.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtApellido);
            this.groupBox5.Location = new System.Drawing.Point(150, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 54);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(6, 19);
            this.txtApellido.MaxLength = 255;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(818, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 33);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Location = new System.Drawing.Point(23, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(6, 19);
            this.txtNombre.MaxLength = 255;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // dataGridViewModificarCliente
            // 
            this.dataGridViewModificarCliente.AllowUserToAddRows = false;
            this.dataGridViewModificarCliente.AllowUserToDeleteRows = false;
            this.dataGridViewModificarCliente.AllowUserToOrderColumns = true;
            this.dataGridViewModificarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModificarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarCliente.Location = new System.Drawing.Point(12, 123);
            this.dataGridViewModificarCliente.Name = "dataGridViewModificarCliente";
            this.dataGridViewModificarCliente.ReadOnly = true;
            this.dataGridViewModificarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModificarCliente.Size = new System.Drawing.Size(919, 337);
            this.dataGridViewModificarCliente.TabIndex = 9;
            // 
            // frmSeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarModif);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.filtros);
            this.Controls.Add(this.dataGridViewModificarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSeleccionarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar cliente";
            this.Load += new System.EventHandler(this.frmSeleccionarCliente_Load);
            this.filtros.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelarModif;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.Button btnLimpiarModif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNroId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbTipoId;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dataGridViewModificarCliente;
    }
}