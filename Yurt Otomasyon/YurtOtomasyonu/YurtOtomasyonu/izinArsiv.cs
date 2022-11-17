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
    public partial class izinArsiv : Form
    {
        public izinArsiv()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "select * from tbl_izinler";
        void Listele(string aranan)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "ODA NO";
            dataGridView1.Columns[4].HeaderText = "YATAK NO";
            dataGridView1.Columns[5].HeaderText = "GİDİŞ SEBEP";
            dataGridView1.Columns[6].HeaderText = "ADRES";
            dataGridView1.Columns[7].HeaderText = "GİDİŞ TARİHİ";
            dataGridView1.Columns[8].HeaderText = "DÖNÜŞ TARİHİ";
            dataGridView1.Columns[9].Visible = false;
        }
        private void izinArsiv_Load(object sender, EventArgs e)
        {
            sql = "select * from tbl_izinler";
            Listele(sql);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Arsiv arsiv = new Arsiv();
            arsiv.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sql = "select * from tbl_izinler where ogr_ad='" + textBox1.Text + "'";
            }          
            else
            {
                sql = "select * from tbl_izinler";
            }
            Listele(sql);
        }
    }
}
