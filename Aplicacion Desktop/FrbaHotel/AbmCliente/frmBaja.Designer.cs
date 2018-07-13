namespace FrbaHotel.AbmCliente
{
    partial class frmBaja
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
            this.btnLimpiarModif = new System.Windows.Forms.Button();
            this.btnCancelarModif = new System.Windows.Forms.Button();
            this.filtros = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoId = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.lblBuscarPor = new System.Windows.Forms.Label();
            this.BotonBaja = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filtros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarModif
            // 
            this.btnLimpiarModif.Location = new System.Drawing.Point(35, 153);
            this.btnLimpiarModif.Name = "btnLimpiarModif";
            this.btnLimpiarModif.Size = new System.Drawing.Size(94, 33);
            this.btnLimpiarModif.TabIndex = 102;
            this.btnLimpiarModif.Text = "Limpiar";
            this.btnLimpiarModif.UseVisualStyleBackColor = true;
            this.btnLimpiarModif.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCancelarModif
            // 
            this.btnCancelarModif.Location = new System.Drawing.Point(420, 153);
            this.btnCancelarModif.Name = "btnCancelarModif";
            this.btnCancelarModif.Size = new System.Drawing.Size(94, 33);
            this.btnCancelarModif.TabIndex = 101;
            this.btnCancelarModif.Text = "Cancelar";
            this.btnCancelarModif.UseVisualStyleBackColor = true;
            this.btnCancelarModif.Click += new System.EventHandler(this.btnCancelarModif_Click);
            // 
            // filtros
            // 
            this.filtros.Controls.Add(this.txtNombre);
            this.filtros.Controls.Add(this.label30);
            this.filtros.Controls.Add(this.label31);
            this.filtros.Controls.Add(this.label4);
            this.filtros.Controls.Add(this.cmbTipoId);
            this.filtros.Controls.Add(this.label3);
            this.filtros.Controls.Add(this.txtNroId);
            this.filtros.Controls.Add(this.label2);
            this.filtros.Controls.Add(this.txtApellido);
            this.filtros.Controls.Add(this.txtMail);
            this.filtros.Location = new System.Drawing.Point(26, 42);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(678, 100);
            this.filtros.TabIndex = 99;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(82, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 83;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
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
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(232, 57);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 13);
            this.label31.TabIndex = 82;
            this.label31.Text = "N° de Identificación:";
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
            this.cmbTipoId.Location = new System.Drawing.Point(340, 18);
            this.cmbTipoId.Name = "cmbTipoId";
            this.cmbTipoId.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoId.TabIndex = 80;
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
            // txtNroId
            // 
            this.txtNroId.Location = new System.Drawing.Point(340, 54);
            this.txtNroId.Name = "txtNroId";
            this.txtNroId.Size = new System.Drawing.Size(100, 20);
            this.txtNroId.TabIndex = 79;
            this.txtNroId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNros_KeyPress);
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
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(82, 51);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 84;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloTexto_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(538, 20);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 85;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(26, 208);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(678, 337);
            this.dataGridViewClientes.TabIndex = 98;
            // 
            // lblBuscarPor
            // 
            this.lblBuscarPor.AutoSize = true;
            this.lblBuscarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarPor.Location = new System.Drawing.Point(23, 9);
            this.lblBuscarPor.Name = "lblBuscarPor";
            this.lblBuscarPor.Size = new System.Drawing.Size(293, 15);
            this.lblBuscarPor.TabIndex = 96;
            this.lblBuscarPor.Text = "Seleccione el cliente que desea dar de baja:";
            // 
            // BotonBaja
            // 
            this.BotonBaja.Location = new System.Drawing.Point(292, 153);
            this.BotonBaja.Name = "BotonBaja";
            this.BotonBaja.Size = new System.Drawing.Size(94, 33);
            this.BotonBaja.TabIndex = 103;
            this.BotonBaja.Text = "Dar de Baja";
            this.BotonBaja.UseVisualStyleBackColor = true;
            this.BotonBaja.Click += new System.EventHandler(this.BotonBaja_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 104;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnBuscar);
            // 
            // frmBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 557);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BotonBaja);
            this.Controls.Add(this.btnLimpiarModif);
            this.Controls.Add(this.btnCancelarModif);
            this.Controls.Add(this.filtros);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.lblBuscarPor);
            this.Name = "frmBaja";
            this.Text = "frmBaja";
            this.Load += new System.EventHandler(this.frmBaja_Load);
            this.filtros.ResumeLayout(false);
            this.filtros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarModif;
        private System.Windows.Forms.Button btnCancelarModif;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Label lblBuscarPor;
        private System.Windows.Forms.Button BotonBaja;
        private System.Windows.Forms.Button button2;
    }
}