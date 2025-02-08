namespace OtelRezervasyonSistemi
{
    partial class YeniSifre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniSifre));
            label1 = new Label();
            label2 = new Label();
            Btn_YeniSifreKaydet = new Button();
            pictureBox1 = new PictureBox();
            MskdTxt_YeniSifre = new MaskedTextBox();
            MskedTxt_YeniSifreTekrar = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(204, 96);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Yeni Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(204, 222);
            label2.Name = "label2";
            label2.Size = new Size(138, 25);
            label2.TabIndex = 2;
            label2.Text = "Yeni Şifre Tekrar:";
            // 
            // Btn_YeniSifreKaydet
            // 
            Btn_YeniSifreKaydet.Cursor = Cursors.Hand;
            Btn_YeniSifreKaydet.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Btn_YeniSifreKaydet.Location = new Point(312, 342);
            Btn_YeniSifreKaydet.Name = "Btn_YeniSifreKaydet";
            Btn_YeniSifreKaydet.Size = new Size(166, 74);
            Btn_YeniSifreKaydet.TabIndex = 4;
            Btn_YeniSifreKaydet.Text = "KAYDET";
            Btn_YeniSifreKaydet.UseVisualStyleBackColor = true;
            Btn_YeniSifreKaydet.Click += Btn_YeniSifreKaydet_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(366, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(333, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // MskdTxt_YeniSifre
            // 
            MskdTxt_YeniSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MskdTxt_YeniSifre.Location = new Point(204, 138);
            MskdTxt_YeniSifre.Mask = "000000";
            MskdTxt_YeniSifre.Name = "MskdTxt_YeniSifre";
            MskdTxt_YeniSifre.Size = new Size(125, 31);
            MskdTxt_YeniSifre.TabIndex = 6;
            MskdTxt_YeniSifre.UseSystemPasswordChar = true;
            MskdTxt_YeniSifre.ValidatingType = typeof(int);
            // 
            // MskedTxt_YeniSifreTekrar
            // 
            MskedTxt_YeniSifreTekrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MskedTxt_YeniSifreTekrar.Location = new Point(204, 264);
            MskedTxt_YeniSifreTekrar.Mask = "000000";
            MskedTxt_YeniSifreTekrar.Name = "MskedTxt_YeniSifreTekrar";
            MskedTxt_YeniSifreTekrar.Size = new Size(125, 31);
            MskedTxt_YeniSifreTekrar.TabIndex = 7;
            MskedTxt_YeniSifreTekrar.UseSystemPasswordChar = true;
            MskedTxt_YeniSifreTekrar.ValidatingType = typeof(int);
            // 
            // YeniSifre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 450);
            Controls.Add(MskedTxt_YeniSifreTekrar);
            Controls.Add(MskdTxt_YeniSifre);
            Controls.Add(pictureBox1);
            Controls.Add(Btn_YeniSifreKaydet);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "YeniSifre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yeni Şifre Oluştur";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Btn_YeniSifreKaydet;
        private PictureBox pictureBox1;
        private MaskedTextBox MskdTxt_YeniSifre;
        private MaskedTextBox MskedTxt_YeniSifreTekrar;
    }
}