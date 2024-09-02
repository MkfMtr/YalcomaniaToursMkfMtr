using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class GorevSeed
    {
        public static List<Gorev> GetSeedData()
        {
            return new List<Gorev>
            {
                    new Gorev {GorevAdi = "admin", Aciklama = null, SilindiMi = false },
                    new Gorev {GorevAdi = "user", Aciklama = null, SilindiMi = false }
            };
        }
    }
}
