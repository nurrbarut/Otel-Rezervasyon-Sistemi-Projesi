using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAIN;
using OtelRezervasyonSistemi.SERVICE;

namespace OtelRezervasyonSistemi
{
    public partial class RezervasyonIslemleriControl : UserControl
    {
        public RezervasyonIslemleriControl()
        {
            InitializeComponent();
        }

        private void RezervasyonIslemleriControl_Load(object sender, EventArgs e)
        {
            List<Rezervasyon> rezervasyonListesi = RezervasyonService.ServiceRezervasyonListele();
            dataGrid_ListeleRezervasyon.DataSource = rezervasyonListesi;
            RezervasyonService.ServiceGecmisRezGuncelle();
            MusteriListesiniYukle();
        }

        private void Btn_RezListesiYenile_Click(object sender, EventArgs e)
        {
            List<Rezervasyon> rezervasyonListesi = RezervasyonService.ServiceRezervasyonListele();
            dataGrid_ListeleRezervasyon.DataSource = rezervasyonListesi;

        }

        private void Btn_EkleRez_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateTime_RezEkleGiris.Value.Date;
            DateTime cikisTarihi = dateTime_RezEkleCikis.Value.Date;

            if (girisTarihi < DateTime.Today || cikisTarihi < DateTime.Today)
            {
                MessageBox.Show("Lütfen güncel giriş ve çıkış tarihleri seçiniz!");
                return;
            }

            if (cikisTarihi <= girisTarihi)
            {
                MessageBox.Show("Çıkış tarihi, giriş tarihinden önce veya aynı olamaz!");
                return;
            }

            List<int> misafirListesi = new List<int>();
            foreach (var item in checkedListBox_Misafir.CheckedItems)
            {
                var selectedPair = (KeyValuePair<int, string>)item;
                misafirListesi.Add(selectedPair.Key);
            }

            Rezervasyon yeniRezervasyon = new Rezervasyon();
            yeniRezervasyon.Musteri_ID = Convert.ToInt32(Txt_EkleRezMusteriID.Text);
            yeniRezervasyon.Oda_ID = Convert.ToInt32(Txt_EkleRezOdaID.Text);
            yeniRezervasyon.Giris_Tarihi = girisTarihi;
            yeniRezervasyon.Cikis_Tarihi = cikisTarihi;


            if (musteriService.ServiceMusteriAktifRezKontrol(yeniRezervasyon.Musteri_ID))
            {
                MessageBox.Show("Bu müşterinin aktif bir rezervasyonu bulunmaktadır!");
                return;
            }

            bool eklendi = RezervasyonService.ServiceRezervasyonEkle(yeniRezervasyon, misafirListesi);

            if (eklendi)
            {
                MessageBox.Show("Rezervasyon başarıyla oluşturuldu!");
                checkedListBox_Misafir.ClearSelected();
            }
            else
            {
                MessageBox.Show("Rezervasyon oluşturulamadı, lütfen tekrar deneyiniz.");
            }
        }

        private void Btn_GuncelleRez_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = dateTime_RezGuncelleGiris.Value.Date;
            DateTime cikisTarihi = dateTime_RezGuncelleCikis.Value.Date;

            if (girisTarihi < DateTime.Today || cikisTarihi < DateTime.Today)
            {
                MessageBox.Show("Lütfen güncel giriş ve çıkış tarihleri seçiniz!");
                return;
            }

            if (cikisTarihi <= girisTarihi)
            {
                MessageBox.Show("Çıkış tarihi, giriş tarihinden önce veya aynı olamaz!");
                return;
            }

            Rezervasyon yeniRezervasyon = new Rezervasyon();
            yeniRezervasyon.rezervasyon_ID = Convert.ToInt32(Txt_GuncelleRezID.Text);
            yeniRezervasyon.Musteri_ID = Convert.ToInt32(Txt_GuncellEMusteriID.Text);
            yeniRezervasyon.Oda_ID = Convert.ToInt32(Txt_GuncelleRezOdaID.Text);
            yeniRezervasyon.Giris_Tarihi = girisTarihi;
            yeniRezervasyon.Cikis_Tarihi = cikisTarihi;
            yeniRezervasyon.Durum = comboBox_RezGuncelleDurum.Text;
            if (RezervasyonService.ServiceRezervasyonGuncelle(yeniRezervasyon))
            {
                MessageBox.Show("Rezervasyon başarıyla güncellendi!");
            }
            else
            {
                MessageBox.Show("Rezervasyon güncellenemedi, lütfen tekrar deneyiniz.");
            }

        }

        private void Btn_SilRez_Click(object sender, EventArgs e)
        {
            int rezervasyonID = Convert.ToInt32(Txt_SilRezID.Text);

            bool silindi = RezervasyonService.ServiceRezervasyonSil(rezervasyonID);

            if (silindi)
            {
                MessageBox.Show("Rezervasyon başarıyla iptal edildi ve oda durumu güncellendi!");
            }
            else
            {
                MessageBox.Show("Rezervasyon silinemedi, lütfen tekrar deneyiniz.");
            }

        }

        private void Btn_RezervasyonAra_Click(object sender, EventArgs e)
        {
            MySqlCommand rezervasyonAra = new MySqlCommand("SELECT * FROM tbl_rezervasyon WHERE giris_tarihi >= @GirisTarihi AND cikis_tarihi <= @CikisTarihi", dbBaglanti.baglanti);
            rezervasyonAra.Parameters.AddWithValue("@GirisTarihi", dateTimep_girisTarihi.Value);
            rezervasyonAra.Parameters.AddWithValue("@CikisTarihi", dateTimep_CikisTarihi.Value);
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(rezervasyonAra);
            dataAdapter.Fill(dt);
            dataGrid_ListeleRezervasyon.DataSource = dt;

        }

        private void dataGrid_ListeleRezervasyon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGrid_ListeleRezervasyon.Columns[e.ColumnIndex].Name == "Durum")
            {
                if (e.Value != null && e.Value.ToString() == "AKTİF")
                {
                    dataGrid_ListeleRezervasyon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orchid;
                }
                else if (e.Value != null && e.Value.ToString() == "PASİF")
                {
                    dataGrid_ListeleRezervasyon.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Silver;
                }
            }
        }
        private void MusteriListesiniYukle()
        {
            checkedListBox_Misafir.Items.Clear();

            List<Musteri> musteriler = musteriService.MusteriListesiGetir();

            foreach (var musteri in musteriler)
            {
                checkedListBox_Misafir.Items.Add(new KeyValuePair<int, string>(musteri.Musteri_ID, musteri.Musteri_ADI + " " + musteri.Musteri_SOYADI));
            }

            checkedListBox_Misafir.DisplayMember = "Value";
            checkedListBox_Misafir.ValueMember = "Key";
        }
        private void RezBilgileriniGoruntule()
        {
            int rezervasyonID = Convert.ToInt32(dataGrid_ListeleRezervasyon.SelectedRows[0].Cells["rezervasyon_id"].Value);
            string rezervasyonSahibi = RezervasyonService.ServiceGetirRezervasyonSahibi(rezervasyonID);
            Lbl_RezSahibi.Text = ("Rezervasyon Sahibi: ") + "\n" + rezervasyonSahibi;
            List<string> misafirler = RezervasyonService.ServiceGetirRezervasyonMisafirleri(rezervasyonID);
            if (misafirler.Count > 0)
            {
                foreach (string misafir in misafirler)
                {
                    Lbl_Misafirler.Text = "Misafirler: " + "\n" + misafir;
                }
            }
            else
            {
                Lbl_Misafirler.Text = "Misafir bulunmuyor.";
            }
        }

        private void dataGrid_ListeleRezervasyon_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid_ListeleRezervasyon.SelectedRows.Count > 0)
            {
                RezBilgileriniGoruntule();
            }
        }

 
    }
}

