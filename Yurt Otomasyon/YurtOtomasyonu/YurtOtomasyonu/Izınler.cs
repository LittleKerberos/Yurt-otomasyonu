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
    public partial class Izınler : Form
    {
        public Izınler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True");
        SqlDataAdapter da;
        DataTable dt;
        string sql = "select tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_ogrenci.ogr_durum=1";
        void Listele(string aranan)
        {
            da = new SqlDataAdapter(sql, baglanti);
            dt = new DataTable();
            baglanti.Open();
            da.Fill(dt);
            baglanti.Close();
            dataGridView1.DataSource = dt;
        }
        public void veriCekme()
        {
            SqlCommand komut = new SqlCommand("select tbl_ogrenci.ogr_id,tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_ogrenci.ogr_durum=1", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "AD";
            dataGridView1.Columns[2].HeaderText = "SOYAD";
            dataGridView1.Columns[3].HeaderText = "ODA NO";
            dataGridView1.Columns[4].HeaderText = "YATAK NO";
        }
        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YoneticiForm yoneticiForm = new YoneticiForm();
            yoneticiForm.Show();
            this.Hide();

        }

        private void çıkışYapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void izinDenetim()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from tbl_izinler where day(donusTarih)<'"+Convert.ToInt32(label7.Text) + "' and izinDurum=1", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show(dr[1] + "  " + dr[2] + " Adlı öğrencinin izni geçmiştir " + " Oda No: " + dr[3] + " Yatak No " + dr[4]);
            }
            baglanti.Close();
        }
        string thisDay;
        private void Izınler_Load(object sender, EventArgs e)
        {
            veriCekme();
            dataGridView1.ForeColor = Color.Black;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "d";
            thisDay = dateTimePicker1.Text;
            label7.Text = thisDay.ToString();
            label7.Visible = false;

            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy.MM.d";
            day = dateTimePicker3.Text;
            lblgidis.Text = day.ToString();
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy.MM.d";
            day = dateTimePicker3.Text;
            lblgidis.Text = day.ToString();
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy.MM.d";
            day2 = dateTimePicker4.Text;
            lbldonus.Text = day2.ToString();
            izinDenetim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sql = "select tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id WHERE tbl_ogrenci.ogr_durum=1 and ogr_odaNo='" + textBox1.Text + "'";
                veriCekme();
            }
            else
            {
                sql = "SELECT * FROM tbl_yurtBilgileri";
            }
            Listele(sql);
        }

        private void button2_Click(object sender, EventArgs e)
        {
             sql = "select tbl_ogrenci.ogr_ad,tbl_ogrenci.ogr_soyad,tbl_yurtBilgileri.ogr_odaNo,tbl_yurtBilgileri.ogr_yatakNo from tbl_ogrenci inner join tbl_yurtBilgileri on tbl_ogrenci.ogr_id = tbl_yurtBilgileri.id where tbl_ogrenci.ogr_durum = 1";
             Listele(sql);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilendeger = dataGridView1.SelectedCells[0].RowIndex;
            label4.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
            lblad.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
            lblsoyad.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
            lblOdaNoo.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
            lblYatakNo.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
            MessageBox.Show("Öğrenci bilgileri çekildi, öğrencinin adı ve soyadı: "+lblad.Text+ " " +lblsoyad.Text+"öğrenci Oda No:" +lblOdaNoo.Text+" Öğrenci Yatak No: "+lblYatakNo.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbl_izinler (ogr_ad,ogr_soyad,ogr_odaNo,ogr_yatakNo,gidisSebep,adres,gidisTarih,donusTarih,izinDurum,veli_id) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", baglanti);        
            komut.Parameters.AddWithValue("@p1", lblad.Text);
            komut.Parameters.AddWithValue("@p2", lblsoyad.Text);
            komut.Parameters.AddWithValue("@p3", lblOdaNoo.Text);
            komut.Parameters.AddWithValue("@p4", lblYatakNo.Text);
            komut.Parameters.AddWithValue("@p5", rchSebep.Text);
            komut.Parameters.AddWithValue("@p6", rchAdres.Text);
            komut.Parameters.AddWithValue("@p7", lblgidis.Text);
            komut.Parameters.AddWithValue("@p8", lbldonus.Text);
            komut.Parameters.AddWithValue("@p9", 1);
            komut.Parameters.AddWithValue("@p10", label4.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {

            }
            baglanti.Close();
            MessageBox.Show("Veritabanına Eklendi");

            //UPDATE
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Update tbl_ogrenci Set ogr_izinDurum=@p1 where ogr_id=@p18", baglanti);
            komut2.Parameters.AddWithValue("@p1", 1);
            komut2.Parameters.AddWithValue("@p18", label4.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Güncellendi");

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            izinListesi izin = new izinListesi();
            izin.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Çanakkale Onsekiz Mart Üniversitesi ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(300, 100));
            e.Graphics.DrawString("DEVLET YURDU", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(350, 130));
            e.Graphics.DrawString("İZİN KAĞIDI", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(370, 180));
            e.Graphics.DrawString("Çanakkale Onsekiz Mart Devlet Yurdumuzun,", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(130, 225));
            e.Graphics.DrawString(lblOdaNoo.Text + "Nolu Odada      ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(130, 250));
            e.Graphics.DrawString("       " + lblYatakNo.Text + " Numaralı yatakta kayıtlı öğrencimiz          ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(275, 250));
            e.Graphics.DrawString(  "      "  +  lblad.Text + " " + lblsoyad.Text + "´ın ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(605, 250));
            e.Graphics.DrawString(lblgidis.Text +  " - "  + lbldonus.Text + " tarihleri arasında" , new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(130, 270));
            e.Graphics.DrawString(rchSebep.Text + "  " , new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(495, 270));
            e.Graphics.DrawString(" " + " sebeplerden ötürü izin verilmiştir ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(130, 295));
            e.Graphics.DrawString("ÖĞRENCİ İMZA ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(100, 350));
            e.Graphics.DrawString("İMZA / KAŞE ", new Font("Arial", 13, FontStyle.Bold), Brushes.Black, new Point(650, 350));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        String day, day2;

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker4.Format = DateTimePickerFormat.Custom;
            dateTimePicker4.CustomFormat = "yyyy.MM.d";
            day2 = dateTimePicker4.Text;
            lbldonus.Text = day2.ToString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "yyyy.MM.d";
            day = dateTimePicker3.Text;
            lblgidis.Text = day.ToString();
        }
    }
}
