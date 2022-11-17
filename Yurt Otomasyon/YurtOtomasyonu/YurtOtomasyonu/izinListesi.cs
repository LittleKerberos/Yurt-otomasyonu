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
    public partial class izinListesi : Form
    {
        public izinListesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "select * from tbl_izinler where izinDurum=1";
        void Listele(string aranan)
        {
           SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        public void veriCek()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_izinler where izinDurum=1",baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void izinListesi_Load(object sender, EventArgs e)
        {
            veriCek();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            label2.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_izinler Set izinDurum=@p1 where id=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", 0);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("İzin Pasif Edildi");

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into tbl_izinGelis (ad,soyad,gelisTarihi) values (@p1,@p2,@p3)", baglanti);
            komut2.Parameters.AddWithValue("@p1", label2.Text);
            komut2.Parameters.AddWithValue("@p2", label3.Text);
            komut2.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            SqlDataReader dr = komut2.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();

            //UPDATE
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Update tbl_ogrenci Set ogr_izinDurum=@p1 where ogr_ad=@p18", baglanti);
            komut3.Parameters.AddWithValue("@p1", 0);
            komut3.Parameters.AddWithValue("@p18", label2.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(radioButton1.Checked)
            {
                sql = "select * from tbl_izinler where izinDurum=1 and ogr_odaNo='" + textBox1.Text + "'";
            }
            else
            {
                sql = "select * from tbl_izinler where izinDurum=1";
            }
            Listele(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "select * from tbl_izinler where izinDurum=1";
            Listele(sql);
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
