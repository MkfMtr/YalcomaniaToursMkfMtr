using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class BolgeSeed
    {
        public static List<Bolge> GetSeeds()
        {
            return new List<Bolge>
                {
                    new Bolge
                    {
                        BolgeIsim = "Bolge Merkez",
                        BolgeMerkezeUzaklikMetre = 0,
                        ServisSaati = new TimeOnly(9, 30),
                        SilindiMi = false
                    },
                    new Bolge
                    {
                        BolgeIsim = "Bolge 1",
                        BolgeMerkezeUzaklikMetre = 2000,
                        ServisSaati = new TimeOnly(10, 0),
                        SilindiMi = false
                    }
                };
        }
    }
}
