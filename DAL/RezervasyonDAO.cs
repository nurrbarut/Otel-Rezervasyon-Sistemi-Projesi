using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using OtelRezervasyonSistemi.DOMAIN;
using OtelRezervasyonSistemi.SERVICE;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace OtelRezervasyonSistemi.DAL
{
    public class RezervasyonDAO
    {
        public static List<Rezervasyon> RezervasyonListele()
        {
            List<Rezervasyon> rezervasyonListesi = new List<Rezervasyon>();
            MySqlCommand komut1 = new MySqlCommand("SELECT * FROM tbl_rezervasyon", dbBaglanti.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            MySqlDataReader okunan1 = komut1.ExecuteReader();
            while (okunan1.Read())
            {
                Rezervasyon rezervasyon = new Rezervasyon();
                rezervasyon.rezervasyon_ID = int.Parse(okunan1["rezervasyon_id"].ToString());
                rezervasyon.Musteri_ID = int.Parse(okunan1["musteri_id"].ToString());
                rezervasyon.Oda_ID = int.Parse(okunan1["oda_id"].ToString());
                rezervasyon.Giris_Tarihi = DateTime.Parse(okunan1["giris_tarihi"].ToString());
                rezervasyon.Cikis_Tarihi = DateTime.Parse(okunan1["cikis_tarihi"].ToString());
                rezervasyon.Odeme_Tutari = int.Parse(okunan1["odeme_tutari"].ToString());
                rezervasyon.Durum = okunan1["durum"].ToString();
                rezervasyonListesi.Add(rezervasyon);
            }
            okunan1.Close();
            return rezervasyonListesi;
        }

        public static bool RezervasyonEkle(Rezervasyon p, List<int> misafirListesi)
        {
            if (AktifRezKontrol(p.Oda_ID))
            {
                MessageBox.Show("Bu oda için zaten aktif bir rezervasyon bulunmaktadır!");
                return false;
            }

            MySqlCommand fiyatGetir = new MySqlCommand("SELECT oda_fiyat FROM tbl_oda WHERE oda_id = @oda_id", dbBaglanti.baglanti);
            fiyatGetir.Parameters.AddWithValue("@oda_id", p.Oda_ID);
            int odaFiyati = Convert.ToInt32(fiyatGetir.ExecuteScalar());
            int toplamGun = (p.Cikis_Tarihi - p.Giris_Tarihi).Days;
            if (toplamGun < 1) toplamGun = 1;
            int toplamUcret = toplamGun * odaFiyati;

            MySqlCommand komut2 = new MySqlCommand("INSERT INTO tbl_rezervasyon(musteri_id, oda_id, giris_tarihi, cikis_tarihi, odeme_tutari) VALUES (@P1, @P2, @P3, @P4, @P5); SELECT LAST_INSERT_ID();", dbBaglanti.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Musteri_ID);
            komut2.Parameters.AddWithValue("@P2", p.Oda_ID);
            komut2.Parameters.AddWithValue("@P3", p.Giris_Tarihi.ToString("yyyy-MM-dd HH:mm:ss"));
            komut2.Parameters.AddWithValue("@P4", p.Cikis_Tarihi.ToString("yyyy-MM-dd HH:mm:ss"));
            komut2.Parameters.AddWithValue("@P5", toplamUcret);
            bool eklendi = komut2.ExecuteNonQuery() > 0;

            long rezervasyonID = komut2.LastInsertedId;
            foreach (int musteriID in misafirListesi)
            {
                MySqlCommand musteriKomut = new MySqlCommand("INSERT INTO tbl_rezervasyon_musteri (rezervasyon_id, musteri_id) VALUES (@P1, @P2);",dbBaglanti.baglanti);
                musteriKomut.Parameters.AddWithValue("@P1", rezervasyonID);
                musteriKomut.Parameters.AddWithValue("@P2", musteriID);
                musteriKomut.ExecuteNonQuery();
            }

            if (eklendi)
            {
                OdaDAO.OdaDurumGuncelle(p.Oda_ID);

                Fatura yeniFatura = new Fatura
                {
                    Rezervasyon_ID = (int)rezervasyonID,
                    Fatura_Tarih = DateTime.Now,
                    Odeme_Tutar = toplamUcret,
                    Odeme_Sekli = "Nakit",
                    Odeme_Durumu = "Ödenmedi"
                };

                FaturaDAO.FaturaEkle(yeniFatura);
            }
            return eklendi;
        }

        public static bool RezervasyonGuncelle(Rezervasyon p)
        {
            MySqlCommand fiyatGetir = new MySqlCommand("SELECT oda_fiyat FROM tbl_oda WHERE oda_id = @oda_id", dbBaglanti.baglanti);
            fiyatGetir.Parameters.AddWithValue("@oda_id", p.Oda_ID);
            int odaFiyati = Convert.ToInt32(fiyatGetir.ExecuteScalar());
            int toplamGun = (p.Cikis_Tarihi - p.Giris_Tarihi).Days;
            if (toplamGun < 1) toplamGun = 1;
            int toplamUcret = toplamGun * odaFiyati;

            MySqlCommand komut3 = new MySqlCommand("UPDATE tbl_rezervasyon SET musteri_id=@P1,oda_id=@P2,giris_tarihi=@P3,cikis_tarihi=@P4,durum=@P5,odeme_tutari=@P6 WHERE rezervasyon_id=@P7", dbBaglanti.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p.Musteri_ID);
            komut3.Parameters.AddWithValue("@P2", p.Oda_ID);
            komut3.Parameters.AddWithValue("@P3", p.Giris_Tarihi.ToString("yyyy-MM-dd HH:mm:ss"));
            komut3.Parameters.AddWithValue("@P4", p.Cikis_Tarihi.ToString("yyyy-MM-dd HH:mm:ss"));
            komut3.Parameters.AddWithValue("@P5", p.Durum);
            komut3.Parameters.AddWithValue("@P6", toplamUcret);
            komut3.Parameters.AddWithValue("@P7", p.rezervasyon_ID);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool RezervasyonSil(int p)
        {

            MySqlCommand komut4 = new MySqlCommand("DELETE FROM tbl_rezervasyon WHERE rezervasyon_id = @P1", dbBaglanti.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", p);
            int silinenRezSayisi = komut4.ExecuteNonQuery();

            if (silinenRezSayisi > 0)
            {
                if (AktifRezKontrol(p))
                {
                    OdaDAO.OdaDurumGuncelle(p);
                }
                return true;
            }
            return false;
        }

        public static int GetOdaIDByRezervasyonID(int rezervasyonID)
        {
            MySqlCommand komutum2 = new MySqlCommand("SELECT oda_id FROM tbl_rezervasyon WHERE rezervasyon_id = @rezervasyon_ID", dbBaglanti.baglanti);
            komutum2.Parameters.AddWithValue("@rezervasyon_ID", rezervasyonID);
            object sonuc = komutum2.ExecuteScalar();
            return (sonuc != null) ? Convert.ToInt32(sonuc) : -1;

        }
        public static void GecmisRezGuncelle()
        {
            MySqlCommand komutum3 = new MySqlCommand("UPDATE tbl_rezervasyon SET durum = 'PASİF' WHERE cikis_tarihi < CURDATE() AND durum = 'AKTİF'", dbBaglanti.baglanti);
            komutum3.ExecuteNonQuery();

            MySqlCommand komutum4 = new MySqlCommand("SELECT DISTINCT oda_id FROM tbl_rezervasyon WHERE cikis_tarihi < CURDATE() AND durum = 'PASİF'", dbBaglanti.baglanti);
            using (MySqlDataReader okunanlar1 = komutum4.ExecuteReader())
            {
                List<int> odaIDList = new List<int>();
                while (okunanlar1.Read())
                {
                    odaIDList.Add(okunanlar1.GetInt32(0));
                }

                okunanlar1.Close();

                foreach (int odaID in odaIDList)
                {
                    OdaDAO.OdaDurumGuncelle(odaID);
                }
            }

            MySqlDataReader okunanlar = komutum3.ExecuteReader();
            while (okunanlar.Read())
            {
                int odaID = okunanlar.GetInt32(0);
                OdaDAO.OdaDurumGuncelle(odaID);
            }
            okunanlar.Close();
        }
        public static bool AktifRezKontrol(int odaID)
        {
            MySqlCommand rezDurum = new MySqlCommand("SELECT COUNT(*) FROM tbl_rezervasyon WHERE oda_id = @oda_id AND durum = 'AKTİF'", dbBaglanti.baglanti);
            rezDurum.Parameters.AddWithValue("@oda_id", odaID);
            int aktifRezervasyonSayisi = Convert.ToInt32(rezDurum.ExecuteScalar());
            return aktifRezervasyonSayisi > 0;
        }

        public static List<string> GetirRezervasyonMisafirler(int rezervasyonID)
        {
            List<string> misafirListesi = new List<string>();

            MySqlCommand misafirGetir = new MySqlCommand("SELECT m.musteri_id, CONCAT(m.musteri_adi, ' ', m.musteri_soyadi) FROM tbl_musteri m " +
                               "INNER JOIN tbl_rezervasyon_musteri rm ON m.musteri_id = rm.musteri_id " +
                               "WHERE rm.rezervasyon_id = @rez_id",dbBaglanti.baglanti);

            misafirGetir.Parameters.AddWithValue("@rez_id", rezervasyonID);
            MySqlDataReader okunanMisafir = misafirGetir.ExecuteReader();
            while (okunanMisafir.Read())
            {
                int musteriID = okunanMisafir.GetInt32(0); 
                string musteriAdiSoyadi = okunanMisafir.GetString(1); 
                misafirListesi.Add($"[{musteriID}] {musteriAdiSoyadi}");
            }
            okunanMisafir.Close();
        return misafirListesi;

    }
        
        public static string GetirRezervasyonSahibi(int rezervasyonID)
        {
            MySqlCommand rezSahibiGetir = new MySqlCommand("SELECT CONCAT(m.musteri_adi, ' ', m.musteri_soyadi) FROM tbl_musteri m " +
                               "INNER JOIN tbl_rezervasyon r ON m.musteri_id = r.musteri_id " +
                               "WHERE r.rezervasyon_id = @rez_id", dbBaglanti.baglanti);
            rezSahibiGetir.Parameters.AddWithValue("@rez_id", rezervasyonID);
            object sonuc = rezSahibiGetir.ExecuteScalar();
            return sonuc.ToString();
        }
    }
}



    


    
 

