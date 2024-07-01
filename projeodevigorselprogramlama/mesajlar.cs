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
    public partial class mesajlar : Form
    {
        public mesajlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");
        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from mesaj", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["mesajid"].ToString();
                ekle.SubItems.Add(oku["adsoyad"].ToString());
                ekle.SubItems.Add(oku["mesaj"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mesajlar_Load(object sender, EventArgs e)
        {
            verilergoster();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into mesaj (adsoyad,mesaj) values ('" + isimsoyisim.Text + "','" + txtmesaj.Text + "' )", baglanti);
            komut.ExecuteReader();

          
            
            verilergoster();
            baglanti.Close();
        }
        int id1=0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id1 = int.Parse(listView1.SelectedItems[0].Text);
            id.Text = listView1.SelectedItems[0].SubItems[0].Text;
            isimsoyisim.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtmesaj.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            Anaform  fr = new Anaform();
            fr.Show();
            this.Close();
        }
    }
}
