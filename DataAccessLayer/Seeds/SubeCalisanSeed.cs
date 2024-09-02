using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class SubeCalisanSeed
    {
        public static List<SubeCalisan> GetSeeds()
        {
            return new List<SubeCalisan>()
            {
                new SubeCalisan { SubeId = 1, CalisanId = 1 },
                new SubeCalisan { SubeId = 1, CalisanId = 2 },
                new SubeCalisan { SubeId = 1, CalisanId = 3 },
                new SubeCalisan { SubeId = 1, CalisanId = 4 },
                new SubeCalisan { SubeId = 1, CalisanId = 5 },
                new SubeCalisan { SubeId = 1, CalisanId = 6 },
                new SubeCalisan { SubeId = 2, CalisanId = 7 },
            };
        }
    }
}
