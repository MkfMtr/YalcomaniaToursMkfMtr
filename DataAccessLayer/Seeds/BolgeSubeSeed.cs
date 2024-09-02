using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class BolgeSubeSeed
    {
        public static List<BolgeSube> GetSeeds()
        {
            return new List<BolgeSube>
                {
                    new BolgeSube { BolgeId = 1, SubeId = 1 },
                    new BolgeSube { BolgeId = 1, SubeId = 2 }
                };
        }
    }
}
