namespace FrbaHotel.ListadoEstadistico
{
    partial class frmListadoEstadistico
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
            this.dataGridResultados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Trimestre = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAño = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTops = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trimestre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridResultados
            // 
            this.dataGridResultados.AllowUserToAddRows = false;
            this.dataGridResultados.AllowUserToDeleteRows = false;
            this.dataGridResultados.AllowUserToOrderColumns = true;
            this.dataGridResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridResultados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResultados.Location = new System.Drawing.Point(12, 91);
            this.dataGridResultados.Name = "dataGridResultados";
            this.dataGridResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridResultados.Size = new System.Drawing.Size(815, 146);
            this.dataGridResultados.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Trimestre);
            this.groupBox1.Controls.Add(this.comboBoxAño);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxTops);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(815, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas";
            // 
            // Trimestre
            // 
            this.Trimestre.Location = new System.Drawing.Point(542, 45);
            this.Trimestre.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.Trimestre.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Trimestre.Name = "Trimestre";
            this.Trimestre.ReadOnly = true;
            this.Trimestre.Size = new System.Drawing.Size(120, 20);
            this.Trimestre.TabIndex = 2;
            this.Trimestre.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxAño
            // 
            this.comboBoxAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAño.FormattingEnabled = true;
            this.comboBoxAño.Location = new System.Drawing.Point(407, 45);
            this.comboBoxAño.Name = "comboBoxAño";
            this.comboBoxAño.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAño.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trimestre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Año";
            // 
            // comboBoxTops
            // 
            this.comboBoxTops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTops.FormattingEnabled = true;
            this.comboBoxTops.Location = new System.Drawing.Point(10, 45);
            this.comboBoxTops.Name = "comboBoxTops";
            this.comboBoxTops.Size = new System.Drawing.Size(382, 21);
            this.comboBoxTops.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Seleccione la estadística que desea consultar";
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(701, 39);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 26);
            this.btnConsulta.TabIndex = 3;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // frmListadoEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridResultados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmListadoEstadistico";
            this.Text = "Listado Estadístico";
            this.Load += new System.EventHandler(this.frmListadoEstadistico_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResultados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Trimestre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridResultados;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxTops;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.NumericUpDown Trimestre;
        private System.Windows.Forms.ComboBox comboBoxAño;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}