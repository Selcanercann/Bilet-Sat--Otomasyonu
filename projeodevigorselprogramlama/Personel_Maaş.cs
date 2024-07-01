using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projeodevigorselprogramlama
{
    public partial class Personel_Maaş : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");
        int id = 0;

        public Personel_Maaş()
        {
            InitializeComponent();
        }

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Personelmaas", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Tc"].ToString();
                ekle.SubItems.Add(oku["İsim"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());
                ekle.SubItems.Add(oku["Maaş"].ToString());
                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void goster_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].Text);
            txttc.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtmeslek.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtmaas.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE Personelmaas SET İsim=@İsim, Soyad=@Soyad, Meslek=@Meslek, Maaş=@Maaş WHERE Tc=@Tc", baglanti);
                komut.Parameters.AddWithValue("@İsim", txtad.Text);
                komut.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@Meslek", txtmeslek.Text);
                komut.Parameters.AddWithValue("@Maaş", int.Parse(txtmaas.Text));
                komut.Parameters.AddWithValue("@Tc", id);

                komut.ExecuteNonQuery();
                baglanti.Close();
                verilergoster();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM Personelmaas WHERE Tc=@Tc", baglanti);
            komut.Parameters.AddWithValue("@Tc", id);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilergoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtad.Clear();
            txtsoyad.Clear();
            txttc.Clear();
            txtmeslek.Clear();
            txtmaas.Clear();
        }

        private void ara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Personelmaas WHERE İsim LIKE @İsim", baglanti);
            komut.Parameters.AddWithValue("@İsim", "%" + txtara.Text + "%");
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Tc"].ToString();
                ekle.SubItems.Add(oku["İsim"].ToString());
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());
                ekle.SubItems.Add(oku["Maaş"].ToString());
                listView1.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            Anaform fr = new Anaform();
            fr.Show();
            this.Hide();
        }
    }
}
