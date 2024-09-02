using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class BolgeOtelSeed
    {
        public static List<BolgeOtel> GetSeeds()
        {
            return new List<BolgeOtel>
            {
                    new BolgeOtel { BolgeId = 1, OtelId = 1 },
                    new BolgeOtel { BolgeId = 1, OtelId = 2 },
                    new BolgeOtel { BolgeId = 2, OtelId = 3 },
                    new BolgeOtel { BolgeId = 2, OtelId = 4 },
            };
        }
    }
}
