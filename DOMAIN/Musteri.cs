using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAIN
{
    public class Musteri
    {
        private int musteri_id;
        public int Musteri_ID 
        {
            get { return musteri_id; }
            set { musteri_id = value; }
        }
        private string musteri_adi;
        public string Musteri_ADI
        {
            get { return musteri_adi; }
            set { musteri_adi = value; }
        }
        private string musteri_soyadi;
        public string Musteri_SOYADI
        {
            get { return musteri_soyadi; }
            set { musteri_soyadi = value; }
        }
        public string musteri_tc;
        public string Musteri_TC
        {
            get { return musteri_tc; }
            set { musteri_tc = value; }
        }
        public string musteri_tel;
        public string Musteri_TEL
        {
            get { return musteri_tel; }
            set { musteri_tel = value; }
        }
     
    }
}
