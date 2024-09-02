using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class AracTipiSeed
    {
        public static List<AracTipi> GetSeeds()
        {
            return new List<AracTipi>()
            {
                new AracTipi { AracTipiAdi = "Otobüs", SilindiMi = false },
                new AracTipi { AracTipiAdi = "Servis", SilindiMi = false }
            };
        }
    }
}
