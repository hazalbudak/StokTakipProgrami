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
    public partial class SatinAlmaSayfasi : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-FV5IBAP\\HAZALSQL;Initial Catalog=Stok_Takip_Programi;Integrated Security=True");
        DataTable tablo = new DataTable();
        DataSet daset = new DataSet();
        SqlCommand komut;
        public SatinAlmaSayfasi()
        {
            InitializeComponent();
        }
        
        private void sepetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Tbl_Sepet", baglanti);
            adtr.Fill(daset, "Tbl_Sepet");
            dataGridView1.DataSource = daset.Tables["Tbl_Sepet"];
            dataGridView1.Columns[0].Visible = true;
            dataGridView1.Columns[1].Visible = true;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            baglanti.Close();

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        


        private void sasTxtBoxUrunAra_TextChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from Tbl_Urun where UrunAdi like'"+sasTxtBoxUrunAra.Text+"%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void SatinAlmaSayfasi_Load(object sender, EventArgs e)
        {
            sepetListele();
            
        }

        private void sepeteEkleButton_Click(object sender, EventArgs e)
        {
            //baglanti.Open();
            //komut = new SqlCommand("sp_SepeteEkle", baglanti);
            //komut.CommandType = CommandType.StoredProcedure;
            
            //komut.Parameters.AddWithValue("UrunBarkod", sasTxtBoxBarkod.Text);
            //komut.Parameters.AddWithValue("UrunAdi", sasTxtBoxUrunAdi.Text);
            //komut.Parameters.AddWithValue("UrunMiktari", sasTxtBoxMiktar.Text);
            //komut.Parameters.AddWithValue("UrunSatisFiyati", sasTxtBoxSatisFiyat.Text);
            //komut.ExecuteNonQuery();
            //baglanti.Close();
            //MessageBox.Show("Sepete Eklendi");
            //sepetListele();

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            sasTxtBoxBarkod.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            sasTxtBoxUrunAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sasTxtBoxSatisFiyat.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void sasTxtBoxMiktar_TextChanged(object sender, EventArgs e)
        {

            try
            {
                sasTxtBoxToplamFiyat.Text = (double.Parse(sasTxtBoxMiktar.Text) * double.Parse(sasTxtBoxSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void sasTxtBoxSatisFiyat_TextChanged(object sender, EventArgs e)
        {

            try
            {
                sasTxtBoxToplamFiyat.Text = (double.Parse(sasTxtBoxMiktar.Text) * double.Parse(sasTxtBoxSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
