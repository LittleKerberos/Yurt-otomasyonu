
namespace YurtOtomasyonu
{
    partial class odemeListele
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(odemeListele));
            this.lbltaksit = new System.Windows.Forms.Label();
            this.lblodenenmiktar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.odemeListeleDB2 = new YurtOtomasyonu.odemeListeleDB2();
            this.tbltaksitBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_taksitTableAdapter1 = new YurtOtomasyonu.odemeListeleDB2TableAdapters.tbl_taksitTableAdapter();
            this.odemeListeleDB2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taksitZamaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenenMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ödemeTürüDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanTaksitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbltaksitBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.odemeListeleDB2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odemeListeleDB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaksitBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeListeleDB2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaksitBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeListeleDB2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltaksit
            // 
            this.lbltaksit.AutoSize = true;
            this.lbltaksit.Location = new System.Drawing.Point(665, 13);
            this.lbltaksit.Name = "lbltaksit";
            this.lbltaksit.Size = new System.Drawing.Size(55, 13);
            this.lbltaksit.TabIndex = 1;
            this.lbltaksit.Text = "gün/ay/yıl";
            this.lbltaksit.Visible = false;
            // 
            // lblodenenmiktar
            // 
            this.lblodenenmiktar.AutoSize = true;
            this.lblodenenmiktar.Location = new System.Drawing.Point(665, 28);
            this.lblodenenmiktar.Name = "lblodenenmiktar";
            this.lblodenenmiktar.Size = new System.Drawing.Size(13, 13);
            this.lblodenenmiktar.TabIndex = 2;
            this.lblodenenmiktar.Text = "0";
            this.lblodenenmiktar.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(665, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 44);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Text = "Baskı önizleme";
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(761, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 273);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(34, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "YIL.AY.GÜN";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(37, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 41);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tüm Kayıtları Göster";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(198, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(37, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 33);
            this.textBox1.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(37, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(165, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Zaman Göre Arama Yap";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1045, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 44);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(993, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 44);
            this.button5.TabIndex = 6;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // odemeListeleDB2
            // 
            this.odemeListeleDB2.DataSetName = "odemeListeleDB2";
            this.odemeListeleDB2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltaksitBindingSource1
            // 
            this.tbltaksitBindingSource1.DataMember = "tbl_taksit";
            this.tbltaksitBindingSource1.DataSource = this.odemeListeleDB2;
            // 
            // tbl_taksitTableAdapter1
            // 
            this.tbl_taksitTableAdapter1.ClearBeforeFill = true;
            // 
            // odemeListeleDB2BindingSource
            // 
            this.odemeListeleDB2BindingSource.DataSource = this.odemeListeleDB2;
            this.odemeListeleDB2BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.taksitZamaniDataGridViewTextBoxColumn,
            this.odenenMiktarDataGridViewTextBoxColumn,
            this.ödemeTürüDataGridViewTextBoxColumn,
            this.kalanTaksitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbltaksitBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 485);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ogr_ad";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "AD";
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogr_soyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "SOYAD";
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            // 
            // taksitZamaniDataGridViewTextBoxColumn
            // 
            this.taksitZamaniDataGridViewTextBoxColumn.DataPropertyName = "taksitZamani";
            this.taksitZamaniDataGridViewTextBoxColumn.HeaderText = "TAKSİT ZAMANI";
            this.taksitZamaniDataGridViewTextBoxColumn.Name = "taksitZamaniDataGridViewTextBoxColumn";
            // 
            // odenenMiktarDataGridViewTextBoxColumn
            // 
            this.odenenMiktarDataGridViewTextBoxColumn.DataPropertyName = "odenenMiktar";
            this.odenenMiktarDataGridViewTextBoxColumn.HeaderText = "ÖDENEN MİKTAR";
            this.odenenMiktarDataGridViewTextBoxColumn.Name = "odenenMiktarDataGridViewTextBoxColumn";
            // 
            // ödemeTürüDataGridViewTextBoxColumn
            // 
            this.ödemeTürüDataGridViewTextBoxColumn.DataPropertyName = "ödemeTürü";
            this.ödemeTürüDataGridViewTextBoxColumn.HeaderText = "ÖDEME TÜRÜ";
            this.ödemeTürüDataGridViewTextBoxColumn.Name = "ödemeTürüDataGridViewTextBoxColumn";
            // 
            // kalanTaksitDataGridViewTextBoxColumn
            // 
            this.kalanTaksitDataGridViewTextBoxColumn.DataPropertyName = "kalanTaksit";
            this.kalanTaksitDataGridViewTextBoxColumn.HeaderText = "KALAN TAKSİT";
            this.kalanTaksitDataGridViewTextBoxColumn.Name = "kalanTaksitDataGridViewTextBoxColumn";
            // 
            // tbltaksitBindingSource2
            // 
            this.tbltaksitBindingSource2.DataMember = "tbl_taksit";
            this.tbltaksitBindingSource2.DataSource = this.odemeListeleDB2BindingSource1;
            // 
            // odemeListeleDB2BindingSource1
            // 
            this.odemeListeleDB2BindingSource1.DataSource = this.odemeListeleDB2;
            this.odemeListeleDB2BindingSource1.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(665, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "0";
            this.label2.Visible = false;
            // 
            // odemeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 510);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblodenenmiktar);
            this.Controls.Add(this.lbltaksit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "odemeListele";
            this.Text = "odemeListele";
            this.Load += new System.EventHandler(this.odemeListele_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odemeListeleDB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaksitBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeListeleDB2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaksitBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odemeListeleDB2BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltaksit;
        private System.Windows.Forms.Label lblodenenmiktar;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private odemeListeleDB2 odemeListeleDB2;
        private System.Windows.Forms.BindingSource tbltaksitBindingSource1;
        private odemeListeleDB2TableAdapters.tbl_taksitTableAdapter tbl_taksitTableAdapter1;
        private System.Windows.Forms.BindingSource odemeListeleDB2BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taksitZamaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenenMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ödemeTürüDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanTaksitDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbltaksitBindingSource2;
        private System.Windows.Forms.BindingSource odemeListeleDB2BindingSource1;
        private System.Windows.Forms.Label label2;
    }
}