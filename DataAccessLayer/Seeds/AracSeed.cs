using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class AracSeed
    {
        public static List<Arac> GetSeeds()
        {
            return new List<Arac>()
            {
                new Arac { AracTipiId = 1, PlakaVeyaIsim = "07 ABC 123", SilindiMi = false },
                new Arac { AracTipiId = 2, PlakaVeyaIsim = "07 DEF 456", SilindiMi = false },
            };
        }
    }
}
