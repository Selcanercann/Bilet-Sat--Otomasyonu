using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projeodevigorselprogramlama
{
    public partial class Form1 : Form
    {
        private const string ServerName = "DESKTOP-ERGBAB8"; // SQL Sunucusu adı
        private const string DatabaseName = "projeodevi"; // Veritabanı adı

        public Form1()
        {
            InitializeComponent();
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            string connectionString = $"Data Source={ServerName};Initial Catalog={DatabaseName};Integrated Security=True";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();

                string kullaniciAdi = txtkulanici.Text;
                string sifre = txtsifre.Text;

                string sqlSorgu = "SELECT Kullanici, Sifre FROM AdminGiris WHERE Kullanici = @ad AND Sifre = @sifre";

                using (SqlCommand sorgu = new SqlCommand(sqlSorgu, baglanti))
                {
                    sorgu.Parameters.AddWithValue("@ad", kullaniciAdi);
                    sorgu.Parameters.AddWithValue("@sifre", sifre);

                    using (SqlDataReader dr = sorgu.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            Anaform frm = new Anaform();
                            frm.Show();
                            this.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Yanlış Kullanıcı Adı veya Parola. Lütfen Bilgileri Doğru Girdiğinizden Emin Olun.");
                        }
                    }
                }
            }
        }

        private void cikis_Click(object sender, EventArgs e)
        {
           DialogResult onay = MessageBox.Show("Çıkmak İstediğinize Emin misiniz?", "Çıkış İşlemi", MessageBoxButtons.YesNo);

            if (onay == DialogResult.Yes)
            {
                Application.Exit();
            }
            /* Anaform frm = new Anaform();
            frm.Show();
            this.Visible = false;*/
        }
    }
}
