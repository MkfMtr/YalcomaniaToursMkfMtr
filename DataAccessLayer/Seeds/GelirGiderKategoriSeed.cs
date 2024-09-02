using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class GelirGiderKategoriSeed
    {
        public static List<GelirGiderKategori> GetSeeds()
        {
            return new List<GelirGiderKategori>()
            {
                new GelirGiderKategori { KategoriAdi = "Gelir Tipi 1", GelirGider = false, SilindiMi = false },
                new GelirGiderKategori { KategoriAdi = "Gidr Tipi 1", GelirGider = true, SilindiMi = false  }
            };
        }
    }
}
