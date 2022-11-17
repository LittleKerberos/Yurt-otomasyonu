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
    public partial class YoneticiForm : Form
    {
        public YoneticiForm()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        int i = 0;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True"); //sql bağlantısı
        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void yatakSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_yataklar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblYatakSayisi.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        public void personelSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_personel ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblPersonel.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void odaSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_odalar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblOdaSayisi.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        //public void personelSayisi()
        //{
        //    baglanti.Open();
        //    da = new SqlDataAdapter("select * from tbl_personel", baglanti);
        //    ds = new DataSet();
        //    da.Fill(ds, "id");
        //    baglanti.Close();
        //    i = ds.Tables[0].Rows.Count - 1;
        //    label7.Text = ds.Tables[0].Rows[i]["id"].ToString();
        //}
        public void ogrenciSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_ogrenci where ogr_durum=1", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblOgrenci.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void gider()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Top(1) toplamUcret from tbl_gider order by giderId desc", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblGider.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void gelir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Top(1) toplamGelir from tbl_gelir order by gelirId desc", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblGelir.Text = dr[0].ToString();
            }
            baglanti.Close();       
        }
        public void kasa()
        {
            int kasa;
            kasa = Convert.ToInt32(lblGelir.Text) - Convert.ToInt32(lblGider.Text);
            lblkasa.Text = kasa.ToString();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        public void veriCekme()
        {
                SqlCommand komut = new SqlCommand("select * from tbl_ogrenci where ogr_durum=1", baglanti);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "AD";
                dataGridView1.Columns[2].HeaderText = "SOYAD";
                dataGridView1.Columns[3].HeaderText = "TC";
                dataGridView1.Columns[4].HeaderText = "DOĞUM TARİHİ";
                dataGridView1.Columns[5].HeaderText = "KAN GRUBU";
                dataGridView1.Columns[6].HeaderText = "İL";
                dataGridView1.Columns[7].HeaderText = "İLÇE";
                dataGridView1.Columns[8].HeaderText = "ADRES";
                dataGridView1.Columns[9].HeaderText = "TEL NO";
                dataGridView1.Columns[10].HeaderText = "E-POSTA";
                dataGridView1.Columns[11].HeaderText = "EV TEL NO";
                dataGridView1.Columns[12].HeaderText = "VELİ YAKINLIK";
                dataGridView1.Columns[13].HeaderText = "VELİ AD";
                dataGridView1.Columns[14].HeaderText = "VELİ SOYAD";
                dataGridView1.Columns[15].HeaderText = "VELİ MESLEK";
                dataGridView1.Columns[16].HeaderText = "VELİ TEL NO";
                dataGridView1.Columns[17].HeaderText = "VELİ İŞ NO";
                dataGridView1.Columns[18].HeaderText = "HAKKINDA";
                dataGridView1.Columns[19].HeaderText = "YAKINLIK DURUM";
                dataGridView1.Columns[20].HeaderText = "YAKIN TEL NO";
                dataGridView1.Columns[21].HeaderText = "YAKIN AD";
                dataGridView1.Columns[22].HeaderText = "YAKIN SOYAD";
                 dataGridView1.Columns[23].Visible = false;

        }
        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            //// TODO: Bu kod satırı 'ogrDB2.tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_ogrenciTableAdapter1.Fill(this.ogrDB2.tbl_ogrenci);
            // TODO: Bu kod satırı 'öğrenciDB.tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            string name = Form1.name;
            DateTime bugun = Form1.bugun;
            girinKişiToolStripMenuItem.Text = "Giren Kişi: " + name;        
            if (girinKişiToolStripMenuItem.Text == "Giren Kişi: personel")
            {
                gelirGider.Enabled = false;
                gelirGiderBox.Visible = false;
            }           
            girişZamanıToolStripMenuItem.Text = "Giriş Zamanı : " + Convert.ToString(bugun);

            yatakSayisi();
            odaSayisi();
            ogrenciSayisi();
            veriCekme();
            gider();
            gelir();
            kasa();
            personelSayisi();

        }
       private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();
            this.Hide();
        }

        private void kullanıcıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
        private void yurtBİlgileriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YurtBilgileriEkle yurtBilgileriEkle = new YurtBilgileriEkle();
            yurtBilgileriEkle.Show();
            this.Hide();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
        }

        private void öğrenciYurtBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YurtBilgileriEkle yurtBilgileriEkle = new YurtBilgileriEkle();
            yurtBilgileriEkle.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OgrenciUpdate ogrenciUpdate = new OgrenciUpdate();
            ogrenciUpdate.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ogrenciListele ogrenciListele = new ogrenciListele();
            ogrenciListele.Show();
            this.Hide();
        }
        private void button15_Click(object sender, EventArgs e)
        {
            odaForm odaForm = new odaForm();
            odaForm.Show();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            odemeSecme odemeSecme = new odemeSecme();
            odemeSecme.Show();
            this.Hide();
        }

        private void gelirGider_Click(object sender, EventArgs e)
        {
            GelirGider gelirGider = new GelirGider();
            gelirGider.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arsiv arsiv = new Arsiv();
            arsiv.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Istatistik ıstatistik = new Istatistik();
            ıstatistik.Show();
            this.Hide();
        }

        private void izinlerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
     
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Izınler izinler = new Izınler();
            izinler.Show();
            this.Hide();

        }

        private void izinlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personelListele2 per = new personelListele2();
            per.Show();
            this.Hide();            
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void yoklamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yoklama yoklama = new Yoklama();
            yoklama.Show();
            this.Hide();
        }
    }
}
