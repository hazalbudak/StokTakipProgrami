namespace StokTakipProgrami
{
    partial class SatinAlmaSayfasi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sasTxtBoxUrunAra = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sepeteEkleButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.satinAlButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.satisİptalButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sasTxtBoxSepetId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sasTxtBoxToplamFiyat = new System.Windows.Forms.TextBox();
            this.sasTxtBoxSatisFiyat = new System.Windows.Forms.TextBox();
            this.sasTxtBoxMiktar = new System.Windows.Forms.TextBox();
            this.sasTxtBoxUrunAdi = new System.Windows.Forms.TextBox();
            this.sasTxtBoxBarkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sasTxtBoxUrunAra
            // 
            this.sasTxtBoxUrunAra.Location = new System.Drawing.Point(19, 31);
            this.sasTxtBoxUrunAra.Name = "sasTxtBoxUrunAra";
            this.sasTxtBoxUrunAra.Size = new System.Drawing.Size(121, 20);
            this.sasTxtBoxUrunAra.TabIndex = 1;
            this.sasTxtBoxUrunAra.TextChanged += new System.EventHandler(this.sasTxtBoxUrunAra_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 276);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // sepeteEkleButton
            // 
            this.sepeteEkleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sepeteEkleButton.Location = new System.Drawing.Point(310, 385);
            this.sepeteEkleButton.Name = "sepeteEkleButton";
            this.sepeteEkleButton.Size = new System.Drawing.Size(95, 57);
            this.sepeteEkleButton.TabIndex = 19;
            this.sepeteEkleButton.Text = "Sepete Ekle";
            this.sepeteEkleButton.UseVisualStyleBackColor = true;
            this.sepeteEkleButton.Click += new System.EventHandler(this.sepeteEkleButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sasTxtBoxUrunAra);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 80);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ara";
            // 
            // satinAlButton
            // 
            this.satinAlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satinAlButton.Location = new System.Drawing.Point(664, 385);
            this.satinAlButton.Name = "satinAlButton";
            this.satinAlButton.Size = new System.Drawing.Size(95, 57);
            this.satinAlButton.TabIndex = 21;
            this.satinAlButton.Text = "Satın Al";
            this.satinAlButton.UseVisualStyleBackColor = true;
            // 
            // silButton
            // 
            this.silButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silButton.Location = new System.Drawing.Point(435, 385);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(95, 57);
            this.silButton.TabIndex = 22;
            this.silButton.Text = "Sil";
            this.silButton.UseVisualStyleBackColor = true;
            // 
            // satisİptalButton
            // 
            this.satisİptalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisİptalButton.Location = new System.Drawing.Point(550, 385);
            this.satisİptalButton.Name = "satisİptalButton";
            this.satisİptalButton.Size = new System.Drawing.Size(95, 57);
            this.satisİptalButton.TabIndex = 23;
            this.satisİptalButton.Text = "Satış İptal";
            this.satisİptalButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sasTxtBoxSepetId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sasTxtBoxToplamFiyat);
            this.groupBox2.Controls.Add(this.sasTxtBoxSatisFiyat);
            this.groupBox2.Controls.Add(this.sasTxtBoxMiktar);
            this.groupBox2.Controls.Add(this.sasTxtBoxUrunAdi);
            this.groupBox2.Controls.Add(this.sasTxtBoxBarkod);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(28, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 309);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satın Alma";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // sasTxtBoxSepetId
            // 
            this.sasTxtBoxSepetId.Enabled = false;
            this.sasTxtBoxSepetId.Location = new System.Drawing.Point(115, 65);
            this.sasTxtBoxSepetId.Name = "sasTxtBoxSepetId";
            this.sasTxtBoxSepetId.Size = new System.Drawing.Size(100, 20);
            this.sasTxtBoxSepetId.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(16, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Sepet Id:";
            // 
            // sasTxtBoxToplamFiyat
            // 
            this.sasTxtBoxToplamFiyat.Location = new System.Drawing.Point(115, 257);
            this.sasTxtBoxToplamFiyat.Name = "sasTxtBoxToplamFiyat";
            this.sasTxtBoxToplamFiyat.Size = new System.Drawing.Size(100, 20);
            this.sasTxtBoxToplamFiyat.TabIndex = 9;
            // 
            // sasTxtBoxSatisFiyat
            // 
            this.sasTxtBoxSatisFiyat.Location = new System.Drawing.Point(115, 219);
            this.sasTxtBoxSatisFiyat.Name = "sasTxtBoxSatisFiyat";
            this.sasTxtBoxSatisFiyat.Size = new System.Drawing.Size(100, 20);
            this.sasTxtBoxSatisFiyat.TabIndex = 8;
            this.sasTxtBoxSatisFiyat.TextChanged += new System.EventHandler(this.sasTxtBoxSatisFiyat_TextChanged);
            // 
            // sasTxtBoxMiktar
            // 
            this.sasTxtBoxMiktar.Location = new System.Drawing.Point(115, 181);
            this.sasTxtBoxMiktar.Name = "sasTxtBoxMiktar";
            this.sasTxtBoxMiktar.Size = new System.Drawing.Size(100, 20);
            this.sasTxtBoxMiktar.TabIndex = 7;
            this.sasTxtBoxMiktar.Text = "1";
            this.sasTxtBoxMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sasTxtBoxMiktar.TextChanged += new System.EventHandler(this.sasTxtBoxMiktar_TextChanged);
            // 
            // sasTxtBoxUrunAdi
            // 
            this.sasTxtBoxUrunAdi.Location = new System.Drawing.Point(115, 144);
            this.sasTxtBoxUrunAdi.Name = "sasTxtBoxUrunAdi";
            this.sasTxtBoxUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.sasTxtBoxUrunAdi.TabIndex = 6;
            // 
            // sasTxtBoxBarkod
            // 
            this.sasTxtBoxBarkod.Location = new System.Drawing.Point(115, 107);
            this.sasTxtBoxBarkod.Name = "sasTxtBoxBarkod";
            this.sasTxtBoxBarkod.Size = new System.Drawing.Size(100, 20);
            this.sasTxtBoxBarkod.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(16, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Toplam Fiyat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Satış Fiyatı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miktar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barkod:";
            // 
            // SatinAlmaSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.satisİptalButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.satinAlButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sepeteEkleButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SatinAlmaSayfasi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satın Alma Sayfası";
            this.Load += new System.EventHandler(this.SatinAlmaSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox sasTxtBoxUrunAra;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button sepeteEkleButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button satinAlButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button satisİptalButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sasTxtBoxToplamFiyat;
        private System.Windows.Forms.TextBox sasTxtBoxSatisFiyat;
        private System.Windows.Forms.TextBox sasTxtBoxMiktar;
        private System.Windows.Forms.TextBox sasTxtBoxUrunAdi;
        private System.Windows.Forms.TextBox sasTxtBoxBarkod;
        private System.Windows.Forms.TextBox sasTxtBoxSepetId;
        private System.Windows.Forms.Label label8;
    }
}