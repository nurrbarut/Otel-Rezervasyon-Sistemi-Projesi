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
    public partial class KullaniciAyarlariControl : UserControl

    {
        public KullaniciAyarlariControl()
        {

            InitializeComponent();
        }


        private void Btn_KullaniciAdiGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_KullaniciAdiGuncelle.Text))
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı adı giriniz!");
                return;
            }
            try
            {
                if (dbBaglanti.baglanti.State == ConnectionState.Closed)
                {
                    dbBaglanti.baglanti.Open();
                }

                string sorgu = ("UPDATE tbl_yonetici SET kullaniciadi= @yeniKullaniciAdi WHERE kullaniciadi= @eskiKullaniciadi");
                MySqlCommand komut = new MySqlCommand(sorgu, dbBaglanti.baglanti);
                {
                    komut.Parameters.AddWithValue("@yeniKullaniciAdi", Txt_KullaniciAdiGuncelle.Text);
                    komut.Parameters.AddWithValue("@eskiKullaniciadi", Login.kullaniciadi);
                }
                int KullaniciAdiGuncellendi = komut.ExecuteNonQuery();
                if (KullaniciAdiGuncellendi > 0)
                {
                    MessageBox.Show("Kullanıcı adınız başarıyla güncellendi!");
                    Login.kullaniciadi = Txt_KullaniciAdiGuncelle.Text;
                    Txt_KullaniciAdiGuncelle.Clear();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adınız güncellenirken beklenmeyen bir hatayla karşılaşıldı,lütfen tekrar deneyiniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı hatası!");
            }
            finally
            {
                dbBaglanti.baglanti.Close();
            }

        }

        private void Btn_SifreGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MskdTxt_SifreGuncelle.Text))
            {
                MessageBox.Show("Lütfen geçerli bir şifre giriniz!");
                return;
            }
            try
            {
                if (dbBaglanti.baglanti.State == ConnectionState.Closed)
                {
                    dbBaglanti.baglanti.Open();
                }
                string sorgu = ("UPDATE tbl_yonetici SET sifre= @yeniSifre WHERE kullaniciadi= @kullaniciadi");
                MySqlCommand komut = new MySqlCommand(sorgu, dbBaglanti.baglanti);
                {
                    komut.Parameters.AddWithValue("@yeniSifre", MskdTxt_SifreGuncelle.Text);
                    komut.Parameters.AddWithValue("@kullaniciadi", Login.kullaniciadi);
                }
                int sifreGuncellendi = komut.ExecuteNonQuery();
                if (sifreGuncellendi > 0)
                {
                    MessageBox.Show("Şifreniz başarıyla güncellendi!");
                    MskdTxt_SifreGuncelle.Clear();
                }
                else
                {
                    MessageBox.Show("Şifreniz güncellenirken beklenmeyen bir hatayla karşılaşıldı,lütfen tekrar deneyiniz.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı hatası!");
            }
            finally
            {
                dbBaglanti.baglanti.Close();
            }
        }

        private void Btn_MailGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_MailGuncelle.Text))
            {
                MessageBox.Show("Lütfen geçerli bir mail adresi giriniz!");
                return;
            }
            try
            {
                if (dbBaglanti.baglanti.State == ConnectionState.Closed)
                {
                    dbBaglanti.baglanti.Open();
                }
                string sorgu = ("UPDATE tbl_yonetici SET yonetici_mail= @yeniMail WHERE kullaniciadi= @kullaniciadi");
                MySqlCommand komut = new MySqlCommand(sorgu, dbBaglanti.baglanti);
                {
                    komut.Parameters.AddWithValue("@yeniMail", Txt_MailGuncelle.Text);
                    komut.Parameters.AddWithValue("@kullaniciadi", Login.kullaniciadi);
                }
                int mailGuncellendi = komut.ExecuteNonQuery();
                if (mailGuncellendi > 0)
                {
                    MessageBox.Show("Mail adresiniz başarıyla güncellendi!");
                    Txt_MailGuncelle.Clear();
                }
                else
                {
                    MessageBox.Show("Mail adresiniz güncellenirken beklenmeyen bir hatayla karşılaşıldı,lütfen tekrar deneyiniz.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Bağlantı hatası!");
            }
            finally
            {
                dbBaglanti.baglanti.Close();
            }
            
        }

        private void Btn_TelGuncelle_Click(object sender, EventArgs e)
        {
            if (!MskdTxt_TelGuncelle.MaskFull)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz!");
                return;
            }
            try
            {
                if (dbBaglanti.baglanti.State == ConnectionState.Closed)
                {
                    dbBaglanti.baglanti.Open();
                }
                string sorgu = ("UPDATE tbl_yonetici SET yonetici_tel= @yeniTel WHERE kullaniciadi= @kullaniciadi");
                MySqlCommand komut = new MySqlCommand(sorgu, dbBaglanti.baglanti);
                {
                    komut.Parameters.AddWithValue("@yeniTel", MskdTxt_TelGuncelle.Text);
                    komut.Parameters.AddWithValue("@kullaniciadi", Login.kullaniciadi);
                }
                int telGuncellendi = komut.ExecuteNonQuery();
                if (telGuncellendi > 0)
                {
                    MessageBox.Show("Telefon numaranız başarıyla güncellendi!");
                    MskdTxt_TelGuncelle.Clear();
                }
                else
                {
                    MessageBox.Show("Telefon numaranız güncellenirken beklenmeyen bir hatayla karşılaşıldı,lütfen tekrar deneyiniz.");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Bağlantı hatası!");
            }
            finally
            {
                dbBaglanti.baglanti.Close();
            }

        }

       
    }
}
