namespace OtelRezervasyonSistemi
{
    partial class OdaIslemleriControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OdaIslemleriControl));
            groupBox1 = new GroupBox();
            comboBox_AraOdaTuru = new ComboBox();
            Btn_OdaTuruAra = new Button();
            label10 = new Label();
            Btn_OdaAra = new Button();
            Txt_OdaAra = new TextBox();
            label9 = new Label();
            Btn_OdaListesiYenile = new Button();
            dataGrid_OdaListesi = new DataGridView();
            groupBox2 = new GroupBox();
            Btn_EkleOda = new Button();
            panel1 = new Panel();
            comboBox_EkleOdaTur = new ComboBox();
            Txt_EkleOdaNo = new TextBox();
            label1 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            Btn_SilOda = new Button();
            panel3 = new Panel();
            label7 = new Label();
            Txt_SılOdaId = new TextBox();
            groupBox4 = new GroupBox();
            Btn_GuncelleOda = new Button();
            panel2 = new Panel();
            Txt_GuncelleOdaFiyat = new TextBox();
            label8 = new Label();
            comboBox_GuncelleOdaTur = new ComboBox();
            rdBtn_Bos = new RadioButton();
            rdBtn_Dolu = new RadioButton();
            label6 = new Label();
            Txt_GuncelleOdaId = new TextBox();
            label5 = new Label();
            Txt_GuncelleOdaNo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_OdaListesi).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            panel3.SuspendLayout();
            groupBox4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox_AraOdaTuru);
            groupBox1.Controls.Add(Btn_OdaTuruAra);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(Btn_OdaAra);
            groupBox1.Controls.Add(Txt_OdaAra);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(Btn_OdaListesiYenile);
            groupBox1.Controls.Add(dataGrid_OdaListesi);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(60, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(837, 741);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Oda Listesi:";
            // 
            // comboBox_AraOdaTuru
            // 
            comboBox_AraOdaTuru.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox_AraOdaTuru.FormattingEnabled = true;
            comboBox_AraOdaTuru.Items.AddRange(new object[] { "Tek Kişilik", "Çift Kişilik", "Üç Kişilik", "Suit Oda" });
            comboBox_AraOdaTuru.Location = new Point(351, 46);
            comboBox_AraOdaTuru.Name = "comboBox_AraOdaTuru";
            comboBox_AraOdaTuru.Size = new Size(151, 33);
            comboBox_AraOdaTuru.TabIndex = 11;
            // 
            // Btn_OdaTuruAra
            // 
            Btn_OdaTuruAra.BackColor = Color.LavenderBlush;
            Btn_OdaTuruAra.Cursor = Cursors.Hand;
            Btn_OdaTuruAra.Image = (Image)resources.GetObject("Btn_OdaTuruAra.Image");
            Btn_OdaTuruAra.Location = new Point(517, 39);
            Btn_OdaTuruAra.Name = "Btn_OdaTuruAra";
            Btn_OdaTuruAra.Size = new Size(46, 42);
            Btn_OdaTuruAra.TabIndex = 10;
            Btn_OdaTuruAra.UseVisualStyleBackColor = false;
            Btn_OdaTuruAra.Click += Btn_OdaTuruAra_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.8F);
            label10.Location = new Point(255, 53);
            label10.Name = "label10";
            label10.Size = new Size(90, 25);
            label10.TabIndex = 8;
            label10.Text = "Oda Türü:";
            // 
            // Btn_OdaAra
            // 
            Btn_OdaAra.BackColor = Color.LavenderBlush;
            Btn_OdaAra.Cursor = Cursors.Hand;
            Btn_OdaAra.Image = (Image)resources.GetObject("Btn_OdaAra.Image");
            Btn_OdaAra.Location = new Point(175, 43);
            Btn_OdaAra.Name = "Btn_OdaAra";
            Btn_OdaAra.Size = new Size(46, 42);
            Btn_OdaAra.TabIndex = 7;
            Btn_OdaAra.UseVisualStyleBackColor = false;
            Btn_OdaAra.Click += Btn_OdaAra_Click;
            // 
            // Txt_OdaAra
            // 
            Txt_OdaAra.Font = new Font("Segoe UI", 10.8F);
            Txt_OdaAra.Location = new Point(106, 50);
            Txt_OdaAra.Name = "Txt_OdaAra";
            Txt_OdaAra.Size = new Size(63, 31);
            Txt_OdaAra.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.8F);
            label9.Location = new Point(27, 53);
            label9.Name = "label9";
            label9.Size = new Size(73, 25);
            label9.TabIndex = 5;
            label9.Text = "Oda ID:";
            // 
            // Btn_OdaListesiYenile
            // 
            Btn_OdaListesiYenile.BackColor = Color.LavenderBlush;
            Btn_OdaListesiYenile.Cursor = Cursors.Hand;
            Btn_OdaListesiYenile.Image = (Image)resources.GetObject("Btn_OdaListesiYenile.Image");
            Btn_OdaListesiYenile.Location = new Point(740, 33);
            Btn_OdaListesiYenile.Name = "Btn_OdaListesiYenile";
            Btn_OdaListesiYenile.Size = new Size(60, 49);
            Btn_OdaListesiYenile.TabIndex = 1;
            Btn_OdaListesiYenile.UseVisualStyleBackColor = false;
            Btn_OdaListesiYenile.Click += Btn_OdaListesiYenile_Click;
            // 
            // dataGrid_OdaListesi
            // 
            dataGrid_OdaListesi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid_OdaListesi.BackgroundColor = Color.LavenderBlush;
            dataGrid_OdaListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_OdaListesi.Location = new Point(23, 116);
            dataGrid_OdaListesi.Name = "dataGrid_OdaListesi";
            dataGrid_OdaListesi.RowHeadersWidth = 51;
            dataGrid_OdaListesi.Size = new Size(777, 590);
            dataGrid_OdaListesi.TabIndex = 0;
            dataGrid_OdaListesi.CellClick += dataGrid_OdaListesi_CellClick;
            dataGrid_OdaListesi.CellFormatting += dataGrid_OdaListesi_CellFormatting;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Btn_EkleOda);
            groupBox2.Controls.Add(panel1);
            groupBox2.Font = new Font("Segoe UI", 12F);
            groupBox2.Location = new Point(975, 59);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(518, 441);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Yeni Oda:";
            // 
            // Btn_EkleOda
            // 
            Btn_EkleOda.Cursor = Cursors.Hand;
            Btn_EkleOda.Font = new Font("Segoe UI", 10F);
            Btn_EkleOda.Location = new Point(182, 337);
            Btn_EkleOda.Name = "Btn_EkleOda";
            Btn_EkleOda.Size = new Size(144, 65);
            Btn_EkleOda.TabIndex = 1;
            Btn_EkleOda.Text = "KAYDET";
            Btn_EkleOda.UseVisualStyleBackColor = true;
            Btn_EkleOda.Click += Btn_EkleOda_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LavenderBlush;
            panel1.Controls.Add(comboBox_EkleOdaTur);
            panel1.Controls.Add(Txt_EkleOdaNo);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(88, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 247);
            panel1.TabIndex = 5;
            // 
            // comboBox_EkleOdaTur
            // 
            comboBox_EkleOdaTur.Cursor = Cursors.Hand;
            comboBox_EkleOdaTur.FormattingEnabled = true;
            comboBox_EkleOdaTur.Items.AddRange(new object[] { "Tek Kişilik", "İki Kişilik", "Üç Kişilik", "Suit Oda" });
            comboBox_EkleOdaTur.Location = new Point(29, 163);
            comboBox_EkleOdaTur.Name = "comboBox_EkleOdaTur";
            comboBox_EkleOdaTur.Size = new Size(165, 36);
            comboBox_EkleOdaTur.TabIndex = 4;
            // 
            // Txt_EkleOdaNo
            // 
            Txt_EkleOdaNo.Font = new Font("Segoe UI", 10.8F);
            Txt_EkleOdaNo.Location = new Point(108, 43);
            Txt_EkleOdaNo.Name = "Txt_EkleOdaNo";
            Txt_EkleOdaNo.Size = new Size(80, 31);
            Txt_EkleOdaNo.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(23, 46);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 1;
            label1.Text = "Oda No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(26, 119);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 4;
            label4.Text = "Oda Türünü Seçiniz:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(Btn_SilOda);
            groupBox3.Controls.Add(panel3);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(60, 823);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(837, 191);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Oda Sil:";
            // 
            // Btn_SilOda
            // 
            Btn_SilOda.Cursor = Cursors.Hand;
            Btn_SilOda.Font = new Font("Segoe UI", 10F);
            Btn_SilOda.Location = new Point(439, 71);
            Btn_SilOda.Name = "Btn_SilOda";
            Btn_SilOda.Size = new Size(144, 65);
            Btn_SilOda.TabIndex = 14;
            Btn_SilOda.Text = "SİL";
            Btn_SilOda.UseVisualStyleBackColor = true;
            Btn_SilOda.Click += Btn_SilOda_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LavenderBlush;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(Txt_SılOdaId);
            panel3.Location = new Point(142, 46);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 114);
            panel3.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(33, 44);
            label7.Name = "label7";
            label7.Size = new Size(68, 23);
            label7.TabIndex = 11;
            label7.Text = "Oda ID:";
            // 
            // Txt_SılOdaId
            // 
            Txt_SılOdaId.Font = new Font("Segoe UI", 10.8F);
            Txt_SılOdaId.Location = new Point(118, 41);
            Txt_SılOdaId.Name = "Txt_SılOdaId";
            Txt_SılOdaId.Size = new Size(80, 31);
            Txt_SılOdaId.TabIndex = 12;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Btn_GuncelleOda);
            groupBox4.Controls.Add(panel2);
            groupBox4.Font = new Font("Segoe UI", 12F);
            groupBox4.Location = new Point(975, 518);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(518, 496);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Oda Bilgilerini Güncelle:";
            // 
            // Btn_GuncelleOda
            // 
            Btn_GuncelleOda.Cursor = Cursors.Hand;
            Btn_GuncelleOda.Font = new Font("Segoe UI", 10F);
            Btn_GuncelleOda.Location = new Point(182, 425);
            Btn_GuncelleOda.Name = "Btn_GuncelleOda";
            Btn_GuncelleOda.Size = new Size(144, 65);
            Btn_GuncelleOda.TabIndex = 7;
            Btn_GuncelleOda.Text = "GÜNCELLE";
            Btn_GuncelleOda.UseVisualStyleBackColor = true;
            Btn_GuncelleOda.Click += Btn_GuncelleOda_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LavenderBlush;
            panel2.Controls.Add(Txt_GuncelleOdaFiyat);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(comboBox_GuncelleOdaTur);
            panel2.Controls.Add(rdBtn_Bos);
            panel2.Controls.Add(rdBtn_Dolu);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(Txt_GuncelleOdaId);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(Txt_GuncelleOdaNo);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(88, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(349, 368);
            panel2.TabIndex = 6;
            // 
            // Txt_GuncelleOdaFiyat
            // 
            Txt_GuncelleOdaFiyat.Font = new Font("Segoe UI", 10F);
            Txt_GuncelleOdaFiyat.Location = new Point(122, 123);
            Txt_GuncelleOdaFiyat.Name = "Txt_GuncelleOdaFiyat";
            Txt_GuncelleOdaFiyat.Size = new Size(107, 30);
            Txt_GuncelleOdaFiyat.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(23, 130);
            label8.Name = "label8";
            label8.Size = new Size(90, 23);
            label8.TabIndex = 15;
            label8.Text = "Oda Fiyatı:";
            // 
            // comboBox_GuncelleOdaTur
            // 
            comboBox_GuncelleOdaTur.Cursor = Cursors.Hand;
            comboBox_GuncelleOdaTur.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox_GuncelleOdaTur.FormattingEnabled = true;
            comboBox_GuncelleOdaTur.Items.AddRange(new object[] { "Tek Kişilik", "İki Kişilik", "Üç Kişilik", "Suit Oda" });
            comboBox_GuncelleOdaTur.Location = new Point(26, 219);
            comboBox_GuncelleOdaTur.Name = "comboBox_GuncelleOdaTur";
            comboBox_GuncelleOdaTur.Size = new Size(165, 31);
            comboBox_GuncelleOdaTur.TabIndex = 14;
            // 
            // rdBtn_Bos
            // 
            rdBtn_Bos.AutoSize = true;
            rdBtn_Bos.Cursor = Cursors.Hand;
            rdBtn_Bos.Font = new Font("Segoe UI", 10.2F);
            rdBtn_Bos.Location = new Point(108, 300);
            rdBtn_Bos.Name = "rdBtn_Bos";
            rdBtn_Bos.Size = new Size(58, 27);
            rdBtn_Bos.TabIndex = 13;
            rdBtn_Bos.TabStop = true;
            rdBtn_Bos.Text = "Boş";
            rdBtn_Bos.UseVisualStyleBackColor = true;
            // 
            // rdBtn_Dolu
            // 
            rdBtn_Dolu.AutoSize = true;
            rdBtn_Dolu.Cursor = Cursors.Hand;
            rdBtn_Dolu.Font = new Font("Segoe UI", 10.2F);
            rdBtn_Dolu.Location = new Point(29, 300);
            rdBtn_Dolu.Name = "rdBtn_Dolu";
            rdBtn_Dolu.Size = new Size(67, 27);
            rdBtn_Dolu.TabIndex = 12;
            rdBtn_Dolu.TabStop = true;
            rdBtn_Dolu.Text = "Dolu";
            rdBtn_Dolu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(26, 265);
            label6.Name = "label6";
            label6.Size = new Size(114, 23);
            label6.TabIndex = 11;
            label6.Text = "Oda Durumu:";
            // 
            // Txt_GuncelleOdaId
            // 
            Txt_GuncelleOdaId.Font = new Font("Segoe UI", 10.8F);
            Txt_GuncelleOdaId.Location = new Point(108, 29);
            Txt_GuncelleOdaId.Name = "Txt_GuncelleOdaId";
            Txt_GuncelleOdaId.Size = new Size(80, 31);
            Txt_GuncelleOdaId.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(23, 37);
            label5.Name = "label5";
            label5.Size = new Size(68, 23);
            label5.TabIndex = 9;
            label5.Text = "Oda ID:";
            // 
            // Txt_GuncelleOdaNo
            // 
            Txt_GuncelleOdaNo.Font = new Font("Segoe UI", 10.8F);
            Txt_GuncelleOdaNo.Location = new Point(108, 74);
            Txt_GuncelleOdaNo.Name = "Txt_GuncelleOdaNo";
            Txt_GuncelleOdaNo.Size = new Size(80, 31);
            Txt_GuncelleOdaNo.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(23, 79);
            label2.Name = "label2";
            label2.Size = new Size(74, 23);
            label2.TabIndex = 1;
            label2.Text = "Oda No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(23, 181);
            label3.Name = "label3";
            label3.Size = new Size(163, 23);
            label3.TabIndex = 4;
            label3.Text = "Oda Türünü Seçiniz:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // OdaIslemleriControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "OdaIslemleriControl";
            Size = new Size(1565, 1102);
            Load += OdaIslemleriControl_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid_OdaListesi).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGrid_OdaListesi;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckBox checkBox_EkleTek;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private TextBox Txt_EkleOdaNo;
        private CheckBox checkBox_EkleSuit;
        private CheckBox checkBox_EkleIki;
        private CheckBox checkBox_EkleUc;
        private Panel panel2;
        private RadioButton rdBtn_Dolu;
        private Label label6;
        private TextBox Txt_GuncelleOdaId;
        private Label label5;
        private TextBox Txt_GuncelleOdaNo;
        private Label label2;
        private Label label3;
        private RadioButton rdBtn_Bos;
        private Button Btn_EkleOda;
        private Button Btn_GuncelleOda;
        private Button Btn_OdaListesiYenile;
        private Panel panel3;
        private Label label7;
        private TextBox Txt_SılOdaId;
        private Button Btn_SilOda;
        private ComboBox comboBox_EkleOdaTur;
        private TextBox Txt_GuncelleOdaFiyat;
        private Label label8;
        private ComboBox comboBox_GuncelleOdaTur;
        private Button Btn_OdaAra;
        private Label label9;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox Txt_OdaAra;
        private ComboBox comboBox_AraOdaTuru;
        private Button Btn_OdaTuruAra;
        private Label label10;
    }
}
