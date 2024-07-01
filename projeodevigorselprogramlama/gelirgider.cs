using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace projeodevigorselprogramlama
{
    public partial class gelirgider : Form
    {
        public gelirgider()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ERGBAB8;Initial Catalog=projeodevi;Integrated Security=True");

        private void hesapla_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Toplam Gelir
                SqlCommand gelirKomut = new SqlCommand("SELECT ISNULL(SUM(Ucret), 0) AS toplam FROM MusteriEkle", baglanti);
                int toplamGelir = Convert.ToInt32(gelirKomut.ExecuteScalar());

                // Toplam Maaş
                SqlCommand maasKomut = new SqlCommand("SELECT ISNULL(SUM(Maas), 0) AS toplam FROM Personelmaas", baglanti);
                int toplamMaas = Convert.ToInt32(maasKomut.ExecuteScalar());

                // Toplam Stok Ürünleri
                SqlCommand stokKomut = new SqlCommand("SELECT ISNULL(SUM(Gida), 0) AS toplam FROM stok", baglanti);
                int toplamStokGida = Convert.ToInt32(stokKomut.ExecuteScalar());
                stokKomut = new SqlCommand("SELECT ISNULL(SUM(Icecekler), 0) AS toplam FROM stok", baglanti);
                int toplamStokIcecekler = Convert.ToInt32(stokKomut.ExecuteScalar());
                stokKomut = new SqlCommand("SELECT ISNULL(SUM(Cerezler), 0) AS toplam FROM stok", baglanti);
                int toplamStokCerezler = Convert.ToInt32(stokKomut.ExecuteScalar());

                // Toplam Gider Faturaları
                SqlCommand giderKomut = new SqlCommand("SELECT ISNULL(SUM(benzin), 0) AS toplam FROM giderfaturalama", baglanti);
                int toplamGiderBenzin = Convert.ToInt32(giderKomut.ExecuteScalar());
                giderKomut = new SqlCommand("SELECT ISNULL(SUM(wifi), 0) AS toplam FROM giderfaturalama", baglanti);
                int toplamGiderWifi = Convert.ToInt32(giderKomut.ExecuteScalar());

                int sonuc = toplamGelir - (toplamMaas + toplamStokGida + toplamStokIcecekler + toplamStokCerezler + toplamGiderBenzin + toplamGiderWifi);
                lblsonuc.Text = sonuc.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void gelirgider_Load(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                // Toplam Gelir
                SqlCommand gelirKomut = new SqlCommand("SELECT ISNULL(SUM(Ucret), 0) AS toplam FROM MusteriEkle", baglanti);
                lbltoplamtutar.Text = gelirKomut.ExecuteScalar().ToString();

                // Toplam Maaş
                SqlCommand maasKomut = new SqlCommand("SELECT ISNULL(SUM(Maas), 0) AS toplam FROM Personelmaas", baglanti);
                lblpmaas.Text = maasKomut.ExecuteScalar().ToString();

                // Toplam Stok Ürünleri
                SqlCommand stokKomut = new SqlCommand("SELECT ISNULL(SUM(Gida), 0) AS toplam FROM stok", baglanti);
                lblurun1.Text = stokKomut.ExecuteScalar().ToString();
                stokKomut = new SqlCommand("SELECT ISNULL(SUM(Icecekler), 0) AS toplam FROM stok", baglanti);
                lblurun2.Text = stokKomut.ExecuteScalar().ToString();
                stokKomut = new SqlCommand("SELECT ISNULL(SUM(Cerezler), 0) AS toplam FROM stok", baglanti);
                lblurun3.Text = stokKomut.ExecuteScalar().ToString();

                // Toplam Gider Faturaları
                SqlCommand giderKomut = new SqlCommand("SELECT ISNULL(SUM(benzin), 0) AS toplam FROM giderfaturalama", baglanti);
                fatura0.Text = giderKomut.ExecuteScalar().ToString();
                giderKomut = new SqlCommand("SELECT ISNULL(SUM(wifi), 0) AS toplam FROM giderfaturalama", baglanti);
                fatura1.Text = giderKomut.ExecuteScalar().ToString();
                giderKomut = new SqlCommand("SELECT ISNULL(SUM(wifi), 0) AS toplam FROM giderfaturalama", baglanti);
                fatura2.Text = giderKomut.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            Anaform fr = new Anaform();
            fr.Show();
            this.Close();
        }
    }
}
