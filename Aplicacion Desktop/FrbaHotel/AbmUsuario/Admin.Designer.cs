namespace FrbaHotel.AbmUsuario
{

    partial class Admin
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabBajaUsr = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.textBoxUsrNameBorrar = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonRecargarTabla = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonCrearUsr = new System.Windows.Forms.Button();
            this.tabAltaUser = new System.Windows.Forms.TabControl();
            this.tabBajaUsr.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabAltaUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBajaUsr
            // 
            this.tabBajaUsr.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabBajaUsr.Controls.Add(this.groupBox12);
            this.tabBajaUsr.Location = new System.Drawing.Point(4, 22);
            this.tabBajaUsr.Name = "tabBajaUsr";
            this.tabBajaUsr.Padding = new System.Windows.Forms.Padding(3);
            this.tabBajaUsr.Size = new System.Drawing.Size(1207, 724);
            this.tabBajaUsr.TabIndex = 1;
            this.tabBajaUsr.Text = "Usuarios";
            this.tabBajaUsr.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.buttonCrearUsr);
            this.groupBox12.Controls.Add(this.label15);
            this.groupBox12.Controls.Add(this.buttonActualizar);
            this.groupBox12.Controls.Add(this.dataGridView1);
            this.groupBox12.Controls.Add(this.button6);
            this.groupBox12.Controls.Add(this.buttonRecargarTabla);
            this.groupBox12.Controls.Add(this.button2);
            this.groupBox12.Controls.Add(this.button5);
            this.groupBox12.Controls.Add(this.textBox1);
            this.groupBox12.Controls.Add(this.comboBox2);
            this.groupBox12.Controls.Add(this.label13);
            this.groupBox12.Controls.Add(this.label14);
            this.groupBox12.Controls.Add(this.label35);
            this.groupBox12.Controls.Add(this.textBoxUsrNameBorrar);
            this.groupBox12.Location = new System.Drawing.Point(11, 6);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1172, 535);
            this.groupBox12.TabIndex = 57;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Crear Usuario";
            // 
            // textBoxUsrNameBorrar
            // 
            this.textBoxUsrNameBorrar.Location = new System.Drawing.Point(236, 19);
            this.textBoxUsrNameBorrar.Name = "textBoxUsrNameBorrar";
            this.textBoxUsrNameBorrar.Size = new System.Drawing.Size(171, 20);
            this.textBoxUsrNameBorrar.TabIndex = 49;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(160, 21);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(58, 13);
            this.label35.TabIndex = 47;
            this.label35.Text = "Username:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(429, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Tipo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(580, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "N° de Identificación";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte",
            "Vacío"});
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DNI",
            "L.E",
            "Carnet Ext.",
            "Pasaporte",
            "Vacío"});
            this.comboBox2.Location = new System.Drawing.Point(463, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(89, 21);
            this.comboBox2.TabIndex = 46;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(686, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 45;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(401, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(332, 40);
            this.button5.TabIndex = 54;
            this.button5.Text = "Filtrar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(496, 460);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 41);
            this.button2.TabIndex = 30;
            this.button2.Text = "Dar de baja";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRecargarTabla
            // 
            this.buttonRecargarTabla.Location = new System.Drawing.Point(990, 408);
            this.buttonRecargarTabla.Name = "buttonRecargarTabla";
            this.buttonRecargarTabla.Size = new System.Drawing.Size(176, 25);
            this.buttonRecargarTabla.TabIndex = 56;
            this.buttonRecargarTabla.Text = "Recargar Tabla";
            this.buttonRecargarTabla.UseVisualStyleBackColor = true;
            this.buttonRecargarTabla.Click += new System.EventHandler(this.buttonRecargarTabla_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(894, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 22);
            this.button6.TabIndex = 58;
            this.button6.Text = "Limpiar campos";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 270);
            this.dataGridView1.TabIndex = 59;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(747, 460);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(165, 41);
            this.buttonActualizar.TabIndex = 60;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Seleccione Usuario:";
            // 
            // buttonCrearUsr
            // 
            this.buttonCrearUsr.Location = new System.Drawing.Point(255, 460);
            this.buttonCrearUsr.Name = "buttonCrearUsr";
            this.buttonCrearUsr.Size = new System.Drawing.Size(162, 40);
            this.buttonCrearUsr.TabIndex = 58;
            this.buttonCrearUsr.Text = "Crear Usuario";
            this.buttonCrearUsr.UseVisualStyleBackColor = true;
            this.buttonCrearUsr.Click += new System.EventHandler(this.buttonCrearUsr_Click);
            // 
            // tabAltaUser
            // 
            this.tabAltaUser.AccessibleDescription = "";
            this.tabAltaUser.AccessibleName = "";
            this.tabAltaUser.Controls.Add(this.tabBajaUsr);
            this.tabAltaUser.Location = new System.Drawing.Point(-4, 0);
            this.tabAltaUser.Name = "tabAltaUser";
            this.tabAltaUser.SelectedIndex = 0;
            this.tabAltaUser.Size = new System.Drawing.Size(1215, 750);
            this.tabAltaUser.TabIndex = 0;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 551);
            this.Controls.Add(this.tabAltaUser);
            this.Name = "Admin";
            this.Text = "ABM Usuario";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabBajaUsr.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabAltaUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabPage tabBajaUsr;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Button buttonCrearUsr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonRecargarTabla;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBoxUsrNameBorrar;
        private System.Windows.Forms.TabControl tabAltaUser;
    }
}