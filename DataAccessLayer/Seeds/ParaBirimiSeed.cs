using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class ParaBirimiSeed
    {
        public static List<ParaBirimi> GetSeeds()
        {
            return new List<ParaBirimi>
            {
                new ParaBirimi
                {
                    Iso4217 = "TRY",
                    ParaBirimiAdi = "Türk Lirası",
                    SilindiMi = false
                },
                new ParaBirimi
                {
                    Iso4217 = "USD",
                    ParaBirimiAdi = "Amerikan Doları",
                    SilindiMi = false
                },
                new ParaBirimi
                {
                    Iso4217 = "EUR",
                    ParaBirimiAdi = "Avro",
                    SilindiMi = false
                }

            };
            
        }
    }
}
