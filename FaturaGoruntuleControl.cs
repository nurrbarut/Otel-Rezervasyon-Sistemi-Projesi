using OtelRezervasyonSistemi.DOMAIN;
using OtelRezervasyonSistemi.SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OtelRezervasyonSistemi.DAL;
using MySql.Data.MySqlClient;


namespace OtelRezervasyonSistemi
{
    public partial class FaturaGoruntuleControl : UserControl
    {
        public FaturaGoruntuleControl()
        {
            InitializeComponent();
        }

        private void FaturaGoruntuleControl_Load(object sender, EventArgs e)
        {
            List<Fatura> faturaListesi = FaturaService.ServiceFaturaListele();
            dataGrid_FaturaGoruntule.DataSource = faturaListesi;
        }

        private void Btn_FaturaEkle_Click(object sender, EventArgs e)
        {
            Fatura yeniFatura = new Fatura();

            yeniFatura.Rezervasyon_ID = Convert.ToInt32(Txt_EkleFaturaRezID.Text);
            yeniFatura.Odeme_Tutar = Convert.ToInt32(comboBox_FaturaEkleOdemeTutarı.Text);
            if (radioButton_EkleFaturaKart.Checked)
            {
                yeniFatura.Odeme_Sekli = "KART";
            }
            else
            {
                yeniFatura.Odeme_Sekli = "NAKİT";
            }
            yeniFatura.Odeme_Durumu = comboBox_EkleFatura.Text;
            FaturaService.ServiceFaturaEkle(yeniFatura);
            MessageBox.Show("Fatura başarıyla kaydedildi!");

        }

        private void Btn_FaturaGuncelle_Click(object sender, EventArgs e)
        {
            Fatura yeniFatura = new Fatura();
            yeniFatura.Rezervasyon_ID = Convert.ToInt32(Txt_GuncelleRezID.Text);
            yeniFatura.Fatura_Tarih = dateTime_GuncelleFaturaTarih.Value;
            yeniFatura.Odeme_Tutar = Convert.ToInt32(comboBox_FaturaGuncelleOdemeTutarı.Text);
            if (radioBtn_GuncelleFaturaKart.Checked)
            {
                yeniFatura.Odeme_Sekli = "KART";
            }
            else
            {
                yeniFatura.Odeme_Sekli = "NAKİT";
            }
            yeniFatura.Odeme_Sekli = comboBox_GuncelleFaturaDurum.Text;
            FaturaService.ServiceFaturaGuncelle(yeniFatura);
            MessageBox.Show("Fatura başarıyla güncellendi!");
        }

        private void Btn_FaturaSil_Click(object sender, EventArgs e)
        {
            Fatura yeniFatura = new Fatura();
            yeniFatura.Fatura_ID = Convert.ToInt32(Txt_FaturaSil.Text);
            FaturaService.ServiceFaturaSil(yeniFatura.Fatura_ID);
            MessageBox.Show("Fatura başarıyla silindi!");
        }

        private void Btn_FaturaAra_Click(object sender, EventArgs e)
        {
            MySqlCommand faturaAra = new MySqlCommand("SELECT * FROM tbl_fatura WHERE fatura_id=@P1", dbBaglanti.baglanti);
            faturaAra.Parameters.AddWithValue("@P1", Txt_FaturaAra.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(faturaAra);
            dataAdapter.Fill(dt);
            dataGrid_FaturaGoruntule.DataSource = dt;
        }

        private void Btn_FaturaYenile_Click(object sender, EventArgs e)
        {
            List<Fatura> faturaListesi = FaturaService.ServiceFaturaListele();
            dataGrid_FaturaGoruntule.DataSource = faturaListesi;

        }
    }
}
