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
    public partial class personelListele2 : Form
    {
        public personelListele2()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "SELECT *FROM tbl_personel;";
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void personelListele2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDB.tbl_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personelTableAdapter.Fill(this.personelDB.tbl_personel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboBox1.Text = "";
                sql = "SELECT *FROM tbl_personel WHERE prsTc='" + textBox1.Text + "'";
            }
            else if (radioButton4.Checked)
            {
                comboBox1.Text = "";
                sql = "SELECT *FROM tbl_personel WHERE prsAd='" + textBox1.Text + "'";
            }
            else if (radioButton1.Checked)
            {
                textBox1.Text = " ";
                sql = "SELECT *FROM tbl_personel WHERE prsKanGrubu='" + comboBox1.Text + "'";
            }
            else
            {
                sql = "SELECT *FROM tbl_personel";
            }
            Listele(sql);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = "SELECT *FROM tbl_personel";
            Listele(sql);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personel per = new personel();
            per.Show();
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
