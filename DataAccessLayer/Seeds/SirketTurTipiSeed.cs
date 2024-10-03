using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class SirketTurTipiSeed
    {
        public static List<SirketTurTipi> GetSeeds()
        {
            return new List<SirketTurTipi>()
            {
                new SirketTurTipi { SirketId = 1, TurTipiId = 1 },
                new SirketTurTipi { SirketId = 1, TurTipiId = 2 },
                new SirketTurTipi { SirketId = 2, TurTipiId = 1 },
                new SirketTurTipi { SirketId = 2, TurTipiId = 2 },
            };
        }
    }
}
