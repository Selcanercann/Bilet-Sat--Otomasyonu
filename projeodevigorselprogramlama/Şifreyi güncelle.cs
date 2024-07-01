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
    public partial class Şifreyi_güncelle : Form
    {
        public Şifreyi_güncelle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE AdminGiris SET Kullanici='" + txtkulanici.Text + "', Sifre='" + txtsifre.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void verilergoster()
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT [ID], [Kullanici], [Sifre] FROM AdminGiris", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ID"].ToString();
                ekle.SubItems.Add(oku["Kullanici"].ToString());
                ekle.SubItems.Add(oku["Sifre"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        int id = 0;

        private void guncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE AdminGiris SET Kullanici='" + txtkulanici.Text + "', Sifre='" + txtsifre.Text + "' WHERE [ID] = " + id, baglanti);
            komut.ExecuteNonQuery();
            verilergoster();
            baglanti.Close();
        }

        private void goster_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].Text);
            txtid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtkulanici.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsifre.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            Anaform fr = new Anaform();
            fr.Show();
            this.Close();
        }
    }
}
