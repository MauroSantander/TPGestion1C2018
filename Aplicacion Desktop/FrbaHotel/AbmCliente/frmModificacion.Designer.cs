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
            this.filtros = new System.Windows.Forms.GroupBox();
            this.btnLimpiarModif = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMailModif = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtNroIdModif = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTipoIdModif = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtApellidoModif = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombreModif = new System.Windows.Forms.TextBox();
            this.btnCancelarModif = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCliente)).BeginInit();
            this.filtros.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewModificarCliente
            // 
            this.dataGridViewModificarCliente.AllowUserToOrderColumns = true;
            this.dataGridViewModificarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewModificarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewModificarCliente.Location = new System.Drawing.Point(12, 126);
            this.dataGridViewModificarCliente.Name = "dataGridViewModificarCliente";
            this.dataGridViewModificarCliente.ReadOnly = true;
            this.dataGridViewModificarCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewModificarCliente.Size = new System.Drawing.Size(732, 337);
            this.dataGridViewModificarCliente.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(632, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 33);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.filtros.Location = new System.Drawing.Point(12, 29);
            this.filtros.Name = "filtros";
            this.filtros.Size = new System.Drawing.Size(732, 91);
            this.filtros.TabIndex = 1;
            this.filtros.TabStop = false;
            this.filtros.Text = "Filtros";
            // 
            // btnLimpiarModif
            // 
            this.btnLimpiarModif.Location = new System.Drawing.Point(632, 10);
            this.btnLimpiarModif.Name = "btnLimpiarModif";
            this.btnLimpiarModif.Size = new System.Drawing.Size(94, 33);
            this.btnLimpiarModif.TabIndex = 5;
            this.btnLimpiarModif.Text = "Limpiar";
            this.btnLimpiarModif.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMailModif);
            this.groupBox2.Location = new System.Drawing.Point(259, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 54);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail";
            // 
            // txtMailModif
            // 
            this.txtMailModif.Location = new System.Drawing.Point(6, 19);
            this.txtMailModif.Name = "txtMailModif";
            this.txtMailModif.Size = new System.Drawing.Size(100, 20);
            this.txtMailModif.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtNroIdModif);
            this.groupBox3.Location = new System.Drawing.Point(495, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(112, 54);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Número identif.";
            // 
            // txtNroIdModif
            // 
            this.txtNroIdModif.Location = new System.Drawing.Point(6, 19);
            this.txtNroIdModif.Name = "txtNroIdModif";
            this.txtNroIdModif.Size = new System.Drawing.Size(100, 20);
            this.txtNroIdModif.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTipoIdModif);
            this.groupBox4.Location = new System.Drawing.Point(377, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 54);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo identificación";
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
            this.cmbTipoIdModif.Location = new System.Drawing.Point(6, 19);
            this.cmbTipoIdModif.Name = "cmbTipoIdModif";
            this.cmbTipoIdModif.Size = new System.Drawing.Size(100, 21);
            this.cmbTipoIdModif.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtApellidoModif);
            this.groupBox5.Location = new System.Drawing.Point(141, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(112, 54);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Apellido";
            // 
            // txtApellidoModif
            // 
            this.txtApellidoModif.Location = new System.Drawing.Point(6, 19);
            this.txtApellidoModif.Name = "txtApellidoModif";
            this.txtApellidoModif.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoModif.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombreModif);
            this.groupBox1.Location = new System.Drawing.Point(23, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombre";
            // 
            // txtNombreModif
            // 
            this.txtNombreModif.Location = new System.Drawing.Point(6, 19);
            this.txtNombreModif.Name = "txtNombreModif";
            this.txtNombreModif.Size = new System.Drawing.Size(100, 20);
            this.txtNombreModif.TabIndex = 0;
            // 
            // btnCancelarModif
            // 
            this.btnCancelarModif.Location = new System.Drawing.Point(550, 469);
            this.btnCancelarModif.Name = "btnCancelarModif";
            this.btnCancelarModif.Size = new System.Drawing.Size(94, 33);
            this.btnCancelarModif.TabIndex = 3;
            this.btnCancelarModif.Text = "Cancelar";
            this.btnCancelarModif.UseVisualStyleBackColor = true;
            this.btnCancelarModif.Click += new System.EventHandler(this.btnCancelarModif_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionar.Location = new System.Drawing.Point(650, 469);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(94, 33);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Modificar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione el cliente que desea modificar";
            // 
            // frmModificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarModif);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.filtros);
            this.Controls.Add(this.dataGridViewModificarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmModificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificación de usuario";
            this.Load += new System.EventHandler(this.frmModificacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewModificarCliente)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewModificarCliente;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox filtros;
        private System.Windows.Forms.Button btnCancelarModif;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnLimpiarModif;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMailModif;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNroIdModif;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbTipoIdModif;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtApellidoModif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreModif;
        private System.Windows.Forms.Label label1;
    }
}