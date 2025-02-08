using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAIN;
using OtelRezervasyonSistemi.SERVICE;

namespace OtelRezervasyonSistemi
{
    public partial class YoneticiIslemleri_Control : UserControl
    {
        public YoneticiIslemleri_Control()
        {
            InitializeComponent();
        }

        private void YoneticiIslemleri_Control_Load(object sender, EventArgs e)
        {
            List<Yonetici> yoneticiListesi = YoneticiService.ServiceYoneticiListele();
            dataGrid_YoneticiListele.DataSource = yoneticiListesi;
        }

        private void Btn_YoneticiListesiYenile_Click(object sender, EventArgs e)
        {
            List<Yonetici> yoneticiListesi = YoneticiService.ServiceYoneticiListele();
            dataGrid_YoneticiListele.DataSource = yoneticiListesi;
        }

        private void Btn_YoneticiEkle_Click(object sender, EventArgs e)
        {
            Yonetici yeniYonetici = new Yonetici();
            yeniYonetici.Yonetici_Ad = Txt_EkleYoneticiAd.Text;
            yeniYonetici.Yonetici_Soyad = Txt_EkleYoneticiSoyad.Text.ToUpper();
            yeniYonetici.Yonetici_TC = MskdTxt_EkleYoneticiTc.Text;
            yeniYonetici.Yonetici_TEL = MskdTxt_EkleYoneticiTel.Text;
            yeniYonetici.Yonetici_Mail = Txt_EkleYoneticiMail.Text; ;
            if (radioBtn_Kadin.Checked)
            {
                yeniYonetici.Yonetici_Cinsiyet = "KADIN";
            }
            else
            {
                yeniYonetici.Yonetici_Cinsiyet = "ERKEK";
            }
            yeniYonetici.Kullanici_Adi = Txt_EkleKullaniciAdi.Text;
            yeniYonetici.Sifre = MskdTxt_EkleSifre.Text;

            YoneticiService.ServiceYoneticiEkle(yeniYonetici);
            MessageBox.Show("Yeni yönetici başarıyla eklendi!");

            Txt_EkleYoneticiAd.Clear();
            Txt_EkleYoneticiSoyad.Clear();
            MskdTxt_EkleYoneticiTc.Clear();
            MskdTxt_EkleYoneticiTel.Clear();
            Txt_EkleYoneticiMail.Clear();
            Txt_EkleKullaniciAdi.Clear();
            radioBtn_Kadin.Checked = false;
            radioBtn_Erkek.Checked = false;
            MskdTxt_EkleSifre.Clear();
        }

        private void Btn_GuncelleYonetici_Click(object sender, EventArgs e)
        {
            Yonetici guncelleYonetici = new Yonetici();
            guncelleYonetici.Yonetici_ID = Convert.ToInt32(Txt_GuncelleID.Text);
            guncelleYonetici.Yonetici_Ad = Txt_GuncelleYoneticiAdi.Text;
            guncelleYonetici.Yonetici_Soyad = Txt_GuncelleYoneticiSoyadi.Text.ToUpper();
            guncelleYonetici.Yonetici_TC = MskdTxt_GuncelleYoneticiTc.Text;
            guncelleYonetici.Yonetici_TEL = MskdTxt_GuncelleTel.Text;
            guncelleYonetici.Yonetici_Mail = Txt_GuncelleMail.Text;
            guncelleYonetici.Kullanici_Adi = Txt_GuncelleKullaniciAdi.Text;
            guncelleYonetici.Sifre = MskdTxt_GuncelleSifre.Text;
            YoneticiService.ServiceYoneticiGuncelle(guncelleYonetici);
            MessageBox.Show("Yönetici bilgileri başarıyla güncellendi!");

            Txt_GuncelleID.Clear();
            Txt_GuncelleYoneticiAdi.Clear();
            Txt_GuncelleYoneticiSoyadi.Clear();
            MskdTxt_GuncelleYoneticiTc.Clear();
            Txt_GuncelleMail.Clear();
            Txt_GuncelleKullaniciAdi.Clear();
            MskdTxt_GuncelleSifre.Clear();
        }

        private void Btn_SilYonetici_Click(object sender, EventArgs e)
        {
            Yonetici silYönetici = new Yonetici();
            silYönetici.Yonetici_ID = Convert.ToInt32(Txt_Sil_ID.Text);
            YoneticiService.ServiceYoneticiSil(silYönetici.Yonetici_ID);
            MessageBox.Show("Yönetici başarıyla silindi!");
            Txt_Sil_ID.Clear();

        }

        private void dataGrid_YoneticiListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_Sil_ID.Text = dataGrid_YoneticiListele.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txt_GuncelleID.Text = dataGrid_YoneticiListele.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Btn_YoneticiAra_Click(object sender, EventArgs e)
        {
            MySqlCommand yoneticiAra = new MySqlCommand("SELECT * FROM tbl_yonetici WHERE yonetici_id=@P1", dbBaglanti.baglanti);
            yoneticiAra.Parameters.AddWithValue("@P1", Txt_YoneticiAra.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(yoneticiAra);
            dataAdapter.Fill(dt);
            dataGrid_YoneticiListele.DataSource = dt;
        }
    }
}
