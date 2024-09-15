using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgrami
{
    public partial class AdminSayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FV5IBAP\\HAZALSQL;Initial Catalog=Stok_Takip_Programi;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommand komut;
        DataTable tablo1 = new DataTable();
        DataTable tablo2 = new DataTable();

        public AdminSayfasi()
        {
            InitializeComponent();
        }
        void MusterileriListele() //Datagridview'da müşteri listeleme.
        {
            tablo1.Clear();
            adtr = new SqlDataAdapter("sp_MusteriListele", baglanti);
            adtr.Fill(tablo1);
            dataGridView1.DataSource = tablo1;
        }

        void UrunleriListele() //Datagridview'da ürünleri listeleme.
        {
            tablo2.Clear();
            adtr = new SqlDataAdapter("sp_UrunListele", baglanti);
            adtr.Fill(tablo2);
            dataGridView2.DataSource = tablo2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusterileriListele();
        }

        private void musteriEkleButton_Click(object sender, EventArgs e) //Sp ile müşteri ekleme
        {
            baglanti.Open();
            komut = new SqlCommand("sp_MusteriEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("MusteriTC", asTxtBoxTc.Text);
            komut.Parameters.AddWithValue("MusteriAd", asTxtBoxAd.Text);
            komut.Parameters.AddWithValue("MusteriSoyad", asTxtBoxSoyad.Text);
            komut.Parameters.AddWithValue("MusteriTelefon", asTxtBoxTelefon.Text);
            komut.Parameters.AddWithValue("MusteriKullaniciAdi", asTxtBoxKullaniciAdi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            MusterileriListele();
        }

        private void musteriSilButton_Click(object sender, EventArgs e) //Sp ile müşteri silme
        {
            baglanti.Open();
            komut = new SqlCommand("sp_MusteriSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("MusteriId", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            MusterileriListele();

        }

        private void musteriGuncelleButton_Click(object sender, EventArgs e) //Sp ile güncelleme
        {
            baglanti.Open();
            komut = new SqlCommand("sp_MusteriGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("MusteriId", asTxtBoxId.Text);
            komut.Parameters.AddWithValue("MusteriTC", asTxtBoxTc.Text);
            komut.Parameters.AddWithValue("MusteriAd", asTxtBoxAd.Text);
            komut.Parameters.AddWithValue("MusteriSoyad", asTxtBoxSoyad.Text);
            komut.Parameters.AddWithValue("MusteriTelefon", asTxtBoxTelefon.Text);
            komut.Parameters.AddWithValue("MusteriKullaniciAdi", asTxtBoxKullaniciAdi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            MusterileriListele();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) ////Datagridview'da satır seçme.
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            asTxtBoxId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            asTxtBoxTc.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            asTxtBoxAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            asTxtBoxSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            asTxtBoxTelefon.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            asTxtBoxKullaniciAdi.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void urunListeleButton_Click(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void urunEkleButton_Click(object sender, EventArgs e) //Sp ile ürün ekleme.
        {
            baglanti.Open();
            komut = new SqlCommand("sp_UrunEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("UrunBarkod", asTxtBoxBarkod.Text);
            komut.Parameters.AddWithValue("UrunAdi",  asTxtBoxUrunAdi.Text);
            komut.Parameters.AddWithValue("UrunMiktari", asTxtBoxMiktar.Text);
            komut.Parameters.AddWithValue("UrunSatisFiyati", asTxtBoxSatisFiyati.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            UrunleriListele();
        }

        private void urunSilButton_Click(object sender, EventArgs e) //Sp ile ürün silme.
        {
            baglanti.Open();
            komut = new SqlCommand("sp_UrunSil", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("UrunId", dataGridView2.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            UrunleriListele();
        }

        private void urunGuncelleButton_Click(object sender, EventArgs e) //Sp ile ürün güncelleme.
        {
            baglanti.Open();
            komut = new SqlCommand("sp_UrunGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("UrunId", asTxtBoxUrunId.Text);
            komut.Parameters.AddWithValue("UrunBarkod", asTxtBoxBarkod.Text);
            komut.Parameters.AddWithValue("UrunAdi", asTxtBoxUrunAdi.Text);
            komut.Parameters.AddWithValue("UrunMiktari", asTxtBoxMiktar.Text);
            komut.Parameters.AddWithValue("UrunSatisFiyati", asTxtBoxSatisFiyati.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            UrunleriListele();
        }
        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int secilen2 = dataGridView2.SelectedCells[0].RowIndex;
            asTxtBoxUrunId.Text = dataGridView2.Rows[secilen2].Cells[0].Value.ToString();
            asTxtBoxBarkod.Text = dataGridView2.Rows[secilen2].Cells[1].Value.ToString();
            asTxtBoxUrunAdi.Text = dataGridView2.Rows[secilen2].Cells[2].Value.ToString();
            asTxtBoxMiktar.Text = dataGridView2.Rows[secilen2].Cells[3].Value.ToString();
            asTxtBoxSatisFiyati.Text = dataGridView2.Rows[secilen2].Cells[4].Value.ToString();
        }
    }

}
