using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DOMAIN
{
    public class Oda
    {
        private int oda_id;
        public int Oda_ID
        {
            get { return oda_id; }
            set { oda_id = value; }
        }
        private int oda_no;
        public int Oda_No
        {
            get { return oda_no; }
            set { oda_no = value; }
        }
        private string oda_tur;
        public string Oda_Tur
        {
            get { return oda_tur; }
            set { oda_tur = value; }
        }
        private int oda_fiyat;
        public int Oda_Fiyat
        {
            get { return oda_fiyat; }
            set { oda_fiyat = value; }
        }
        private string oda_durum;
        public string Oda_Durum
        {
            get { return oda_durum; }
            set { oda_durum = value; }
        }
      
    }
}
