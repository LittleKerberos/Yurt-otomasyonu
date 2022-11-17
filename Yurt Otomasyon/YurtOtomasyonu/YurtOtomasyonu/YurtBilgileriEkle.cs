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
    public partial class YurtBilgileriEkle : Form
    {
        public YurtBilgileriEkle()
        {
            InitializeComponent();
        }
        int j = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "select tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad, tbl_yurtBilgileri.ogr_baslangıcTarihi,tbl_yurtBilgileri.ogr_bitisTarihi,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo,tbl_yurtBilgileri.ogr_ucret from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum=1";
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView2.DataSource = dt;
        }   
        public void yatakEkle()
        {
            cmbYatakBox.Items.Clear();
            cmbYatakBox.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From tbl_yataklar Where YatakOdaID=@p1 and YatakDurum=0", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbOdaBox.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbYatakBox.Items.Add(dr[1].ToString());
            }
            baglanti.Close();
        }
        //public void katEkle()
        //{
        //    baglanti.Open();
        //    SqlCommand komut = new SqlCommand("select * from tbl_kat", baglanti);
        //    SqlDataReader dr = komut.ExecuteReader();
        //    while (dr.Read())
        //    {
        //        comboBox1.Items.Add(dr[1]);
        //    }
        //    baglanti.Close();
        //}

        public void veriCekme()
        {
            SqlCommand komut = new SqlCommand("select tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad, tbl_yurtBilgileri.ogr_baslangıcTarihi,tbl_yurtBilgileri.ogr_bitisTarihi,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo,tbl_yurtBilgileri.ogr_ucret from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].HeaderText = "ODA NO";
            dataGridView2.Columns[2].HeaderText = "YATAK NO";
            dataGridView2.Columns[3].HeaderText = "ÜCRET";
            dataGridView2.Columns[4].HeaderText = "BAŞLANGIÇ TARİHİ";
            dataGridView2.Columns[5].HeaderText = "BİTİŞ TARİHİ";
            dataGridView2.Columns[6].Visible = false;
        }
        private void YurtBilgileriEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yurtOtomasyonDatabaseDataSet3.tbl_yurtBilgileri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_yurtBilgileriTableAdapter1.Fill(this.yurtOtomasyonDatabaseDataSet3.tbl_yurtBilgileri);
            odaEkle();
            //katEkle();
            veriCekme();
        }   
        void odaEkle()
        {
            cmbOdaBox.Items.Clear();
            cmbOdaBox.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_odalar", baglanti);
            komut.Parameters.AddWithValue("@p1",comboBox1.SelectedIndex+1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbOdaBox.Items.Add(dr[1].ToString());
            }
            baglanti.Close();
        }
        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_yurtBilgileri (ogr_odaNo,ogr_yatakNo,ogr_ucret,ogr_baslangıcTarihi,ogr_bitisTarihi,ogr_durum) values (@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);
            //komut.Parameters.AddWithValue("@p4", comboBox1.Text);
            komut.Parameters.AddWithValue("@p5", cmbOdaBox.Text);
            komut.Parameters.AddWithValue("@p6", cmbYatakBox.Text);
            komut.Parameters.AddWithValue("@p7", mtxtUcret.Text);
            komut.Parameters.AddWithValue("@p8", mtxtBaslangic.Text);
            komut.Parameters.AddWithValue("@p9", mtxtBitisTarihi.Text);
            komut.Parameters.AddWithValue("@p10",1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Yurt Bilgileri Eklendi");

            baglanti.Open();
            SqlCommand yatakUpdae = new SqlCommand("update tbl_yataklar set YatakDurum=1 where yatakIsım=@p1", baglanti);
            yatakUpdae.Parameters.AddWithValue("@p1", cmbYatakBox.Text);
            yatakUpdae.ExecuteNonQuery();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tbl_borclar (ogr_kalanBorc,ogr_taksitSayisi) values(@p3,@p4)",baglanti);
            komut2.Parameters.AddWithValue("@p3", mtxtUcret.Text);
            komut2.Parameters.AddWithValue("@p4", comboBox2.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {

            }
            baglanti.Close();


            //ARŞİV

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into tbl_yurtBilgileriArsiv (ogr_odaNo,ogr_yatakNo,ogr_ucret,ogr_baslangıcTarihi,ogr_bitisTarihi) values (@p5,@p6,@p7,@p8,@p9)", baglanti);
            //komut.Parameters.AddWithValue("@p4", comboBox1.Text);
            komut3.Parameters.AddWithValue("@p5", cmbOdaBox.Text);
            komut3.Parameters.AddWithValue("@p6", cmbYatakBox.Text);
            komut3.Parameters.AddWithValue("@p7", mtxtUcret.Text);
            komut3.Parameters.AddWithValue("@p8", mtxtBaslangic.Text);
            komut3.Parameters.AddWithValue("@p9", mtxtBitisTarihi.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {

            }
            baglanti.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                sql = "select tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad, tbl_yurtBilgileri.ogr_baslangıcTarihi,tbl_yurtBilgileri.ogr_bitisTarihi,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo,tbl_yurtBilgileri.ogr_ucret from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum = 1 and ogr_odaNo='" + textBox1.Text + "'";
            }
            else if (radioButton4.Checked)
            {
                sql = "select tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad, tbl_yurtBilgileri.ogr_baslangıcTarihi,tbl_yurtBilgileri.ogr_bitisTarihi,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo,tbl_yurtBilgileri.ogr_ucret from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum = 1 and ogr_baslangıcTarihi ='" + textBox1.Text + "'";
            }
            else
            {
                sql = "select tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad, tbl_yurtBilgileri.ogr_baslangıcTarihi,tbl_yurtBilgileri.ogr_bitisTarihi,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo,tbl_yurtBilgileri.ogr_ucret from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_yurtBilgileri.ogr_durum = 1";
            }
            Listele(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            veriCekme();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void öğrenciBilgiGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();
            this.Hide();
        }

        private void cmbOdaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            yatakEkle();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //odaEkle();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }
    }
}
