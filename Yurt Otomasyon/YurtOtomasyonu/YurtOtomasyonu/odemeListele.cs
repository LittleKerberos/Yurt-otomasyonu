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
    public partial class odemeListele : Form
    {
        public odemeListele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "SELECT * FROM tbl_taksit";
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        private void odemeListele_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odemeListeleDB2.tbl_taksit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_taksitTableAdapter1.Fill(this.odemeListeleDB2.tbl_taksit);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Çanakkale Onsekiz Mart Üniversitesi ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString("DEVLET YURDU", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(350, 130));
            e.Graphics.DrawString("Taksit Zamanı :         " + lbltaksit.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(595, 20));
            e.Graphics.DrawString("Öğrenci Adı:  ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(15, 225));
            e.Graphics.DrawString(".................................................", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(130, 225));
            e.Graphics.DrawString("Ödenen Miktar: " + lblodenenmiktar.Text + " TL", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(15, 315));
            e.Graphics.DrawString("İMZA / KAŞE ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(650, 325));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            lbltaksit.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            lblodenenmiktar.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            MessageBox.Show("Veri tabanından bilgiler çekildi!!!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            odemeSecme odeme = new odemeSecme();
            odeme.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sql = "SELECT *FROM tbl_taksit WHERE taksitZamani='" + textBox1.Text + "'";
            }
            else
            {
                sql = "SELECT *FROM tbl_taksit";
            }
            Listele(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sql = "SELECT *FROM tbl_taksit";
            Listele(sql);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            lbltaksit.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            lblodenenmiktar.Text= dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            label2.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            MessageBox.Show(label2.Text + " Adlı öğrencinin Bilgileri Veritabanından Çekildi");
        }
    }
}
