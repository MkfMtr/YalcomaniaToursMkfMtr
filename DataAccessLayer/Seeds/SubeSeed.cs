using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class SubeSeed
    {
        public static List<Sube> GetSeeds()
        {
            return new List<Sube>
            {
                new Sube
                {
                    SubeAd = "Merkez Sube",
                    SilindiMi = false
                },
                new Sube
                {
                    SubeAd = "Yan Sube 1",
                    SilindiMi = false
                },

            };
            
        }
    }
}
