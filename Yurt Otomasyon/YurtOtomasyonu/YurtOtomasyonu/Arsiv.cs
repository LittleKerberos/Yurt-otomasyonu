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
    public partial class Arsiv : Form
    {
        public Arsiv()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_ogrenciArsiv",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "DOĞUM TARİHİ";
            dataGridView1.Columns[5].HeaderText = "KAN GRUBU";
            dataGridView1.Columns[6].HeaderText = "İL";
            dataGridView1.Columns[7].HeaderText = "İLÇE";
            dataGridView1.Columns[8].HeaderText = "ADRES";
            dataGridView1.Columns[9].HeaderText = "TEL NO";
            dataGridView1.Columns[10].HeaderText = "EPOSTA";
            dataGridView1.Columns[11].HeaderText = "EV TEL NO";
            dataGridView1.Columns[12].HeaderText = "YAKINLIK DURUMU";
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
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_personelArsiv", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "TEL NO";
            dataGridView1.Columns[5].HeaderText = "EV TEL NO";
            dataGridView1.Columns[6].HeaderText = "YAKIN TEL NO";
            dataGridView1.Columns[7].HeaderText = "ADRES";
            dataGridView1.Columns[8].HeaderText = "EPOSTA";
            dataGridView1.Columns[9].HeaderText = "KAN GRUBU";
            dataGridView1.Columns[10].HeaderText = "DOĞUM TARİHİ";
            dataGridView1.Columns[11].HeaderText = "HAKKINDA";
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_yurtBilgileriArsiv", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "KAT";
            dataGridView1.Columns[2].HeaderText = "ODA NO";
            dataGridView1.Columns[3].HeaderText = "YATAK NO";
            dataGridView1.Columns[4].HeaderText = "ÜCRET";
            dataGridView1.Columns[5].HeaderText = "BAŞLANGIC";
            dataGridView1.Columns[6].HeaderText = "BİTİŞ";
            baglanti.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //öğrenci tablosundan silindi
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_ogrenci Set ogr_durum=@p1 where ogr_id=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", 1);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Aktifleştirildi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            MessageBox.Show("Öğrenci bilgileri çekildi");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            izinArsiv izin = new izinArsiv();
            izin.Show();
            this.Hide();
        }

        private void Arsiv_Load(object sender, EventArgs e)
        {

        }
    }
}
