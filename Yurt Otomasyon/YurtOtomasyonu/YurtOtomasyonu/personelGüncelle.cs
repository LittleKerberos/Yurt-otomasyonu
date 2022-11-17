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
    public partial class personelGüncelle : Form
    {
        public personelGüncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        private void personelGüncelle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDB.tbl_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personelTableAdapter.Fill(this.personelDB.tbl_personel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            mtxtTelNo.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            mtxtEvTelNo.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();
            mtxtYakınTelNo.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString();
            rtxtAdres.Text = dataGridView1.Rows[secilendeger].Cells[7].Value.ToString();
            txtEposta.Text = dataGridView1.Rows[secilendeger].Cells[8].Value.ToString();
            rtxtHakkinda.Text = dataGridView1.Rows[secilendeger].Cells[11].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbl_personel Set prsTelNo=@p6,prsEvTelNo=@p7,prsYakınTelNo=@p8,prsAdres=@p9,prsEposta=@p10,prsHakkinda=@p11 where id=@p18", baglanti);
            komut.Parameters.AddWithValue("@p6",  mtxtTelNo.Text);
            komut.Parameters.AddWithValue("@p7",  mtxtEvTelNo.Text);
            komut.Parameters.AddWithValue("@p8",  mtxtYakınTelNo.Text);
            komut.Parameters.AddWithValue("@p9",  rtxtAdres.Text);
            komut.Parameters.AddWithValue("@p10", txtEposta.Text);
            komut.Parameters.AddWithValue("@p11", rtxtHakkinda.Text);
            komut.Parameters.AddWithValue("@p18", txtID.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel bilgileri başarılı bir şekilde güncellenmiştir...");
        }
    }
}
