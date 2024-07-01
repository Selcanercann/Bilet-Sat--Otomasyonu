using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace projeodevigorselprogramlama
{
    public partial class kullanicikayit : Form
    {
        private const string DateFormat = "yyyy-MM-dd";
        private SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");

        public kullanicikayit()
        {
            InitializeComponent();
        }
        public void RemoveOldButtons()
        {
            foreach (var item in this.Controls)
            {
                if (item is Button)
                {
                    Button button = (Button)item;
                    if (button.Text != "Kadın" && button.Text != "Erkek" && button.Text != "Boş" && button.Text != "KAYDET")
                    {
                        this.Controls.Remove(button);
                    }
                }
            }
        }

        private void otbussecimi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ucret;

            switch (otbussecimi.Text)
            {
                case "Travego":
                    koltukdoldur(8, false);
                    ucret = 100;
                    txtucret.Text = ucret.ToString();
                    txtotobussecimi.Text = "Travego";
                    break;
                case "Setra":
                    koltukdoldur(12, true);
                    ucret = 65;
                    txtucret.Text = ucret.ToString();
                    txtotobussecimi.Text = "Setra";
                    break;
                case "Neoplan":
                    koltukdoldur(10, false);
                    ucret = 80;
                    txtotobussecimi.Text = "Neoplan";
                    txtucret.Text = ucret.ToString();
                    break;
                default:
                    break;
            }
        }

        private void koltukdoldur(int sira, bool arkabeslimi)
        {
            this.RemoveOldButtons(); // Buradaki "this" nesnesini kullanarak RemoveOldButtons() yöntemini çağırın.

            int koltukno = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == sira / 2 && j > 2)
                    {
                        continue;
                    }

                    if (arkabeslimi == true)
                    {
                        if (i != sira - 1 && j == 2)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (j == 2)
                            continue;
                    }

                    Button koltuk = CreateKoltukButton(koltukno, i, j);
                    Controls.Add(koltuk);

                    koltukno++;
                }
            }
        }


        private Button CreateKoltukButton(int koltukno, int i, int j)
        {
            Button koltuk = new Button
            {
                Height = 40,
                Width = 40,
                Top = 30 + (i * 45),
                Left = 5 + (j * 45),
                BackColor = Color.Silver,
                Text = koltukno.ToString(),
                ContextMenuStrip = contextMenuStrip1
            };

            koltuk.MouseDown += Koltuk_MouseDown;

            return koltuk;
        }

        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            Button tiklanan = sender as Button;
            txtkoltukno.Text = tiklanan.Text;
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            using (SqlCommand komut = new SqlCommand("INSERT INTO MusteriEkle (Adi, Soyadi, TelefonNo, Mail, TcNo, KoltukNo, Ucret, Cinsiyeti, OtobusSecimi, SeferTarihi, SeferSaati, Nerden, Nereye) VALUES (@Adi, @Soyadi, @TelefonNo, @Mail, @TcNo, @KoltukNo, @Ucret, @Cinsiyeti, @OtobusSecimi, @SeferTarihi, @SeferSaati, @Nerden, @Nereye)", baglanti))
            {
                komut.Parameters.AddWithValue("@Adi", txtadi.Text);
                komut.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                komut.Parameters.AddWithValue("@TelefonNo", txttelefon.Text);
                komut.Parameters.AddWithValue("@Mail", txtmail.Text);
                komut.Parameters.AddWithValue("@TcNo", txttc.Text);
                komut.Parameters.AddWithValue("@KoltukNo", txtkoltukno.Text);
                komut.Parameters.AddWithValue("@Ucret", txtucret.Text);
                komut.Parameters.AddWithValue("@Cinsiyeti", cinsiyetTxt.Text);
                komut.Parameters.AddWithValue("@OtobusSecimi", txtotobussecimi.Text);
                komut.Parameters.AddWithValue("@SeferTarihi", dtTmPckrsefertarihi.Value.ToString(DateFormat));
                komut.Parameters.AddWithValue("@SeferSaati", txtsaat.Text);
                komut.Parameters.AddWithValue("@Nerden", txtnerden.Text);
                komut.Parameters.AddWithValue("@Nereye", txtnereye.Text);

                komut.ExecuteNonQuery();
            }
            baglanti.Close();
            cmbBxsefersaati.Text = "";

            MessageBox.Show("Müşteri kaydı yapıldı");
        }

        private void cmbBxsefersaati_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsaat.Text = cmbBxsefersaati.Text;
        }

        private void cmbBxnerden_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnerden.Text = cmbBxnerden.Text;
        }

        private void cmbBxnereye_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtnereye.Text = cmbBxnereye.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cinsiyetTxt.Text = comboBox2.Text;
        }

        private void koltukrenk()
        {
            // Koltuk rengini ayarlama kodu burada olacak.
        }

        private void otobus_Click(object sender, EventArgs e)
        {
            otobuskayt_listesi fr = new otobuskayt_listesi();
            fr.Show();
        }

        private void anasayfa_Click_1(object sender, EventArgs e)
        {
            Anaform fr = new Anaform();
            fr.Show();
            this.Hide();
        }

       
    }
}
