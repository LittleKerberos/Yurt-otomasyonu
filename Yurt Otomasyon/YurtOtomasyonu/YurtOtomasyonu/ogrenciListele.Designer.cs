
namespace YurtOtomasyonu
{
    partial class ogrenciListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenciListele));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencereyiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ogrenciDataBase = new YurtOtomasyonu.OgrenciDataBase();
            this.tblogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ogrenciTableAdapter = new YurtOtomasyonu.OgrenciDataBaseTableAdapters.tbl_ogrenciTableAdapter();
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrdogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrkanGrubuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrilceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrepostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrevTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliYakınlıkDurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrveliIsNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrhakkindaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogryakınlıkDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogryakınTelNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogryakınAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogryakınSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.veliidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrizinDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem,
            this.listeleToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pencereyiKapatToolStripMenuItem,
            this.çıkışYapToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayarlarToolStripMenuItem.Image")));
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // pencereyiKapatToolStripMenuItem
            // 
            this.pencereyiKapatToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pencereyiKapatToolStripMenuItem.Image")));
            this.pencereyiKapatToolStripMenuItem.Name = "pencereyiKapatToolStripMenuItem";
            this.pencereyiKapatToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.pencereyiKapatToolStripMenuItem.Text = "Pencereyi Kapat";
            this.pencereyiKapatToolStripMenuItem.Click += new System.EventHandler(this.pencereyiKapatToolStripMenuItem_Click);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışYapToolStripMenuItem.Image")));
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // listeleToolStripMenuItem
            // 
            this.listeleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listeleToolStripMenuItem.Image")));
            this.listeleToolStripMenuItem.Name = "listeleToolStripMenuItem";
            this.listeleToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.listeleToolStripMenuItem.Text = "Listeyi Yenile";
            this.listeleToolStripMenuItem.Click += new System.EventHandler(this.listeleToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrtcDataGridViewTextBoxColumn,
            this.ogrdogumTarihiDataGridViewTextBoxColumn,
            this.ogrkanGrubuDataGridViewTextBoxColumn,
            this.ogrilDataGridViewTextBoxColumn,
            this.ogrilceDataGridViewTextBoxColumn,
            this.ogradresDataGridViewTextBoxColumn,
            this.ogrtelNoDataGridViewTextBoxColumn,
            this.ogrepostaDataGridViewTextBoxColumn,
            this.ogrevTelNoDataGridViewTextBoxColumn,
            this.ogrveliYakınlıkDurumuDataGridViewTextBoxColumn,
            this.ogrveliAdDataGridViewTextBoxColumn,
            this.ogrveliSoyadDataGridViewTextBoxColumn,
            this.ogrveliMeslekDataGridViewTextBoxColumn,
            this.ogrveliTelNoDataGridViewTextBoxColumn,
            this.ogrveliIsNoDataGridViewTextBoxColumn,
            this.ogrhakkindaDataGridViewTextBoxColumn,
            this.ogryakınlıkDurumDataGridViewTextBoxColumn,
            this.ogryakınTelNoDataGridViewTextBoxColumn,
            this.ogryakınAdDataGridViewTextBoxColumn,
            this.ogryakınSoyadDataGridViewTextBoxColumn,
            this.ogrdurumDataGridViewCheckBoxColumn,
            this.veliidDataGridViewTextBoxColumn,
            this.ogrizinDurumDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblogrenciBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1396, 42);
            this.panel1.TabIndex = 33;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.label18.Location = new System.Drawing.Point(3, 10);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 25);
            this.label18.TabIndex = 25;
            this.label18.Text = "Öğrenci Listele";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Soccer League", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.label19.Location = new System.Drawing.Point(790, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(176, 22);
            this.label19.TabIndex = 6;
            this.label19.Text = "Devlet Yurdu";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(446, 8);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(353, 25);
            this.label21.TabIndex = 3;
            this.label21.Text = "Çanakakle Onsekiz Mart Üniversitesi \r\n";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Location = new System.Drawing.Point(12, 130);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(1346, 66);
            this.panel2.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1281, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 58);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(10, 16);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(190, 29);
            this.label24.TabIndex = 24;
            this.label24.Text = "Öğrenci Listele";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(1128, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 428);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton4.Location = new System.Drawing.Point(30, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 25);
            this.radioButton4.TabIndex = 48;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "İle Göre Ara";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.Location = new System.Drawing.Point(30, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 25);
            this.radioButton1.TabIndex = 42;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "İsme Göre Ara";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(68)))), ((int)(((byte)(84)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(30, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 37);
            this.button3.TabIndex = 47;
            this.button3.Text = "Tüm Kayıtları Göster";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.Location = new System.Drawing.Point(30, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 25);
            this.radioButton2.TabIndex = 43;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "TC\'ye göre ara";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(170, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 32);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton3.Location = new System.Drawing.Point(30, 83);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(181, 25);
            this.radioButton3.TabIndex = 44;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Kan grubuna göre Ara";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(30, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 32);
            this.textBox1.TabIndex = 45;
            // 
            // ogrenciDataBase
            // 
            this.ogrenciDataBase.DataSetName = "OgrenciDataBase";
            this.ogrenciDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblogrenciBindingSource
            // 
            this.tblogrenciBindingSource.DataMember = "tbl_ogrenci";
            this.tblogrenciBindingSource.DataSource = this.ogrenciDataBase;
            // 
            // tbl_ogrenciTableAdapter
            // 
            this.tbl_ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogr_id";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogr_id";
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ogr_ad";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ogr_ad";
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            this.ogradDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogr_soyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogr_soyad";
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            this.ogrsoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrtcDataGridViewTextBoxColumn
            // 
            this.ogrtcDataGridViewTextBoxColumn.DataPropertyName = "ogr_tc";
            this.ogrtcDataGridViewTextBoxColumn.HeaderText = "ogr_tc";
            this.ogrtcDataGridViewTextBoxColumn.Name = "ogrtcDataGridViewTextBoxColumn";
            this.ogrtcDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrdogumTarihiDataGridViewTextBoxColumn
            // 
            this.ogrdogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "ogr_dogumTarihi";
            this.ogrdogumTarihiDataGridViewTextBoxColumn.HeaderText = "ogr_dogumTarihi";
            this.ogrdogumTarihiDataGridViewTextBoxColumn.Name = "ogrdogumTarihiDataGridViewTextBoxColumn";
            this.ogrdogumTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrkanGrubuDataGridViewTextBoxColumn
            // 
            this.ogrkanGrubuDataGridViewTextBoxColumn.DataPropertyName = "ogr_kanGrubu";
            this.ogrkanGrubuDataGridViewTextBoxColumn.HeaderText = "ogr_kanGrubu";
            this.ogrkanGrubuDataGridViewTextBoxColumn.Name = "ogrkanGrubuDataGridViewTextBoxColumn";
            this.ogrkanGrubuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrilDataGridViewTextBoxColumn
            // 
            this.ogrilDataGridViewTextBoxColumn.DataPropertyName = "ogr_il";
            this.ogrilDataGridViewTextBoxColumn.HeaderText = "ogr_il";
            this.ogrilDataGridViewTextBoxColumn.Name = "ogrilDataGridViewTextBoxColumn";
            this.ogrilDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrilceDataGridViewTextBoxColumn
            // 
            this.ogrilceDataGridViewTextBoxColumn.DataPropertyName = "ogr_ilce";
            this.ogrilceDataGridViewTextBoxColumn.HeaderText = "ogr_ilce";
            this.ogrilceDataGridViewTextBoxColumn.Name = "ogrilceDataGridViewTextBoxColumn";
            this.ogrilceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogradresDataGridViewTextBoxColumn
            // 
            this.ogradresDataGridViewTextBoxColumn.DataPropertyName = "ogr_adres";
            this.ogradresDataGridViewTextBoxColumn.HeaderText = "ogr_adres";
            this.ogradresDataGridViewTextBoxColumn.Name = "ogradresDataGridViewTextBoxColumn";
            this.ogradresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrtelNoDataGridViewTextBoxColumn
            // 
            this.ogrtelNoDataGridViewTextBoxColumn.DataPropertyName = "ogr_telNo";
            this.ogrtelNoDataGridViewTextBoxColumn.HeaderText = "ogr_telNo";
            this.ogrtelNoDataGridViewTextBoxColumn.Name = "ogrtelNoDataGridViewTextBoxColumn";
            this.ogrtelNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrepostaDataGridViewTextBoxColumn
            // 
            this.ogrepostaDataGridViewTextBoxColumn.DataPropertyName = "ogr_eposta";
            this.ogrepostaDataGridViewTextBoxColumn.HeaderText = "ogr_eposta";
            this.ogrepostaDataGridViewTextBoxColumn.Name = "ogrepostaDataGridViewTextBoxColumn";
            this.ogrepostaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrevTelNoDataGridViewTextBoxColumn
            // 
            this.ogrevTelNoDataGridViewTextBoxColumn.DataPropertyName = "ogr_evTelNo";
            this.ogrevTelNoDataGridViewTextBoxColumn.HeaderText = "ogr_evTelNo";
            this.ogrevTelNoDataGridViewTextBoxColumn.Name = "ogrevTelNoDataGridViewTextBoxColumn";
            this.ogrevTelNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrveliYakınlıkDurumuDataGridViewTextBoxColumn
            // 
            this.ogrveliYakınlıkDurumuDataGridViewTextBoxColumn.DataPropertyName = "ogr_veliYakınlıkDurumu";
            this.ogrveliYakınlıkDurumuDataGridViewTextBoxColumn.HeaderText = "ogr_veliYakınlıkDurumu";
            this.ogrveliYakınlıkDurumuDataGridViewTextBoxColumn.Name = "ogrveliYakınlıkDurumuDataGridViewTextBoxColumn";
            this.ogrveliYakınlıkDurumuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrveliAdDataGridViewTextBoxColumn
            // 
            this.ogrveliAdDataGridViewTextBoxColumn.DataPropertyName = "ogr_veliAd";
            this.ogrveliAdDataGridViewTextBoxColumn.HeaderText = "ogr_veliAd";
            this.ogrveliAdDataGridViewTextBoxColumn.Name = "ogrveliAdDataGridViewTextBoxColumn";
            this.ogrveliAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrveliSoyadDataGridViewTextBoxColumn
            // 
            this.ogrveliSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogr_veliSoyad";
            this.ogrveliSoyadDataGridViewTextBoxColumn.HeaderText = "ogr_veliSoyad";
            this.ogrveliSoyadDataGridViewTextBoxColumn.Name = "ogrveliSoyadDataGridViewTextBoxColumn";
            this.ogrveliSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrveliMeslekDataGridViewTextBoxColumn
            // 
            this.ogrveliMeslekDataGridViewTextBoxColumn.DataPropertyName = "ogr_veliMeslek";
            this.ogrveliMeslekDataGridViewTextBoxColumn.HeaderText = "ogr_veliMeslek";
            this.ogrveliMeslekDataGridViewTextBoxColumn.Name = "ogrveliMeslekDataGridViewTextBoxColumn";
            this.ogrveliMeslekDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrveliTelNoDataGridViewTextBoxColumn
            // 
            this.ogrveliTelNoDataGridViewTextBoxColumn.DataPropertyName = "ogr_veliTelNo";
            this.ogrveliTelNoDataGridViewTextBoxColumn.HeaderText = "ogr_veliTelNo";
            this.ogrveliTelNoDataGridViewTextBoxColumn.Name = "ogrveliTelNoDataGridViewTextBoxColumn";
            this.ogrveliTelNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrveliIsNoDataGridViewTextBoxColumn
            // 
            this.ogrveliIsNoDataGridViewTextBoxColumn.DataPropertyName = "ogr_veliIsNo";
            this.ogrveliIsNoDataGridViewTextBoxColumn.HeaderText = "ogr_veliIsNo";
            this.ogrveliIsNoDataGridViewTextBoxColumn.Name = "ogrveliIsNoDataGridViewTextBoxColumn";
            this.ogrveliIsNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrhakkindaDataGridViewTextBoxColumn
            // 
            this.ogrhakkindaDataGridViewTextBoxColumn.DataPropertyName = "ogr_hakkinda";
            this.ogrhakkindaDataGridViewTextBoxColumn.HeaderText = "ogr_hakkinda";
            this.ogrhakkindaDataGridViewTextBoxColumn.Name = "ogrhakkindaDataGridViewTextBoxColumn";
            this.ogrhakkindaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogryakınlıkDurumDataGridViewTextBoxColumn
            // 
            this.ogryakınlıkDurumDataGridViewTextBoxColumn.DataPropertyName = "ogr_yakınlıkDurum";
            this.ogryakınlıkDurumDataGridViewTextBoxColumn.HeaderText = "ogr_yakınlıkDurum";
            this.ogryakınlıkDurumDataGridViewTextBoxColumn.Name = "ogryakınlıkDurumDataGridViewTextBoxColumn";
            this.ogryakınlıkDurumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogryakınTelNoDataGridViewTextBoxColumn
            // 
            this.ogryakınTelNoDataGridViewTextBoxColumn.DataPropertyName = "ogr_yakınTelNo";
            this.ogryakınTelNoDataGridViewTextBoxColumn.HeaderText = "ogr_yakınTelNo";
            this.ogryakınTelNoDataGridViewTextBoxColumn.Name = "ogryakınTelNoDataGridViewTextBoxColumn";
            this.ogryakınTelNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogryakınAdDataGridViewTextBoxColumn
            // 
            this.ogryakınAdDataGridViewTextBoxColumn.DataPropertyName = "ogr_yakınAd";
            this.ogryakınAdDataGridViewTextBoxColumn.HeaderText = "ogr_yakınAd";
            this.ogryakınAdDataGridViewTextBoxColumn.Name = "ogryakınAdDataGridViewTextBoxColumn";
            this.ogryakınAdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogryakınSoyadDataGridViewTextBoxColumn
            // 
            this.ogryakınSoyadDataGridViewTextBoxColumn.DataPropertyName = "ogr_yakınSoyad";
            this.ogryakınSoyadDataGridViewTextBoxColumn.HeaderText = "ogr_yakınSoyad";
            this.ogryakınSoyadDataGridViewTextBoxColumn.Name = "ogryakınSoyadDataGridViewTextBoxColumn";
            this.ogryakınSoyadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrdurumDataGridViewCheckBoxColumn
            // 
            this.ogrdurumDataGridViewCheckBoxColumn.DataPropertyName = "ogr_durum";
            this.ogrdurumDataGridViewCheckBoxColumn.HeaderText = "ogr_durum";
            this.ogrdurumDataGridViewCheckBoxColumn.Name = "ogrdurumDataGridViewCheckBoxColumn";
            this.ogrdurumDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // veliidDataGridViewTextBoxColumn
            // 
            this.veliidDataGridViewTextBoxColumn.DataPropertyName = "veli_id";
            this.veliidDataGridViewTextBoxColumn.HeaderText = "veli_id";
            this.veliidDataGridViewTextBoxColumn.Name = "veliidDataGridViewTextBoxColumn";
            this.veliidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ogrizinDurumDataGridViewCheckBoxColumn
            // 
            this.ogrizinDurumDataGridViewCheckBoxColumn.DataPropertyName = "ogr_izinDurum";
            this.ogrizinDurumDataGridViewCheckBoxColumn.HeaderText = "ogr_izinDurum";
            this.ogrizinDurumDataGridViewCheckBoxColumn.Name = "ogrizinDurumDataGridViewCheckBoxColumn";
            this.ogrizinDurumDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ogrenciListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ogrenciListele";
            this.Text = "ogrenciListele";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ogrenciListele_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblogrenciBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencereyiKapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox1;
        private OgrenciDataBase ogrenciDataBase;
        private System.Windows.Forms.BindingSource tblogrenciBindingSource;
        private OgrenciDataBaseTableAdapters.tbl_ogrenciTableAdapter tbl_ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrdogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrkanGrubuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrilceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrepostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrevTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliYakınlıkDurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrveliIsNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrhakkindaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogryakınlıkDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogryakınTelNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogryakınAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogryakınSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ogrdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veliidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ogrizinDurumDataGridViewCheckBoxColumn;
    }
}