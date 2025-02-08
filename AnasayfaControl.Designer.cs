namespace OtelRezervasyonSistemi
{
    partial class AnasayfaControl
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaControl));
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label1 = new Label();
            Lbl_Mesaj = new Label();
            pctrBox_Tarih = new PictureBox();
            Lbl_Tarih = new Label();
            Lbl_Saat = new Label();
            label7 = new Label();
            label6 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctrBox_Tarih).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-54, -18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(507, 383);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightPink;
            label2.Font = new Font("Ink Free", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(75, 141);
            label2.Name = "label2";
            label2.Size = new Size(267, 29);
            label2.TabIndex = 19;
            label2.Text = "Lütfen günlük planlarınızı ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightPink;
            label3.Font = new Font("Ink Free", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(58, 183);
            label3.Name = "label3";
            label3.Size = new Size(296, 29);
            label3.TabIndex = 20;
            label3.Text = "tamamladığınızdan emin olun ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightPink;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(189, 223);
            label4.Name = "label4";
            label4.Size = new Size(26, 31);
            label4.TabIndex = 21;
            label4.Text = ":)";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(782, 183);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 916);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(Lbl_Mesaj);
            panel3.Location = new Point(90, 481);
            panel3.Name = "panel3";
            panel3.Size = new Size(739, 253);
            panel3.TabIndex = 27;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(496, 141);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(92, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(23, 156);
            label5.Name = "label5";
            label5.Size = new Size(467, 33);
            label5.TabIndex = 17;
            label5.Text = "BULUNAN MENÜDEN SEÇİNİZ!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(23, 105);
            label1.Name = "label1";
            label1.Size = new Size(700, 33);
            label1.TabIndex = 16;
            label1.Text = "LÜTFEN YAPMAK İSTEDİĞİNİZ İŞLEMİ YANDA ";
            // 
            // Lbl_Mesaj
            // 
            Lbl_Mesaj.AutoSize = true;
            Lbl_Mesaj.Font = new Font("Century Schoolbook", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl_Mesaj.Location = new Point(23, 54);
            Lbl_Mesaj.Name = "Lbl_Mesaj";
            Lbl_Mesaj.Size = new Size(365, 33);
            Lbl_Mesaj.TabIndex = 15;
            Lbl_Mesaj.Text = "İYİ GÜNLER/AKŞAMLAR";
            Lbl_Mesaj.Visible = false;
            // 
            // pctrBox_Tarih
            // 
            pctrBox_Tarih.Image = (Image)resources.GetObject("pctrBox_Tarih.Image");
            pctrBox_Tarih.Location = new Point(1292, -35);
            pctrBox_Tarih.Name = "pctrBox_Tarih";
            pctrBox_Tarih.Size = new Size(269, 265);
            pctrBox_Tarih.SizeMode = PictureBoxSizeMode.Zoom;
            pctrBox_Tarih.TabIndex = 28;
            pctrBox_Tarih.TabStop = false;
            // 
            // Lbl_Tarih
            // 
            Lbl_Tarih.AutoSize = true;
            Lbl_Tarih.BackColor = SystemColors.ButtonFace;
            Lbl_Tarih.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Lbl_Tarih.Location = new Point(1376, 92);
            Lbl_Tarih.Name = "Lbl_Tarih";
            Lbl_Tarih.Size = new Size(106, 25);
            Lbl_Tarih.TabIndex = 29;
            Lbl_Tarih.Text = "00/00/0000";
            Lbl_Tarih.Visible = false;
            // 
            // Lbl_Saat
            // 
            Lbl_Saat.AutoSize = true;
            Lbl_Saat.BackColor = SystemColors.ButtonFace;
            Lbl_Saat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Lbl_Saat.Location = new Point(1404, 128);
            Lbl_Saat.Name = "Lbl_Saat";
            Lbl_Saat.Size = new Size(50, 23);
            Lbl_Saat.TabIndex = 30;
            Lbl_Saat.Text = "00:00";
            Lbl_Saat.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FloralWhite;
            label7.Location = new Point(523, 247);
            label7.Name = "label7";
            label7.Size = new Size(917, 58);
            label7.TabIndex = 31;
            label7.Text = "\"HER TATİL, GÖKYÜZÜ KADAR EŞSİZ...\"";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Ink Free", 55.9999962F, FontStyle.Bold);
            label6.ForeColor = Color.Snow;
            label6.Location = new Point(387, 113);
            label6.Name = "label6";
            label6.Size = new Size(545, 117);
            label6.TabIndex = 32;
            label6.Text = "SKY HOTEL";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // AnasayfaControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(Lbl_Saat);
            Controls.Add(Lbl_Tarih);
            Controls.Add(pctrBox_Tarih);
            Controls.Add(panel3);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Name = "AnasayfaControl";
            Size = new Size(1561, 1102);
            Load += AnasayfaControl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctrBox_Tarih).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label1;
        private Label Lbl_Mesaj;
        private PictureBox pctrBox_Tarih;
        private Label Lbl_Tarih;
        private Label Lbl_Saat;
        private Label label7;
        private Label label6;
        private System.Windows.Forms.Timer timer1;
    }
}
