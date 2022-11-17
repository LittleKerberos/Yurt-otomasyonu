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
    public partial class personelMaasDepartmanEkle : Form
    {
        public personelMaasDepartmanEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void personelMaasDepartmanEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDB.tbl_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personelTableAdapter1.Fill(this.personelDB.tbl_personel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text=  dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            txtTc.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_personelUcret (prs_tc,prs_maas,prs_departman) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtTc.Text);
            komut.Parameters.AddWithValue("@p2", txtMaas.Text);
            komut.Parameters.AddWithValue("@p3", cmbDepartman.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Bilgiler Yüklendi...");


            double maas, sgk, prim, toplam;
            maas = Convert.ToDouble(txtMaas.Text);
            sgk = maas * 15.5 / 100;
            prim = maas * 2 / 100;
            toplam = maas + sgk + prim;
            label4.Text = toplam.ToString();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into maas (maas) values (@p2)", baglanti);
            komut2.Parameters.AddWithValue("@p2", label4.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {

            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_personelUcret Set prs_tc=@p6,prs_maas=@p7,prs_departman=@p8 where İD=@p18", baglanti);
            komut.Parameters.AddWithValue("@p6", txtTc.Text);
            komut.Parameters.AddWithValue("@p7", txtMaas.Text);
            komut.Parameters.AddWithValue("@p8", cmbDepartman.Text);
            komut.Parameters.AddWithValue("@p18", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Güncellendi");


            double maas2, sgk2, prim2, toplam2;
            maas2 = Convert.ToDouble(txtMaas.Text);
            sgk2 = maas2 * 15.5 / 100;
            prim2 = maas2 * 2 / 100;
            toplam2 = maas2 + sgk2 + prim2;
            label4.Text = toplam2.ToString();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update maas Set maas=@p1 where İD=@p18", baglanti);
            komut2.Parameters.AddWithValue("@p1", toplam2);
            komut2.Parameters.AddWithValue("@p18", txtID.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Güncelleme İşlemi yaparken tüm bilgileri eksiksiz olarak giriniz.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PersonelListele personelListele = new PersonelListele();
            personelListele.Show();
        }

        private void txtMaas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            personel personel = new personel();
            personel.Show();
            this.Hide();
        }
    }
}
