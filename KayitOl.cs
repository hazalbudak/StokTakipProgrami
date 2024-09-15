using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StokTakipProgrami
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FV5IBAP\\HAZALSQL;Initial Catalog=Stok_Takip_Programi;Integrated Security=True");
        private void KayitOl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //Müşteri kaydı 
            SqlCommand komut = new SqlCommand("insert into Tbl_Musteri(MusteriTC, MusteriAd, MusteriSoyad, MusteriTelefon, MusteriAdres, MusteriKullaniciAdi, MusteriEmail, MusteriSifre) values (@m1, @m2, @m3, @m4, @m5, @m6, @m7, @m8)", baglanti);
            komut.Parameters.AddWithValue("@m1", koTcTxtBox.Text);
            komut.Parameters.AddWithValue("@m2", koAdTxtBox.Text);
            komut.Parameters.AddWithValue("@m3", koSoyadTxtBox.Text);
            komut.Parameters.AddWithValue("@m4", koTelNoTxtBox.Text);
            komut.Parameters.AddWithValue("@m5", comboBoxAdres.Text);
            komut.Parameters.AddWithValue("@m6", koKAdiTxtBox.Text);
            komut.Parameters.AddWithValue("@m7", koEmailTxtBox.Text);
            komut.Parameters.AddWithValue("@m8", koSifreTxtBox.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kaydınız Başarılı.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is CheckBox)
                {
                    item.Text = "";
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
            GirisSayfasi girisSayfasiForm = new GirisSayfasi();
            girisSayfasiForm.ShowDialog();

        }
    }
}
