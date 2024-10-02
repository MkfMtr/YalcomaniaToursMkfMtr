﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class BiletSeed
    {
        public static List<Bilet> GetSeeds()
        {
            return new List<Bilet>
            {
                new Bilet
                {
                    TurId = 2,
                    YeniTurId = null,
                    SatanSubeId = 1,
                    SatanElemanId = 3,
                    MusteriAd = "Ali",
                    MusteriSoyad = "Kaya",
                    MusteriUyruk = "TUR",
                    MusteriBolgeId = 1,
                    MusteriOtelId = null,
                    MusteriOdaNo = null,
                    MusteriAdres = "Antalya Merkez",
                    MusteriTelNo = "+9005125481483",
                    FullSayi = 1,
                    HalfSayi = 1,
                    GuestSayi = 0,
                    ParaBirimi = "TRY",
                    Paid = 70,
                    Rest = 80,
                    OdendiMi = false,
                    Aciklama = null,
                    ServisIstiyorMu = false,
                    ServisSaati = null,
                    BiletIptalMi = true,
                    PasBiletMi = false,
                    GelenGidenPas = null,
                    PasSirketi = null
                },
                new Bilet
                {
                    TurId = 2,
                    YeniTurId = null,
                    SatanSubeId = 2,
                    SatanElemanId = 7,
                    MusteriAd = "Veli",
                    MusteriSoyad = "Türkoğlu",
                    MusteriUyruk = "TUR",
                    MusteriBolgeId = 2,
                    MusteriOtelId = null,
                    MusteriOdaNo = null,
                    MusteriAdres = "Antalya Bölge 1",
                    MusteriTelNo = "+9005125481483",
                    FullSayi = 1,
                    HalfSayi = 0,
                    GuestSayi = 0,
                    ParaBirimi = "TRY",
                    Paid = 50,
                    Rest = 50,
                    OdendiMi = true,
                    Aciklama = null,
                    ServisIstiyorMu = false,
                    ServisSaati = null,
                    BiletIptalMi = false,
                    PasBiletMi = false,
                    GelenGidenPas = null,
                    PasSirketi = null
                },
                new Bilet
                {
                    TurId = 4,
                    YeniTurId = null,
                    SatanSubeId = 1,
                    SatanElemanId = 3,
                    MusteriAd = "Mehmet",
                    MusteriSoyad = "Yılmaz",
                    MusteriUyruk = "TUR",
                    MusteriBolgeId = 1,
                    MusteriOtelId = null,
                    MusteriOdaNo = null,
                    MusteriAdres = "Antalya Merkez",
                    MusteriTelNo = "+9005321234567",
                    FullSayi = 2,
                    HalfSayi = 1,
                    GuestSayi = 0,
                    ParaBirimi = "TRY",
                    Paid = 150,
                    Rest = 150,
                    OdendiMi = false,
                    Aciklama = "Yol tutuyor.",
                    ServisIstiyorMu = false,
                    ServisSaati = null,
                    BiletIptalMi = false,
                    PasBiletMi = false,
                    GelenGidenPas = null,
                    PasSirketi = null
                },
                new Bilet{
                    TurId = 4,
                    YeniTurId = null,
                    SatanSubeId = 1,
                    SatanElemanId = 3,
                    MusteriAd = "John",
                    MusteriSoyad = "Doe",
                    MusteriUyruk = "USA",
                    MusteriBolgeId = 1,
                    MusteriOtelId = 1,
                    MusteriOdaNo = "101",
                    MusteriAdres = null,
                    MusteriTelNo = "+9005256247314",
                    FullSayi = 1,
                    HalfSayi = 0,
                    GuestSayi = 0,
                    ParaBirimi = "USD",
                    Paid = 4,
                    Rest = 6,
                    OdendiMi = false,
                    Aciklama = null,
                    ServisIstiyorMu = true,
                    ServisSaati = new TimeOnly(9, 30),
                    BiletIptalMi = false,
                    PasBiletMi = false,
                    GelenGidenPas = null,
                    PasSirketi = null
                },
                new Bilet
                {
                    TurId = 5,
                    YeniTurId = null,
                    SatanSubeId = 2,
                    SatanElemanId = 7,
                    MusteriAd = "Klaus",
                    MusteriSoyad = "Müller",
                    MusteriUyruk = "DEU",
                    MusteriBolgeId = 2,
                    MusteriOtelId = 3,
                    MusteriOdaNo = "206",
                    MusteriAdres = null,
                    MusteriTelNo = "+9005923517421",
                    FullSayi = 1,
                    HalfSayi = 3,
                    GuestSayi = 0,
                    ParaBirimi = "EUR",
                    Paid = 20,
                    Rest = 20,
                    OdendiMi = false,
                    Aciklama = null,
                    ServisIstiyorMu = true,
                    ServisSaati = new TimeOnly(10,00),
                    BiletIptalMi = false,
                    PasBiletMi = false,
                    GelenGidenPas = null,
                    PasSirketi = null
                }
            };
        }
    }
}
