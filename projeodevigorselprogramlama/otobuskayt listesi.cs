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
    public partial class otobuskayt_listesi : Form
    {
        public otobuskayt_listesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void otobuskayt_listesi_Load(object sender, EventArgs e)
        {
            verilergoster();
        }
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

                ekle.SubItems.Add(oku["KoltukNo"].ToString());

                ekle.SubItems.Add(oku["OtobusSeçimi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
