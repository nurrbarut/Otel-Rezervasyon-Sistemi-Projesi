namespace OtelRezervasyonSistemi
{
    partial class YoneticiIslemleri_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiIslemleri_Control));
            groupBox1 = new GroupBox();
            Btn_YoneticiAra = new Button();
            Txt_YoneticiAra = new TextBox();
            label18 = new Label();
            Btn_YoneticiListesiYenile = new Button();
            dataGrid_YoneticiListele = new DataGridView();
            groupBox2 = new GroupBox();
            panel1 = new Panel();
            label17 = new Label();
            Txt_Sil_ID = new TextBox();
            Btn_SilYonetici = new Button();
            groupBox3 = new GroupBox();
            groupBox6 = new GroupBox();
            MskdTxt_EkleSifre = new MaskedTextBox();
            Txt_EkleKullaniciAdi = new TextBox();
            label8 = new Label();
            label7 = new Label();
            groupBox5 = new GroupBox();
            Txt_EkleYoneticiMail = new TextBox();
            MskdTxt_EkleYoneticiTel = new MaskedTextBox();
            radioBtn_Erkek = new RadioButton();
            label1 = new Label();
            radioBtn_Kadin = new RadioButton();
            Txt_EkleYoneticiAd = new TextBox();
            label6 = new Label();
            MskdTxt_EkleYoneticiTc = new MaskedTextBox();
            label2 = new Label();
            Txt_EkleYoneticiSoyad = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            Btn_YoneticiEkle = new Button();
            groupBox4 = new GroupBox();
            Btn_GuncelleYonetici = new Button();
            groupBox8 = new GroupBox();
            MskdTxt_GuncelleSifre = new MaskedTextBox();
            Txt_GuncelleKullaniciAdi = new TextBox();
            label15 = new Label();
            label16 = new Label();
            groupBox7 = new GroupBox();
            MskdTxt_GuncelleYoneticiTc = new MaskedTextBox();
            label13 = new Label();
            label9 = new Label();
            Txt_GuncelleYoneticiAdi = new TextBox();
            label11 = new Label();
            Txt_GuncelleYoneticiSoyadi = new TextBox();
            Txt_GuncelleID = new TextBox();
            label10 = new Label();
            Txt_GuncelleMail = new TextBox();
            MskdTxt_GuncelleTel = new MaskedTextBox();
            label12 = new Label();
            label14 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_YoneticiListele).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_YoneticiAra);
            groupBox1.Controls.Add(Txt_YoneticiAra);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(Btn_YoneticiListesiYenile);
            groupBox1.Controls.Add(dataGrid_YoneticiListele);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(48, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(882, 741);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yönetici Listele:";
            // 
            // Btn_YoneticiAra
            // 
            Btn_YoneticiAra.BackColor = Color.LavenderBlush;
            Btn_YoneticiAra.Cursor = Cursors.Hand;
            Btn_YoneticiAra.Image = (Image)resources.GetObject("Btn_YoneticiAra.Image");
            Btn_YoneticiAra.Location = new Point(208, 55);
            Btn_YoneticiAra.Name = "Btn_YoneticiAra";
            Btn_YoneticiAra.Size = new Size(46, 42);
            Btn_YoneticiAra.TabIndex = 10;
            Btn_YoneticiAra.UseVisualStyleBackColor = false;
            Btn_YoneticiAra.Click += Btn_YoneticiAra_Click;
            // 
            // Txt_YoneticiAra
            // 
            Txt_YoneticiAra.Font = new Font("Segoe UI", 10.8F);
            Txt_YoneticiAra.Location = new Point(139, 62);
            Txt_YoneticiAra.Name = "Txt_YoneticiAra";
            Txt_YoneticiAra.Size = new Size(63, 31);
            Txt_YoneticiAra.TabIndex = 9;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10.8F);
            label18.Location = new Point(34, 65);
            label18.Name = "label18";
            label18.Size = new Size(99, 25);
            label18.TabIndex = 8;
            label18.Text = "Yönetici ID:";
            // 
            // Btn_YoneticiListesiYenile
            // 
            Btn_YoneticiListesiYenile.BackColor = Color.LavenderBlush;
            Btn_YoneticiListesiYenile.Cursor = Cursors.Hand;
            Btn_YoneticiListesiYenile.Image = (Image)resources.GetObject("Btn_YoneticiListesiYenile.Image");
            Btn_YoneticiListesiYenile.Location = new Point(775, 41);
            Btn_YoneticiListesiYenile.Name = "Btn_YoneticiListesiYenile";
            Btn_YoneticiListesiYenile.Size = new Size(60, 49);
            Btn_YoneticiListesiYenile.TabIndex = 0;
            Btn_YoneticiListesiYenile.UseVisualStyleBackColor = false;
            Btn_YoneticiListesiYenile.Click += Btn_YoneticiListesiYenile_Click;
            // 
            // dataGrid_YoneticiListele
            // 
            dataGrid_YoneticiListele.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGrid_YoneticiListele.BackgroundColor = Color.LavenderBlush;
            dataGrid_YoneticiListele.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_YoneticiListele.Location = new Point(34, 116);
            dataGrid_YoneticiListele.Name = "dataGrid_YoneticiListele";
            dataGrid_YoneticiListele.RowHeadersWidth = 51;
            dataGrid_YoneticiListele.Size = new Size(801, 587);
            dataGrid_YoneticiListele.TabIndex = 0;
            dataGrid_YoneticiListele.CellClick += dataGrid_YoneticiListele_CellClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel1);
            groupBox2.Controls.Add(Btn_SilYonetici);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(48, 773);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(882, 201);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yönetici Sil:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(label17);
            panel1.Controls.Add(Txt_Sil_ID);
            panel1.Location = new Point(173, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(336, 117);
            panel1.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label17.Location = new Point(27, 47);
            label17.Name = "label17";
            label17.Size = new Size(99, 25);
            label17.TabIndex = 1;
            label17.Text = "Yönetici ID:";
            // 
            // Txt_Sil_ID
            // 
            Txt_Sil_ID.Location = new Point(146, 41);
            Txt_Sil_ID.Name = "Txt_Sil_ID";
            Txt_Sil_ID.Size = new Size(87, 34);
            Txt_Sil_ID.TabIndex = 2;
            // 
            // Btn_SilYonetici
            // 
            Btn_SilYonetici.Cursor = Cursors.Hand;
            Btn_SilYonetici.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_SilYonetici.Location = new Point(583, 78);
            Btn_SilYonetici.Name = "Btn_SilYonetici";
            Btn_SilYonetici.Size = new Size(125, 62);
            Btn_SilYonetici.TabIndex = 0;
            Btn_SilYonetici.Text = "SİL";
            Btn_SilYonetici.UseVisualStyleBackColor = true;
            Btn_SilYonetici.Click += Btn_SilYonetici_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(groupBox6);
            groupBox3.Controls.Add(groupBox5);
            groupBox3.Controls.Add(Btn_YoneticiEkle);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(947, 26);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(604, 455);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Yeni Yönetici:";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.LavenderBlush;
            groupBox6.Controls.Add(MskdTxt_EkleSifre);
            groupBox6.Controls.Add(Txt_EkleKullaniciAdi);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(label7);
            groupBox6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox6.Location = new Point(347, 44);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(251, 288);
            groupBox6.TabIndex = 12;
            groupBox6.TabStop = false;
            groupBox6.Text = "Hesap Bilgileri:";
            // 
            // MskdTxt_EkleSifre
            // 
            MskdTxt_EkleSifre.Location = new Point(127, 152);
            MskdTxt_EkleSifre.Mask = "000000";
            MskdTxt_EkleSifre.Name = "MskdTxt_EkleSifre";
            MskdTxt_EkleSifre.Size = new Size(104, 30);
            MskdTxt_EkleSifre.TabIndex = 16;
            MskdTxt_EkleSifre.ValidatingType = typeof(int);
            // 
            // Txt_EkleKullaniciAdi
            // 
            Txt_EkleKullaniciAdi.Location = new Point(127, 103);
            Txt_EkleKullaniciAdi.Name = "Txt_EkleKullaniciAdi";
            Txt_EkleKullaniciAdi.Size = new Size(104, 30);
            Txt_EkleKullaniciAdi.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 159);
            label8.Name = "label8";
            label8.Size = new Size(47, 23);
            label8.TabIndex = 14;
            label8.Text = "Şifre:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 110);
            label7.Name = "label7";
            label7.Size = new Size(107, 23);
            label7.TabIndex = 13;
            label7.Text = "Kullanıcı Adı:";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.LavenderBlush;
            groupBox5.Controls.Add(Txt_EkleYoneticiMail);
            groupBox5.Controls.Add(MskdTxt_EkleYoneticiTel);
            groupBox5.Controls.Add(radioBtn_Erkek);
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(radioBtn_Kadin);
            groupBox5.Controls.Add(Txt_EkleYoneticiAd);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(MskdTxt_EkleYoneticiTc);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(Txt_EkleYoneticiSoyad);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(label4);
            groupBox5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox5.Location = new Point(6, 44);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(335, 288);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Kişisel Bilgiler:";
            // 
            // Txt_EkleYoneticiMail
            // 
            Txt_EkleYoneticiMail.Location = new Point(128, 238);
            Txt_EkleYoneticiMail.Name = "Txt_EkleYoneticiMail";
            Txt_EkleYoneticiMail.Size = new Size(198, 30);
            Txt_EkleYoneticiMail.TabIndex = 6;
            // 
            // MskdTxt_EkleYoneticiTel
            // 
            MskdTxt_EkleYoneticiTel.Location = new Point(128, 196);
            MskdTxt_EkleYoneticiTel.Mask = "(999) 000-0000";
            MskdTxt_EkleYoneticiTel.Name = "MskdTxt_EkleYoneticiTel";
            MskdTxt_EkleYoneticiTel.Size = new Size(198, 30);
            MskdTxt_EkleYoneticiTel.TabIndex = 7;
            // 
            // radioBtn_Erkek
            // 
            radioBtn_Erkek.AutoSize = true;
            radioBtn_Erkek.Cursor = Cursors.Hand;
            radioBtn_Erkek.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            radioBtn_Erkek.Location = new Point(226, 127);
            radioBtn_Erkek.Name = "radioBtn_Erkek";
            radioBtn_Erkek.Size = new Size(71, 27);
            radioBtn_Erkek.TabIndex = 10;
            radioBtn_Erkek.TabStop = true;
            radioBtn_Erkek.Text = "Erkek";
            radioBtn_Erkek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 49);
            label1.Name = "label1";
            label1.Size = new Size(39, 23);
            label1.TabIndex = 0;
            label1.Text = "Adı:";
            // 
            // radioBtn_Kadin
            // 
            radioBtn_Kadin.AutoSize = true;
            radioBtn_Kadin.Cursor = Cursors.Hand;
            radioBtn_Kadin.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            radioBtn_Kadin.Location = new Point(137, 127);
            radioBtn_Kadin.Name = "radioBtn_Kadin";
            radioBtn_Kadin.Size = new Size(74, 27);
            radioBtn_Kadin.TabIndex = 9;
            radioBtn_Kadin.TabStop = true;
            radioBtn_Kadin.Text = "Kadın";
            radioBtn_Kadin.UseVisualStyleBackColor = true;
            // 
            // Txt_EkleYoneticiAd
            // 
            Txt_EkleYoneticiAd.Location = new Point(128, 42);
            Txt_EkleYoneticiAd.Name = "Txt_EkleYoneticiAd";
            Txt_EkleYoneticiAd.Size = new Size(198, 30);
            Txt_EkleYoneticiAd.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 127);
            label6.Name = "label6";
            label6.Size = new Size(73, 23);
            label6.TabIndex = 8;
            label6.Text = "Cinsiyet:";
            // 
            // MskdTxt_EkleYoneticiTc
            // 
            MskdTxt_EkleYoneticiTc.Location = new Point(128, 159);
            MskdTxt_EkleYoneticiTc.Mask = "00000000000";
            MskdTxt_EkleYoneticiTc.Name = "MskdTxt_EkleYoneticiTc";
            MskdTxt_EkleYoneticiTc.Size = new Size(198, 30);
            MskdTxt_EkleYoneticiTc.TabIndex = 2;
            MskdTxt_EkleYoneticiTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 87);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Soyadı:";
            // 
            // Txt_EkleYoneticiSoyad
            // 
            Txt_EkleYoneticiSoyad.Location = new Point(128, 84);
            Txt_EkleYoneticiSoyad.Name = "Txt_EkleYoneticiSoyad";
            Txt_EkleYoneticiSoyad.Size = new Size(198, 30);
            Txt_EkleYoneticiSoyad.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 245);
            label5.Name = "label5";
            label5.Size = new Size(98, 23);
            label5.TabIndex = 4;
            label5.Text = "Mail Adresi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 166);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 2;
            label3.Text = "TC No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 203);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 3;
            label4.Text = "Tel No:";
            // 
            // Btn_YoneticiEkle
            // 
            Btn_YoneticiEkle.Cursor = Cursors.Hand;
            Btn_YoneticiEkle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_YoneticiEkle.Location = new Point(249, 357);
            Btn_YoneticiEkle.Name = "Btn_YoneticiEkle";
            Btn_YoneticiEkle.Size = new Size(177, 76);
            Btn_YoneticiEkle.TabIndex = 2;
            Btn_YoneticiEkle.Text = "KAYDET";
            Btn_YoneticiEkle.UseVisualStyleBackColor = true;
            Btn_YoneticiEkle.Click += Btn_YoneticiEkle_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Btn_GuncelleYonetici);
            groupBox4.Controls.Add(groupBox8);
            groupBox4.Controls.Add(groupBox7);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(947, 487);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(604, 487);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Yönetici Bilgilerini Güncelle:";
            // 
            // Btn_GuncelleYonetici
            // 
            Btn_GuncelleYonetici.Cursor = Cursors.Hand;
            Btn_GuncelleYonetici.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_GuncelleYonetici.Location = new Point(249, 369);
            Btn_GuncelleYonetici.Name = "Btn_GuncelleYonetici";
            Btn_GuncelleYonetici.Size = new Size(177, 76);
            Btn_GuncelleYonetici.TabIndex = 14;
            Btn_GuncelleYonetici.Text = "GÜNCELLE";
            Btn_GuncelleYonetici.UseVisualStyleBackColor = true;
            Btn_GuncelleYonetici.Click += Btn_GuncelleYonetici_Click;
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.LavenderBlush;
            groupBox8.Controls.Add(MskdTxt_GuncelleSifre);
            groupBox8.Controls.Add(Txt_GuncelleKullaniciAdi);
            groupBox8.Controls.Add(label15);
            groupBox8.Controls.Add(label16);
            groupBox8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox8.Location = new Point(347, 50);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(251, 288);
            groupBox8.TabIndex = 13;
            groupBox8.TabStop = false;
            groupBox8.Text = "Hesap Bilgileri:";
            // 
            // MskdTxt_GuncelleSifre
            // 
            MskdTxt_GuncelleSifre.Location = new Point(127, 143);
            MskdTxt_GuncelleSifre.Mask = "000000";
            MskdTxt_GuncelleSifre.Name = "MskdTxt_GuncelleSifre";
            MskdTxt_GuncelleSifre.Size = new Size(104, 30);
            MskdTxt_GuncelleSifre.TabIndex = 16;
            MskdTxt_GuncelleSifre.ValidatingType = typeof(int);
            // 
            // Txt_GuncelleKullaniciAdi
            // 
            Txt_GuncelleKullaniciAdi.Location = new Point(127, 84);
            Txt_GuncelleKullaniciAdi.Name = "Txt_GuncelleKullaniciAdi";
            Txt_GuncelleKullaniciAdi.Size = new Size(104, 30);
            Txt_GuncelleKullaniciAdi.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(66, 150);
            label15.Name = "label15";
            label15.Size = new Size(47, 23);
            label15.TabIndex = 14;
            label15.Text = "Şifre:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(6, 91);
            label16.Name = "label16";
            label16.Size = new Size(107, 23);
            label16.TabIndex = 13;
            label16.Text = "Kullanıcı Adı:";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.LavenderBlush;
            groupBox7.Controls.Add(MskdTxt_GuncelleYoneticiTc);
            groupBox7.Controls.Add(label13);
            groupBox7.Controls.Add(label9);
            groupBox7.Controls.Add(Txt_GuncelleYoneticiAdi);
            groupBox7.Controls.Add(label11);
            groupBox7.Controls.Add(Txt_GuncelleYoneticiSoyadi);
            groupBox7.Controls.Add(Txt_GuncelleID);
            groupBox7.Controls.Add(label10);
            groupBox7.Controls.Add(Txt_GuncelleMail);
            groupBox7.Controls.Add(MskdTxt_GuncelleTel);
            groupBox7.Controls.Add(label12);
            groupBox7.Controls.Add(label14);
            groupBox7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox7.Location = new Point(6, 50);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(335, 288);
            groupBox7.TabIndex = 12;
            groupBox7.TabStop = false;
            groupBox7.Text = "Kişisel Bilgiler:";
            // 
            // MskdTxt_GuncelleYoneticiTc
            // 
            MskdTxt_GuncelleYoneticiTc.Location = new Point(128, 162);
            MskdTxt_GuncelleYoneticiTc.Mask = "00000000000";
            MskdTxt_GuncelleYoneticiTc.Name = "MskdTxt_GuncelleYoneticiTc";
            MskdTxt_GuncelleYoneticiTc.Size = new Size(198, 30);
            MskdTxt_GuncelleYoneticiTc.TabIndex = 21;
            MskdTxt_GuncelleYoneticiTc.ValidatingType = typeof(int);
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(17, 169);
            label13.Name = "label13";
            label13.Size = new Size(61, 23);
            label13.TabIndex = 22;
            label13.Text = "TC No:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 91);
            label9.Name = "label9";
            label9.Size = new Size(39, 23);
            label9.TabIndex = 17;
            label9.Text = "Adı:";
            // 
            // Txt_GuncelleYoneticiAdi
            // 
            Txt_GuncelleYoneticiAdi.Location = new Point(129, 84);
            Txt_GuncelleYoneticiAdi.Name = "Txt_GuncelleYoneticiAdi";
            Txt_GuncelleYoneticiAdi.Size = new Size(198, 30);
            Txt_GuncelleYoneticiAdi.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 129);
            label11.Name = "label11";
            label11.Size = new Size(64, 23);
            label11.TabIndex = 18;
            label11.Text = "Soyadı:";
            // 
            // Txt_GuncelleYoneticiSoyadi
            // 
            Txt_GuncelleYoneticiSoyadi.Location = new Point(129, 126);
            Txt_GuncelleYoneticiSoyadi.Name = "Txt_GuncelleYoneticiSoyadi";
            Txt_GuncelleYoneticiSoyadi.Size = new Size(198, 30);
            Txt_GuncelleYoneticiSoyadi.TabIndex = 20;
            // 
            // Txt_GuncelleID
            // 
            Txt_GuncelleID.Location = new Point(128, 46);
            Txt_GuncelleID.Name = "Txt_GuncelleID";
            Txt_GuncelleID.Size = new Size(69, 30);
            Txt_GuncelleID.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 53);
            label10.Name = "label10";
            label10.Size = new Size(31, 23);
            label10.TabIndex = 15;
            label10.Text = "ID:";
            // 
            // Txt_GuncelleMail
            // 
            Txt_GuncelleMail.Location = new Point(128, 236);
            Txt_GuncelleMail.Name = "Txt_GuncelleMail";
            Txt_GuncelleMail.Size = new Size(198, 30);
            Txt_GuncelleMail.TabIndex = 6;
            // 
            // MskdTxt_GuncelleTel
            // 
            MskdTxt_GuncelleTel.Location = new Point(128, 200);
            MskdTxt_GuncelleTel.Mask = "(999) 000-0000";
            MskdTxt_GuncelleTel.Name = "MskdTxt_GuncelleTel";
            MskdTxt_GuncelleTel.Size = new Size(198, 30);
            MskdTxt_GuncelleTel.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(17, 243);
            label12.Name = "label12";
            label12.Size = new Size(98, 23);
            label12.TabIndex = 4;
            label12.Text = "Mail Adresi:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 207);
            label14.Name = "label14";
            label14.Size = new Size(62, 23);
            label14.TabIndex = 3;
            label14.Text = "Tel No:";
            // 
            // YoneticiIslemleri_Control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "YoneticiIslemleri_Control";
            Size = new Size(1565, 1102);
            Load += YoneticiIslemleri_Control_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_YoneticiListele).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGrid_YoneticiListele;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button Btn_YoneticiListesiYenile;
        private TextBox Txt_EkleYoneticiAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Btn_YoneticiEkle;
        private MaskedTextBox MskdTxt_EkleYoneticiTel;
        private MaskedTextBox MskdTxt_EkleYoneticiTc;
        private TextBox Txt_EkleYoneticiMail;
        private TextBox Txt_EkleYoneticiSoyad;
        private RadioButton radioBtn_Erkek;
        private RadioButton radioBtn_Kadin;
        private Label label6;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label8;
        private Label label7;
        private MaskedTextBox MskdTxt_EkleSifre;
        private TextBox Txt_EkleKullaniciAdi;
        private Button Btn_GuncelleYonetici;
        private GroupBox groupBox8;
        private MaskedTextBox MskdTxt_GuncelleSifre;
        private TextBox Txt_GuncelleKullaniciAdi;
        private Label label15;
        private Label label16;
        private GroupBox groupBox7;
        private TextBox Txt_GuncelleMail;
        private MaskedTextBox MskdTxt_GuncelleTel;
        private Label label12;
        private Label label14;
        private TextBox Txt_GuncelleID;
        private Label label10;
        private MaskedTextBox MskdTxt_GuncelleYoneticiTc;
        private Label label13;
        private Label label9;
        private TextBox Txt_GuncelleYoneticiAdi;
        private Label label11;
        private TextBox Txt_GuncelleYoneticiSoyadi;
        private Panel panel1;
        private Label label17;
        private TextBox Txt_Sil_ID;
        private Button Btn_SilYonetici;
        private Button Btn_YoneticiAra;
        private TextBox Txt_YoneticiAra;
        private Label label18;
    }
}
