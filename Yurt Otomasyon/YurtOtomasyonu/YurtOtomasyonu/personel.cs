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
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        private void öğrenciBilgiGirişiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void personelArsivEkle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_personelArsiv (prsAd,prsSoyad,prsTc,prsDogumTarihi,prsKanGrubu,prsTelNo,prsEvTelNo,prsYakınTelNo,prsAdres,prsEposta,prsHakkinda) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtxtTc.Text);
            komut.Parameters.AddWithValue("@p4", mtxtDogumTarihi.Text);
            komut.Parameters.AddWithValue("@p5", cmbKan.Text);
            komut.Parameters.AddWithValue("@p6", mtxtTelNo.Text);
            komut.Parameters.AddWithValue("@p7", mtxtEvTelNo.Text);
            komut.Parameters.AddWithValue("@p8", mtxtYakınTelNo.Text);
            komut.Parameters.AddWithValue("@p9", rtxtAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtEposta.Text);
            komut.Parameters.AddWithValue("@p11", rtxtHakkinda.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();
        }
        private void personel_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDB.tbl_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personelTableAdapter1.Fill(this.personelDB.tbl_personel);

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
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_personel (prsAd,prsSoyad,prsTc,prsDogumTarihi,prsKanGrubu,prsTelNo,prsEvTelNo,prsYakınTelNo,prsAdres,prsEposta,prsHakkinda) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtName.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mtxtTc.Text);
            komut.Parameters.AddWithValue("@p4", mtxtDogumTarihi.Text);
            komut.Parameters.AddWithValue("@p5", cmbKan.Text);
            komut.Parameters.AddWithValue("@p6", mtxtTelNo.Text);
            komut.Parameters.AddWithValue("@p7", mtxtEvTelNo.Text);
            komut.Parameters.AddWithValue("@p8", mtxtYakınTelNo.Text);
            komut.Parameters.AddWithValue("@p9", rtxtAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtEposta.Text);
            komut.Parameters.AddWithValue("@p11", rtxtHakkinda.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");

            personelArsivEkle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            personelMaasDepartmanEkle personelMaasDepartmanEkle = new personelMaasDepartmanEkle();
            personelMaasDepartmanEkle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelSil personelSil = new PersonelSil();
            personelSil.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personelGüncelle personelGüncelle = new personelGüncelle();
            personelGüncelle.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personelListele2 personelListele2 = new personelListele2();
            personelListele2.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}