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
                new GelirGiderKategori { KategoriAdi = "Bilet Satış Komisyon", GelirGider = false, SilindiMi = false },
                new GelirGiderKategori { KategoriAdi = "PAID", GelirGider = false, SilindiMi = false },
                new GelirGiderKategori { KategoriAdi = "REST", GelirGider = false, SilindiMi = false },
                new GelirGiderKategori { KategoriAdi = "Gezi Maliyeti", GelirGider = true, SilindiMi = false  }
            };
        }
    }
}
