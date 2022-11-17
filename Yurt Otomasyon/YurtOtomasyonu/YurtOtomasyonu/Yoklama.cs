using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YurtOtomasyonu
{
    public partial class Yoklama : Form
    {
        public Yoklama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        public void veriCekme()
        {
            SqlCommand komut = new SqlCommand("select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum=1 and tbl_ogrenci.ogr_izinDurum=0", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "ODA NO";
            dataGridView1.Columns[4].HeaderText = "YATAK NO";




        }

        string sql = "select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum=1 and tbl_ogrenci.ogr_izinDurum=0";
        SqlDataAdapter da;
        DataTable dt;
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yonetici = new YoneticiForm();
            yonetici.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string thisDay;
        private void Yoklama_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.d";
            thisDay = dateTimePicker1.Text;
            lbltarih.Text = thisDay.ToString();
            veriCekme();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            label2.Text= dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            lblAd.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            lblSoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            lblOdaNo.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            lblYatakNo.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            MessageBox.Show("Öğrenci bilgileri çekildi, öğrencinin adı ve soyadı: " + lblAd.Text + "  " + lblSoyad.Text + " öğrenci Oda No: " + lblOdaNo.Text + " Öğrenci Yatak No: " + lblYatakNo.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sql = "select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum=1 and ogr_odaNo='" + textBox1.Text + "'";
            }
            else if (radioButton2.Checked)
            {
                sql = "select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum=1 and ogr_ad ='" + textBox1.Text + "'";
            }
            else
            {
                sql = "select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum=1";
            }
            Listele(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into tbl_yoklama (tarih,yoklamaDurum,ad,soyad,odaNo,yatakNo,veli_id) values (@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
            komut3.Parameters.AddWithValue("@p5", lbltarih.Text);
            komut3.Parameters.AddWithValue("@p6", 1);
            komut3.Parameters.AddWithValue("@p7", lblAd.Text);
            komut3.Parameters.AddWithValue("@p8", lblSoyad.Text);
            komut3.Parameters.AddWithValue("@p9", lblOdaNo.Text);
            komut3.Parameters.AddWithValue("@p10", lblYatakNo.Text);
            komut3.Parameters.AddWithValue("@p11", label2.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Öğrenci Var Olarak Kaydedildi " + "öğrencinin adı ve soyadı: " + lblAd.Text + "  " + lblSoyad.Text + " öğrenci Oda No: " + lblOdaNo.Text + " Öğrenci Yatak No: " + lblYatakNo.Text);
            dataGridView1.DefaultCellStyle.SelectionBackColor= Color.GreenYellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into tbl_yoklama (tarih,yoklamaDurum,ad,soyad,odaNo,yatakNo,veli_id) values (@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
            komut3.Parameters.AddWithValue("@p5", lbltarih.Text);
            komut3.Parameters.AddWithValue("@p6", 0);
            komut3.Parameters.AddWithValue("@p7", lblAd.Text);
            komut3.Parameters.AddWithValue("@p8", lblSoyad.Text);
            komut3.Parameters.AddWithValue("@p9", lblOdaNo.Text);
            komut3.Parameters.AddWithValue("@p10", lblYatakNo.Text);
            komut3.Parameters.AddWithValue("@p11", label2.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Öğrenci Bugün Gelmedi" + " öğrencinin adı ve soyadı: " + lblAd.Text + "  " + lblSoyad.Text + " öğrenci Oda No: " + lblOdaNo.Text + " Öğrenci Yatak No: " + lblYatakNo.Text);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;
        }

        private void yoklamaListewsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoklamaListesi yoklamaListesi = new YoklamaListesi();
            yoklamaListesi.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum=1";
            Listele(sql);
        }
    }
}
