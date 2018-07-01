namespace FrbaHotel.AbmHotel
{
    partial class frmNuevoHotel
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCIU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPAIS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDIR = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxTE = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDES = new System.Windows.Forms.CheckBox();
            this.checkBoxMP = new System.Windows.Forms.CheckBox();
            this.checkBoxPC = new System.Windows.Forms.CheckBox();
            this.checkBoxALLIN = new System.Windows.Forms.CheckBox();
            this.radioBut1 = new System.Windows.Forms.RadioButton();
            this.radioBut5 = new System.Windows.Forms.RadioButton();
            this.radioBut4 = new System.Windows.Forms.RadioButton();
            this.radioBut3 = new System.Windows.Forms.RadioButton();
            this.radioBut2 = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 75;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBut2);
            this.groupBox2.Controls.Add(this.radioBut3);
            this.groupBox2.Controls.Add(this.radioBut4);
            this.groupBox2.Controls.Add(this.radioBut5);
            this.groupBox2.Controls.Add(this.radioBut1);
            this.groupBox2.Location = new System.Drawing.Point(52, 382);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 41);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estrellas";
            // 
            // textBoxCIU
            // 
            this.textBoxCIU.Location = new System.Drawing.Point(130, 268);
            this.textBoxCIU.Name = "textBoxCIU";
            this.textBoxCIU.Size = new System.Drawing.Size(178, 20);
            this.textBoxCIU.TabIndex = 72;
            this.textBoxCIU.TextChanged += new System.EventHandler(this.textBoxCIU_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Ciudad:";
            // 
            // textBoxPAIS
            // 
            this.textBoxPAIS.Location = new System.Drawing.Point(130, 233);
            this.textBoxPAIS.Name = "textBoxPAIS";
            this.textBoxPAIS.Size = new System.Drawing.Size(178, 20);
            this.textBoxPAIS.TabIndex = 70;
            this.textBoxPAIS.TextChanged += new System.EventHandler(this.textBoxPAIS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "País:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(160, 439);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 68;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBoxDIR
            // 
            this.textBoxDIR.Location = new System.Drawing.Point(130, 192);
            this.textBoxDIR.Name = "textBoxDIR";
            this.textBoxDIR.Size = new System.Drawing.Size(255, 20);
            this.textBoxDIR.TabIndex = 67;
            this.textBoxDIR.TextChanged += new System.EventHandler(this.textBoxDIR_TextChanged);
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(130, 106);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(178, 20);
            this.textBoxMail.TabIndex = 66;
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            // 
            // textBoxTE
            // 
            this.textBoxTE.Location = new System.Drawing.Point(130, 152);
            this.textBoxTE.Name = "textBoxTE";
            this.textBoxTE.Size = new System.Drawing.Size(178, 20);
            this.textBoxTE.TabIndex = 65;
            this.textBoxTE.TextChanged += new System.EventHandler(this.textBoxTE_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(178, 20);
            this.textBoxName.TabIndex = 64;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 443);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "Fecha de creación:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 199);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(55, 13);
            this.label19.TabIndex = 62;
            this.label19.Text = "Dirección:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 111);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 61;
            this.label20.Text = "Mail:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(55, 154);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 13);
            this.label21.TabIndex = 60;
            this.label21.Text = "Teléfono:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(55, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 13);
            this.label24.TabIndex = 59;
            this.label24.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 58;
            this.label1.Text = "Registrar un nuevo hotel";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxDES);
            this.groupBox1.Controls.Add(this.checkBoxMP);
            this.groupBox1.Controls.Add(this.checkBoxPC);
            this.groupBox1.Controls.Add(this.checkBoxALLIN);
            this.groupBox1.Location = new System.Drawing.Point(48, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 71);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Regímenes";
            // 
            // checkBoxDES
            // 
            this.checkBoxDES.AutoSize = true;
            this.checkBoxDES.Location = new System.Drawing.Point(213, 45);
            this.checkBoxDES.Name = "checkBoxDES";
            this.checkBoxDES.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDES.TabIndex = 37;
            this.checkBoxDES.Text = "Sólo desayuno";
            this.checkBoxDES.UseVisualStyleBackColor = true;
            this.checkBoxDES.CheckedChanged += new System.EventHandler(this.checkBoxDES_CheckedChanged);
            // 
            // checkBoxMP
            // 
            this.checkBoxMP.AutoSize = true;
            this.checkBoxMP.Location = new System.Drawing.Point(90, 45);
            this.checkBoxMP.Name = "checkBoxMP";
            this.checkBoxMP.Size = new System.Drawing.Size(99, 17);
            this.checkBoxMP.TabIndex = 36;
            this.checkBoxMP.Text = "Media Pensión ";
            this.checkBoxMP.UseVisualStyleBackColor = true;
            this.checkBoxMP.CheckedChanged += new System.EventHandler(this.checkBoxMP_CheckedChanged);
            // 
            // checkBoxPC
            // 
            this.checkBoxPC.AutoSize = true;
            this.checkBoxPC.Location = new System.Drawing.Point(213, 17);
            this.checkBoxPC.Name = "checkBoxPC";
            this.checkBoxPC.Size = new System.Drawing.Size(111, 17);
            this.checkBoxPC.TabIndex = 35;
            this.checkBoxPC.Text = "Pensión Completa";
            this.checkBoxPC.UseVisualStyleBackColor = true;
            this.checkBoxPC.CheckedChanged += new System.EventHandler(this.checkBoxPC_CheckedChanged);
            // 
            // checkBoxALLIN
            // 
            this.checkBoxALLIN.AutoSize = true;
            this.checkBoxALLIN.Location = new System.Drawing.Point(91, 16);
            this.checkBoxALLIN.Name = "checkBoxALLIN";
            this.checkBoxALLIN.Size = new System.Drawing.Size(81, 17);
            this.checkBoxALLIN.TabIndex = 33;
            this.checkBoxALLIN.Text = "All inclusive";
            this.checkBoxALLIN.UseVisualStyleBackColor = true;
            this.checkBoxALLIN.CheckedChanged += new System.EventHandler(this.checkBoxALLIN_CheckedChanged);
            // 
            // radioBut1
            // 
            this.radioBut1.AutoSize = true;
            this.radioBut1.Location = new System.Drawing.Point(60, 16);
            this.radioBut1.Name = "radioBut1";
            this.radioBut1.Size = new System.Drawing.Size(31, 17);
            this.radioBut1.TabIndex = 0;
            this.radioBut1.TabStop = true;
            this.radioBut1.Text = "1";
            this.radioBut1.UseVisualStyleBackColor = true;
            this.radioBut1.CheckedChanged += new System.EventHandler(this.radioBut1_CheckedChanged);
            // 
            // radioBut5
            // 
            this.radioBut5.AutoSize = true;
            this.radioBut5.Location = new System.Drawing.Point(256, 16);
            this.radioBut5.Name = "radioBut5";
            this.radioBut5.Size = new System.Drawing.Size(31, 17);
            this.radioBut5.TabIndex = 1;
            this.radioBut5.TabStop = true;
            this.radioBut5.Text = "5";
            this.radioBut5.UseVisualStyleBackColor = true;
            this.radioBut5.CheckedChanged += new System.EventHandler(this.radioBut5_CheckedChanged);
            // 
            // radioBut4
            // 
            this.radioBut4.AutoSize = true;
            this.radioBut4.Location = new System.Drawing.Point(204, 16);
            this.radioBut4.Name = "radioBut4";
            this.radioBut4.Size = new System.Drawing.Size(31, 17);
            this.radioBut4.TabIndex = 2;
            this.radioBut4.TabStop = true;
            this.radioBut4.Text = "4";
            this.radioBut4.UseVisualStyleBackColor = true;
            this.radioBut4.CheckedChanged += new System.EventHandler(this.radioBut4_CheckedChanged);
            // 
            // radioBut3
            // 
            this.radioBut3.AutoSize = true;
            this.radioBut3.Location = new System.Drawing.Point(156, 16);
            this.radioBut3.Name = "radioBut3";
            this.radioBut3.Size = new System.Drawing.Size(31, 17);
            this.radioBut3.TabIndex = 3;
            this.radioBut3.TabStop = true;
            this.radioBut3.Text = "3";
            this.radioBut3.UseVisualStyleBackColor = true;
            this.radioBut3.CheckedChanged += new System.EventHandler(this.radioBut3_CheckedChanged);
            // 
            // radioBut2
            // 
            this.radioBut2.AutoSize = true;
            this.radioBut2.Location = new System.Drawing.Point(108, 16);
            this.radioBut2.Name = "radioBut2";
            this.radioBut2.Size = new System.Drawing.Size(31, 17);
            this.radioBut2.TabIndex = 4;
            this.radioBut2.TabStop = true;
            this.radioBut2.Text = "2";
            this.radioBut2.UseVisualStyleBackColor = true;
            this.radioBut2.CheckedChanged += new System.EventHandler(this.radioBut2_CheckedChanged);
            // 
            // NuevoHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 532);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxCIU);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPAIS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.textBoxDIR);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxTE);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NuevoHotel";
            this.Text = "Nuevo Hotel";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxCIU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPAIS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBoxDIR;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxTE;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxDES;
        private System.Windows.Forms.CheckBox checkBoxMP;
        private System.Windows.Forms.CheckBox checkBoxPC;
        private System.Windows.Forms.CheckBox checkBoxALLIN;
        private System.Windows.Forms.RadioButton radioBut2;
        private System.Windows.Forms.RadioButton radioBut3;
        private System.Windows.Forms.RadioButton radioBut4;
        private System.Windows.Forms.RadioButton radioBut5;
        private System.Windows.Forms.RadioButton radioBut1;

    }
}