using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAIN;
using System.Collections;
using System.Reflection.Metadata.Ecma335;

namespace OtelRezervasyonSistemi.SERVICE
{
    public class odaService
    {
        public static List<Oda> ServiceOdaListele()
        {
            return OdaDAO.OdaListele();
        }
        public static int ServiceOdaEkle(Oda gOda)
        {
            return OdaDAO.OdaEkle(gOda);
        }
        public static bool ServiceOdaGuncelle(Oda gOda)
        {
            return OdaDAO.OdaGuncelle(gOda);
        }
        public static bool ServiceOdaSil(int p)
        {
            if (p >= 1)
            {
                return OdaDAO.OdaSil(p);
            }
            else
            {
                return false;
            }
        }
        public static void ServiceOdaDurumGuncelle(int odaId)
        {
            OdaDAO.OdaDurumGuncelle(odaId);
        }
      

    }
}
