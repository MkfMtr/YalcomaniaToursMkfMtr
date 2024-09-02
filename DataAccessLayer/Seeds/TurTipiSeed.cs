using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class TurTipiSeed
    {
        public static List<TurTipi> GetSeeds()
        {
            return new List<TurTipi>()
            {
                new TurTipi { TurTipiAdi = "Sehir Turu 1", AracTipiId = 1 , SilindiMi = false },
                new TurTipi { TurTipiAdi = "Sehir Turu 2", AracTipiId = 1 , SilindiMi = false },
            };
        }
    }
}
