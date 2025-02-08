using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DOMAIN;
using Mysqlx.Cursor;
using System.Data;


namespace OtelRezervasyonSistemi.DAL
{
    class MusteriDAO
    {
      public static List<Musteri> MusteriListele()
        {
            List<Musteri> musteriListesi  = new List<Musteri>();
            MySqlCommand komutum1 = new MySqlCommand("SELECT * FROM tbl_musteri", dbBaglanti.baglanti);
            if (komutum1.Connection.State != ConnectionState.Open)
            {
                komutum1.Connection.Open();
            }
            MySqlDataReader okunan1  = komutum1.ExecuteReader();
            while(okunan1.Read())
            {
                Musteri musteri = new Musteri();
                musteri.Musteri_ID = int.Parse(okunan1["musteri_id"].ToString());
                musteri.Musteri_ADI = okunan1["musteri_adi"].ToString();
                musteri.Musteri_SOYADI = okunan1["musteri_soyadi"].ToString();
                musteri.Musteri_TC = okunan1["musteri_tc"].ToString();
                musteri.Musteri_TEL = okunan1["musteri_tel"].ToString();
                musteriListesi.Add(musteri);
            }
             okunan1.Close();
             return musteriListesi;
        }
        public static int MusteriEkle(Musteri m)
        {
            MySqlCommand komut2 = new MySqlCommand("INSERT INTO tbl_musteri(musteri_adi,musteri_soyadi,musteri_tc,musteri_tel) VALUES (@P1, @P2, @P3, @P4)", dbBaglanti.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", m.Musteri_ADI);
            komut2.Parameters.AddWithValue("@P2", m.Musteri_SOYADI);
            komut2.Parameters.AddWithValue("@P3", m.Musteri_TC);
            komut2.Parameters.AddWithValue("@P4", m.Musteri_TEL);
            return komut2.ExecuteNonQuery();
        }
        public static bool MusteriGuncelle(Musteri m)
        {
            MySqlCommand komut3 = new MySqlCommand("UPDATE tbl_musteri SET musteri_adi=@P1, musteri_soyadi=@P2, musteri_tc=@P3, musteri_tel=@P4 WHERE musteri_id=@P5", dbBaglanti.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1", m.Musteri_ADI);
            komut3.Parameters.AddWithValue("@P2", m.Musteri_SOYADI);
            komut3.Parameters.AddWithValue("@P3", m.Musteri_TC);
            komut3.Parameters.AddWithValue("@P4", m.Musteri_TEL);
            komut3.Parameters.AddWithValue("@P5", m.Musteri_ID);
            return komut3.ExecuteNonQuery() > 0;

        }

        public static bool MusteriSil(int id)
        {
            MySqlCommand komut4 = new MySqlCommand("DELETE FROM tbl_musteri WHERE musteri_id = @P1" ,dbBaglanti.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1",id);
            return komut4.ExecuteNonQuery() > 0;
        }
        public static bool MusteriAktifRezKontrol(int musteriID)
        {
            MySqlCommand komut5 = new MySqlCommand("SELECT COUNT(*) FROM tbl_rezervasyon WHERE musteri_id = @musteriID AND durum = 'AKTİF'", dbBaglanti.baglanti);
            if (komut5.Connection.State != ConnectionState.Open)
            {
                komut5.Connection.Open();
            }
            komut5.Parameters.AddWithValue("@musteriID", musteriID);
            int aktifRezervasyonSayisi = Convert.ToInt32(komut5.ExecuteScalar());
            return aktifRezervasyonSayisi > 0;
        }
        public static List<int> GetirRezervasyon_Musteri(int rezervasyonID)
        {
            List<int> misafirListesi = new List<int>();
            MySqlCommand getirRezMusteri= new MySqlCommand("SELECT musteri_id FROM tbl_rezervasyon_musteri WHERE rezervasyon_id = @rez_id");
            getirRezMusteri.Parameters.AddWithValue("@rez_id", rezervasyonID);
            MySqlDataReader okunanlar = getirRezMusteri.ExecuteReader();
            while (okunanlar.Read())
            {
                misafirListesi.Add(okunanlar.GetInt32(0));
            }
            okunanlar.Close();
            return misafirListesi;
        }
    }
}
