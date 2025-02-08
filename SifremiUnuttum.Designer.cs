namespace OtelRezervasyonSistemi
{
    partial class SifremiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttum));
            Lbl_GuvenlikSorusu = new Label();
            Txt_GuvenlikCevap = new TextBox();
            pictureBox1 = new PictureBox();
            Btn_Dogrula = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Lbl_GuvenlikSorusu
            // 
            Lbl_GuvenlikSorusu.AutoSize = true;
            Lbl_GuvenlikSorusu.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Lbl_GuvenlikSorusu.Location = new Point(356, 161);
            Lbl_GuvenlikSorusu.Name = "Lbl_GuvenlikSorusu";
            Lbl_GuvenlikSorusu.Size = new Size(217, 31);
            Lbl_GuvenlikSorusu.TabIndex = 0;
            Lbl_GuvenlikSorusu.Text = "GÜVENLİK SORUSU:";
            // 
            // Txt_GuvenlikCevap
            // 
            Txt_GuvenlikCevap.Location = new Point(393, 211);
            Txt_GuvenlikCevap.Name = "Txt_GuvenlikCevap";
            Txt_GuvenlikCevap.Size = new Size(144, 27);
            Txt_GuvenlikCevap.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(139, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Btn_Dogrula
            // 
            Btn_Dogrula.Cursor = Cursors.Hand;
            Btn_Dogrula.Location = new Point(415, 249);
            Btn_Dogrula.Name = "Btn_Dogrula";
            Btn_Dogrula.Size = new Size(95, 40);
            Btn_Dogrula.TabIndex = 3;
            Btn_Dogrula.Text = "DOĞRULA";
            Btn_Dogrula.UseVisualStyleBackColor = true;
            Btn_Dogrula.Click += Btn_Dogrula_Click;
            // 
            // SifremiUnuttum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Dogrula);
            Controls.Add(pictureBox1);
            Controls.Add(Txt_GuvenlikCevap);
            Controls.Add(Lbl_GuvenlikSorusu);
            Name = "SifremiUnuttum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Güvenlik Sorusu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_GuvenlikSorusu;
        private TextBox Txt_GuvenlikCevap;
        private PictureBox pictureBox1;
        private Button Btn_Dogrula;
    }
}