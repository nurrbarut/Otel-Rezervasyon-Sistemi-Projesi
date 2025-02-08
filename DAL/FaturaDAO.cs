using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DOMAIN;

namespace OtelRezervasyonSistemi.DAL
{
    public class FaturaDAO
    {
        public static List<Fatura> FaturaListele()
        {
            List<Fatura> faturaListesi = new List<Fatura>();
            MySqlCommand komut1 = new MySqlCommand("SELECT * FROM tbl_fatura", dbBaglanti.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            MySqlDataReader okunan1 = komut1.ExecuteReader();
            while (okunan1.Read())
            {
                Fatura fatura = new Fatura();
                fatura.Fatura_ID= int.Parse(okunan1["fatura_id"].ToString());
                fatura.Rezervasyon_ID = int.Parse(okunan1["rezervasyon_id"].ToString());
                fatura.Odeme_Tutar = int.Parse(okunan1["odeme_tutari"].ToString());
                fatura.Fatura_Tarih = DateTime.Parse(okunan1["fatura_tarih"].ToString());
                fatura.Odeme_Durumu= okunan1["odeme_durumu"].ToString();
                fatura.Odeme_Sekli = okunan1["odeme_sekli"].ToString();
                faturaListesi.Add(fatura);
            }
            okunan1.Close();
            return faturaListesi;
        }
        public static bool FaturaEkle(Fatura p)
        {
            MySqlCommand komut2 = new MySqlCommand("INSERT INTO tbl_fatura(rezervasyon_id,odeme_tutari,fatura_tarih,odeme_durumu,odeme_sekli) VALUES (@P1, @P2, @P3,@P4,@P5)", dbBaglanti.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Rezervasyon_ID);
            komut2.Parameters.AddWithValue("@P2", p.Odeme_Tutar);
            komut2.Parameters.AddWithValue("@P3", p.Fatura_Tarih);
            komut2.Parameters.AddWithValue("@P4", p.Odeme_Durumu);
            komut2.Parameters.AddWithValue("@P5", p.Odeme_Sekli);
            return komut2.ExecuteNonQuery() > 0;
        }
        public static bool FaturaGuncelle(Fatura p)
        {
            MySqlCommand komut3 = new MySqlCommand("UPDATE tbl_fatura SET rezervasyon_id=@P1,odeme_tutari=@P2,fatura_tarih=@P3,odeme_durumu=@P4,odeme_sekli=@P5 WHERE fatura_id=@P6", dbBaglanti.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", p.Rezervasyon_ID);
            komut3.Parameters.AddWithValue("@P2", p.Odeme_Tutar);
            komut3.Parameters.AddWithValue("@P3", p.Fatura_Tarih);
            komut3.Parameters.AddWithValue("@P4", p.Odeme_Durumu);
            komut3.Parameters.AddWithValue("@P5", p.Odeme_Sekli);
            komut3.Parameters.AddWithValue("@P6", p.Fatura_ID);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool FaturaSil(int p)
        {
            MySqlCommand komut4 = new MySqlCommand("DELETE FROM tbl_fatura WHERE fatura_id = @P1", dbBaglanti.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", p);
            return komut4.ExecuteNonQuery() > 0;
        }

    }     
}
