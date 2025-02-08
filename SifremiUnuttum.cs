using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class SifremiUnuttum : Form
    {
        public string _KullaniciAdi;
        public SifremiUnuttum(string gKullaniciAdi)
        {
            InitializeComponent();
            _KullaniciAdi = gKullaniciAdi;
            GuvenlikSorusuGetir();
        }
        private void GuvenlikSorusuGetir()
        {
            dbBaglanti.baglanti.Open();
            string sorgu = ("SELECT sifre_guvenliksoru FROM tbl_yonetici WHERE kullaniciadi= @kullaniciadi");
            MySqlCommand komut = new MySqlCommand(sorgu, dbBaglanti.baglanti);
            komut.Parameters.AddWithValue("@kullaniciadi", _KullaniciAdi);
            MySqlDataReader okunan = komut.ExecuteReader();
            if (okunan.Read())
            {
                Lbl_GuvenlikSorusu.Text = okunan["sifre_guvenliksoru"].ToString();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı!");
                this.Close();

            }
            dbBaglanti.baglanti.Close();

        }

        private void Btn_Dogrula_Click(object sender, EventArgs e)
        {
            string guvenlikCevap = Txt_GuvenlikCevap.Text;
            if (SifreDogrula(guvenlikCevap))
            {
                YeniSifre yeniSifre = new YeniSifre(_KullaniciAdi);
                yeniSifre.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Güvenlik sorusunu yanlış yanıtladınız, lütfen tekrar deneyiniz.");
            }
            dbBaglanti.baglanti.Close();


        }
        private bool SifreDogrula(string guvenlikCevap)
        {
            dbBaglanti.baglanti.Open();
            string sorgu2 = "SELECT sifre_guvenlikcvp FROM tbl_yonetici WHERE kullaniciadi= @kullaniciadi";
            MySqlCommand komut2 = new MySqlCommand(sorgu2, dbBaglanti.baglanti);
            komut2.Parameters.AddWithValue("@kullaniciadi", _KullaniciAdi);
            MySqlDataReader okunan2 = komut2.ExecuteReader();
            if (okunan2.Read())
            {
                return okunan2["sifre_guvenlikcvp"].ToString().Equals(guvenlikCevap, StringComparison.OrdinalIgnoreCase);
            }
            else
            {
                return false;

            }

            
        }

        
    }
}
