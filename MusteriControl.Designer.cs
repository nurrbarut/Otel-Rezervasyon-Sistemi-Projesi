namespace OtelRezervasyonSistemi
{
    partial class MusteriControl
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriControl));
            dataGrid_MusteriListele = new DataGridView();
            groupBox1 = new GroupBox();
            Btn_MusteriAra = new Button();
            Txt_MusteriAra = new TextBox();
            label11 = new Label();
            Btn_MusteriYenile = new Button();
            groupBox2 = new GroupBox();
            Btn_MusteriSil = new Button();
            panel3 = new Panel();
            Txt_SilMusteri_ID = new TextBox();
            label10 = new Label();
            groupBox4 = new GroupBox();
            Btn_MusteriEkle = new Button();
            panel1 = new Panel();
            MskdTxt_EkleMusteriTel = new MaskedTextBox();
            MskdTxt_EkleMusteriTc = new MaskedTextBox();
            Txt_EkleMusteriSoyad = new TextBox();
            Txt_EkleMusteriAd = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox5 = new GroupBox();
            Btn_MusteriGuncelle = new Button();
            panel2 = new Panel();
            Txt_GuncelleMusteriID = new TextBox();
            label9 = new Label();
            MskdTxt_GuncelleMusteriTel = new MaskedTextBox();
            MskdTxt_GuncelleMusteriTc = new MaskedTextBox();
            Txt_GuncelleMusteriSoyad = new TextBox();
            Txt_GuncelleMusteriAd = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_MusteriListele).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel1.SuspendLayout();
            groupBox5.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid_MusteriListele
            // 
            dataGrid_MusteriListele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_MusteriListele.BackgroundColor = Color.LavenderBlush;
            dataGrid_MusteriListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_MusteriListele.Location = new Point(34, 121);
            dataGrid_MusteriListele.Name = "dataGrid_MusteriListele";
            dataGrid_MusteriListele.RowHeadersWidth = 51;
            dataGrid_MusteriListele.Size = new Size(677, 549);
            dataGrid_MusteriListele.TabIndex = 1;
            dataGrid_MusteriListele.CellClick += dataGrid_MusteriListele_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_MusteriAra);
            groupBox1.Controls.Add(Txt_MusteriAra);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(Btn_MusteriYenile);
            groupBox1.Controls.Add(dataGrid_MusteriListele);
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(37, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 720);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "MEVCUT MÜŞTERİ LİSTESİ:";
            // 
            // Btn_MusteriAra
            // 
            Btn_MusteriAra.BackColor = Color.LavenderBlush;
            Btn_MusteriAra.Cursor = Cursors.Hand;
            Btn_MusteriAra.Image = (Image)resources.GetObject("Btn_MusteriAra.Image");
            Btn_MusteriAra.Location = new Point(207, 68);
            Btn_MusteriAra.Name = "Btn_MusteriAra";
            Btn_MusteriAra.Size = new Size(46, 42);
            Btn_MusteriAra.TabIndex = 10;
            Btn_MusteriAra.UseVisualStyleBackColor = false;
            Btn_MusteriAra.Click += Btn_MusteriAra_Click;
            // 
            // Txt_MusteriAra
            // 
            Txt_MusteriAra.Font = new Font("Segoe UI", 10.8F);
            Txt_MusteriAra.Location = new Point(138, 75);
            Txt_MusteriAra.Name = "Txt_MusteriAra";
            Txt_MusteriAra.Size = new Size(63, 31);
            Txt_MusteriAra.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.8F);
            label11.Location = new Point(34, 77);
            label11.Name = "label11";
            label11.Size = new Size(98, 25);
            label11.TabIndex = 8;
            label11.Text = "Müşteri ID:";
            // 
            // Btn_MusteriYenile
            // 
            Btn_MusteriYenile.BackColor = Color.LavenderBlush;
            Btn_MusteriYenile.Cursor = Cursors.Hand;
            Btn_MusteriYenile.Image = (Image)resources.GetObject("Btn_MusteriYenile.Image");
            Btn_MusteriYenile.Location = new Point(656, 30);
            Btn_MusteriYenile.Name = "Btn_MusteriYenile";
            Btn_MusteriYenile.Size = new Size(55, 53);
            Btn_MusteriYenile.TabIndex = 2;
            Btn_MusteriYenile.UseVisualStyleBackColor = false;
            Btn_MusteriYenile.Click += Btn_MusteriYenile_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn_MusteriSil);
            groupBox2.Controls.Add(panel3);
            groupBox2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(37, 797);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(751, 215);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "MÜŞTERİ SİL";
            // 
            // Btn_MusteriSil
            // 
            Btn_MusteriSil.Cursor = Cursors.Hand;
            Btn_MusteriSil.Location = new Point(494, 84);
            Btn_MusteriSil.Name = "Btn_MusteriSil";
            Btn_MusteriSil.Size = new Size(103, 59);
            Btn_MusteriSil.TabIndex = 12;
            Btn_MusteriSil.Text = "SİL";
            Btn_MusteriSil.UseVisualStyleBackColor = true;
            Btn_MusteriSil.Click += Btn_MusteriSil_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(Txt_SilMusteri_ID);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(131, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 125);
            panel3.TabIndex = 12;
            // 
            // Txt_SilMusteri_ID
            // 
            Txt_SilMusteri_ID.Location = new Point(156, 49);
            Txt_SilMusteri_ID.Name = "Txt_SilMusteri_ID";
            Txt_SilMusteri_ID.Size = new Size(106, 31);
            Txt_SilMusteri_ID.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 52);
            label10.Name = "label10";
            label10.Size = new Size(98, 25);
            label10.TabIndex = 10;
            label10.Text = "Müşteri ID:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Btn_MusteriEkle);
            groupBox4.Controls.Add(panel1);
            groupBox4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(849, 55);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(680, 464);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "YENİ MÜŞTERİ";
            // 
            // Btn_MusteriEkle
            // 
            Btn_MusteriEkle.Cursor = Cursors.Hand;
            Btn_MusteriEkle.Location = new Point(281, 369);
            Btn_MusteriEkle.Name = "Btn_MusteriEkle";
            Btn_MusteriEkle.Size = new Size(145, 61);
            Btn_MusteriEkle.TabIndex = 11;
            Btn_MusteriEkle.Text = "KAYDET";
            Btn_MusteriEkle.UseVisualStyleBackColor = true;
            Btn_MusteriEkle.Click += Btn_MusteriEkle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(MskdTxt_EkleMusteriTel);
            panel1.Controls.Add(MskdTxt_EkleMusteriTc);
            panel1.Controls.Add(Txt_EkleMusteriSoyad);
            panel1.Controls.Add(Txt_EkleMusteriAd);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(151, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 247);
            panel1.TabIndex = 4;
            // 
            // MskdTxt_EkleMusteriTel
            // 
            MskdTxt_EkleMusteriTel.Location = new Point(177, 174);
            MskdTxt_EkleMusteriTel.Mask = "(999) 000-0000";
            MskdTxt_EkleMusteriTel.Name = "MskdTxt_EkleMusteriTel";
            MskdTxt_EkleMusteriTel.Size = new Size(164, 31);
            MskdTxt_EkleMusteriTel.TabIndex = 7;
            // 
            // MskdTxt_EkleMusteriTc
            // 
            MskdTxt_EkleMusteriTc.Location = new Point(177, 127);
            MskdTxt_EkleMusteriTc.Mask = "00000000000";
            MskdTxt_EkleMusteriTc.Name = "MskdTxt_EkleMusteriTc";
            MskdTxt_EkleMusteriTc.Size = new Size(164, 31);
            MskdTxt_EkleMusteriTc.TabIndex = 6;
            MskdTxt_EkleMusteriTc.ValidatingType = typeof(int);
            // 
            // Txt_EkleMusteriSoyad
            // 
            Txt_EkleMusteriSoyad.Location = new Point(177, 78);
            Txt_EkleMusteriSoyad.Name = "Txt_EkleMusteriSoyad";
            Txt_EkleMusteriSoyad.Size = new Size(164, 31);
            Txt_EkleMusteriSoyad.TabIndex = 5;
            // 
            // Txt_EkleMusteriAd
            // 
            Txt_EkleMusteriAd.Location = new Point(177, 26);
            Txt_EkleMusteriAd.Name = "Txt_EkleMusteriAd";
            Txt_EkleMusteriAd.Size = new Size(164, 31);
            Txt_EkleMusteriAd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Adı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 3;
            label4.Text = "Telefon Numarası:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 1;
            label2.Text = "Müşteri Soyadı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 133);
            label3.Name = "label3";
            label3.Size = new Size(67, 25);
            label3.TabIndex = 2;
            label3.Text = "TC NO:";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Btn_MusteriGuncelle);
            groupBox5.Controls.Add(panel2);
            groupBox5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox5.Location = new Point(849, 544);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(680, 468);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "MÜŞTERİ BİLGİSİ GÜNCELLE";
            // 
            // Btn_MusteriGuncelle
            // 
            Btn_MusteriGuncelle.Cursor = Cursors.Hand;
            Btn_MusteriGuncelle.Location = new Point(281, 374);
            Btn_MusteriGuncelle.Name = "Btn_MusteriGuncelle";
            Btn_MusteriGuncelle.Size = new Size(145, 61);
            Btn_MusteriGuncelle.TabIndex = 10;
            Btn_MusteriGuncelle.Text = "GÜNCELLE";
            Btn_MusteriGuncelle.UseVisualStyleBackColor = true;
            Btn_MusteriGuncelle.Click += Btn_MusteriGuncelle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(Txt_GuncelleMusteriID);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(MskdTxt_GuncelleMusteriTel);
            panel2.Controls.Add(MskdTxt_GuncelleMusteriTc);
            panel2.Controls.Add(Txt_GuncelleMusteriSoyad);
            panel2.Controls.Add(Txt_GuncelleMusteriAd);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(151, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 289);
            panel2.TabIndex = 5;
            // 
            // Txt_GuncelleMusteriID
            // 
            Txt_GuncelleMusteriID.Location = new Point(186, 27);
            Txt_GuncelleMusteriID.Name = "Txt_GuncelleMusteriID";
            Txt_GuncelleMusteriID.Size = new Size(106, 31);
            Txt_GuncelleMusteriID.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 33);
            label9.Name = "label9";
            label9.Size = new Size(98, 25);
            label9.TabIndex = 8;
            label9.Text = "Müşteri ID:";
            // 
            // MskdTxt_GuncelleMusteriTel
            // 
            MskdTxt_GuncelleMusteriTel.Location = new Point(186, 223);
            MskdTxt_GuncelleMusteriTel.Mask = "(999) 000-0000";
            MskdTxt_GuncelleMusteriTel.Name = "MskdTxt_GuncelleMusteriTel";
            MskdTxt_GuncelleMusteriTel.Size = new Size(164, 31);
            MskdTxt_GuncelleMusteriTel.TabIndex = 7;
            // 
            // MskdTxt_GuncelleMusteriTc
            // 
            MskdTxt_GuncelleMusteriTc.Location = new Point(186, 176);
            MskdTxt_GuncelleMusteriTc.Mask = "00000000000";
            MskdTxt_GuncelleMusteriTc.Name = "MskdTxt_GuncelleMusteriTc";
            MskdTxt_GuncelleMusteriTc.Size = new Size(164, 31);
            MskdTxt_GuncelleMusteriTc.TabIndex = 6;
            MskdTxt_GuncelleMusteriTc.ValidatingType = typeof(int);
            // 
            // Txt_GuncelleMusteriSoyad
            // 
            Txt_GuncelleMusteriSoyad.Location = new Point(186, 127);
            Txt_GuncelleMusteriSoyad.Name = "Txt_GuncelleMusteriSoyad";
            Txt_GuncelleMusteriSoyad.Size = new Size(164, 31);
            Txt_GuncelleMusteriSoyad.TabIndex = 5;
            // 
            // Txt_GuncelleMusteriAd
            // 
            Txt_GuncelleMusteriAd.Location = new Point(186, 75);
            Txt_GuncelleMusteriAd.Name = "Txt_GuncelleMusteriAd";
            Txt_GuncelleMusteriAd.Size = new Size(164, 31);
            Txt_GuncelleMusteriAd.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 81);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 0;
            label5.Text = "Müşteri Adı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 229);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 3;
            label6.Text = "Telefon Numarası:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 133);
            label7.Name = "label7";
            label7.Size = new Size(134, 25);
            label7.TabIndex = 1;
            label7.Text = "Müşteri Soyadı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(21, 182);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 2;
            label8.Text = "TC NO:";
            // 
            // MusteriControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "MusteriControl";
            Size = new Size(1561, 1102);
            Load += MusteriControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_MusteriListele).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGrid_MusteriListele;
        private GroupBox groupBox1;
        private Button Btn_MusteriYenile;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private MaskedTextBox MskdTxt_EkleMusteriTel;
        private MaskedTextBox MskdTxt_EkleMusteriTc;
        private TextBox Txt_EkleMusteriSoyad;
        private TextBox Txt_EkleMusteriAd;
        private Panel panel2;
        private MaskedTextBox MskdTxt_GuncelleMusteriTel;
        private MaskedTextBox MskdTxt_GuncelleMusteriTc;
        private TextBox Txt_GuncelleMusteriSoyad;
        private TextBox Txt_GuncelleMusteriAd;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel3;
        private TextBox Txt_SilMusteri_ID;
        private Label label10;
        private Button Btn_MusteriEkle;
        private Button Btn_MusteriGuncelle;
        private TextBox Txt_GuncelleMusteriID;
        private Button Btn_MusteriSil;
        private Button Btn_MusteriAra;
        private TextBox Txt_MusteriAra;
        private Label label11;
    }
}
