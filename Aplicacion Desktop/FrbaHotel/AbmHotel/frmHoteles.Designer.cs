namespace FrbaHotel.AbmHotel
{
    partial class frmHoteles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoteles));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkEst5 = new System.Windows.Forms.CheckBox();
            this.checkEst4 = new System.Windows.Forms.CheckBox();
            this.checkEst3 = new System.Windows.Forms.CheckBox();
            this.checkEst2 = new System.Windows.Forms.CheckBox();
            this.checkEst1 = new System.Windows.Forms.CheckBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dataGridViewHoteles = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.País = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonUpd = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtrar:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkEst5);
            this.groupBox2.Controls.Add(this.checkEst4);
            this.groupBox2.Controls.Add(this.checkEst3);
            this.groupBox2.Controls.Add(this.checkEst2);
            this.groupBox2.Controls.Add(this.checkEst1);
            this.groupBox2.Location = new System.Drawing.Point(362, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 85);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estrellas";
            // 
            // checkEst5
            // 
            this.checkEst5.AutoSize = true;
            this.checkEst5.Location = new System.Drawing.Point(121, 49);
            this.checkEst5.Name = "checkEst5";
            this.checkEst5.Size = new System.Drawing.Size(32, 17);
            this.checkEst5.TabIndex = 43;
            this.checkEst5.Text = "5";
            this.checkEst5.UseVisualStyleBackColor = true;
            this.checkEst5.CheckedChanged += new System.EventHandler(this.checkEst5_CheckedChanged);
            // 
            // checkEst4
            // 
            this.checkEst4.AutoSize = true;
            this.checkEst4.Location = new System.Drawing.Point(76, 49);
            this.checkEst4.Name = "checkEst4";
            this.checkEst4.Size = new System.Drawing.Size(32, 17);
            this.checkEst4.TabIndex = 42;
            this.checkEst4.Text = "4";
            this.checkEst4.UseVisualStyleBackColor = true;
            this.checkEst4.CheckedChanged += new System.EventHandler(this.checkEst4_CheckedChanged);
            // 
            // checkEst3
            // 
            this.checkEst3.AutoSize = true;
            this.checkEst3.Location = new System.Drawing.Point(169, 16);
            this.checkEst3.Name = "checkEst3";
            this.checkEst3.Size = new System.Drawing.Size(32, 17);
            this.checkEst3.TabIndex = 41;
            this.checkEst3.Text = "3";
            this.checkEst3.UseVisualStyleBackColor = true;
            this.checkEst3.CheckedChanged += new System.EventHandler(this.checkEst3_CheckedChanged);
            // 
            // checkEst2
            // 
            this.checkEst2.AutoSize = true;
            this.checkEst2.Location = new System.Drawing.Point(121, 16);
            this.checkEst2.Name = "checkEst2";
            this.checkEst2.Size = new System.Drawing.Size(32, 17);
            this.checkEst2.TabIndex = 40;
            this.checkEst2.Text = "2";
            this.checkEst2.UseVisualStyleBackColor = true;
            this.checkEst2.CheckedChanged += new System.EventHandler(this.checkEst2_CheckedChanged);
            // 
            // checkEst1
            // 
            this.checkEst1.AutoSize = true;
            this.checkEst1.Location = new System.Drawing.Point(75, 16);
            this.checkEst1.Name = "checkEst1";
            this.checkEst1.Size = new System.Drawing.Size(32, 17);
            this.checkEst1.TabIndex = 39;
            this.checkEst1.Text = "1";
            this.checkEst1.UseVisualStyleBackColor = true;
            this.checkEst1.CheckedChanged += new System.EventHandler(this.checkEst1_CheckedChanged);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Location = new System.Drawing.Point(140, 142);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(178, 20);
            this.textBoxCiudad.TabIndex = 80;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxCiudad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 79;
            this.label3.Text = "Ciudad:";
            // 
            // textBoxPais
            // 
            this.textBoxPais.Location = new System.Drawing.Point(140, 107);
            this.textBoxPais.Name = "textBoxPais";
            this.textBoxPais.Size = new System.Drawing.Size(178, 20);
            this.textBoxPais.TabIndex = 78;
            this.textBoxPais.TextChanged += new System.EventHandler(this.textBoxPais_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "País:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(140, 77);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(178, 20);
            this.textBoxNombre.TabIndex = 76;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(65, 80);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 75;
            this.label24.Text = "Nombre:";
            // 
            // dataGridViewHoteles
            // 
            this.dataGridViewHoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHoteles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Direccion,
            this.País,
            this.Ciudad,
            this.Estrellas});
            this.dataGridViewHoteles.Location = new System.Drawing.Point(67, 199);
            this.dataGridViewHoteles.Name = "dataGridViewHoteles";
            this.dataGridViewHoteles.Size = new System.Drawing.Size(582, 257);
            this.dataGridViewHoteles.TabIndex = 82;
            this.dataGridViewHoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHoteles_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            // 
            // País
            // 
            this.País.HeaderText = "País";
            this.País.Name = "País";
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            // 
            // Estrellas
            // 
            this.Estrellas.HeaderText = "Estrellas";
            this.Estrellas.Name = "Estrellas";
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(67, 485);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(136, 38);
            this.buttonNew.TabIndex = 83;
            this.buttonNew.Text = "Nuevo Hotel";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonUpd
            // 
            this.buttonUpd.Location = new System.Drawing.Point(288, 485);
            this.buttonUpd.Name = "buttonUpd";
            this.buttonUpd.Size = new System.Drawing.Size(136, 38);
            this.buttonUpd.TabIndex = 84;
            this.buttonUpd.Text = "Actualizar Hotel";
            this.buttonUpd.UseVisualStyleBackColor = true;
            this.buttonUpd.Click += new System.EventHandler(this.buttonUpd_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(513, 485);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(136, 38);
            this.buttonEliminar.TabIndex = 85;
            this.buttonEliminar.Text = "Baja de Hotel";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // Hoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 557);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonUpd);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.dataGridViewHoteles);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxCiudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Hoteles";
            this.Text = "Hoteles";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHoteles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkEst5;
        private System.Windows.Forms.CheckBox checkEst4;
        private System.Windows.Forms.CheckBox checkEst3;
        private System.Windows.Forms.CheckBox checkEst2;
        private System.Windows.Forms.CheckBox checkEst1;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPais;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DataGridView dataGridViewHoteles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn País;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrellas;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonUpd;
        private System.Windows.Forms.Button buttonEliminar;
    }
}