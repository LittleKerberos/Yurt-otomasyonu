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
    public partial class GelirGider : Form
    {
        public GelirGider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        public void personelMaasTOplam()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" SELECT sum(maas) AS maaş FROM maas", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtPersonel.Text = dr[0].ToString();
            }
            baglanti.Close();
        }
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double e1, s, d, g, p, di,i,toplam;

            e1 = Convert.ToDouble(txtElektrik.Text);
            s = Convert.ToDouble(txtSu.Text);
            d = Convert.ToDouble(txtDogalgaz.Text);
            g = Convert.ToDouble(txtInternet.Text);
            p = Convert.ToDouble(txtGıda.Text);
            di= Convert.ToDouble(txtPersonel.Text);
            i = Convert.ToDouble(txtDiger.Text);
            toplam = e1 + s + d + g + p + di + i;
            textBox8.Text = toplam.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GelirGider_Load(object sender, EventArgs e)
        {
            txtPersonel.Enabled = false;
            personelMaasTOplam();
        }

        private void gelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gelirler gelirler = new Gelirler();
            gelirler.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_gider (tarih,elektrik,su,dogalgaz,internet,gida,personel,diger,toplamUcret) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", baglanti);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", txtElektrik.Text);
            komut.Parameters.AddWithValue("@p3", txtSu.Text);
            komut.Parameters.AddWithValue("@p4", txtDogalgaz.Text);
            komut.Parameters.AddWithValue("@p5", txtInternet.Text);
            komut.Parameters.AddWithValue("@p6", txtGıda.Text);
            komut.Parameters.AddWithValue("@p7", txtPersonel.Text);
            komut.Parameters.AddWithValue("@p8", txtDiger.Text);
            komut.Parameters.AddWithValue("@p9", textBox8.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Gider Bilgileri Kaydedildi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aylıkMaasGostergesi aylıkMaasGostergesi = new aylıkMaasGostergesi();
            aylıkMaasGostergesi.Show();
            
        }
    }
}
