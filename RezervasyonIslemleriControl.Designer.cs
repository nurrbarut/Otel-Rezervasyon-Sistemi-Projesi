namespace OtelRezervasyonSistemi
{
    partial class RezervasyonIslemleriControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonIslemleriControl));
            groupBox1 = new GroupBox();
            panel_RezBilgileri = new Panel();
            label15 = new Label();
            Lbl_Misafirler = new Label();
            Lbl_RezSahibi = new Label();
            panel1 = new Panel();
            Btn_SilRez = new Button();
            Txt_SilRezID = new TextBox();
            label9 = new Label();
            Btn_RezListesiYenile = new Button();
            label5 = new Label();
            dateTimep_CikisTarihi = new DateTimePicker();
            pictureBox1 = new PictureBox();
            dateTimep_girisTarihi = new DateTimePicker();
            Btn_RezervasyonAra = new Button();
            label1 = new Label();
            dataGrid_ListeleRezervasyon = new DataGridView();
            groupBox2 = new GroupBox();
            Btn_EkleRez = new Button();
            panel2 = new Panel();
            checkedListBox_Misafir = new CheckedListBox();
            label6 = new Label();
            Txt_EkleRezOdaID = new TextBox();
            label2 = new Label();
            Txt_EkleRezMusteriID = new TextBox();
            label3 = new Label();
            label7 = new Label();
            dateTime_RezEkleGiris = new DateTimePicker();
            label8 = new Label();
            dateTime_RezEkleCikis = new DateTimePicker();
            groupBox3 = new GroupBox();
            Btn_GuncelleRez = new Button();
            panel3 = new Panel();
            comboBox_RezGuncelleDurum = new ComboBox();
            label4 = new Label();
            label10 = new Label();
            Txt_GuncelleRezOdaID = new TextBox();
            label11 = new Label();
            Txt_GuncellEMusteriID = new TextBox();
            label12 = new Label();
            Txt_GuncelleRezID = new TextBox();
            label13 = new Label();
            dateTime_RezGuncelleGiris = new DateTimePicker();
            label14 = new Label();
            dateTime_RezGuncelleCikis = new DateTimePicker();
            groupBox1.SuspendLayout();
            panel_RezBilgileri.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_ListeleRezervasyon).BeginInit();
            groupBox2.SuspendLayout();
            panel2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel_RezBilgileri);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(Btn_RezListesiYenile);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimep_CikisTarihi);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(dateTimep_girisTarihi);
            groupBox1.Controls.Add(Btn_RezervasyonAra);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGrid_ListeleRezervasyon);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(36, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(924, 969);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rezervasyon Listesi:";
            // 
            // panel_RezBilgileri
            // 
            panel_RezBilgileri.BackColor = Color.AliceBlue;
            panel_RezBilgileri.Controls.Add(label15);
            panel_RezBilgileri.Controls.Add(Lbl_Misafirler);
            panel_RezBilgileri.Controls.Add(Lbl_RezSahibi);
            panel_RezBilgileri.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            panel_RezBilgileri.Location = new Point(550, 101);
            panel_RezBilgileri.Name = "panel_RezBilgileri";
            panel_RezBilgileri.Size = new Size(158, 200);
            panel_RezBilgileri.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Corbel", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label15.Location = new Point(0, 11);
            label15.Name = "label15";
            label15.Size = new Size(163, 21);
            label15.TabIndex = 2;
            label15.Text = "Rezervasyon Bilgileri";
            // 
            // Lbl_Misafirler
            // 
            Lbl_Misafirler.AutoSize = true;
            Lbl_Misafirler.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Lbl_Misafirler.ForeColor = SystemColors.ControlText;
            Lbl_Misafirler.Location = new Point(3, 99);
            Lbl_Misafirler.Name = "Lbl_Misafirler";
            Lbl_Misafirler.Size = new Size(0, 20);
            Lbl_Misafirler.TabIndex = 1;
            // 
            // Lbl_RezSahibi
            // 
            Lbl_RezSahibi.AutoSize = true;
            Lbl_RezSahibi.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Lbl_RezSahibi.ForeColor = SystemColors.ControlText;
            Lbl_RezSahibi.Location = new Point(3, 40);
            Lbl_RezSahibi.Name = "Lbl_RezSahibi";
            Lbl_RezSahibi.Size = new Size(0, 20);
            Lbl_RezSahibi.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(Btn_SilRez);
            panel1.Controls.Add(Txt_SilRezID);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(18, 200);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 101);
            panel1.TabIndex = 1;
            // 
            // Btn_SilRez
            // 
            Btn_SilRez.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_SilRez.Location = new Point(292, 23);
            Btn_SilRez.Name = "Btn_SilRez";
            Btn_SilRez.Size = new Size(129, 51);
            Btn_SilRez.TabIndex = 2;
            Btn_SilRez.Text = "İPTAL";
            Btn_SilRez.UseVisualStyleBackColor = true;
            Btn_SilRez.Click += Btn_SilRez_Click;
            // 
            // Txt_SilRezID
            // 
            Txt_SilRezID.Location = new Point(161, 29);
            Txt_SilRezID.Name = "Txt_SilRezID";
            Txt_SilRezID.Size = new Size(125, 34);
            Txt_SilRezID.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(16, 37);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 0;
            label9.Text = "Rezervasyon ID:";
            // 
            // Btn_RezListesiYenile
            // 
            Btn_RezListesiYenile.BackColor = Color.LavenderBlush;
            Btn_RezListesiYenile.Cursor = Cursors.Hand;
            Btn_RezListesiYenile.Image = (Image)resources.GetObject("Btn_RezListesiYenile.Image");
            Btn_RezListesiYenile.Location = new Point(840, 33);
            Btn_RezListesiYenile.Name = "Btn_RezListesiYenile";
            Btn_RezListesiYenile.Size = new Size(78, 58);
            Btn_RezListesiYenile.TabIndex = 2;
            Btn_RezListesiYenile.UseVisualStyleBackColor = false;
            Btn_RezListesiYenile.Click += Btn_RezListesiYenile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(18, 141);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 13;
            label5.Text = "Çıkış Tarihi:";
            // 
            // dateTimep_CikisTarihi
            // 
            dateTimep_CikisTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimep_CikisTarihi.Location = new Point(129, 137);
            dateTimep_CikisTarihi.Name = "dateTimep_CikisTarihi";
            dateTimep_CikisTarihi.Size = new Size(250, 30);
            dateTimep_CikisTarihi.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(486, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // dateTimep_girisTarihi
            // 
            dateTimep_girisTarihi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimep_girisTarihi.Location = new Point(129, 94);
            dateTimep_girisTarihi.Name = "dateTimep_girisTarihi";
            dateTimep_girisTarihi.Size = new Size(250, 30);
            dateTimep_girisTarihi.TabIndex = 11;
            // 
            // Btn_RezervasyonAra
            // 
            Btn_RezervasyonAra.BackColor = Color.LavenderBlush;
            Btn_RezervasyonAra.Image = (Image)resources.GetObject("Btn_RezervasyonAra.Image");
            Btn_RezervasyonAra.Location = new Point(394, 101);
            Btn_RezervasyonAra.Name = "Btn_RezervasyonAra";
            Btn_RezervasyonAra.Size = new Size(56, 54);
            Btn_RezervasyonAra.TabIndex = 10;
            Btn_RezervasyonAra.UseVisualStyleBackColor = false;
            Btn_RezervasyonAra.Click += Btn_RezervasyonAra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(18, 99);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 8;
            label1.Text = "Giriş Tarihi:";
            // 
            // dataGrid_ListeleRezervasyon
            // 
            dataGrid_ListeleRezervasyon.BackgroundColor = Color.LavenderBlush;
            dataGrid_ListeleRezervasyon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_ListeleRezervasyon.Location = new Point(18, 353);
            dataGrid_ListeleRezervasyon.Name = "dataGrid_ListeleRezervasyon";
            dataGrid_ListeleRezervasyon.RowHeadersWidth = 51;
            dataGrid_ListeleRezervasyon.Size = new Size(882, 579);
            dataGrid_ListeleRezervasyon.TabIndex = 0;
            dataGrid_ListeleRezervasyon.CellFormatting += dataGrid_ListeleRezervasyon_CellFormatting;
            dataGrid_ListeleRezervasyon.SelectionChanged += dataGrid_ListeleRezervasyon_SelectionChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn_EkleRez);
            groupBox2.Controls.Add(panel2);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(966, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 456);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Rezervasyon:";
            // 
            // Btn_EkleRez
            // 
            Btn_EkleRez.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_EkleRez.Location = new Point(208, 371);
            Btn_EkleRez.Name = "Btn_EkleRez";
            Btn_EkleRez.Size = new Size(147, 68);
            Btn_EkleRez.TabIndex = 10;
            Btn_EkleRez.Text = "KAYDET";
            Btn_EkleRez.UseVisualStyleBackColor = true;
            Btn_EkleRez.Click += Btn_EkleRez_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(checkedListBox_Misafir);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Txt_EkleRezOdaID);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Txt_EkleRezMusteriID);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(dateTime_RezEkleGiris);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(dateTime_RezEkleCikis);
            panel2.Location = new Point(6, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(555, 284);
            panel2.TabIndex = 10;
            // 
            // checkedListBox_Misafir
            // 
            checkedListBox_Misafir.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkedListBox_Misafir.FormattingEnabled = true;
            checkedListBox_Misafir.Location = new Point(294, 125);
            checkedListBox_Misafir.Name = "checkedListBox_Misafir";
            checkedListBox_Misafir.Size = new Size(250, 144);
            checkedListBox_Misafir.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F);
            label6.Location = new Point(294, 99);
            label6.Name = "label6";
            label6.Size = new Size(121, 23);
            label6.TabIndex = 10;
            label6.Text = "Misafir Seçiniz:";
            // 
            // Txt_EkleRezOdaID
            // 
            Txt_EkleRezOdaID.Font = new Font("Segoe UI", 10.2F);
            Txt_EkleRezOdaID.Location = new Point(129, 190);
            Txt_EkleRezOdaID.Name = "Txt_EkleRezOdaID";
            Txt_EkleRezOdaID.Size = new Size(66, 30);
            Txt_EkleRezOdaID.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(15, 156);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 1;
            label2.Text = "Müşteri ID:";
            // 
            // Txt_EkleRezMusteriID
            // 
            Txt_EkleRezMusteriID.Font = new Font("Segoe UI", 10.2F);
            Txt_EkleRezMusteriID.Location = new Point(129, 149);
            Txt_EkleRezMusteriID.Name = "Txt_EkleRezMusteriID";
            Txt_EkleRezMusteriID.Size = new Size(66, 30);
            Txt_EkleRezMusteriID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F);
            label3.Location = new Point(15, 197);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 2;
            label3.Text = "Oda ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F);
            label7.Location = new Point(15, 18);
            label7.Name = "label7";
            label7.Size = new Size(92, 23);
            label7.TabIndex = 3;
            label7.Text = "Giriş Tarihi:";
            // 
            // dateTime_RezEkleGiris
            // 
            dateTime_RezEkleGiris.Font = new Font("Segoe UI", 10.2F);
            dateTime_RezEkleGiris.Location = new Point(15, 47);
            dateTime_RezEkleGiris.Name = "dateTime_RezEkleGiris";
            dateTime_RezEkleGiris.Size = new Size(250, 30);
            dateTime_RezEkleGiris.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F);
            label8.Location = new Point(294, 18);
            label8.Name = "label8";
            label8.Size = new Size(93, 23);
            label8.TabIndex = 4;
            label8.Text = "Çıkış Tarihi:";
            // 
            // dateTime_RezEkleCikis
            // 
            dateTime_RezEkleCikis.Font = new Font("Segoe UI", 10.2F);
            dateTime_RezEkleCikis.Location = new Point(294, 47);
            dateTime_RezEkleCikis.Name = "dateTime_RezEkleCikis";
            dateTime_RezEkleCikis.Size = new Size(250, 30);
            dateTime_RezEkleCikis.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Btn_GuncelleRez);
            groupBox3.Controls.Add(panel3);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(966, 506);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(582, 494);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rezervasyon Güncelle:";
            // 
            // Btn_GuncelleRez
            // 
            Btn_GuncelleRez.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_GuncelleRez.Location = new Point(228, 404);
            Btn_GuncelleRez.Name = "Btn_GuncelleRez";
            Btn_GuncelleRez.Size = new Size(147, 68);
            Btn_GuncelleRez.TabIndex = 12;
            Btn_GuncelleRez.Text = "GÜNCELLE";
            Btn_GuncelleRez.UseVisualStyleBackColor = true;
            Btn_GuncelleRez.Click += Btn_GuncelleRez_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(comboBox_RezGuncelleDurum);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(Txt_GuncelleRezOdaID);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(Txt_GuncellEMusteriID);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(Txt_GuncelleRezID);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(dateTime_RezGuncelleGiris);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(dateTime_RezGuncelleCikis);
            panel3.Location = new Point(34, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(495, 305);
            panel3.TabIndex = 11;
            // 
            // comboBox_RezGuncelleDurum
            // 
            comboBox_RezGuncelleDurum.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox_RezGuncelleDurum.FormattingEnabled = true;
            comboBox_RezGuncelleDurum.Items.AddRange(new object[] { "AKTİF", "PASİF" });
            comboBox_RezGuncelleDurum.Location = new Point(187, 240);
            comboBox_RezGuncelleDurum.Name = "comboBox_RezGuncelleDurum";
            comboBox_RezGuncelleDurum.Size = new Size(151, 31);
            comboBox_RezGuncelleDurum.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(53, 248);
            label4.Name = "label4";
            label4.Size = new Size(67, 23);
            label4.TabIndex = 10;
            label4.Text = "Durum:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F);
            label10.Location = new Point(53, 19);
            label10.Name = "label10";
            label10.Size = new Size(130, 23);
            label10.TabIndex = 0;
            label10.Text = "Rezervasyon ID:";
            // 
            // Txt_GuncelleRezOdaID
            // 
            Txt_GuncelleRezOdaID.Font = new Font("Segoe UI", 10.2F);
            Txt_GuncelleRezOdaID.Location = new Point(187, 108);
            Txt_GuncelleRezOdaID.Name = "Txt_GuncelleRezOdaID";
            Txt_GuncelleRezOdaID.Size = new Size(66, 30);
            Txt_GuncelleRezOdaID.TabIndex = 9;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10.2F);
            label11.Location = new Point(53, 67);
            label11.Name = "label11";
            label11.Size = new Size(93, 23);
            label11.TabIndex = 1;
            label11.Text = "Müşteri ID:";
            // 
            // Txt_GuncellEMusteriID
            // 
            Txt_GuncellEMusteriID.Font = new Font("Segoe UI", 10.2F);
            Txt_GuncellEMusteriID.Location = new Point(187, 60);
            Txt_GuncellEMusteriID.Name = "Txt_GuncellEMusteriID";
            Txt_GuncellEMusteriID.Size = new Size(66, 30);
            Txt_GuncellEMusteriID.TabIndex = 8;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F);
            label12.Location = new Point(53, 115);
            label12.Name = "label12";
            label12.Size = new Size(68, 23);
            label12.TabIndex = 2;
            label12.Text = "Oda ID:";
            // 
            // Txt_GuncelleRezID
            // 
            Txt_GuncelleRezID.Font = new Font("Segoe UI", 10.2F);
            Txt_GuncelleRezID.Location = new Point(187, 19);
            Txt_GuncelleRezID.Name = "Txt_GuncelleRezID";
            Txt_GuncelleRezID.Size = new Size(66, 30);
            Txt_GuncelleRezID.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.2F);
            label13.Location = new Point(53, 159);
            label13.Name = "label13";
            label13.Size = new Size(92, 23);
            label13.TabIndex = 3;
            label13.Text = "Giriş Tarihi:";
            // 
            // dateTime_RezGuncelleGiris
            // 
            dateTime_RezGuncelleGiris.Font = new Font("Segoe UI", 10.2F);
            dateTime_RezGuncelleGiris.Location = new Point(187, 153);
            dateTime_RezGuncelleGiris.Name = "dateTime_RezGuncelleGiris";
            dateTime_RezGuncelleGiris.Size = new Size(250, 30);
            dateTime_RezGuncelleGiris.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10.2F);
            label14.Location = new Point(53, 205);
            label14.Name = "label14";
            label14.Size = new Size(93, 23);
            label14.TabIndex = 4;
            label14.Text = "Çıkış Tarihi:";
            // 
            // dateTime_RezGuncelleCikis
            // 
            dateTime_RezGuncelleCikis.Font = new Font("Segoe UI", 10.2F);
            dateTime_RezGuncelleCikis.Location = new Point(187, 199);
            dateTime_RezGuncelleCikis.Name = "dateTime_RezGuncelleCikis";
            dateTime_RezGuncelleCikis.Size = new Size(250, 30);
            dateTime_RezGuncelleCikis.TabIndex = 5;
            // 
            // RezervasyonIslemleriControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "RezervasyonIslemleriControl";
            Size = new Size(1565, 1102);
            Load += RezervasyonIslemleriControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel_RezBilgileri.ResumeLayout(false);
            panel_RezBilgileri.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid_ListeleRezervasyon).EndInit();
            groupBox2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGrid_ListeleRezervasyon;
        private Button Btn_RezListesiYenile;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Label label9;
        private Button Btn_SilRez;
        private Panel panel1;
        private TextBox Txt_SilRezID;
        private Label label7;
        private Panel panel2;
        private Button Btn_EkleRez;
        private TextBox Txt_EkleRezOdaID;
        private TextBox Txt_EkleRezMusteriID;
        private DateTimePicker dateTime_RezEkleGiris;
        private Label label8;
        private DateTimePicker dateTime_RezEkleCikis;
        private Panel panel3;
        private ComboBox comboBox_RezGuncelleDurum;
        private Label label4;
        private Label label10;
        private TextBox Txt_GuncelleRezOdaID;
        private Label label11;
        private TextBox Txt_GuncellEMusteriID;
        private Label label12;
        private TextBox Txt_GuncelleRezID;
        private Label label13;
        private DateTimePicker dateTime_RezGuncelleGiris;
        private Label label14;
        private DateTimePicker dateTime_RezGuncelleCikis;
        private Button Btn_GuncelleRez;
        private Button Btn_RezervasyonAra;
        private Label label1;
        private Label label5;
        private DateTimePicker dateTimep_CikisTarihi;
        private DateTimePicker dateTimep_girisTarihi;
        private PictureBox pictureBox1;
        private CheckedListBox checkedListBox_Misafir;
        private Label label6;
        private Panel panel_RezBilgileri;
        private Label Lbl_RezSahibi;
        private Label Lbl_Misafirler;
        private Label label15;
    }
}
