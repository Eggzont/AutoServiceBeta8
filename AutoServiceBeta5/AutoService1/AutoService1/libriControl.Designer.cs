namespace AutoService1
{
    partial class libriControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMotori = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVetura = new System.Windows.Forms.Label();
            this.Motori = new System.Windows.Forms.Label();
            this.lblEmri = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hlbl = new System.Windows.Forms.Label();
            this.anuloBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.txtPjeset = new System.Windows.Forms.TextBox();
            this.txtPershkrimi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.selectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 586);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Te dhenat e klientit";
            // 
            // selectPanel
            // 
            this.selectPanel.Controls.Add(this.datagrid);
            this.selectPanel.Controls.Add(this.txtSearch);
            this.selectPanel.Controls.Add(this.label3);
            this.selectPanel.Location = new System.Drawing.Point(343, 9);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(553, 538);
            this.selectPanel.TabIndex = 1;
            this.selectPanel.Visible = false;
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.datagrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Location = new System.Drawing.Point(34, 70);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.Size = new System.Drawing.Size(481, 403);
            this.datagrid.TabIndex = 19;
            this.datagrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(136, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 22);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kerko";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(178, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zgjidhe Klientin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMotori);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblVetura);
            this.groupBox2.Controls.Add(this.Motori);
            this.groupBox2.Controls.Add(this.lblEmri);
            this.groupBox2.Location = new System.Drawing.Point(26, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 188);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klienti :";
            // 
            // lblMotori
            // 
            this.lblMotori.AutoSize = true;
            this.lblMotori.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotori.Location = new System.Drawing.Point(212, 116);
            this.lblMotori.Name = "lblMotori";
            this.lblMotori.Size = new System.Drawing.Size(0, 23);
            this.lblMotori.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vetura :";
            // 
            // lblVetura
            // 
            this.lblVetura.AutoSize = true;
            this.lblVetura.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVetura.Location = new System.Drawing.Point(212, 78);
            this.lblVetura.Name = "lblVetura";
            this.lblVetura.Size = new System.Drawing.Size(0, 23);
            this.lblVetura.TabIndex = 3;
            // 
            // Motori
            // 
            this.Motori.AutoSize = true;
            this.Motori.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Motori.Location = new System.Drawing.Point(49, 116);
            this.Motori.Name = "Motori";
            this.Motori.Size = new System.Drawing.Size(78, 23);
            this.Motori.TabIndex = 2;
            this.Motori.Text = "Motori :";
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmri.Location = new System.Drawing.Point(212, 45);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(0, 23);
            this.lblEmri.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hlbl);
            this.groupBox3.Controls.Add(this.anuloBtn);
            this.groupBox3.Controls.Add(this.SaveBtn);
            this.groupBox3.Controls.Add(this.txtPjeset);
            this.groupBox3.Controls.Add(this.txtPershkrimi);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lblData);
            this.groupBox3.Controls.Add(this.txtKM);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox3.Location = new System.Drawing.Point(641, 36);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 586);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Regjistro Servisin";
            // 
            // hlbl
            // 
            this.hlbl.AutoSize = true;
            this.hlbl.Location = new System.Drawing.Point(377, 42);
            this.hlbl.Name = "hlbl";
            this.hlbl.Size = new System.Drawing.Size(0, 21);
            this.hlbl.TabIndex = 20;
            this.hlbl.Visible = false;
            // 
            // anuloBtn
            // 
            this.anuloBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.anuloBtn.Enabled = false;
            this.anuloBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anuloBtn.ForeColor = System.Drawing.Color.Snow;
            this.anuloBtn.Location = new System.Drawing.Point(340, 517);
            this.anuloBtn.Name = "anuloBtn";
            this.anuloBtn.Size = new System.Drawing.Size(108, 33);
            this.anuloBtn.TabIndex = 17;
            this.anuloBtn.Text = "Anulo";
            this.anuloBtn.UseVisualStyleBackColor = false;
            this.anuloBtn.Click += new System.EventHandler(this.anuloBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.Snow;
            this.SaveBtn.Location = new System.Drawing.Point(112, 517);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 33);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Ruaj";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // txtPjeset
            // 
            this.txtPjeset.Enabled = false;
            this.txtPjeset.Location = new System.Drawing.Point(76, 340);
            this.txtPjeset.Multiline = true;
            this.txtPjeset.Name = "txtPjeset";
            this.txtPjeset.Size = new System.Drawing.Size(413, 145);
            this.txtPjeset.TabIndex = 7;
            // 
            // txtPershkrimi
            // 
            this.txtPershkrimi.Enabled = false;
            this.txtPershkrimi.Location = new System.Drawing.Point(76, 140);
            this.txtPershkrimi.Multiline = true;
            this.txtPershkrimi.Name = "txtPershkrimi";
            this.txtPershkrimi.Size = new System.Drawing.Size(413, 141);
            this.txtPershkrimi.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(213, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Pjeset e Perdorura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(242, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Pershkrimi";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(176, 42);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(135, 21);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Data Tanishme";
            // 
            // txtKM
            // 
            this.txtKM.Enabled = false;
            this.txtKM.Location = new System.Drawing.Point(176, 76);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(234, 28);
            this.txtKM.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "KM :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data :";
            // 
            // libriControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.selectPanel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "libriControl";
            this.Size = new System.Drawing.Size(1297, 665);
            this.Load += new System.EventHandler(this.libriControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.selectPanel.ResumeLayout(false);
            this.selectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.Label lblMotori;
        private System.Windows.Forms.Label lblVetura;
        private System.Windows.Forms.Label Motori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtPjeset;
        private System.Windows.Forms.TextBox txtPershkrimi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button anuloBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label hlbl;
    }
}
