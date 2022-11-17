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
    public partial class YoklamaListesi : Form
    {
        public YoklamaListesi()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.d";
            day = dateTimePicker1.Text;
            textBox1.Text = day.ToString();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "select * from tbl_yoklama";
        void Listele(string aranan)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[6].Value) == true)
                {
                    renk.BackColor = Color.GreenYellow;
                    renk.ForeColor = Color.Black;
                }
                else
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
            }
        String day;
        private void YoklamaListesi_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yoklamaDB.tbl_yoklama' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_yoklamaTableAdapter.Fill(this.yoklamaDB.tbl_yoklama);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy.MM.d";
            day = dateTimePicker1.Text;
            textBox1.Text = day.ToString();

            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[6].Value)==true)
                {
                    renk.BackColor = Color.GreenYellow;
                    renk.ForeColor = Color.Black;
                }
                else
                {
                    renk.BackColor = Color.Red;
                    renk.ForeColor = Color.White;
                }
                dataGridView1.Rows[i].DefaultCellStyle = renk;
            }
            menuStrip2.BackColor = Color.White;
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                sql = "select * from tbl_yoklama where tarih='" + textBox1.Text + "'";
            }
            else if (radioButton2.Checked)
            {
                sql = "select * from tbl_yoklama where ad='" + textBox1.Text + "'";
            }
            else if(radioButton1.Checked)
            {
                sql = "select * from tbl_yoklama where odaNo='" + textBox1.Text + "'";
            }
            else
            {
                sql = "select * from tbl_yoklama ";
            }
            Listele(sql);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sql = "select * from tbl_yoklama ";
            Listele(sql);
        }
    }
}
