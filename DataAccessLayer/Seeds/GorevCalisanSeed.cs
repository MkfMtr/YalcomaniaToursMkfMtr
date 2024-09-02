using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class GorevCalisanSeed
    {
        public static List<GorevCalisan> GetSeeds()
        {
            return new List<GorevCalisan>
            {
                    new GorevCalisan { GorevId = 1, CalisanId = 1 },
                    new GorevCalisan { GorevId = 1, CalisanId = 2 },
                    new GorevCalisan { GorevId = 2, CalisanId = 3 },
                    new GorevCalisan { GorevId = 3, CalisanId = 4 },
                    new GorevCalisan { GorevId = 4, CalisanId = 5 },
                    new GorevCalisan { GorevId = 5, CalisanId = 6 },
                    new GorevCalisan { GorevId = 2, CalisanId = 7 },
            };
        }
    }
}
