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
    public partial class odaForm : Form
    {
        public odaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "SELECT * FROM tbl_odalar";
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }        
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_odalar (odaIsım,odaKapasite,odaKisi) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", 0);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Oda Eklendi");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_odalar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblsonodatut.Text = dr[0].ToString();
            }
            baglanti.Close();
        }

        private void odaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odalarDB.tbl_odalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_odalarTableAdapter.Fill(this.odalarDB.tbl_odalar);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM tbl_odalar", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblsonodatut.Text = dr[0].ToString();
            }
            baglanti.Close();
            label10.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_yataklar (yatakIsım,YatakDurum,YatakOdaId) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox4.Text);
            komut.Parameters.AddWithValue("@p2", 0);
            komut.Parameters.AddWithValue("@p3", textBox6.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Yatak Eklendi");
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sql = "SELECT *FROM tbl_odalar WHERE OdaID='" + txtAra.Text + "'";
            }
            else if (radioButton2.Checked)
            {
                sql = "SELECT *FROM tbl_odalar WHERE odaIsım='" + txtAra.Text + "'";
            }
            else if (radioButton3.Checked)
            {
                sql = "SELECT *FROM tbl_odalar WHERE OdaID='" + lblsonodatut.Text+ "'";
            }
            else
            {
                sql = "SELECT *FROM tbl_odalar";
            }
            Listele(sql);
        }

        private void btnTumKayıtlar_Click(object sender, EventArgs e)
        {
            sql = "SELECT *FROM tbl_odalar";
            Listele(sql);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            textBox6.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();    
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
