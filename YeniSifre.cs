using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class YeniSifre : Form
    {
        private string yeniSifre_KullaniciAdi;
        public YeniSifre(string _KullaniciAdi)
        {
            yeniSifre_KullaniciAdi = _KullaniciAdi;
            InitializeComponent();

        }
        private void Btn_YeniSifreKaydet_Click_1(object sender, EventArgs e)
        {
            string yeniSifre = MskdTxt_YeniSifre.Text;
            string sifreTekrar = MskedTxt_YeniSifreTekrar.Text;
            if (string.IsNullOrEmpty(yeniSifre) || string.IsNullOrEmpty(sifreTekrar))
            {
                MessageBox.Show("Lütfen yeni şifrenizi ve doğrulama şifrenizi giriniz.");
            }
            if (yeniSifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler eşleşmiyor, lütfen tekrar deneyiniz!");
                return;
            }
            else
            {
                YeniSifreOlustur(yeniSifre);
            }
            dbBaglanti.baglanti.Close();
        }
        private void YeniSifreOlustur(string yeniSifre)
        {
            dbBaglanti.baglanti.Open();
            string sorgu = "UPDATE tbl_yonetici SET sifre = @yeniSifre WHERE kullaniciadi= @kullaniciadi";
            MySqlCommand komut = new MySqlCommand(sorgu, dbBaglanti.baglanti);
            komut.Parameters.AddWithValue("@kullaniciadi", yeniSifre_KullaniciAdi);
            komut.Parameters.AddWithValue("@yenisifre", yeniSifre);
            int sonuc = komut.ExecuteNonQuery();
            if (sonuc > 0)
            {
                MessageBox.Show("Yeni şifreniz başarıyla kaydedildi!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Yeni şifre kaydedilemedi, lütfen tekrar deneyiniz.");
            }

           
        }
    }
}
