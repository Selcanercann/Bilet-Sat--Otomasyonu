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
    public partial class faturalar : Form
    {
        public faturalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");

        private void veri()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from giderfaturalama", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["benzin"].ToString();
                ekle.SubItems.Add(oku["wifi"].ToString());
                ekle.SubItems.Add(oku["personelyemek"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();

        }

        private void kaydet_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into giderfaturalama(benzin,wifi,personelyemek) values('" + txtbenzin.Text + "','" + txtwifi.Text + "','" + txtyemek.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veri();
        }

        private void faturalar_Load(object sender, EventArgs e)
        {
            veri();
        }

       
        private void anasayfa_Click(object sender, EventArgs e)
        {
            Anaform fr = new Anaform();
            fr.Show();
            this.Hide();

        }
    }
}
