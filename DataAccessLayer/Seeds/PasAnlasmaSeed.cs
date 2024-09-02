using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class PasAnlasmaSeed
    {
        public static List<PasAnlasma> GetSeeds()
        {
            return new List<PasAnlasma>
            {
                new PasAnlasma
                {
                    Tarih = new DateOnly(2024, 08, 30),
                    Sirket = 1,
                    AlacakParaBirimi = "TRY",
                    AlacakF = 20.00m,
                    AlacakH = 10.00m,
                    VerecekParaBirimi = "TRY",
                    VerecekF = 25.00m,
                    VerecehH = 12.50m,
                    AnlasmaBittiMi = false,
                },
            };
        }
    }
}
