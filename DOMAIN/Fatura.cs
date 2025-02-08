using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAIN
{
    public class Fatura
    {
        private int fatura_id;
        public int Fatura_ID
        {
            get { return fatura_id; }
            set { fatura_id = value; }
        }
        private int rezervasyon_id;
        public int Rezervasyon_ID
        {
            get { return rezervasyon_id; }
            set { rezervasyon_id = value; }
        }
        private DateTime fatura_tarih;
        public DateTime Fatura_Tarih
        {
            get { return fatura_tarih; }
            set { fatura_tarih = value; }
        }
        private int odeme_tutar;
        public int Odeme_Tutar
        {
            get { return odeme_tutar; }
            set { odeme_tutar = value; }
        }
        private string odeme_sekli;
        public string Odeme_Sekli
        {
            get { return odeme_sekli;}
            set {  odeme_sekli = value;}
        }
        private string odeme_durumu;
        public string Odeme_Durumu
        {
            get{ return odeme_durumu;}
            set { odeme_durumu = value;}
        }
    }
}
