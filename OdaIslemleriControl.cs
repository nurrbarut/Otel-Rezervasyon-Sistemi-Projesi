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
    public partial class OdaIslemleriControl : UserControl
    {
        public OdaIslemleriControl()
        {
            InitializeComponent();
        }

        private void OdaIslemleriControl_Load(object sender, EventArgs e)
        {
            List<Oda> odaListesi = odaService.ServiceOdaListele();
            dataGrid_OdaListesi.DataSource = odaListesi;
            dataGrid_OdaListesi.CellFormatting += dataGrid_OdaListesi_CellFormatting;
        }

        private void Btn_OdaListesiYenile_Click(object sender, EventArgs e)
        {
            List<Oda> odaListesi = odaService.ServiceOdaListele();
            dataGrid_OdaListesi.DataSource = odaListesi;
        }

        private void Btn_EkleOda_Click(object sender, EventArgs e)
        {
            Oda yeniOda = new Oda();
            yeniOda.Oda_No = Convert.ToInt32(Txt_EkleOdaNo.Text);
            yeniOda.Oda_Tur = comboBox_EkleOdaTur.Text;
            if (comboBox_EkleOdaTur.Text == "Tek Kişilik")
            {
                yeniOda.Oda_Fiyat = 1800;
            }
            else if (comboBox_EkleOdaTur.Text == "İki Kişilik")
            {
                yeniOda.Oda_Fiyat = 3200;
            }
            else if (comboBox_EkleOdaTur.Text == "Üç Kişilik")
            {
                yeniOda.Oda_Fiyat = 5000;
            }
            else
            {
                yeniOda.Oda_Fiyat = 7200;
            }
            odaService.ServiceOdaEkle(yeniOda);
            MessageBox.Show("Oda başarıyla eklendi!");
        }

        private void Btn_GuncelleOda_Click(object sender, EventArgs e)
        {
            Oda yeniOda = new Oda();
            yeniOda.Oda_ID = Convert.ToInt32(Txt_GuncelleOdaId.Text);
            yeniOda.Oda_No = Convert.ToInt32(Txt_GuncelleOdaNo.Text);
            yeniOda.Oda_Tur = comboBox_GuncelleOdaTur.Text;
            yeniOda.Oda_Fiyat = Convert.ToInt32(Txt_GuncelleOdaFiyat.Text);
            if (rdBtn_Bos.Checked)
            {
                yeniOda.Oda_Durum = "BOŞ";
            }
            else
            {
                yeniOda.Oda_Durum = "DOLU";
            }
            odaService.ServiceOdaGuncelle(yeniOda);
            MessageBox.Show("Oda başarıyla güncellendi!");

        }

        private void Btn_SilOda_Click(object sender, EventArgs e)
        {
            Oda yeniOda = new Oda();
            yeniOda.Oda_ID = Convert.ToInt32(Txt_SılOdaId.Text);
            odaService.ServiceOdaSil(yeniOda.Oda_ID);
            MessageBox.Show("Oda başarıyla silindi!");

        }

        private void dataGrid_OdaListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Txt_SılOdaId.Text = dataGrid_OdaListesi.Rows[e.RowIndex].Cells[0].Value.ToString();
            Txt_GuncelleOdaId.Text = dataGrid_OdaListesi.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void Btn_OdaAra_Click(object sender, EventArgs e)
        {
            MySqlCommand odaAra = new MySqlCommand("SELECT * FROM tbl_oda WHERE oda_id=@P1", dbBaglanti.baglanti);
            odaAra.Parameters.AddWithValue("@P1", Txt_OdaAra.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(odaAra);
            dataAdapter.Fill(dt);
            dataGrid_OdaListesi.DataSource = dt;

        }

        private void dataGrid_OdaListesi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGrid_OdaListesi.Columns[e.ColumnIndex].Name == "Oda_Durum")
            {
                if (e.Value != null && e.Value.ToString() == "BOŞ")
                {
                    dataGrid_OdaListesi.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                else if (e.Value != null && e.Value.ToString() == "DOLU")
                {
                    dataGrid_OdaListesi.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Crimson;
                }
            }
        }

        private void Btn_OdaTuruAra_Click(object sender, EventArgs e)
        {
            MySqlCommand odaTuruAra = new MySqlCommand("SELECT * FROM tbl_oda WHERE oda_turu=@P1", dbBaglanti.baglanti);
            odaTuruAra.Parameters.AddWithValue("@P1", comboBox_AraOdaTuru.Text);
            DataTable dt = new DataTable();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(odaTuruAra);
            dataAdapter.Fill(dt);
            dataGrid_OdaListesi.DataSource = dt;
        }
    }
}
