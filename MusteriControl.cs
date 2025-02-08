using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DAL;
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

namespace OtelRezervasyonSistemi
{
    public partial class MusteriControl : UserControl
    {
        public MusteriControl()
        {
            InitializeComponent();
        }

        private void MusteriControl_Load(object sender, EventArgs e)
        {
            List<Musteri> musteriListesi = musteriService.ServiceMusterlListesi();
            dataGrid_MusteriListele.DataSource = musteriListesi;
        }

        private void Btn_MusteriYenile_Click(object sender, EventArgs e)
        {
            List<Musteri> musteriListesi = musteriService.ServiceMusterlListesi();
            dataGrid_MusteriListele.DataSource = musteriListesi;
        }

        private void Btn_MusteriEkle_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.Musteri_ADI = Txt_EkleMusteriAd.Text;
            yeniMusteri.Musteri_SOYADI = Txt_EkleMusteriSoyad.Text.ToUpper();
            yeniMusteri.Musteri_TC = MskdTxt_EkleMusteriTc.Text;
            yeniMusteri.Musteri_TEL = MskdTxt_EkleMusteriTel.Text;
            musteriService.ServiceMusteriEkle(yeniMusteri);
            MessageBox.Show("Müşteri başarıyla kaydedildi!");
            Txt_EkleMusteriAd.Clear();
            Txt_EkleMusteriSoyad.Clear();
            MskdTxt_EkleMusteriTc.Clear();
            MskdTxt_EkleMusteriTel.Clear();
        }

        private void Btn_MusteriGuncelle_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.Musteri_ADI = Txt_GuncelleMusteriAd.Text;
            yeniMusteri.Musteri_SOYADI = Txt_GuncelleMusteriSoyad.Text.ToUpper();
            yeniMusteri.Musteri_TC = MskdTxt_GuncelleMusteriTc.Text;
            yeniMusteri.Musteri_TEL = MskdTxt_GuncelleMusteriTel.Text;
            yeniMusteri.Musteri_ID = Convert.ToInt32(Txt_GuncelleMusteriID.Text);
            musteriService.ServiceMusteriGuncelle(yeniMusteri);
            MessageBox.Show("Müşteri bilgileri başarıyla güncellendi!");
            Txt_GuncelleMusteriAd.Clear();
            Txt_GuncelleMusteriSoyad.Clear();
            MskdTxt_GuncelleMusteriTc.Clear();
            MskdTxt_GuncelleMusteriTel.Clear();
            Txt_GuncelleMusteriID.Clear();

        }

        private void Btn_MusteriSil_Click(object sender, EventArgs e)
        {
            Musteri yeniMusteri = new Musteri();
            yeniMusteri.Musteri_ID = Convert.ToInt32(Txt_SilMusteri_ID.Text);
            musteriService.ServiceMusteriSil(yeniMusteri.Musteri_ID);
            MessageBox.Show("Müşteri başarıyla silindi!");
            Txt_SilMusteri_ID.Clear();
        }

        private void dataGrid_MusteriListele_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_SilMusteri_ID.Text = dataGrid_MusteriListele.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txt_GuncelleMusteriID.Text = dataGrid_MusteriListele.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Btn_MusteriAra_Click(object sender, EventArgs e)
        {
            MySqlCommand musteriAra = new MySqlCommand("SELECT * FROM tbl_musteri WHERE musteri_id=@P1", dbBaglanti.baglanti);
            musteriAra.Parameters.AddWithValue("@P1", Txt_MusteriAra.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(musteriAra);
            dataAdapter.Fill(dt);
            dataGrid_MusteriListele.DataSource = dt;
        }
    }
}
