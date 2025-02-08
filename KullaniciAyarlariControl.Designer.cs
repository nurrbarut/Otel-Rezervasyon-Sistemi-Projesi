namespace OtelRezervasyonSistemi
{
    partial class KullaniciAyarlariControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciAyarlariControl));
            Btn_KullaniciAdiGuncelle = new Button();
            Txt_KullaniciAdiGuncelle = new TextBox();
            label5 = new Label();
            MskdTxt_SifreGuncelle = new MaskedTextBox();
            Btn_SifreGuncelle = new Button();
            label6 = new Label();
            Btn_MailGuncelle = new Button();
            Txt_MailGuncelle = new TextBox();
            label7 = new Label();
            Btn_TelGuncelle = new Button();
            MskdTxt_TelGuncelle = new MaskedTextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Btn_KullaniciAdiGuncelle
            // 
            Btn_KullaniciAdiGuncelle.Cursor = Cursors.Hand;
            Btn_KullaniciAdiGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_KullaniciAdiGuncelle.Location = new Point(253, 140);
            Btn_KullaniciAdiGuncelle.Name = "Btn_KullaniciAdiGuncelle";
            Btn_KullaniciAdiGuncelle.Size = new Size(126, 57);
            Btn_KullaniciAdiGuncelle.TabIndex = 12;
            Btn_KullaniciAdiGuncelle.Text = "GÜNCELLE";
            Btn_KullaniciAdiGuncelle.UseVisualStyleBackColor = true;
            Btn_KullaniciAdiGuncelle.Click += Btn_KullaniciAdiGuncelle_Click;
            // 
            // Txt_KullaniciAdiGuncelle
            // 
            Txt_KullaniciAdiGuncelle.Font = new Font("Segoe UI", 10.8F);
            Txt_KullaniciAdiGuncelle.Location = new Point(303, 81);
            Txt_KullaniciAdiGuncelle.Name = "Txt_KullaniciAdiGuncelle";
            Txt_KullaniciAdiGuncelle.Size = new Size(215, 31);
            Txt_KullaniciAdiGuncelle.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(134, 87);
            label5.Name = "label5";
            label5.Size = new Size(147, 25);
            label5.TabIndex = 1;
            label5.Text = "Yeni Kullanıcı Adı:";
            // 
            // MskdTxt_SifreGuncelle
            // 
            MskdTxt_SifreGuncelle.Font = new Font("Segoe UI", 10.8F);
            MskdTxt_SifreGuncelle.Location = new Point(303, 81);
            MskdTxt_SifreGuncelle.Mask = "000000";
            MskdTxt_SifreGuncelle.Name = "MskdTxt_SifreGuncelle";
            MskdTxt_SifreGuncelle.Size = new Size(87, 31);
            MskdTxt_SifreGuncelle.TabIndex = 2;
            MskdTxt_SifreGuncelle.UseSystemPasswordChar = true;
            MskdTxt_SifreGuncelle.ValidatingType = typeof(int);
            // 
            // Btn_SifreGuncelle
            // 
            Btn_SifreGuncelle.Cursor = Cursors.Hand;
            Btn_SifreGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_SifreGuncelle.Location = new Point(253, 140);
            Btn_SifreGuncelle.Name = "Btn_SifreGuncelle";
            Btn_SifreGuncelle.Size = new Size(126, 57);
            Btn_SifreGuncelle.TabIndex = 30;
            Btn_SifreGuncelle.Text = "GÜNCELLE";
            Btn_SifreGuncelle.UseVisualStyleBackColor = true;
            Btn_SifreGuncelle.Click += Btn_SifreGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(194, 87);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 2;
            label6.Text = "Yeni Şifre:";
            // 
            // Btn_MailGuncelle
            // 
            Btn_MailGuncelle.Cursor = Cursors.Hand;
            Btn_MailGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_MailGuncelle.Location = new Point(253, 140);
            Btn_MailGuncelle.Name = "Btn_MailGuncelle";
            Btn_MailGuncelle.Size = new Size(126, 57);
            Btn_MailGuncelle.TabIndex = 48;
            Btn_MailGuncelle.Text = "GÜNCELLE";
            Btn_MailGuncelle.UseVisualStyleBackColor = true;
            Btn_MailGuncelle.Click += Btn_MailGuncelle_Click;
            // 
            // Txt_MailGuncelle
            // 
            Txt_MailGuncelle.Font = new Font("Segoe UI", 10.8F);
            Txt_MailGuncelle.Location = new Point(303, 81);
            Txt_MailGuncelle.Name = "Txt_MailGuncelle";
            Txt_MailGuncelle.Size = new Size(215, 31);
            Txt_MailGuncelle.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(141, 87);
            label7.Name = "label7";
            label7.Size = new Size(140, 25);
            label7.TabIndex = 3;
            label7.Text = "Yeni Mail Adresi:";
            // 
            // Btn_TelGuncelle
            // 
            Btn_TelGuncelle.Cursor = Cursors.Hand;
            Btn_TelGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_TelGuncelle.Location = new Point(253, 140);
            Btn_TelGuncelle.Name = "Btn_TelGuncelle";
            Btn_TelGuncelle.Size = new Size(126, 57);
            Btn_TelGuncelle.TabIndex = 55;
            Btn_TelGuncelle.Text = "GÜNCELLE";
            Btn_TelGuncelle.UseVisualStyleBackColor = true;
            Btn_TelGuncelle.Click += Btn_TelGuncelle_Click;
            // 
            // MskdTxt_TelGuncelle
            // 
            MskdTxt_TelGuncelle.Font = new Font("Segoe UI", 10.8F);
            MskdTxt_TelGuncelle.Location = new Point(303, 81);
            MskdTxt_TelGuncelle.Mask = "(999) 000-0000";
            MskdTxt_TelGuncelle.Name = "MskdTxt_TelGuncelle";
            MskdTxt_TelGuncelle.Size = new Size(144, 31);
            MskdTxt_TelGuncelle.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F);
            label8.Location = new Point(180, 87);
            label8.Name = "label8";
            label8.Size = new Size(101, 25);
            label8.TabIndex = 4;
            label8.Text = "Yeni Tel No:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LavenderBlush;
            groupBox1.Controls.Add(Btn_KullaniciAdiGuncelle);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(Txt_KullaniciAdiGuncelle);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(455, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(670, 229);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Adınızı Güncelleyin:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LavenderBlush;
            groupBox2.Controls.Add(Btn_SifreGuncelle);
            groupBox2.Controls.Add(MskdTxt_SifreGuncelle);
            groupBox2.Controls.Add(label6);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(455, 271);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(670, 229);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Şifrenizi Güncelleyin:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LavenderBlush;
            groupBox3.Controls.Add(Btn_MailGuncelle);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(Txt_MailGuncelle);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(455, 521);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(670, 229);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Mail Adresinizi Güncelleyin:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.LavenderBlush;
            groupBox4.Controls.Add(Btn_TelGuncelle);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(MskdTxt_TelGuncelle);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(455, 771);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(670, 229);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Telefon Numaranızı Güncelleyin:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, -211);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(430, 711);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1128, -211);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(430, 711);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // KullaniciAyarlariControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "KullaniciAyarlariControl";
            Size = new Size(1561, 1102);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox Txt_KullaniciAdiGuncelle;
        private Label label5;
        private Label label6;
        private TextBox Txt_MailGuncelle;
        private Label label7;
        private MaskedTextBox MskdTxt_TelGuncelle;
        private Label label8;
        private Button Btn_KullaniciAdiGuncelle;
        private Button Btn_SifreGuncelle;
        private Button Btn_MailGuncelle;
        private Button Btn_TelGuncelle;
        private MaskedTextBox MskdTxt_SifreGuncelle;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
