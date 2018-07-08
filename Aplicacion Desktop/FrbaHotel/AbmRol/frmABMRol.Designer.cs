namespace FrbaHotel.AbmRol
{
    partial class frmABMRol
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listFuncionalidades = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listRoles = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkListFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkActivo = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(336, 307);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(328, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Modificar/Eliminar Rol";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listFuncionalidades);
            this.groupBox3.Location = new System.Drawing.Point(159, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 205);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Funcionalidades";
            // 
            // listFuncionalidades
            // 
            this.listFuncionalidades.FormattingEnabled = true;
            this.listFuncionalidades.Location = new System.Drawing.Point(6, 19);
            this.listFuncionalidades.Name = "listFuncionalidades";
            this.listFuncionalidades.Size = new System.Drawing.Size(151, 173);
            this.listFuncionalidades.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEstado);
            this.groupBox2.Location = new System.Drawing.Point(6, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(147, 39);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listRoles);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 160);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles";
            // 
            // listRoles
            // 
            this.listRoles.FormattingEnabled = true;
            this.listRoles.Location = new System.Drawing.Point(6, 19);
            this.listRoles.Name = "listRoles";
            this.listRoles.Size = new System.Drawing.Size(135, 134);
            this.listRoles.TabIndex = 1;
            this.listRoles.SelectedIndexChanged += new System.EventHandler(this.listRoles_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(157, 238);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Salir";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkListFuncionalidades);
            this.tabPage2.Controls.Add(this.txtNombreRol);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.checkActivo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(328, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Rol";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // checkListFuncionalidades
            // 
            this.checkListFuncionalidades.FormattingEnabled = true;
            this.checkListFuncionalidades.Location = new System.Drawing.Point(144, 70);
            this.checkListFuncionalidades.Name = "checkListFuncionalidades";
            this.checkListFuncionalidades.Size = new System.Drawing.Size(168, 109);
            this.checkListFuncionalidades.TabIndex = 22;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Location = new System.Drawing.Point(144, 43);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(168, 20);
            this.txtNombreRol.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Para crear un rol complete los siguientes campos:";
            // 
            // checkActivo
            // 
            this.checkActivo.AutoSize = true;
            this.checkActivo.Checked = true;
            this.checkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkActivo.Location = new System.Drawing.Point(144, 200);
            this.checkActivo.Name = "checkActivo";
            this.checkActivo.Size = new System.Drawing.Size(56, 17);
            this.checkActivo.TabIndex = 17;
            this.checkActivo.Text = "Activo";
            this.checkActivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Funcionalidades:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre del Rol:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(237, 237);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCrearRol_Click_1);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(6, 16);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 38;
            // 
            // frmABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 303);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmABMRol";
            this.Text = "Abm Rol";
            this.Load += new System.EventHandler(this.frmABMRol_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkActivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.CheckedListBox checkListFuncionalidades;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listFuncionalidades;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listRoles;
        private System.Windows.Forms.Label lblEstado;

    }
}