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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        int j = 0;
        SqlDataAdapter da;
        DataTable dt;
        string sql = "SELECT *FROM tbl_ogrenci";
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        public void vericekme()
        {
            SqlCommand komut = new SqlCommand("select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_ogrenci.ogr_tc,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_ogrenci.ogr_durum=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "TC";
            dataGridView1.Columns[4].HeaderText = "ODA NO";
            dataGridView1.Columns[5].HeaderText = "YATAK NO";
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrDB2.tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            Ekle();
            vericekme();
        }
        void Ekle()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_ogrenci", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[3]);
            }
            baglanti.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //öğrenci tablosundan silindi
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_ogrenci Set ogr_durum=@p1 where ogr_id=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", 0);
            komut.Parameters.AddWithValue("@p2", comboBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Silindi");
            //yurt tablosundan silindi
            baglanti.Open();
            SqlCommand delete2= new SqlCommand("Update tbl_yurtBilgileri Set ogr_durum=@p1 where id=@p2", baglanti);
            delete2.Parameters.AddWithValue("@p1", 0);
            delete2.Parameters.AddWithValue("@p2", comboBox3.Text);
            delete2.ExecuteNonQuery();
            baglanti.Close();
            //yatak
            baglanti.Open();
            SqlCommand yatakUpdae = new SqlCommand("update tbl_yataklar set YatakDurum=0 where YatakID=@p1", baglanti);
            yatakUpdae.Parameters.AddWithValue("@p1", comboBox3.Text);
            yatakUpdae.ExecuteNonQuery();
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            comboBox3.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sql = "SELECT *FROM tbl_ogrenci WHERE ogr_ad='" + textBox1.Text + "'";
            }
            else
            {
                sql = "SELECT * FROM tbl_ogrenci";
            }
            Listele(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "SELECT *FROM tbl_ogrenci where ogr_durum=1";
            Listele(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;       
            comboBox3.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            MessageBox.Show("Öğrenci bilgileri çekildi");
        }
    }
}
