
namespace YurtOtomasyonu
{
    partial class personelGüncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelGüncelle));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rtxtHakkinda = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxtYakınTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtEvTelNo = new System.Windows.Forms.MaskedTextBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mtxtTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.rtxtAdres = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsTcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsEvTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsYakınTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsEpostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsKanGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsDogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prsHakkindaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblpersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDB = new YurtOtomasyonu.personelDB();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbl_personelTableAdapter = new YurtOtomasyonu.personelDBTableAdapters.tbl_personelTableAdapter();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDB)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.rtxtHakkinda);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.groupBox5.Location = new System.Drawing.Point(12, 286);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(697, 228);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Diğer Bilgiler";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.DarkGray;
            this.label11.Location = new System.Drawing.Point(446, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 21);
            this.label11.TabIndex = 19;
            this.label11.Text = "Max \'255\' karakter girebilirsiniz !";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.Color.DarkGray;
            this.label17.Location = new System.Drawing.Point(51, 439);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(237, 21);
            this.label17.TabIndex = 18;
            this.label17.Text = "Max \'255\' karakter girebilirsiniz !";
            // 
            // rtxtHakkinda
            // 
            this.rtxtHakkinda.Location = new System.Drawing.Point(17, 53);
            this.rtxtHakkinda.Name = "rtxtHakkinda";
            this.rtxtHakkinda.Size = new System.Drawing.Size(666, 160);
            this.rtxtHakkinda.TabIndex = 17;
            this.rtxtHakkinda.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.ForeColor = System.Drawing.Color.DimGray;
            this.label20.Location = new System.Drawing.Point(13, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 21);
            this.label20.TabIndex = 17;
            this.label20.Text = "Personel Hakkında";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.mtxtYakınTelNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.mtxtEvTelNo);
            this.groupBox2.Controls.Add(this.txtEposta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.mtxtTelNo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.groupBox2.Location = new System.Drawing.Point(355, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 226);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İletişim Bilgileri";
            // 
            // mtxtYakınTelNo
            // 
            this.mtxtYakınTelNo.Location = new System.Drawing.Point(183, 172);
            this.mtxtYakınTelNo.Mask = "00000000000";
            this.mtxtYakınTelNo.Name = "mtxtYakınTelNo";
            this.mtxtYakınTelNo.Size = new System.Drawing.Size(157, 29);
            this.mtxtYakınTelNo.TabIndex = 16;
            this.mtxtYakınTelNo.ValidatingType = typeof(int);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(20, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Personel  Yakın Tel No";
            // 
            // mtxtEvTelNo
            // 
            this.mtxtEvTelNo.Location = new System.Drawing.Point(183, 137);
            this.mtxtEvTelNo.Mask = "00000000000";
            this.mtxtEvTelNo.Name = "mtxtEvTelNo";
            this.mtxtEvTelNo.Size = new System.Drawing.Size(157, 29);
            this.mtxtEvTelNo.TabIndex = 14;
            this.mtxtEvTelNo.ValidatingType = typeof(int);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(183, 100);
            this.txtEposta.Multiline = true;
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(157, 25);
            this.txtEposta.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(41, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "Personel  Ev Tel No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(62, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 21);
            this.label8.TabIndex = 9;
            this.label8.Text = "Personel Eposta";
            // 
            // mtxtTelNo
            // 
            this.mtxtTelNo.Location = new System.Drawing.Point(183, 60);
            this.mtxtTelNo.Mask = "00000000000";
            this.mtxtTelNo.Name = "mtxtTelNo";
            this.mtxtTelNo.Size = new System.Drawing.Size(157, 29);
            this.mtxtTelNo.TabIndex = 6;
            this.mtxtTelNo.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(69, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Personel Tel No";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.rtxtAdres);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 226);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(279, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(40, 29);
            this.txtID.TabIndex = 15;
            // 
            // rtxtAdres
            // 
            this.rtxtAdres.Location = new System.Drawing.Point(17, 73);
            this.rtxtAdres.Name = "rtxtAdres";
            this.rtxtAdres.Size = new System.Drawing.Size(302, 146);
            this.rtxtAdres.TabIndex = 14;
            this.rtxtAdres.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(13, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Personel Adres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.prsAdDataGridViewTextBoxColumn,
            this.prsSoyadDataGridViewTextBoxColumn,
            this.prsTcDataGridViewTextBoxColumn,
            this.prsTelNoDataGridViewTextBoxColumn,
            this.prsEvTelNoDataGridViewTextBoxColumn,
            this.prsYakınTelNoDataGridViewTextBoxColumn,
            this.prsAdresDataGridViewTextBoxColumn,
            this.prsEpostaDataGridViewTextBoxColumn,
            this.prsKanGrubuDataGridViewTextBoxColumn,
            this.prsDogumTarihiDataGridViewTextBoxColumn,
            this.prsHakkindaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblpersonelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(715, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(481, 402);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prsAdDataGridViewTextBoxColumn
            // 
            this.prsAdDataGridViewTextBoxColumn.DataPropertyName = "prsAd";
            this.prsAdDataGridViewTextBoxColumn.HeaderText = "prsAd";
            this.prsAdDataGridViewTextBoxColumn.Name = "prsAdDataGridViewTextBoxColumn";
            // 
            // prsSoyadDataGridViewTextBoxColumn
            // 
            this.prsSoyadDataGridViewTextBoxColumn.DataPropertyName = "prsSoyad";
            this.prsSoyadDataGridViewTextBoxColumn.HeaderText = "prsSoyad";
            this.prsSoyadDataGridViewTextBoxColumn.Name = "prsSoyadDataGridViewTextBoxColumn";
            // 
            // prsTcDataGridViewTextBoxColumn
            // 
            this.prsTcDataGridViewTextBoxColumn.DataPropertyName = "prsTc";
            this.prsTcDataGridViewTextBoxColumn.HeaderText = "prsTc";
            this.prsTcDataGridViewTextBoxColumn.Name = "prsTcDataGridViewTextBoxColumn";
            // 
            // prsTelNoDataGridViewTextBoxColumn
            // 
            this.prsTelNoDataGridViewTextBoxColumn.DataPropertyName = "prsTelNo";
            this.prsTelNoDataGridViewTextBoxColumn.HeaderText = "prsTelNo";
            this.prsTelNoDataGridViewTextBoxColumn.Name = "prsTelNoDataGridViewTextBoxColumn";
            // 
            // prsEvTelNoDataGridViewTextBoxColumn
            // 
            this.prsEvTelNoDataGridViewTextBoxColumn.DataPropertyName = "prsEvTelNo";
            this.prsEvTelNoDataGridViewTextBoxColumn.HeaderText = "prsEvTelNo";
            this.prsEvTelNoDataGridViewTextBoxColumn.Name = "prsEvTelNoDataGridViewTextBoxColumn";
            // 
            // prsYakınTelNoDataGridViewTextBoxColumn
            // 
            this.prsYakınTelNoDataGridViewTextBoxColumn.DataPropertyName = "prsYakınTelNo";
            this.prsYakınTelNoDataGridViewTextBoxColumn.HeaderText = "prsYakınTelNo";
            this.prsYakınTelNoDataGridViewTextBoxColumn.Name = "prsYakınTelNoDataGridViewTextBoxColumn";
            // 
            // prsAdresDataGridViewTextBoxColumn
            // 
            this.prsAdresDataGridViewTextBoxColumn.DataPropertyName = "prsAdres";
            this.prsAdresDataGridViewTextBoxColumn.HeaderText = "prsAdres";
            this.prsAdresDataGridViewTextBoxColumn.Name = "prsAdresDataGridViewTextBoxColumn";
            // 
            // prsEpostaDataGridViewTextBoxColumn
            // 
            this.prsEpostaDataGridViewTextBoxColumn.DataPropertyName = "prsEposta";
            this.prsEpostaDataGridViewTextBoxColumn.HeaderText = "prsEposta";
            this.prsEpostaDataGridViewTextBoxColumn.Name = "prsEpostaDataGridViewTextBoxColumn";
            // 
            // prsKanGrubuDataGridViewTextBoxColumn
            // 
            this.prsKanGrubuDataGridViewTextBoxColumn.DataPropertyName = "prsKanGrubu";
            this.prsKanGrubuDataGridViewTextBoxColumn.HeaderText = "prsKanGrubu";
            this.prsKanGrubuDataGridViewTextBoxColumn.Name = "prsKanGrubuDataGridViewTextBoxColumn";
            // 
            // prsDogumTarihiDataGridViewTextBoxColumn
            // 
            this.prsDogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "prsDogumTarihi";
            this.prsDogumTarihiDataGridViewTextBoxColumn.HeaderText = "prsDogumTarihi";
            this.prsDogumTarihiDataGridViewTextBoxColumn.Name = "prsDogumTarihiDataGridViewTextBoxColumn";
            // 
            // prsHakkindaDataGridViewTextBoxColumn
            // 
            this.prsHakkindaDataGridViewTextBoxColumn.DataPropertyName = "prsHakkinda";
            this.prsHakkindaDataGridViewTextBoxColumn.HeaderText = "prsHakkinda";
            this.prsHakkindaDataGridViewTextBoxColumn.Name = "prsHakkindaDataGridViewTextBoxColumn";
            // 
            // tblpersonelBindingSource
            // 
            this.tblpersonelBindingSource.DataMember = "tbl_personel";
            this.tblpersonelBindingSource.DataSource = this.personelDB;
            // 
            // personelDB
            // 
            this.personelDB.DataSetName = "personelDB";
            this.personelDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1036, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 48);
            this.button1.TabIndex = 37;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1156, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 36);
            this.button3.TabIndex = 38;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Soccer League", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(532, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Devlet Yurdu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(443, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Çanakakle Onsekiz Mart Üniversitesi \r\n";
            // 
            // tbl_personelTableAdapter
            // 
            this.tbl_personelTableAdapter.ClearBeforeFill = true;
            // 
            // personelGüncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1206, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "personelGüncelle";
            this.Text = "personelGüncelle";
            this.Load += new System.EventHandler(this.personelGüncelle_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rtxtHakkinda;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mtxtYakınTelNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtEvTelNo;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtTelNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.RichTextBox rtxtAdres;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private personelDB personelDB;
        private System.Windows.Forms.BindingSource tblpersonelBindingSource;
        private personelDBTableAdapters.tbl_personelTableAdapter tbl_personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsTcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsEvTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsYakınTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsEpostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsKanGrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsDogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prsHakkindaDataGridViewTextBoxColumn;
    }
}