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
    public partial class Gelirler : Form
    {
        public Gelirler()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        public void toplamPara()
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Gelirler_Load(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
       }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Select * from tbl_taksit where taksitZamani between '"+maskedTextBox1.Text+ "' and '"+maskedTextBox2.Text+"'", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();
        }

        private void gelirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GelirGider gelirGider = new GelirGider();
            gelirGider.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select SUM(odenenMiktar) from tbl_taksit where taksitZamani between '" + maskedTextBox1.Text + "' and '" + maskedTextBox2.Text + "'",con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            con.Open();
            lblToplam.Text = komut.ExecuteScalar().ToString();
            con.Close();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_gelir (tarih,toplamGelir) values (@p1,@p2)", con);
            komut.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p2", lblToplam.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            con.Close();
            MessageBox.Show("Gelir Bilgileri Kaydedildi");
        }

        private void lblToplam_Click(object sender, EventArgs e)
        {

        }
    }
}
