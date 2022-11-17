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
    public partial class Istatistik : Form
    {
        public Istatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True"); //sql bağlantısı
        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }
        public void ogrenciSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_ogrenci", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblOgrenci.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void yatakSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_yataklar ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblYatakSayisi.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void bosYatakSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_yataklar where yatakDurum=0 ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblBosYatak.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void doluYatakSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_yataklar where yatakDurum=1 ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblDoluYatak.Text = dr[0].ToString();
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
        public void persoenlSayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_personel", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblPersonel.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void personelAylıkMaas()
        {
            SqlCommand komut = new SqlCommand("select SUM(ucret) from tbl_aylıkMaas ", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            baglanti.Open();
            lblAyPersonel.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        public void personelYıllıkMaas()
        {
            SqlCommand komut = new SqlCommand("select SUM(personel) from tbl_gider", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            baglanti.Open();
            lblYıllıkMaas.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        public void toplamGelir()
        {
            SqlCommand komut = new SqlCommand("select SUM(toplamGelir) from tbl_gelir", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            baglanti.Open();
            lblYıllıkMaas.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        public void aylıkGider()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Top(1) toplamUcret from tbl_gider order by giderId desc", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAylıkGider.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void yıllıkGider()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SUM(toplamUcret) from tbl_gider", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblYıllıkGider.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void aylıkGelir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Top(1) toplamGelir from tbl_gelir order by gelirId desc", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAylıkGelir.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        public void yıllıkGelir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select SUM(toplamGelir) from tbl_gelir", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblYIllıkGelir.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        private void Istatistik_Load(object sender, EventArgs e)
        {
            odaSayisi();
            yatakSayisi();
            ogrenciSayisi();
            persoenlSayisi();
            personelAylıkMaas();
            personelYıllıkMaas();
            bosYatakSayisi();
            doluYatakSayisi();
            aylıkGelir();
            yıllıkGelir();
            aylıkGider();
            yıllıkGider();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
