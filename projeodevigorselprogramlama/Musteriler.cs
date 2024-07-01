using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace projeodevigorselprogramlama
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        private const string Format = "yyyy-MM-dd";
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");
        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyeti"].ToString());
                ekle.SubItems.Add(oku["TelefonNo"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TcNo"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["SeferTarihi"].ToString());
                ekle.SubItems.Add(oku["SeferSaati"].ToString());
                ekle.SubItems.Add(oku["Nerden"].ToString());
                ekle.SubItems.Add(oku["Nereye"].ToString());
                ekle.SubItems.Add(oku["OtobusSeçimi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();

        }



        private void anasayfa_Click(object sender, EventArgs e)
        {
            Anaform fr = new Anaform();
            fr.Show();
            this.Hide();
        }


        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].Text);
            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txttelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txttc.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtkoltukno.Text = listView1.SelectedItems[0].SubItems[7].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            txtsaat.Text = listView1.SelectedItems[0].SubItems[10].Text;
            dtTmPckrsefertarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            txtnerden.Text = listView1.SelectedItems[0].SubItems[11].Text;
            txtnereye.Text = listView1.SelectedItems[0].SubItems[12].Text;
            c1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtotobussecimi.Text = listView1.SelectedItems[0].SubItems[13].Text;




        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string query = "UPDATE MusteriEkle SET Adi=@Adi, Soyadi=@Soyadi, Cinsiyeti=@Cinsiyeti, TelefonNo=@TelefonNo, Mail=@Mail, TcNo=@TcNo, KoltukNo=@KoltukNo, Ucret=@Ucret, SeferTarihi=@SeferTarihi, SeferSaati=@SeferSaati, Nerden=@Nerden, Nereye=@Nereye, OtobusSeçimi=@OtobusSeçimi WHERE Musteriid=@Musteriid";

                using (SqlCommand komut = new SqlCommand(query, baglanti))
                {
                    komut.Parameters.AddWithValue("@Adi", txtadi.Text);
                    komut.Parameters.AddWithValue("@Soyadi", txtsoyadi.Text);
                    komut.Parameters.AddWithValue("@Cinsiyeti", c1.Text);
                    komut.Parameters.AddWithValue("@TelefonNo", txttelefon.Text);
                    komut.Parameters.AddWithValue("@Mail", txtmail.Text);
                    komut.Parameters.AddWithValue("@TcNo", txttc.Text);
                    komut.Parameters.AddWithValue("@KoltukNo", txtkoltukno.Text);
                    komut.Parameters.AddWithValue("@Ucret", decimal.Parse(txtucret.Text));
                    komut.Parameters.AddWithValue("@SeferTarihi", dtTmPckrsefertarihi.Value);
                    komut.Parameters.AddWithValue("@SeferSaati", txtsaat.Text);
                    komut.Parameters.AddWithValue("@Nerden", txtnerden.Text);
                    komut.Parameters.AddWithValue("@Nereye", txtnereye.Text);
                    komut.Parameters.AddWithValue("@OtobusSeçimi", txtotobussecimi.Text);
                    komut.Parameters.AddWithValue("@Musteriid", id);

                    komut.ExecuteNonQuery();
                }

                baglanti.Close();
                verilergoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }


        private void btnverilerisil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where Musteriid=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();

        }

        private void verileritemizle_Click(object sender, EventArgs e)
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            txttelefon.Clear();
            txtmail.Clear();
            txttc.Clear();
            txtkoltukno.Clear();
            txtucret.Clear();
            dtTmPckrsefertarihi.Text = "";
            txtsaat.Clear();
            txtnerden.Clear();
            txtnereye.Clear();
            c1.Clear();



        }


        private void btnverileriara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where Adi like '%" + txtara.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriid"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyeti"].ToString());
                ekle.SubItems.Add(oku["TelefonNo"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TcNo"].ToString());
                ekle.SubItems.Add(oku["KoltukNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["SeferTarihi"].ToString());
                ekle.SubItems.Add(oku["SeferSaati"].ToString());
                ekle.SubItems.Add(oku["Nerden"].ToString());
                ekle.SubItems.Add(oku["Nereye"].ToString());
                ekle.SubItems.Add(oku["OtobusSeçimi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }


    }
}
