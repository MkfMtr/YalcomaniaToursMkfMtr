using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class UyrukSeed
    {
        public static List<Uyruk> GetSeeds()
        {
            return new List<Uyruk>
            {
                new Uyruk { Alpha3Code = "TUR", UlkeIsmi = "Türkiye", SilindiMi = false },
                new Uyruk { Alpha3Code = "USA", UlkeIsmi = "Amerika Birleşik Devletleri", SilindiMi = false },
                new Uyruk { Alpha3Code = "DEU", UlkeIsmi = "Almanya", SilindiMi = false }
            };
        }
    }
}
