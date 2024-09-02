using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class CalisanSeed
    {
        public static List<Calisan> GetCalisanSeeds()
        {
            return new List<Calisan>
                {
                    new Calisan
                    {
                        CalisanAdi = "Adi 1",
                        CalisanSifre = "1",
                        CalisanTelNo = "1234567890",
                        CalisanMail = "1",
                        SilindiMi = false,
                        CalisanSoyadi = "Soyadi 1"
                    },
                    new Calisan
                    {
                        CalisanAdi = "Adi 2",
                        CalisanSifre = "2",
                        CalisanTelNo = "9876543210",
                        CalisanMail = "2",
                        SilindiMi = false,
                        CalisanSoyadi = "Soyadi 2"
                    }
                };
        }
    }
}
