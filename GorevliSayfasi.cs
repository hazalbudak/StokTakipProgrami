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
    public partial class GorevliSayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FV5IBAP\\HAZALSQL;Initial Catalog=Stok_Takip_Programi;Integrated Security=True");
        SqlDataAdapter adtr;
        SqlCommand komut;
        DataTable tablo = new DataTable();
        public GorevliSayfasi()
        {
            InitializeComponent();
        }
        void UrunleriListele()
        {
            tablo.Clear();
            adtr = new SqlDataAdapter("sp_UrunListele", baglanti);
            adtr.Fill(tablo);
            dataGridView2.DataSource = tablo;
        }
        private void urunListButton_Click(object sender, EventArgs e)
        {
            UrunleriListele();
        }

        private void urunEkleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("sp_UrunEkle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("UrunBarkod", gsTxtBoxBarkod.Text);
            komut.Parameters.AddWithValue("UrunAdi", gsTxtBoxUrunAdi.Text);
            komut.Parameters.AddWithValue("UrunMiktari", gsTxtBoxMiktar.Text);
            komut.Parameters.AddWithValue("UrunSatisFiyati", gsTxtBoxSatisFiyati.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ekleme İşlemi Başarılı");
            UrunleriListele();
        }

        private void urunSilButton_Click(object sender, EventArgs e)
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

        private void urunGuncelleButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("sp_UrunGuncelle", baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("UrunId", gsTxtBoxUrunId.Text);
            komut.Parameters.AddWithValue("UrunBarkod", gsTxtBoxBarkod.Text);
            komut.Parameters.AddWithValue("UrunAdi", gsTxtBoxUrunAdi.Text);
            komut.Parameters.AddWithValue("UrunMiktari", gsTxtBoxMiktar.Text);
            komut.Parameters.AddWithValue("UrunSatisFiyati", gsTxtBoxSatisFiyati.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            UrunleriListele();
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            //gsTxtBoxUrunId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            gsTxtBoxBarkod.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            gsTxtBoxUrunAdi.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            gsTxtBoxMiktar.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
            gsTxtBoxSatisFiyati.Text = dataGridView2.Rows[secilen].Cells[3].Value.ToString();
        }
    }
}
