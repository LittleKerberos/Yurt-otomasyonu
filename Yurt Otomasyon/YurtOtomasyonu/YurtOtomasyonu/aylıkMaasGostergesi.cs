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
    public partial class aylıkMaasGostergesi : Form
    {
        public aylıkMaasGostergesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        public void vericek()
        {
            SqlCommand komut = new SqlCommand("select tbl_aylıkMaas.id,tbl_personel.prsAd,tbl_personel.prsSoyad,tbl_aylıkMaas.ucret from tbl_personel inner join tbl_aylıkMaas on tbl_personel.id = tbl_aylıkMaas.id", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "ÜCRET";
        }
        private void aylıkMaasGostergesi_Load(object sender, EventArgs e)
        {
            vericek();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            textBox3.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_aylıkMaas Set ucret =@p6 where İD=@p18", baglanti);
            komut.Parameters.AddWithValue("@p6", textBox2.Text);
            komut.Parameters.AddWithValue("@p18", textBox3.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Aylık Maaş Güncellendi");

            double maas2, sgk2, prim2, toplam2;
            maas2 = Convert.ToDouble(textBox2.Text);
            sgk2 = maas2 * 15.5 / 100;
            prim2 = maas2 * 2 / 100;
            toplam2 = maas2 + sgk2 + prim2;

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update maas Set maas=@p1 where İD=@p18", baglanti);
            komut2.Parameters.AddWithValue("@p1", toplam2);
            komut2.Parameters.AddWithValue("@p18", textBox3.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GelirGider gelirGider = new GelirGider();
            gelirGider.Show();
            this.Hide();
        }
    }
}
