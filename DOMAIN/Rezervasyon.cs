using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAIN
{
    public class Rezervasyon
    {
        private int rezervasyon_id;
        public int rezervasyon_ID
        {
            get { return rezervasyon_id; }
            set { rezervasyon_id = value; }
        }
        private int musteri_id;
        public int Musteri_ID
        {
            get { return musteri_id; }
            set { musteri_id = value; }
        }
        private int oda_id;
        public int Oda_ID
        {
            get { return oda_id; }
            set { oda_id = value; }
        }
        private DateTime giris_Tarihi;
        public DateTime Giris_Tarihi
        {
            get { return giris_Tarihi; }
            set { giris_Tarihi = value; }
        }
        private DateTime cikis_tarihi;
        public DateTime Cikis_Tarihi
        {
            get { return cikis_tarihi; }
            set { cikis_tarihi = value; }
        }
        private int odeme_tutari;
        public int Odeme_Tutari
        {
            get { return odeme_tutari; }
            set { odeme_tutari = value; }
        }
        private string durum;
        public string Durum
        {
            get { return durum; }
            set { durum = value; }
        }
      

    }
}
