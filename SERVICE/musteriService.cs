using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAIN;
using System.Collections;

namespace OtelRezervasyonSistemi.SERVICE
{
    public class musteriService
    {
        public static List<Musteri> ServiceMusterlListesi()
        {
            return MusteriDAO.MusteriListele();
        }
        public static int ServiceMusteriEkle(Musteri gMusteri)
        {
            return MusteriDAO.MusteriEkle(gMusteri);
        }
        public static bool ServiceMusteriGuncelle(Musteri gMusteri)
        {
            return MusteriDAO.MusteriGuncelle(gMusteri);
        }
        public static bool ServiceMusteriSil(int id)
        {
            if (id >= 1)
            {
                return MusteriDAO.MusteriSil(id);
            }
            else
            {
                return false;
            }
        }
        public static bool ServiceMusteriAktifRezKontrol(int musteriID)
        {
            return MusteriDAO.MusteriAktifRezKontrol(musteriID);
        }

        public static List<Musteri> MusteriListesiGetir()
        {
            return MusteriDAO.MusteriListele();
        }
        public static List<int> ServiceGetirRezervasyon_Musteri(int rezervasyonID)
        {
            return MusteriDAO.GetirRezervasyon_Musteri(rezervasyonID);
        }
    }
    
}
