using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipProgrami
{
    public partial class GirisSayfasi : Form
    {
        public GirisSayfasi()
        {
            InitializeComponent();
        }

        string selectedComboBox;
        private void kTipicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedComboBox = kTipicomboBox.SelectedItem.ToString(); //combobox'daki değişim ile picturebox'daki resmin değişimi.
            if (selectedComboBox == " ")
            {
                pictureBox1.Image = Image.FromFile("..\\..\\Picture\\stok.png");
            }

            if (selectedComboBox == "Admin")
            {
                pictureBox1.Image = Image.FromFile("..\\..\\Picture\\admin.png");
                button1.Visible = false; 
            }

            if (selectedComboBox == "Görevli")
            {
                pictureBox1.Image = Image.FromFile("..\\..\\Picture\\gorevli.png");
                button1.Visible = false;
            }

            if (selectedComboBox == "Müşteri")
            {
                pictureBox1.Image = Image.FromFile("..\\..\\Picture\\user.png");
                button1.Visible = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //Parolayı gösterme ve gizleme.
        {
            if (checkBox1.Checked)
            {
                parolatxtBox.UseSystemPasswordChar = false;
                checkBox1.Text = "Parolayı Gizle";
            }
            else
            {
                parolatxtBox.UseSystemPasswordChar = true;
                checkBox1.Text = "Parolayı Göster";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            parolatxtBox.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e) //Kayıt ol sayfasına gönderme.
        {
            KayitOl kayitOlForm = new KayitOl();
            kayitOlForm.ShowDialog();
        }

        private void kAditxtBox_TextChanged(object sender, EventArgs e) //Kullanıcı adı boş ise hata mesajı verir.
        {
            if (kAditxtBox.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı Boş Bırakılamaz!");
            }
        }

        private void parolatxtBox_TextChanged(object sender, EventArgs e) //Şifre boş ise hata verir
        {
            if (parolatxtBox.Text =="")
            {
                MessageBox.Show("Lütfen Parolanızı Giriniz!");
            }
        }

        private void girisYapButton_Click(object sender, EventArgs e) //Kayıt ol butonunun sadece Müşteri girişinde gösterme.
        {
            if (selectedComboBox == "Admin")
            {
                AdminSayfasi adminSayfasiForm = new AdminSayfasi();
                adminSayfasiForm.ShowDialog();
            }
            if (selectedComboBox == "Görevli")
            {
                GorevliSayfasi gorevliSayfasiForm = new GorevliSayfasi();
                gorevliSayfasiForm.ShowDialog();
            }
            if (selectedComboBox == "Müşteri")
            {
                SatinAlmaSayfasi satinAlmaSayfasiForm = new SatinAlmaSayfasi();
                satinAlmaSayfasiForm.ShowDialog();
            }
        }
    }
}
