using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtelRezervasyonSistemi.DAL;
using OtelRezervasyonSistemi.DOMAIN;

namespace OtelRezervasyonSistemi.SERVICE
{
    public class FaturaService
    {
        public static List<Fatura> ServiceFaturaListele()
        {
            return FaturaDAO.FaturaListele();
        }
        public static bool ServiceFaturaEkle(Fatura gFatura)
        {
            return FaturaDAO.FaturaEkle(gFatura);
        }
        public static bool ServiceFaturaGuncelle(Fatura gFatura)
        {
            return FaturaDAO.FaturaGuncelle(gFatura);
        }
        public static bool ServiceFaturaSil(int p)
        {
            if (p >= 1)
            {
                return FaturaDAO.FaturaSil(p);
            }
            else
            {
                return false;
            }
        }
    }
}
