using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class OtelSeed
    {
        public static List<Otel> GetSeeds()
        {
            return new List<Otel>
            {
                    new Otel
                    {
                        OtelIsim = "Merkez Otel 1",
                        OtelMerkezeUzaklikMetre = 300,
                        SilindiMi = false
                    },
                    new Otel
                    {
                        OtelIsim = "Merkez Otel 2",
                        OtelMerkezeUzaklikMetre = 500,
                        SilindiMi = false
                    },
                    new Otel
                    {
                        OtelIsim = "Bolge 1 Otel 1",
                        OtelMerkezeUzaklikMetre = 1500,
                        SilindiMi = false
                    },
                    new Otel
                    {
                        OtelIsim = "Bolge 1 Otel 2",
                        OtelMerkezeUzaklikMetre = 2150,
                        SilindiMi = false
                    }
            };
        }
    }
}
