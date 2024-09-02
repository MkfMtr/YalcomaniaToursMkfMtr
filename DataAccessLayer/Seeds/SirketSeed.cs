using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class SirketSeed
    {
        public static List<Sirket> GetSeeds()
        {
            return new List<Sirket>
            {
                new Sirket
                {
                    SirketAdi = "Ainamoclay Turizm",
                    SirketMail = "temsilci@ainamoclayturizm.com",
                    SirketTelNo = "0212 123 45 67",
                    SirketGirisAdi = "ainamoclay",
                    SirketSifre = "ainamoclay",
                    SilindiMi = false
                },
                new Sirket
                {
                    SirketAdi = "Otobüsçü Şirket",
                    SirketMail = "temsilci@otobüscü.com",
                    SirketTelNo = "0312 123 45 67",
                    SirketGirisAdi = "otobuscu",
                    SirketSifre = "otobuscu",
                    SilindiMi = false
                }
            };
        }
    }
}
