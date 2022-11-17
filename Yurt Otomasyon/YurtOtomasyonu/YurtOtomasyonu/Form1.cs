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
    public partial class Form1 : Form
    {     
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int kalanHak = 3;
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-BSDGJ678;Initial Catalog=YurtOtomasyonDatabase;Integrated Security=True"); //sql bağlantısı
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz ?" ,"", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);            
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Start();
                MessageBox.Show("Çıkış yapılıyor lütfen bekleyiniz...");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Çıkış işleminiz iptal edildi...");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("3 Defa giriş hakkınız bulunmaktadır... 3 Defa yanlış şifre veya kullanıcı adı girdiğinizde program otomatik olarak kapatılacaktır. Eğer Giriş bilgilerinizi unuttuysanız yazılım şirketi ile iletişime geçiniz.\nİletişim Bilgileri için 'HAYIRA' tıklayınız", "Bilgilendirme Mesajı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);   
            if (dialogResult == DialogResult.Yes)
            {
                
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Bizimle İletişime geçmek için: 0543 000 00 00\nEposta adresimiz:ozan@gmail.com\nFaks Numaramız:0543 763 00 00");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {     
            sayac++;
            label4.Text = sayac.ToString();
            if (label4.Text == "2")
            {
                Application.Exit();
            }
        }
        public static string name;
        public static DateTime bugun;
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand giris = new SqlCommand("Select * from tbl_yonetici where kln_adi=@p1 and kln_sifre=@p2", baglanti);
            giris.Parameters.AddWithValue("@p1", textBox1.Text);
            name = textBox1.Text;
            giris.Parameters.AddWithValue("@P2", textBox2.Text);
            SqlDataReader d1 = giris.ExecuteReader();
            if (d1.Read())
            {
                bugun = DateTime.Now;
                YoneticiForm yoneticiForm = new YoneticiForm();        
                yoneticiForm.Show();               
                this.Hide();
            }
            else
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Boş giriş yapılmıştır tekrar deneyiniz");
                }
                else
                {
                    kalanHak = kalanHak - 1;
                    MessageBox.Show("\nKalan Hakkınız: " + kalanHak);
                    while (kalanHak == 0)
                    {
                        MessageBox.Show("Giriş haklarınız bitmiştir\n uygulama Kapatılıyor...");
                        Application.Exit();
                        break;
                    }
                }
            }
            baglanti.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
