using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class TurSeed
    {
        public static List<Tur> GetSeeds()
        {
            return new List<Tur>
            {
                new Tur
                {
                    Tarih = new DateOnly(2024, 09, 30),
                    Saat = new TimeOnly(12, 30),
                    TurTipiId = 1,
                    BittiMi = false,
                    FiyatTRY = 100,
                    FiyatUSD = 10,
                    FiyatEUR = 8,
                    AracId1 = 1,
                    AracId2 = 2,
                    AracId3 = null,
                    AracId4 = null,
                    ServisId1 = 5,
                    ServisId2 = null,
                    ServisId3 = null,
                    TurIptalMi = true
                },
                new Tur
                {
                    Tarih = new DateOnly(2024, 10, 1),
                    Saat = new TimeOnly(12, 30),
                    TurTipiId = 1,
                    BittiMi = true,
                    FiyatTRY = 100,
                    FiyatUSD = 10,
                    FiyatEUR = 8,
                    AracId1 = 1,
                    AracId2 = 2,
                    AracId3 = null,
                    AracId4 = null,
                    ServisId1 = 5,
                    ServisId2 = null,
                    ServisId3 = null,
                    TurIptalMi = false
                },
                new Tur
                {
                    Tarih = new DateOnly(2024, 10, 1),
                    Saat = new TimeOnly(14, 30),
                    TurTipiId = 2,
                    BittiMi = true,
                    FiyatTRY = 200,
                    FiyatUSD = 20,
                    FiyatEUR = 16,
                    AracId1 = 3,
                    AracId2 = null,
                    AracId3 = null,
                    AracId4 = null,
                    ServisId1 = 6,
                    ServisId2 = null,
                    ServisId3 = null,
                    TurIptalMi = false
                },
                new Tur
                {
                    Tarih = new DateOnly(2024, 10, 2),
                    Saat = new TimeOnly(12, 30),
                    TurTipiId = 1,
                    BittiMi = false,
                    FiyatTRY = 100,
                    FiyatUSD = 10,
                    FiyatEUR = 8,
                    AracId1 = 1,
                    AracId2 = 2,
                    AracId3 = null,
                    AracId4 = null,
                    ServisId1 = 5,
                    ServisId2 = null,
                    ServisId3 = null,
                    TurIptalMi = false
                },
                new Tur
                {
                    Tarih = new DateOnly(2024, 10, 2),
                    Saat = new TimeOnly(14, 30),
                    TurTipiId = 2,
                    BittiMi = false,
                    FiyatTRY = 200,
                    FiyatUSD = 20,
                    FiyatEUR = 16,
                    AracId1 = 3,
                    AracId2 = null,
                    AracId3 = null,
                    AracId4 = null,
                    ServisId1 = 6,
                    ServisId2 = null,
                    ServisId3 = null,
                    TurIptalMi = false
                },

            };

        }
    }
}
