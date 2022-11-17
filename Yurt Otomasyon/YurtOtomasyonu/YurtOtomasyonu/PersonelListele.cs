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
    public partial class PersonelListele : Form
    {
        public PersonelListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "SELECT *FROM tbl_personelUcret;";
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        private void PersonelListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelUcretDB.tbl_personelUcret' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personelUcretTableAdapter.Fill(this.personelUcretDB.tbl_personelUcret);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                sql = "SELECT *FROM tbl_personelUcret WHERE prs_tc='" + textBox1.Text + "'";
            }
            else if (radioButton4.Checked)
            {
                sql = "SELECT *FROM tbl_personelUcret WHERE prs_departman='" + comboBox1.Text + "'";
            }
            else
            {
                sql = "SELECT *FROM tbl_personelUcret";
            }
            Listele(sql);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sql = "SELECT *FROM tbl_personelUcret";
            Listele(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
