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
    public partial class koltuklar : Form
    {
        public koltuklar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");

        private void Neoplan_Click(object sender, EventArgs e)
        {
           
        }

        private void Setra_Click(object sender, EventArgs e)
        {
        }

        private void Travego_Click(object sender, EventArgs e)
        {
            
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            Anaform fr = new Anaform();
            fr.Show();
            this.Hide();
        }

        private void koltuklar_Load(object sender, EventArgs e)
        {

        }
    }
}
