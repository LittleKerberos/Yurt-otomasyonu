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
    public partial class OgrenciEkle : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");

        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            rtxtHakkinda.MaxLength = 255;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from iller", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIL.Items.Add(dr[1]);
            }
            baglanti.Close();      
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }

        private void cmbYatak_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbKat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void yurtBilgileriGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YurtBilgileriEkle yurtBilgileriEkle = new YurtBilgileriEkle();
            yurtBilgileriEkle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_ogrenci (ogr_ad,ogr_soyad,ogr_tc,ogr_dogumTarihi,ogr_kanGrubu,ogr_il,ogr_ilce,ogr_adres,ogr_telNo,ogr_eposta,ogr_evTelNo,ogr_veliAd,ogr_veliSoyad,ogr_veliMeslek,ogr_veliTelNo,ogr_veliIsNo,ogr_hakkinda,ogr_yakınlıkDurum,ogr_yakınTelNo,ogr_veliYakınlıkDurumu,ogr_yakınAd,ogr_yakınSoyad,ogr_durum) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22,@p23)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtxtTc.Text);
            komut.Parameters.AddWithValue("@p4", mtxtDogumTarihi.Text);
            komut.Parameters.AddWithValue("@p5", cmbKan.Text);
            komut.Parameters.AddWithValue("@p6", cmbIL.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", rtxtAdres.Text);
            komut.Parameters.AddWithValue("@p9",  mtxtTelNo.Text);
            komut.Parameters.AddWithValue("@p10", txtEposta.Text);
            komut.Parameters.AddWithValue("@p11", mtxtEvTelNo.Text);
            komut.Parameters.AddWithValue("@p12", txtVeliAd.Text);
            komut.Parameters.AddWithValue("@p13", txtVeliSoyad.Text);
            komut.Parameters.AddWithValue("@p14", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p15", mtxtVelİTelNo.Text);
            komut.Parameters.AddWithValue("@p16", mtxtVeliIsNo.Text);
            komut.Parameters.AddWithValue("@p17", rtxtHakkinda.Text);
            komut.Parameters.AddWithValue("@p18", cmbYakınlıkDurum.Text);
            komut.Parameters.AddWithValue("@p19", mskYakınTelNo.Text);
            komut.Parameters.AddWithValue("@p20", cmbVelİYakınlıkDurumuBox.Text);
            komut.Parameters.AddWithValue("@p21", txtYakınAd.Text);
            komut.Parameters.AddWithValue("@p22", txtYakınSoyad.Text);
            komut.Parameters.AddWithValue("@p23", 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
               
            }
            baglanti.Close(); 
            MessageBox.Show("Öğrenci Eklendi");

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tbl_ogrenciArsiv (ogr_ad,ogr_soyad,ogr_tc,ogr_dogumTarihi,ogr_kanGrubu,ogr_il,ogr_ilce,ogr_adres,ogr_telNo,ogr_eposta,ogr_evTelNo,ogr_veliAd,ogr_veliSoyad,ogr_veliMeslek,ogr_veliTelNo,ogr_veliIsNo,ogr_hakkinda,ogr_yakınlıkDurum,ogr_yakınTelNo,ogr_veliYakınlıkDurumu,ogr_yakınAd,ogr_yakınSoyad) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17,@p18,@p19,@p20,@p21,@p22)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtName.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", mtxtTc.Text);
            komut2.Parameters.AddWithValue("@p4", mtxtDogumTarihi.Text);
            komut2.Parameters.AddWithValue("@p5", cmbKan.Text);
            komut2.Parameters.AddWithValue("@p6", cmbIL.Text);
            komut2.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut2.Parameters.AddWithValue("@p8", rtxtAdres.Text);
            komut2.Parameters.AddWithValue("@p9", mtxtTelNo.Text);
            komut2.Parameters.AddWithValue("@p10", txtEposta.Text);
            komut2.Parameters.AddWithValue("@p11", mtxtEvTelNo.Text);
            komut2.Parameters.AddWithValue("@p12", txtVeliAd.Text);
            komut2.Parameters.AddWithValue("@p13", txtVeliSoyad.Text);
            komut2.Parameters.AddWithValue("@p14", txtMeslek.Text);
            komut2.Parameters.AddWithValue("@p15", mtxtVelİTelNo.Text);
            komut2.Parameters.AddWithValue("@p16", mtxtVeliIsNo.Text);
            komut2.Parameters.AddWithValue("@p17", rtxtHakkinda.Text);
            komut2.Parameters.AddWithValue("@p18", cmbYakınlıkDurum.Text);
            komut2.Parameters.AddWithValue("@p19", mskYakınTelNo.Text);
            komut2.Parameters.AddWithValue("@p20", cmbVelİYakınlıkDurumuBox.Text);
            komut2.Parameters.AddWithValue("@p21", txtYakınAd.Text);
            komut2.Parameters.AddWithValue("@p22", txtYakınSoyad.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {

            }
            baglanti.Close();

            //öğrenci id'yi label çekme
            //baglanti.Open();
            //SqlCommand kaydet = new SqlCommand("select ogr_id from tbl_ogrenci",baglanti);
            //SqlDataReader oku = kaydet.ExecuteReader();
            //while (oku.Read())
            //{
            //    label18.Text = oku[0].ToString();
            //}
            //baglanti.Close();


            ////Öğrenci Borç Alanı Oluşturma
            //baglanti.Open();
            //SqlCommand komutKaydet = new SqlCommand("insert into tbl_borclar  (ogr_id,ogr_ad,ogr_soyad) values (@b1,@b2,@b3)",baglanti);
            //komutKaydet.Parameters.AddWithValue("@b1",label18.Text);
            //komutKaydet.Parameters.AddWithValue("@b2",txtName.Text);
            //komutKaydet.Parameters.AddWithValue("@b3",txtSoyad.Text);
            //komutKaydet.ExecuteNonQuery();
            //baglanti.Close();




            //Yurt Bilgileri Tablosuna Eklenecek
            //baglanti.Open();
            //SqlCommand komut2 = new SqlCommand("insert into tbl_yurtBilgileri (ogr_ad,ogr_soyad,ogr_tc) values (@p1,@p2,@p3)",baglanti);
            //komut2.Parameters.AddWithValue("@p1", txtName.Text);
            //komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            //komut2.Parameters.AddWithValue("@p3", mtxtTc.Text);
            //SqlDataReader dr2 = komut2.ExecuteReader();
            //while (dr2.Read())
            //{

            //}
            //baglanti.Close();
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            int u = rtxtHakkinda.TextLength;
            label30.Text = "Yazılan Karakter Sayısı: " + rtxtHakkinda.TextLength.ToString();
            if (u == 255)
            {
                MessageBox.Show("Maksimum sınıra ulaştınız!");
            }
        }

        private void cmbIL_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIlce.Items.Clear();
            cmbIlce.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From ilceler Where il_no=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", cmbIL.SelectedIndex + 1);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIlce.Items.Add(dr[1]);
            }
            baglanti.Close();
        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cmbKan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbVelİYakınlıkDurumuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVelİYakınlıkDurumuBox.Text == "Diğer")
            {
                txtDiger.Enabled = true;
                label27.Enabled = true;
            }
            else
            {
                txtDiger.Enabled = false;
                label27.Enabled = false;
            }
        }
    }
}
