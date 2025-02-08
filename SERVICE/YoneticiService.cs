using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAIN;
namespace OtelRezervasyonSistemi.SERVICE
{
    public class YoneticiService
    {
        public static List<Yonetici> ServiceYoneticiListele()
        {
            return YoneticiDAO.YoneticileriListele();
        }
        public static int ServiceYoneticiEkle(Yonetici gYonetici)
        {
           
           return YoneticiDAO.YoneticiEkle(gYonetici);
            
          
        }
        public static bool ServiceYoneticiSil(int p)
        {
            if (p >= 1)
            {
                return YoneticiDAO.YoneticiSil(p);

            }
            else
            {
                return false;
            }
        }
        public static bool ServiceYoneticiGuncelle(Yonetici gYonetici)
        {
            return YoneticiDAO.YoneticiGuncelle(gYonetici);
        }
    }
    
}
