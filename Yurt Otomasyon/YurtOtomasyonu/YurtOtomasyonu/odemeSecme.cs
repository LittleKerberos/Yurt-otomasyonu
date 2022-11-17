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
    public partial class odemeSecme : Form
    {
        public odemeSecme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        private void odemeSecme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'borclarDB.tbl_borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_borclarTableAdapter.Fill(this.borclarDB.tbl_borclar);
            veriCekme();
        }
        public void veriCekme()
        {
            SqlCommand komut = new SqlCommand("select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad, tbl_borclar.ogr_kalanBorc, tbl_borclar.ogr_taksitSayisi from tbl_ogrenci inner join tbl_borclar on tbl_ogrenci.ogr_id = tbl_borclar.ogr_id", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Öğrenci NO";
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "BORÇ";
            dataGridView1.Columns[4].HeaderText = "TAKSİT SAYİSİ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            textBox4.Text=dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            lblBorc.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            lblTaksit.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            MessageBox.Show(textBox2.Text + " " + textBox3.Text + " Adlı öğrencinin Bilgileri Veritabanından Çekildi");
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }
        double borc,kalanBorc;
        private void button1_Click(object sender, EventArgs e)
        {
            int taksitSayisi;
            double odenecekMiktar;
            taksitSayisi = Convert.ToInt32(lblTaksit.Text);
            borc = Convert.ToInt32(lblBorc.Text);
            odenecekMiktar = borc / taksitSayisi;
            textBox1.Text = odenecekMiktar.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(5);
            if (progressBar1.Value==100)
            {
                timer1.Stop();
                MessageBox.Show("Ödeme bilgileri veritabanına kaydedilmiştir.") ;
                progressBar1.Visible = false;
                timer1.Enabled = false;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            odemeListele odeme = new odemeListele();
            odeme.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            kalanBorc = borc - Convert.ToInt32(textBox1.Text);
            int taksitSayisi;
            taksitSayisi = Convert.ToInt32(lblTaksit.Text);
            lblKalanBorc.Text = kalanBorc.ToString();

            
            if (lblBorc.Text=="0")
            {
                //MessageBox.Show("Ödemeniz bitti");
            }
            else
            { 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_taksit (ogr_ad,ogr_soyad,taksitZamani,odenenMiktar,ödemeTürü,kalanTaksit) values (@p1,@p2,@p5,@p6,@p7,@p8)", baglanti);
            //komut.Parameters.AddWithValue("@p4", comboBox1.Text);
            komut.Parameters.AddWithValue("@p1", textBox2.Text);
            komut.Parameters.AddWithValue("@p2", textBox3.Text);
            komut.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p6", textBox1.Text);
            komut.Parameters.AddWithValue("@p7", comboBox1.Text);
            komut.Parameters.AddWithValue("@p8", taksitSayisi-1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update tbl_borclar Set ogr_kalanBorc=@p5,ogr_taksitSayisi=@p6 where ogr_id=@p18", baglanti);
            komut2.Parameters.AddWithValue("@p5", lblKalanBorc.Text);
            komut2.Parameters.AddWithValue("@p6", taksitSayisi - 1);
            komut2.Parameters.AddWithValue("@p18", textBox4.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ödeme bilgisi Güncellendi");

            MessageBox.Show("Kalan Borc: " + lblKalanBorc.Text);
            MessageBox.Show("Ödeme bilgileri veritabanına kaydediliyor lütfen bekleyin...");
            progressBar1.Visible = true;
            timer1.Enabled = true;
            }
            if (lblKalanBorc.Text == "0") 
            {
                MessageBox.Show("Ödemeniz bitti");
            }
        }
    }
}
