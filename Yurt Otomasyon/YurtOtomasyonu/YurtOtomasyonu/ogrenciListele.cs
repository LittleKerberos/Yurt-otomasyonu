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
    public partial class ogrenciListele : Form
    {
        public ogrenciListele()
        {
            InitializeComponent();
        }

        private void ogrenciListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciDataBase.tbl_ogrenci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_ogrenciTableAdapter.Fill(this.ogrenciDataBase.tbl_ogrenci);
         
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "select * from tbl_ogrenci where ogr_durum = 1;";
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbl_ogrenciTableAdapter.Fill(this.ogrenciDataBase.tbl_ogrenci);
        }

        private void pencereyiKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             if (radioButton1.Checked)
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 and ogr_ad='" + textBox1.Text + "'";
            }
            else if (radioButton2.Checked)
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 and ogr_tc='" + textBox1.Text + "'";
            }
            else if (radioButton3.Checked)
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 and ogr_kanGrubu='" + textBox1.Text + "'";
            }
            else if (radioButton4.Checked)
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 and ogr_il='" + textBox1.Text + "'";
            }
            else
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 ";
            }
            Listele(sql);if (radioButton1.Checked)
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 and ogr_ad='" + textBox1.Text + "'";
            }
            else if (radioButton2.Checked)
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 and ogr_tc='" + textBox1.Text + "'";
            }
            else if (radioButton3.Checked)
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 and ogr_kanGrubu='" + textBox1.Text + "'";
            }
            else if (radioButton4.Checked)
            {
                sql = "select * from tbl_ogrenci where ogr_durum = 1 and ogr_il='" + textBox1.Text + "'";
            }
            else
            {
                sql = "select * from tbl_ogrenci where ogr_durum ";
            }
            Listele(sql);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "select * from tbl_ogrenci where ogr_durum = 1 ";
            Listele(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
