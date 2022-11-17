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
    public partial class OgrenciUpdate : Form
    {
        public OgrenciUpdate()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        private void OgrenciUpdate_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciDataBase.tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ogrenciTableAdapter.Fill(this.ogrenciDataBase.tbl_ogrenci);
            // TODO: Bu kod satırı 'yurtOtomasyonDatabaseDataSet7.tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            //this.tbl_ogrenciTableAdapter.Fill(this.yurtOtomasyonDatabaseDataSet7.tbl_ogrenci);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from iller", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbIL.Items.Add(dr[1]);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_ogrenci Set ogr_il=@p6,ogr_ilce=@p7,ogr_adres=@p8,ogr_telNo=@p9,ogr_eposta=@p10,ogr_evTelNo=@p11,ogr_veliMeslek=@p14,ogr_veliTelNo=@p15,ogr_veliIsNo=@p16,ogr_hakkinda=@p17 where ogr_id=@p18", baglanti);
            komut.Parameters.AddWithValue("@p6", cmbIL.Text);
            komut.Parameters.AddWithValue("@p7", cmbIlce.Text);
            komut.Parameters.AddWithValue("@p8", rtxtAdres.Text);
            komut.Parameters.AddWithValue("@p9", mtxtTelNo.Text);
            komut.Parameters.AddWithValue("@p10", txtEposta.Text);
            komut.Parameters.AddWithValue("@p11", mtxtEvTelNo.Text);
            komut.Parameters.AddWithValue("@p14", txtMeslek.Text);
            komut.Parameters.AddWithValue("@p15", mtxtVelİTelNo.Text);
            komut.Parameters.AddWithValue("@p16", mtxtVeliIsNo.Text);
            komut.Parameters.AddWithValue("@p17", rtxtHakkinda.Text);
            komut.Parameters.AddWithValue("@p18", txtİdName.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            txtİdName.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            cmbIL.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();
            cmbIlce.Text = dataGridView1.Rows[secilendeger].Cells[7].Value.ToString();
            rtxtAdres.Text = dataGridView1.Rows[secilendeger].Cells[8].Value.ToString();
            mtxtTelNo.Text = dataGridView1.Rows[secilendeger].Cells[9].Value.ToString();
            txtEposta.Text = dataGridView1.Rows[secilendeger].Cells[10].Value.ToString();
            mtxtEvTelNo.Text = dataGridView1.Rows[secilendeger].Cells[11].Value.ToString();
            txtMeslek.Text = dataGridView1.Rows[secilendeger].Cells[14].Value.ToString();
            mtxtVelİTelNo.Text = dataGridView1.Rows[secilendeger].Cells[17].Value.ToString();
            mtxtVeliIsNo.Text = dataGridView1.Rows[secilendeger].Cells[16].Value.ToString();
            rtxtHakkinda.Text = dataGridView1.Rows[secilendeger].Cells[18].Value.ToString();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
