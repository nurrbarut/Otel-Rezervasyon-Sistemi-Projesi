namespace OtelRezervasyonSistemi
{
    partial class FaturaGoruntuleControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaGoruntuleControl));
            groupBox1 = new GroupBox();
            Btn_FaturaYenile = new Button();
            Btn_FaturaAra = new Button();
            Txt_FaturaAra = new TextBox();
            label1 = new Label();
            dataGrid_FaturaGoruntule = new DataGridView();
            groupBox2 = new GroupBox();
            Btn_FaturaEkle = new Button();
            panel1 = new Panel();
            comboBox_FaturaEkleOdemeTutarı = new ComboBox();
            comboBox_EkleFatura = new ComboBox();
            radioButton_EkleFaturaKart = new RadioButton();
            radioButton_EkleFaturaNakit = new RadioButton();
            Txt_EkleFaturaRezID = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            Btn_FaturaGuncelle = new Button();
            panel2 = new Panel();
            comboBox_FaturaGuncelleOdemeTutarı = new ComboBox();
            textBox1 = new TextBox();
            label12 = new Label();
            comboBox_GuncelleFaturaDurum = new ComboBox();
            radioBtn_GuncelleFaturaKart = new RadioButton();
            radioBtn_GuncelleFaturaNakit = new RadioButton();
            dateTime_GuncelleFaturaTarih = new DateTimePicker();
            Txt_GuncelleRezID = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            panel3 = new Panel();
            label13 = new Label();
            Btn_FaturaSil = new Button();
            Txt_FaturaSil = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_FaturaGoruntule).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel2.SuspendLayout();
            groupBox4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Btn_FaturaYenile);
            groupBox1.Controls.Add(Btn_FaturaAra);
            groupBox1.Controls.Add(Txt_FaturaAra);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGrid_FaturaGoruntule);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(52, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(880, 727);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fatura Görüntüle:";
            // 
            // Btn_FaturaYenile
            // 
            Btn_FaturaYenile.BackColor = Color.LavenderBlush;
            Btn_FaturaYenile.Cursor = Cursors.Hand;
            Btn_FaturaYenile.Image = (Image)resources.GetObject("Btn_FaturaYenile.Image");
            Btn_FaturaYenile.Location = new Point(776, 47);
            Btn_FaturaYenile.Name = "Btn_FaturaYenile";
            Btn_FaturaYenile.Size = new Size(60, 49);
            Btn_FaturaYenile.TabIndex = 14;
            Btn_FaturaYenile.UseVisualStyleBackColor = false;
            Btn_FaturaYenile.Click += Btn_FaturaYenile_Click;
            // 
            // Btn_FaturaAra
            // 
            Btn_FaturaAra.BackColor = Color.LavenderBlush;
            Btn_FaturaAra.Cursor = Cursors.Hand;
            Btn_FaturaAra.Image = (Image)resources.GetObject("Btn_FaturaAra.Image");
            Btn_FaturaAra.Location = new Point(199, 61);
            Btn_FaturaAra.Name = "Btn_FaturaAra";
            Btn_FaturaAra.Size = new Size(46, 42);
            Btn_FaturaAra.TabIndex = 13;
            Btn_FaturaAra.UseVisualStyleBackColor = false;
            Btn_FaturaAra.Click += Btn_FaturaAra_Click;
            // 
            // Txt_FaturaAra
            // 
            Txt_FaturaAra.Font = new Font("Segoe UI", 10.8F);
            Txt_FaturaAra.Location = new Point(130, 68);
            Txt_FaturaAra.Name = "Txt_FaturaAra";
            Txt_FaturaAra.Size = new Size(63, 31);
            Txt_FaturaAra.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(37, 71);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 11;
            label1.Text = "Fatura ID:";
            // 
            // dataGrid_FaturaGoruntule
            // 
            dataGrid_FaturaGoruntule.BackgroundColor = Color.LavenderBlush;
            dataGrid_FaturaGoruntule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_FaturaGoruntule.Location = new Point(37, 121);
            dataGrid_FaturaGoruntule.Name = "dataGrid_FaturaGoruntule";
            dataGrid_FaturaGoruntule.RowHeadersWidth = 51;
            dataGrid_FaturaGoruntule.Size = new Size(799, 561);
            dataGrid_FaturaGoruntule.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn_FaturaEkle);
            groupBox2.Controls.Add(panel1);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(973, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(539, 469);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Fatura Oluştur:";
            // 
            // Btn_FaturaEkle
            // 
            Btn_FaturaEkle.Cursor = Cursors.Hand;
            Btn_FaturaEkle.Font = new Font("Segoe UI", 10F);
            Btn_FaturaEkle.Location = new Point(199, 378);
            Btn_FaturaEkle.Name = "Btn_FaturaEkle";
            Btn_FaturaEkle.Size = new Size(133, 60);
            Btn_FaturaEkle.TabIndex = 16;
            Btn_FaturaEkle.Text = "KAYDET";
            Btn_FaturaEkle.UseVisualStyleBackColor = true;
            Btn_FaturaEkle.Click += Btn_FaturaEkle_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(comboBox_FaturaEkleOdemeTutarı);
            panel1.Controls.Add(comboBox_EkleFatura);
            panel1.Controls.Add(radioButton_EkleFaturaKart);
            panel1.Controls.Add(radioButton_EkleFaturaNakit);
            panel1.Controls.Add(Txt_EkleFaturaRezID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(35, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 298);
            panel1.TabIndex = 15;
            // 
            // comboBox_FaturaEkleOdemeTutarı
            // 
            comboBox_FaturaEkleOdemeTutarı.Cursor = Cursors.Hand;
            comboBox_FaturaEkleOdemeTutarı.Font = new Font("Segoe UI", 10F);
            comboBox_FaturaEkleOdemeTutarı.FormattingEnabled = true;
            comboBox_FaturaEkleOdemeTutarı.Items.AddRange(new object[] { "1800", "3200", "5000", "7200" });
            comboBox_FaturaEkleOdemeTutarı.Location = new Point(188, 102);
            comboBox_FaturaEkleOdemeTutarı.Name = "comboBox_FaturaEkleOdemeTutarı";
            comboBox_FaturaEkleOdemeTutarı.Size = new Size(151, 31);
            comboBox_FaturaEkleOdemeTutarı.TabIndex = 11;
            // 
            // comboBox_EkleFatura
            // 
            comboBox_EkleFatura.Cursor = Cursors.Hand;
            comboBox_EkleFatura.Font = new Font("Segoe UI", 10F);
            comboBox_EkleFatura.FormattingEnabled = true;
            comboBox_EkleFatura.Items.AddRange(new object[] { "ÖDENDİ", "ÖDENMEDİ" });
            comboBox_EkleFatura.Location = new Point(188, 214);
            comboBox_EkleFatura.Name = "comboBox_EkleFatura";
            comboBox_EkleFatura.Size = new Size(151, 31);
            comboBox_EkleFatura.TabIndex = 10;
            // 
            // radioButton_EkleFaturaKart
            // 
            radioButton_EkleFaturaKart.AutoSize = true;
            radioButton_EkleFaturaKart.Cursor = Cursors.Hand;
            radioButton_EkleFaturaKart.Font = new Font("Segoe UI", 10F);
            radioButton_EkleFaturaKart.Location = new Point(188, 158);
            radioButton_EkleFaturaKart.Name = "radioButton_EkleFaturaKart";
            radioButton_EkleFaturaKart.Size = new Size(62, 27);
            radioButton_EkleFaturaKart.TabIndex = 9;
            radioButton_EkleFaturaKart.TabStop = true;
            radioButton_EkleFaturaKart.Text = "Kart";
            radioButton_EkleFaturaKart.UseVisualStyleBackColor = true;
            // 
            // radioButton_EkleFaturaNakit
            // 
            radioButton_EkleFaturaNakit.AutoSize = true;
            radioButton_EkleFaturaNakit.Cursor = Cursors.Hand;
            radioButton_EkleFaturaNakit.Font = new Font("Segoe UI", 10F);
            radioButton_EkleFaturaNakit.Location = new Point(268, 160);
            radioButton_EkleFaturaNakit.Name = "radioButton_EkleFaturaNakit";
            radioButton_EkleFaturaNakit.Size = new Size(71, 27);
            radioButton_EkleFaturaNakit.TabIndex = 8;
            radioButton_EkleFaturaNakit.TabStop = true;
            radioButton_EkleFaturaNakit.Text = "Nakit";
            radioButton_EkleFaturaNakit.UseVisualStyleBackColor = true;
            // 
            // Txt_EkleFaturaRezID
            // 
            Txt_EkleFaturaRezID.Font = new Font("Segoe UI", 10F);
            Txt_EkleFaturaRezID.Location = new Point(188, 53);
            Txt_EkleFaturaRezID.Name = "Txt_EkleFaturaRezID";
            Txt_EkleFaturaRezID.Size = new Size(87, 30);
            Txt_EkleFaturaRezID.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(34, 217);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 4;
            label6.Text = "Ödenme Durumu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(34, 162);
            label5.Name = "label5";
            label5.Size = new Size(109, 23);
            label5.TabIndex = 3;
            label5.Text = "Ödeme Şekli:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(34, 105);
            label4.Name = "label4";
            label4.Size = new Size(119, 23);
            label4.TabIndex = 2;
            label4.Text = "Ödeme Tutarı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(34, 60);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 0;
            label2.Text = "Rezervasyon ID:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Btn_FaturaGuncelle);
            groupBox3.Controls.Add(panel2);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(973, 553);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(539, 448);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Fatura Düzenle:";
            // 
            // Btn_FaturaGuncelle
            // 
            Btn_FaturaGuncelle.Cursor = Cursors.Hand;
            Btn_FaturaGuncelle.Font = new Font("Segoe UI", 10F);
            Btn_FaturaGuncelle.Location = new Point(208, 367);
            Btn_FaturaGuncelle.Name = "Btn_FaturaGuncelle";
            Btn_FaturaGuncelle.Size = new Size(133, 60);
            Btn_FaturaGuncelle.TabIndex = 18;
            Btn_FaturaGuncelle.Text = "GÜNCELLE";
            Btn_FaturaGuncelle.UseVisualStyleBackColor = true;
            Btn_FaturaGuncelle.Click += Btn_FaturaGuncelle_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(comboBox_FaturaGuncelleOdemeTutarı);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(comboBox_GuncelleFaturaDurum);
            panel2.Controls.Add(radioBtn_GuncelleFaturaKart);
            panel2.Controls.Add(radioBtn_GuncelleFaturaNakit);
            panel2.Controls.Add(dateTime_GuncelleFaturaTarih);
            panel2.Controls.Add(Txt_GuncelleRezID);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Location = new Point(44, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 294);
            panel2.TabIndex = 17;
            // 
            // comboBox_FaturaGuncelleOdemeTutarı
            // 
            comboBox_FaturaGuncelleOdemeTutarı.Font = new Font("Segoe UI", 10F);
            comboBox_FaturaGuncelleOdemeTutarı.FormattingEnabled = true;
            comboBox_FaturaGuncelleOdemeTutarı.Items.AddRange(new object[] { "1800", "3200", "5000", "7200" });
            comboBox_FaturaGuncelleOdemeTutarı.Location = new Point(179, 153);
            comboBox_FaturaGuncelleOdemeTutarı.Name = "comboBox_FaturaGuncelleOdemeTutarı";
            comboBox_FaturaGuncelleOdemeTutarı.Size = new Size(151, 31);
            comboBox_FaturaGuncelleOdemeTutarı.TabIndex = 21;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F);
            textBox1.Location = new Point(179, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 30);
            textBox1.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(32, 24);
            label12.Name = "label12";
            label12.Size = new Size(83, 23);
            label12.TabIndex = 19;
            label12.Text = "Fatura ID:";
            // 
            // comboBox_GuncelleFaturaDurum
            // 
            comboBox_GuncelleFaturaDurum.Font = new Font("Segoe UI", 10F);
            comboBox_GuncelleFaturaDurum.FormattingEnabled = true;
            comboBox_GuncelleFaturaDurum.Items.AddRange(new object[] { "ÖDENDİ", "ÖDENMEDİ" });
            comboBox_GuncelleFaturaDurum.Location = new Point(179, 241);
            comboBox_GuncelleFaturaDurum.Name = "comboBox_GuncelleFaturaDurum";
            comboBox_GuncelleFaturaDurum.Size = new Size(151, 31);
            comboBox_GuncelleFaturaDurum.TabIndex = 10;
            // 
            // radioBtn_GuncelleFaturaKart
            // 
            radioBtn_GuncelleFaturaKart.AutoSize = true;
            radioBtn_GuncelleFaturaKart.Font = new Font("Segoe UI", 10F);
            radioBtn_GuncelleFaturaKart.Location = new Point(179, 203);
            radioBtn_GuncelleFaturaKart.Name = "radioBtn_GuncelleFaturaKart";
            radioBtn_GuncelleFaturaKart.Size = new Size(62, 27);
            radioBtn_GuncelleFaturaKart.TabIndex = 9;
            radioBtn_GuncelleFaturaKart.TabStop = true;
            radioBtn_GuncelleFaturaKart.Text = "Kart";
            radioBtn_GuncelleFaturaKart.UseVisualStyleBackColor = true;
            // 
            // radioBtn_GuncelleFaturaNakit
            // 
            radioBtn_GuncelleFaturaNakit.AutoSize = true;
            radioBtn_GuncelleFaturaNakit.Font = new Font("Segoe UI", 10F);
            radioBtn_GuncelleFaturaNakit.Location = new Point(256, 203);
            radioBtn_GuncelleFaturaNakit.Name = "radioBtn_GuncelleFaturaNakit";
            radioBtn_GuncelleFaturaNakit.Size = new Size(71, 27);
            radioBtn_GuncelleFaturaNakit.TabIndex = 8;
            radioBtn_GuncelleFaturaNakit.TabStop = true;
            radioBtn_GuncelleFaturaNakit.Text = "Nakit";
            radioBtn_GuncelleFaturaNakit.UseVisualStyleBackColor = true;
            // 
            // dateTime_GuncelleFaturaTarih
            // 
            dateTime_GuncelleFaturaTarih.CalendarFont = new Font("Segoe UI", 10F);
            dateTime_GuncelleFaturaTarih.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTime_GuncelleFaturaTarih.Location = new Point(179, 110);
            dateTime_GuncelleFaturaTarih.Name = "dateTime_GuncelleFaturaTarih";
            dateTime_GuncelleFaturaTarih.Size = new Size(158, 30);
            dateTime_GuncelleFaturaTarih.TabIndex = 7;
            // 
            // Txt_GuncelleRezID
            // 
            Txt_GuncelleRezID.Font = new Font("Segoe UI", 10F);
            Txt_GuncelleRezID.Location = new Point(179, 62);
            Txt_GuncelleRezID.Name = "Txt_GuncelleRezID";
            Txt_GuncelleRezID.Size = new Size(87, 30);
            Txt_GuncelleRezID.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(32, 249);
            label7.Name = "label7";
            label7.Size = new Size(148, 23);
            label7.TabIndex = 4;
            label7.Text = "Ödenme Durumu:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(32, 207);
            label8.Name = "label8";
            label8.Size = new Size(109, 23);
            label8.TabIndex = 3;
            label8.Text = "Ödeme Şekli:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(32, 161);
            label9.Name = "label9";
            label9.Size = new Size(119, 23);
            label9.TabIndex = 2;
            label9.Text = "Ödeme Tutarı:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(32, 116);
            label10.Name = "label10";
            label10.Size = new Size(106, 23);
            label10.TabIndex = 1;
            label10.Text = "Fatura Tarihi:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(32, 69);
            label11.Name = "label11";
            label11.Size = new Size(130, 23);
            label11.TabIndex = 0;
            label11.Text = "Rezervasyon ID:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(panel3);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(52, 801);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(880, 200);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Fatura Sil:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(Btn_FaturaSil);
            panel3.Controls.Add(Txt_FaturaSil);
            panel3.Location = new Point(216, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 125);
            panel3.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label13.Location = new Point(17, 53);
            label13.Name = "label13";
            label13.Size = new Size(87, 25);
            label13.TabIndex = 19;
            label13.Text = "Fatura ID:";
            // 
            // Btn_FaturaSil
            // 
            Btn_FaturaSil.Cursor = Cursors.Hand;
            Btn_FaturaSil.Font = new Font("Segoe UI", 10F);
            Btn_FaturaSil.Location = new Point(243, 36);
            Btn_FaturaSil.Name = "Btn_FaturaSil";
            Btn_FaturaSil.Size = new Size(93, 54);
            Btn_FaturaSil.TabIndex = 21;
            Btn_FaturaSil.Text = "SİL";
            Btn_FaturaSil.UseVisualStyleBackColor = true;
            Btn_FaturaSil.Click += Btn_FaturaSil_Click;
            // 
            // Txt_FaturaSil
            // 
            Txt_FaturaSil.Font = new Font("Segoe UI", 11F);
            Txt_FaturaSil.Location = new Point(110, 50);
            Txt_FaturaSil.Name = "Txt_FaturaSil";
            Txt_FaturaSil.Size = new Size(101, 32);
            Txt_FaturaSil.TabIndex = 20;
            // 
            // FaturaGoruntuleControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FaturaGoruntuleControl";
            Size = new Size(1565, 1102);
            Load += FaturaGoruntuleControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_FaturaGoruntule).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGrid_FaturaGoruntule;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button Btn_FaturaAra;
        private TextBox Txt_FaturaAra;
        private Label label1;
        private Button Btn_FaturaYenile;
        private Panel panel1;
        private TextBox Txt_EkleFaturaRezID;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button Btn_FaturaEkle;
        private ComboBox comboBox_EkleFatura;
        private RadioButton radioButton_EkleFaturaKart;
        private RadioButton radioButton_EkleFaturaNakit;
        private Button Btn_FaturaGuncelle;
        private Panel panel2;
        private ComboBox comboBox_GuncelleFaturaDurum;
        private RadioButton radioBtn_GuncelleFaturaKart;
        private RadioButton radioBtn_GuncelleFaturaNakit;
        private DateTimePicker dateTime_GuncelleFaturaTarih;
        private TextBox Txt_GuncelleRezID;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private Label label12;
        private Panel panel3;
        private Label label13;
        private Button Btn_FaturaSil;
        private TextBox Txt_FaturaSil;
        private ComboBox comboBox_FaturaEkleOdemeTutarı;
        private ComboBox comboBox_FaturaGuncelleOdemeTutarı;
    }
}
