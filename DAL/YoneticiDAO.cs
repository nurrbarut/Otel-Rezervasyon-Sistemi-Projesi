using MySql.Data.MySqlClient;
using OtelRezervasyonSistemi.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Mysqlx.Prepare;

namespace OtelRezervasyonSistemi.DAL
{
    public class YoneticiDAO
    {
        public static List<Yonetici> YoneticileriListele()
        {
            List<Yonetici> yoneticiListesi = new List<Yonetici>();
            MySqlCommand komut1 = new MySqlCommand("SELECT * FROM tbl_yonetici", dbBaglanti.baglanti);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            MySqlDataReader okunanlar1 = komut1.ExecuteReader();
            while (okunanlar1.Read())
            {
                Yonetici yonetici = new Yonetici();
                yonetici.Yonetici_ID = int.Parse(okunanlar1["yonetici_id"].ToString());
                yonetici.Yonetici_Ad = okunanlar1["yonetici_adi"].ToString();
                yonetici.Yonetici_Soyad = okunanlar1["yonetici_soyadi"].ToString();
                yonetici.Yonetici_TC = okunanlar1["yonetici_tc"].ToString();
                yonetici.Yonetici_Cinsiyet = okunanlar1["yonetici_cinsiyet"].ToString();
                yonetici.Yonetici_TEL = okunanlar1["yonetici_tel"].ToString();
                yonetici.Yonetici_Mail = okunanlar1["yonetici_mail"].ToString();
                yonetici.Kullanici_Adi = okunanlar1["kullaniciadi"].ToString();
                yonetici.Sifre = okunanlar1["sifre"].ToString();
                yoneticiListesi.Add(yonetici);
            }
            okunanlar1.Close();
            return yoneticiListesi;

        }
        public static int YoneticiEkle(Yonetici p)
        {
            MySqlCommand komut2 = new MySqlCommand("INSERT INTO tbl_yonetici(yonetici_adi, yonetici_soyadi,yonetici_cinsiyet,yonetici_tc,yonetici_tel,yonetici_mail,kullaniciadi,sifre) VALUES (@P1,@P2,@P3,@P4,@P5,@P6,@P7,@P8)", dbBaglanti.baglanti);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@P1", p.Yonetici_Ad); 
            komut2.Parameters.AddWithValue("@P2", p.Yonetici_Soyad);
            komut2.Parameters.AddWithValue("@P3", p.Yonetici_Cinsiyet);
            komut2.Parameters.AddWithValue("@P4", p.Yonetici_TC);
            komut2.Parameters.AddWithValue("@P5", p.Yonetici_TEL);
            komut2.Parameters.AddWithValue("@P6", p.Yonetici_Mail);
            komut2.Parameters.AddWithValue("@P7", p.Kullanici_Adi);
            komut2.Parameters.AddWithValue("@P8", p.Sifre);
            return komut2.ExecuteNonQuery();
        }
        public static bool YoneticiSil(int p)
        {
            MySqlCommand komut3 = new MySqlCommand("DELETE FROM tbl_yonetici WHERE yonetici_id=@P1", dbBaglanti.baglanti);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@P1",p);
            return komut3.ExecuteNonQuery() > 0;
           
        }
        public static bool YoneticiGuncelle(Yonetici p)
        {
            MySqlCommand komut4 = new MySqlCommand("UPDATE tbl_yonetici SET yonetici_adi = @P1, yonetici_soyadi=@P2,yonetici_tc=@P3,yonetici_tel=@P4,yonetici_mail=@P5,kullaniciadi=@P6,sifre=@P7 WHERE yonetici_id=@P8", dbBaglanti.baglanti);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@P1", p.Yonetici_Ad);
            komut4.Parameters.AddWithValue("@P2", p.Yonetici_Soyad);
            komut4.Parameters.AddWithValue("@P3", p.Yonetici_TC);
            komut4.Parameters.AddWithValue("@P4", p.Yonetici_TEL);
            komut4.Parameters.AddWithValue("@P5", p.Yonetici_Mail);
            komut4.Parameters.AddWithValue("@P6", p.Kullanici_Adi);
            komut4.Parameters.AddWithValue("@P7", p.Sifre);
            komut4.Parameters.AddWithValue("@P8", p.Yonetici_ID);
            return komut4.ExecuteNonQuery() > 0;

        }
    }
}
