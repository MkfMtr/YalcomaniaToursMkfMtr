using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class KurSeed
    {
        public static List<Kur> GetSeeds()
        {
            return new List<Kur>()
            {
                new Kur { Tarih = new DateOnly(2024,01,01), ParaBirimiAdi = "TRY", DolaraOran = 0.029m, EuroyaOran = 0.026m }
            };
        }
    }
}
