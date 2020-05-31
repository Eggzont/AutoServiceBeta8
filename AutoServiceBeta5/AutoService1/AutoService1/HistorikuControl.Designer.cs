namespace AutoService1
{
    partial class HistorikuControl
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorikuControl));
            this.datagrid = new System.Windows.Forms.DataGridView();
            this.ServisiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Klienti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefoni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vetura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pershkrimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pjeset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shiko = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shikopanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblEmri = new System.Windows.Forms.Label();
            this.kthehubtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).BeginInit();
            this.shikopanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.AllowUserToAddRows = false;
            this.datagrid.AllowUserToDeleteRows = false;
            this.datagrid.AllowUserToOrderColumns = true;
            this.datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServisiID,
            this.Klienti,
            this.Telefoni,
            this.Vetura,
            this.Pershkrimi,
            this.Pjeset,
            this.Shiko});
            this.datagrid.Location = new System.Drawing.Point(29, 110);
            this.datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.datagrid.Name = "datagrid";
            this.datagrid.ReadOnly = true;
            this.datagrid.RowHeadersWidth = 51;
            this.datagrid.RowTemplate.Height = 24;
            this.datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid.Size = new System.Drawing.Size(644, 306);
            this.datagrid.TabIndex = 0;
            this.datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_CellContentClick);
            // 
            // ServisiID
            // 
            this.ServisiID.DataPropertyName = "ServisiID";
            this.ServisiID.HeaderText = "ServisiID";
            this.ServisiID.MinimumWidth = 6;
            this.ServisiID.Name = "ServisiID";
            this.ServisiID.ReadOnly = true;
            this.ServisiID.Visible = false;
            // 
            // Klienti
            // 
            this.Klienti.DataPropertyName = "Klienti";
            this.Klienti.HeaderText = "Klienti";
            this.Klienti.MinimumWidth = 6;
            this.Klienti.Name = "Klienti";
            this.Klienti.ReadOnly = true;
            // 
            // Telefoni
            // 
            this.Telefoni.DataPropertyName = "Telefoni";
            this.Telefoni.HeaderText = "Telefoni";
            this.Telefoni.MinimumWidth = 6;
            this.Telefoni.Name = "Telefoni";
            this.Telefoni.ReadOnly = true;
            // 
            // Vetura
            // 
            this.Vetura.DataPropertyName = "Vetura";
            this.Vetura.HeaderText = "Vetura";
            this.Vetura.MinimumWidth = 6;
            this.Vetura.Name = "Vetura";
            this.Vetura.ReadOnly = true;
            // 
            // Pershkrimi
            // 
            this.Pershkrimi.DataPropertyName = "Pershkrimi";
            this.Pershkrimi.HeaderText = "Pershkrimi";
            this.Pershkrimi.MinimumWidth = 6;
            this.Pershkrimi.Name = "Pershkrimi";
            this.Pershkrimi.ReadOnly = true;
            // 
            // Pjeset
            // 
            this.Pjeset.DataPropertyName = "Pjeset";
            this.Pjeset.HeaderText = "Pjeset";
            this.Pjeset.MinimumWidth = 6;
            this.Pjeset.Name = "Pjeset";
            this.Pjeset.ReadOnly = true;
            // 
            // Shiko
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Shiko.DefaultCellStyle = dataGridViewCellStyle3;
            this.Shiko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shiko.HeaderText = "Opsionet";
            this.Shiko.MinimumWidth = 6;
            this.Shiko.Name = "Shiko";
            this.Shiko.ReadOnly = true;
            this.Shiko.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Shiko.Text = "Shiko";
            this.Shiko.UseColumnTextForButtonValue = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(260, 64);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kerko";
            // 
            // shikopanel
            // 
            this.shikopanel.Controls.Add(this.groupBox1);
            this.shikopanel.Controls.Add(this.kthehubtn);
            this.shikopanel.Location = new System.Drawing.Point(29, 60);
            this.shikopanel.Margin = new System.Windows.Forms.Padding(2);
            this.shikopanel.Name = "shikopanel";
            this.shikopanel.Size = new System.Drawing.Size(658, 356);
            this.shikopanel.TabIndex = 3;
            this.shikopanel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblEmri);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(124, 82);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klienti";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Emri";
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Location = new System.Drawing.Point(36, 18);
            this.lblEmri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(35, 13);
            this.lblEmri.TabIndex = 1;
            this.lblEmri.Text = "label3";
            // 
            // kthehubtn
            // 
            this.kthehubtn.Location = new System.Drawing.Point(544, 11);
            this.kthehubtn.Margin = new System.Windows.Forms.Padding(2);
            this.kthehubtn.Name = "kthehubtn";
            this.kthehubtn.Size = new System.Drawing.Size(83, 29);
            this.kthehubtn.TabIndex = 2;
            this.kthehubtn.Text = "Kthehu";
            this.kthehubtn.UseVisualStyleBackColor = true;
            this.kthehubtn.Click += new System.EventHandler(this.kthehubtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(451, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 29);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "refresh.png");
            // 
            // HistorikuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.shikopanel);
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HistorikuControl";
            this.Size = new System.Drawing.Size(722, 435);
            this.Load += new System.EventHandler(this.HistorikuControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid)).EndInit();
            this.shikopanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServisiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klienti;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefoni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vetura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pershkrimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pjeset;
        private System.Windows.Forms.DataGridViewButtonColumn Shiko;
        private System.Windows.Forms.Panel shikopanel;
        private System.Windows.Forms.Label lblEmri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kthehubtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
