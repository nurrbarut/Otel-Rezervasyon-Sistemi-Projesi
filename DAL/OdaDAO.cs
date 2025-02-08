using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DOMAIN;
using OtelRezervasyonSistemi.SERVICE;

namespace OtelRezervasyonSistemi.DAL
{
    public class OdaDAO
    {
        public static List<Oda> OdaListele()
        {
            List<Oda> odaListesi = new List<Oda>();
            MySqlCommand komut1 = new MySqlCommand("SELECT * FROM tbl_oda", dbBaglanti.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            MySqlDataReader okunan1 = komut1.ExecuteReader();
            while (okunan1.Read())
            {
                Oda oda = new Oda();
                oda.Oda_ID = int.Parse(okunan1["oda_id"].ToString());
                oda.Oda_No = int.Parse(okunan1["oda_no"].ToString());
                oda.Oda_Tur = okunan1["oda_turu"].ToString();
                oda.Oda_Fiyat = int.Parse(okunan1["oda_fiyat"].ToString());
                oda.Oda_Durum = okunan1["oda_durum"].ToString();
                odaListesi.Add(oda);
            }
            okunan1.Close();
            return odaListesi;
        }
        public static int OdaEkle(Oda p)
        {
            MySqlCommand komut2 = new MySqlCommand("INSERT INTO tbl_oda(oda_no,oda_turu,oda_fiyat) VALUES (@P1, @P2, @P3)", dbBaglanti.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Oda_No);
            komut2.Parameters.AddWithValue("@P2", p.Oda_Tur);
            komut2.Parameters.AddWithValue("@P3", p.Oda_Fiyat);
            return komut2.ExecuteNonQuery();
        }
        public static bool OdaGuncelle(Oda oda)
        {
            MySqlCommand komut3 = new MySqlCommand("UPDATE tbl_oda SET oda_no=@P1,oda_turu=@P2,oda_fiyat=@P3,oda_durum=@P4 WHERE oda_id=@P5", dbBaglanti.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", oda.Oda_No);
            komut3.Parameters.AddWithValue("@P2", oda.Oda_Tur);
            komut3.Parameters.AddWithValue("@P3", oda.Oda_Fiyat);
            komut3.Parameters.AddWithValue("@P4", oda.Oda_Durum);
            komut3.Parameters.AddWithValue("@P5", oda.Oda_ID);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool OdaSil(int oda)
        {
            MySqlCommand komut4 = new MySqlCommand("DELETE FROM tbl_oda WHERE oda_id = @P1", dbBaglanti.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", oda);
            return komut4.ExecuteNonQuery() > 0;
        }
        public static void OdaDurumGuncelle(int odaId)
        {
            MySqlCommand komutRezDurum = new MySqlCommand("SELECT COUNT(*) FROM tbl_rezervasyon WHERE oda_id = @oda_id AND durum = 'AKTİF'", dbBaglanti.baglanti);
            komutRezDurum.Parameters.AddWithValue("@oda_id", odaId);
            int aktifRezervasyonSayisi = Convert.ToInt32(komutRezDurum.ExecuteScalar());

            string yeniDurum;
            if(aktifRezervasyonSayisi > 0)
            {
                yeniDurum = "DOLU";
            }
            else
            {
                yeniDurum = "BOŞ";
            }
            MySqlCommand komutOdaDurum = new MySqlCommand("UPDATE tbl_oda SET oda_durum = @yeniDurum WHERE oda_id = @oda_id", dbBaglanti.baglanti);
            komutOdaDurum.Parameters.AddWithValue("@oda_id", odaId);
            komutOdaDurum.Parameters.AddWithValue("@yeniDurum",yeniDurum);
            int etkilenenSatir = komutOdaDurum.ExecuteNonQuery();
            komutOdaDurum.ExecuteNonQuery();

        }
    }
}
