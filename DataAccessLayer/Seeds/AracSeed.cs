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
                new Arac { SahipSirket = 1, AracTipiId = 1, Kapasite = 39, PlakaVeyaIsim = "07 ABC 123", SilindiMi = false },
                new Arac { SahipSirket = 1, AracTipiId = 1, Kapasite = 39, PlakaVeyaIsim = "07 DEF 456", SilindiMi = false },
                new Arac { SahipSirket = 3, AracTipiId = 1, Kapasite = 39, PlakaVeyaIsim = "07 GHI 789", SilindiMi = true },
                new Arac { SahipSirket = 3, AracTipiId = 1, Kapasite = 39, PlakaVeyaIsim = "07 JKL 012", SilindiMi = true },
                new Arac { SahipSirket = 1, AracTipiId = 2, Kapasite = 17, PlakaVeyaIsim = "07 MNO 345", SilindiMi = false },
                new Arac { SahipSirket = 1, AracTipiId = 2, Kapasite = 17, PlakaVeyaIsim = "07 PQR 678", SilindiMi = false },
                new Arac { SahipSirket = 1, AracTipiId = 2, Kapasite = 17, PlakaVeyaIsim = "07 STU 901", SilindiMi = false },
            };
        }
    }
}
