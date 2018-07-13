namespace FrbaHotel.AbmCliente
{
    partial class frmModificacion
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
            this.dataGridViewModificarCliente = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailModif = new System.Windows.Forms.TextBox();
            this.txtApellidoModif = new System.Windows.Forms.TextBox();
            this.txtNombreModif = new System.Windows.Forms.TextBox();
            this.txtNroIdModif = new System.Windows.Forms.TextBox();
            this.cmbTipoIdModif = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.btnLimpiarModif = new System.Windows.Forms.Button();
            this.btnCancelarModif = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCliente)).BeginInit();
            this.filtros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewModificarCliente
            // 
            this.dataGridViewModificarCliente.AllowUserToOrderColumns = true;
            this.dataGridViewModificarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModificarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarCliente.Location = new System.Drawing.Point(26, 208);
            this.dataGridViewModificarCliente.Name = "dataGridViewModificarCliente";
            this.dataGridViewModificarCliente.ReadOnly = true;
            this.dataGridViewModificarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModificarCliente.Size = new System.Drawing.Size(678, 337);
            this.dataGridViewModificarCliente.TabIndex = 90;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(174, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 33);
            this.btnBuscar.TabIndex = 89;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 86;
            this.label2.Text = "Nombre:";
            // 
            // txtMailModif
            // 
            this.txtMailModif.Location = new System.Drawing.Point(538, 20);
            this.txtMailModif.Name = "txtMailModif";
            this.txtMailModif.Size = new System.Drawing.Size(100, 20);
            this.txtMailModif.TabIndex = 85;
            // 
            // txtApellidoModif
            // 
            this.txtApellidoModif.Location = new System.Drawing.Point(82, 51);
            this.txtApellidoModif.Name = "txtApellidoModif";
            this.txtApellidoModif.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoModif.TabIndex = 84;
            this.txtApellidoModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // txtNombreModif
            // 
            this.txtNombreModif.Location = new System.Drawing.Point(82, 19);
            this.txtNombreModif.Name = "txtNombreModif";
            this.txtNombreModif.Size = new System.Drawing.Size(100, 20);
            this.txtNombreModif.TabIndex = 83;
            this.txtNombreModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // txtNroIdModif
            // 
            this.txtNroIdModif.Location = new System.Drawing.Point(340, 54);
            this.txtNroIdModif.Name = "txtNroIdModif";
            this.txtNroIdModif.Size = new System.Drawing.Size(100, 20);
            this.txtNroIdModif.TabIndex = 79;
            this.txtNroIdModif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNros_KeyPress);
            // 
            // cmbTipoIdModif
            // 
            this.cmbTipoIdModif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIdModif.FormattingEnabled = true;
            this.cmbTipoIdModif.Items.AddRange(new object[] {
            "Vacío",
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte"});
            this.cmbTipoIdModif.Location = new System.Drawing.Point(340, 18);
            this.cmbTipoIdModif.Name = "cmbTipoIdModif";
            this.cmbTipoIdModif.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoIdModif.TabIndex = 80;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(232, 57);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 13);
            this.label31.TabIndex = 82;
            this.label31.Text = "N° de Identificación:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(232, 26);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(45, 13);
            this.label30.TabIndex = 81;
            this.label30.Text = "Tipo ID:";
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(23, 9);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(280, 15);
            this.lblBuscarPor.TabIndex = 78;
            this.lblBuscarPor.Text = "Seleccione el cliente que desea modificar:";
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.txtNombreModif);
            this.filtros.Controls.Add(this.label30);
            this.filtros.Controls.Add(this.label31);
            this.filtros.Controls.Add(this.label4);
            this.filtros.Controls.Add(this.cmbTipoIdModif);
            this.filtros.Controls.Add(this.label3);
            this.filtros.Controls.Add(this.txtNroIdModif);
            this.filtros.Controls.Add(this.label2);
            this.filtros.Controls.Add(this.txtApellidoModif);
            this.filtros.Controls.Add(this.txtMailModif);
            this.filtros.Location = new System.Drawing.Point(26, 42);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(678, 100);
            this.filtros.TabIndex = 92;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // btnLimpiarModif
            // 
            this.btnLimpiarModif.Location = new System.Drawing.Point(35, 153);
            this.btnLimpiarModif.Name = "btnLimpiarModif";
            this.btnLimpiarModif.Size = new System.Drawing.Size(94, 33);
            this.btnLimpiarModif.TabIndex = 95;
            this.btnLimpiarModif.Text = "Limpiar";
            this.btnLimpiarModif.UseVisualStyleBackColor = true;
            this.btnLimpiarModif.Click += new System.EventHandler(this.btnLimpiarModif_Click);
            // 
            // btnCancelarModif
            // 
            this.btnCancelarModif.Location = new System.Drawing.Point(446, 153);
            this.btnCancelarModif.Name = "btnCancelarModif";
            this.btnCancelarModif.Size = new System.Drawing.Size(94, 33);
            this.btnCancelarModif.TabIndex = 94;
            this.btnCancelarModif.Text = "Cancelar";
            this.btnCancelarModif.UseVisualStyleBackColor = true;
            this.btnCancelarModif.Click += new System.EventHandler(this.btnCancelarModif_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionar.Location = new System.Drawing.Point(317, 153);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(94, 33);
            this.btnSeleccionar.TabIndex = 93;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // frmModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 557);
            this.Controls.Add(this.btnLimpiarModif);
            this.Controls.Add(this.btnCancelarModif);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.filtros);
            this.Controls.Add(this.dataGridViewModificarCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscarPor);
            this.Name = "frmModificacion";
            this.Text = "frmModificacion";
            this.Load += new System.EventHandler(this.frmModificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCliente)).EndInit();
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModificarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMailModif;
        private System.Windows.Forms.TextBox txtApellidoModif;
        private System.Windows.Forms.TextBox txtNombreModif;
        private System.Windows.Forms.TextBox txtNroIdModif;
        private System.Windows.Forms.ComboBox cmbTipoIdModif;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.Button btnLimpiarModif;
        private System.Windows.Forms.Button btnCancelarModif;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}