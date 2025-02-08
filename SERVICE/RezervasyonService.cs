using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAIN;

namespace OtelRezervasyonSistemi.SERVICE
{
    public class RezervasyonService
    {
        public static List<Rezervasyon> ServiceRezervasyonListele()
        {
            return RezervasyonDAO.RezervasyonListele();
        }
        public static bool ServiceRezervasyonEkle(Rezervasyon gRezervasyon, List<int> misafirListesi)
        {

            bool aktifRezervasyonSayisi = RezervasyonDAO.AktifRezKontrol(gRezervasyon.Oda_ID);
            bool eklendi = RezervasyonDAO.RezervasyonEkle(gRezervasyon, misafirListesi);

            if (eklendi)
            {
                OdaDAO.OdaDurumGuncelle(gRezervasyon.Oda_ID);
            }

            return eklendi;
        }

        
        public static bool ServiceRezervasyonGuncelle(Rezervasyon gRezervasyon)
        {
            bool guncellendi = RezervasyonDAO.RezervasyonGuncelle(gRezervasyon);

            if (guncellendi)
            {
                int odaID = gRezervasyon.Oda_ID;
                OdaDAO.OdaDurumGuncelle(odaID);
            }
            return guncellendi;
        }
        public static bool ServiceRezervasyonSil(int rezervasyonId)
        {
            int odaID = RezervasyonDAO.GetOdaIDByRezervasyonID(rezervasyonId);
            bool silindi = RezervasyonDAO.RezervasyonSil(rezervasyonId);
            if (silindi)
            {
                OdaDAO.OdaDurumGuncelle(odaID);
            }
            return silindi;
        }
        public static void ServiceGecmisRezGuncelle()
        {
            RezervasyonDAO.GecmisRezGuncelle();
        }
        public static List<string> ServiceGetirRezervasyonMisafirleri(int rezervasyonID)
        {
            return RezervasyonDAO.GetirRezervasyonMisafirler(rezervasyonID);
        }
        public static string ServiceGetirRezervasyonSahibi(int rezervasyonID)
        {
            return RezervasyonDAO.GetirRezervasyonSahibi(rezervasyonID);
        }

    }
}
