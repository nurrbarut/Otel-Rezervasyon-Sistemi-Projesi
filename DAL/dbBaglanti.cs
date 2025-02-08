using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelRezervasyonSistemi.DAL
{
    public class dbBaglanti
    {
        public static MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.253;Database=25_132330042;User=25_132330042;Password=!nif.ogr42BA;");
     
    }
}
