using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class CalisanSeed
    {
        public static List<Calisan> GetSeeds()
        {
            return new List<Calisan>
            {
                    new Calisan
                    {
                        CalisanAdi = "Default Admin",
                        CalisanSifre = "admin",
                        CalisanTelNo = "0000000000",
                        CalisanMail = "admin",
                        SilindiMi = false,
                        CalisanSoyadi = "Hesap"
                    },
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
                    },
                    new Calisan
                    {
                        CalisanAdi = "Adi 3",
                        CalisanSifre = "3",
                        CalisanTelNo = "1234567890",
                        CalisanMail = "3",
                        SilindiMi = false,
                        CalisanSoyadi = "Soyadi 3"
                    },
                    new Calisan
                    {
                        CalisanAdi = "Adi 4",
                        CalisanSifre = "4",
                        CalisanTelNo = "9876543210",
                        CalisanMail = "4",
                        SilindiMi = false,
                        CalisanSoyadi = "Soyadi 4"
                    },
                    new Calisan
                    {
                        CalisanAdi = "Adi 5",
                        CalisanSifre = "5",
                        CalisanTelNo = "1234567890",
                        CalisanMail = "5",
                        SilindiMi = false,
                        CalisanSoyadi = "Soyadi 5"
                    },
                    new Calisan
                    {
                        CalisanAdi = "Adi 6",
                        CalisanSifre = "6",
                        CalisanTelNo = "9876543210",
                        CalisanMail = "6",
                        SilindiMi = false,
                        CalisanSoyadi = "Soyadi 6"
                    }
            };
        }
    }
}
