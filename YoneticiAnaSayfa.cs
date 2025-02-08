using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class YoneticiAnaSayfa : Form

    {


        public YoneticiAnaSayfa(string cinsiyet, string yoneticiAdi, string yoneticiSoyadi)
        {

            string _cinsiyet = cinsiyet;
            InitializeComponent();

            this.Opacity = 0;

            Lbl_KullaniciAdi.Text = "HOŞ GELDİNİZ " + "\n" + yoneticiAdi + " " + yoneticiSoyadi;


            if (cinsiyet == "KADIN")
            {
                pictureBox_Kadin.Visible = true;
            }
            else
            {
                {
                    pictureBox_Erkek.Visible = true;
                }

            }
        }
        private void Yönetici_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Timer_Animasyon.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Lbl_Tarih.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Lbl_Saat.Text = DateTime.Now.ToString("HH:mm");
            Lbl_Tarih.Visible = true;
            Lbl_Saat.Visible = true;
            int saat = DateTime.Now.Hour;
            if ((saat >= 18 || saat < 6))
            {
                Lbl_Mesaj.Text = "İYİ AKŞAMLAR,";
            }
            else
            {
                Lbl_Mesaj.Text = "İYİ GÜNLER,";
            }
            Lbl_Mesaj.Visible = true;

        }

        private void Timer_Animasyon_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.05;
            }
            else
            {
                Timer_Animasyon.Stop();
            }
        }

        private void Btn_AnaSayfa_Click(object sender, EventArgs e)
        {
            AnasayfaControl anasayfa = new AnasayfaControl();
            anasayfa.Dock = DockStyle.Right;
            panel4.Controls.Clear();
            panel4.Controls.Add(anasayfa);

        }

        private void Btn_MusteriIslem_Click(object sender, EventArgs e)
        {
            MusteriControl musteriControl = new MusteriControl();
            musteriControl.Dock = DockStyle.Right;
            panel4.Controls.Clear();
            panel4.Controls.Add(musteriControl);
        }

        private void Btn_YoneticiIslem_Click(object sender, EventArgs e)
        {
            YoneticiIslemleri_Control yoneticiControl = new YoneticiIslemleri_Control();
            yoneticiControl.Dock = DockStyle.Right;
            panel4.Controls.Clear();
            panel4.Controls.Add(yoneticiControl);
        }

        private void Btn_CikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_KullaniciAyarlari_Click(object sender, EventArgs e)
        {
            KullaniciAyarlariControl kullaniciAyar = new KullaniciAyarlariControl();
            kullaniciAyar.Dock = DockStyle.Right;
            panel4.Controls.Clear();
            panel4.Controls.Add(kullaniciAyar);

        }

        private void Btn_OdaIslem_Click(object sender, EventArgs e)
        {
            OdaIslemleriControl odaIslem = new OdaIslemleriControl();
            odaIslem.Dock = DockStyle.Right;
            panel4.Controls.Clear();
            panel4.Controls.Add(odaIslem);
        }

        private void Btn_RezervasyonIslem_Click(object sender, EventArgs e)
        {
            RezervasyonIslemleriControl rezIslem = new RezervasyonIslemleriControl();
            rezIslem.Dock = DockStyle.Right;
            panel4.Controls.Clear();
            panel4.Controls.Add(rezIslem);
        }

        private void Btn_FaturaGoruntule_Click(object sender, EventArgs e)
        {
            FaturaGoruntuleControl faturaIslem = new FaturaGoruntuleControl();
            faturaIslem.Dock = DockStyle.Right;
            panel4.Controls.Clear();
            panel4.Controls.Add(faturaIslem);
        }
    }
}
