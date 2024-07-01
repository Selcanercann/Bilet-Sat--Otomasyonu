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
    public partial class stoklar : Form
    {
        public stoklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");

        private void veri()
        {   listView1.Items.Clear();    
            baglanti.Open(); 
            SqlCommand komut = new SqlCommand("select * from stok",baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                
                 ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gıda"].ToString();
                ekle.SubItems.Add(oku["İçecekler"].ToString());
                ekle.SubItems.Add(oku["Çerezler"].ToString());
                listView1.Items.Add(ekle);
            }baglanti.Close();

        }
        
        private void kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into stok(Gıda,İçecekler,Çerezler) values('"+txxtgida.Text+"','"+txtiçecek.Text+"','"+txtcerez.Text+"')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            veri();
        }

        private void stoklar_Load(object sender, EventArgs e)
        {
            veri();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            Anaform fr = new Anaform();
            fr.Show();
            this.Close();
        }
    }
}
