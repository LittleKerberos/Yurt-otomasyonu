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
    public partial class PersonelSil : Form
    {
        public PersonelSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        private void PersonelSil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'personelDB.tbl_personel' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_personelTableAdapter.Fill(this.personelDB.tbl_personel);
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Personel tablosundan silindi
            baglanti.Open();
            SqlCommand delete = new SqlCommand("Delete from tbl_personel where prsTc=@k1", baglanti);
            delete.Parameters.AddWithValue("@k1", txtTc.Text);
            delete.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Silindi");
            //PersonelcUcret tablosundan silindi
            baglanti.Open();
            SqlCommand delete2 = new SqlCommand("Delete from tbl_personelUcret where prs_tc=@k1", baglanti);
            delete2.Parameters.AddWithValue("@k1", txtTc.Text);
            delete2.ExecuteNonQuery();
            baglanti.Close();
            //personel maaş bilgileri
            baglanti.Open();
            SqlCommand delete3= new SqlCommand("Delete from maas where id=@k1", baglanti);
            delete3.Parameters.AddWithValue("@k1", textBox1.Text);
            delete3.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            txtTc.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            textBox1.Text= dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
        }
    }
}
