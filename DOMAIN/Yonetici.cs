using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAIN
{
    public class Yonetici
    {
        private int yonetici_id;
        public int Yonetici_ID
        {
            get { return yonetici_id; }
            set { yonetici_id = value; }
        }
        private string yonetici_Ad;
        public string Yonetici_Ad
        {
            get { return yonetici_Ad; }
            set { yonetici_Ad = value; }
        }
        private string yonetici_soyad;
        public string Yonetici_Soyad
        {
            get { return yonetici_soyad; }
            set { yonetici_soyad = value; }
        }
        private string yonetici_tc;
        public string Yonetici_TC
        {
            get { return yonetici_tc; }
            set { yonetici_tc = value; }
        }
        private string yonetici_cinsiyet;
        public string Yonetici_Cinsiyet
        {
            get { return yonetici_cinsiyet; }
            set { yonetici_cinsiyet = value; }
        }
        private string kullanici_adi;
        public string Kullanici_Adi
        {
            get { return kullanici_adi; }
            set { kullanici_adi = value; }
        }
        private string sifre;
        public string Sifre
        {
            get { return sifre; }
            set { sifre = value; }
        }
        private string yonetici_mail;
        public string Yonetici_Mail
        {
            get { return yonetici_mail; }
            set { yonetici_mail = value; }
        }
        private string yonetici_tel;
        public string Yonetici_TEL
        {
            get { return yonetici_tel; }
            set { yonetici_tel = value; }
        }
    }
}
