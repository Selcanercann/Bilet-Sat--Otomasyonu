using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeodevigorselprogramlama
{
    public partial class Anaform : Form
    {
        public Anaform()
        {
            InitializeComponent();
        }

        private void admingiris_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void yenimusteri_Click(object sender, EventArgs e)
        {
            kullanicikayit fr = new kullanicikayit();
            fr.Show();
            this.Hide();
        }

        private void odalar_Click(object sender, EventArgs e)
        {
         koltuklar fr = new koltuklar();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yılanoyunu fr = new yılanoyunu();
            fr.Show();
            this.Hide();
        }

        private void musteriler_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();
            fr.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Personel_Maaş fr = new Personel_Maaş();
            fr.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToString();
            

        }

        private void Anaform_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
         Şifreyi_güncelle fr = new Şifreyi_güncelle();
            fr.Show();
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            mesajlar  fr = new mesajlar();
            fr.Show();
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Güvenli yolculuk için en güvenli adres biziz. ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gelirgider fr = new gelirgider();
            fr.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stoklar fr = new stoklar();
            fr.Show();
            this.Close();

        }

        private void button7_Click(object sender, EventArgs e)
        {
           faturalar fr = new faturalar();
            fr.Show();
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
