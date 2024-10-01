using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using YalcomaniaToursMkfMtr.Models;

namespace YalcomaniaToursMkfMtr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly YalcoContext _context;
        private readonly ITurService _turService;
        private readonly IBiletService _biletService;

        public HomeController(ILogger<HomeController> logger, YalcoContext context, ITurService turService, IBiletService biletService)
        {
            _logger = logger;
            _context = context;
            _turService = turService;
            _biletService = biletService;
        }

        public IActionResult TicketCreate()
        {
            var turList = _context.Turlar.ToList();
            var turTipiList = _context.TurTipleri.ToList();
            var subeList = _context.Subeler.ToList();
            var calisanList = _context.Calisanlar.ToList();
            var subeCalisanList = _context.SubelerCalisanlar.ToList();
            var bolgeSubeList = _context.BolgelerSubeler.ToList();
            var uyrukList = _context.Uyruklar.ToList();
            var otelList = _context.Oteller.ToList();
            var bolgeList = _context.Bolgeler.ToList();
            var bolgeOtelList = _context.BolgelerOteller.ToList();
            var parabirimiList = _context.ParaBirimleri.ToList();
            var kurList = _context.Kurlar.ToList();
            var model = new TicketCreateModel
            {
                TurList = turList,
                TurTipiList = turTipiList,
                SubeList = subeList,
                CalisanList = calisanList,
                SubeCalisanList = subeCalisanList,
                BolgeSubeList = bolgeSubeList,
                UyrukList = uyrukList,
                OtelList = otelList,
                BolgeList = bolgeList,
                BolgeOtelList = bolgeOtelList,
                ParaBirimiList = parabirimiList,
                KurList = kurList
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SendTicketDetails([FromBody] List<string> ticketValues)
        {
            if (ticketValues == null || ticketValues.Count == 0)
            {
                return BadRequest("Array is null or empty");
            }
            else
            {
                //foreach (var value in ticketValues)
                //{
                //    Console.WriteLine(value);
                //}
                var satanSubeId = int.Parse(ticketValues[0]);
                var satanElemanId = int.Parse(ticketValues[1]);
                var turId = int.Parse(ticketValues[2]);
                var musteriAd = ticketValues[3];
                var musteriSoyad = ticketValues[4];
                var musteriUyruk = ticketValues[5];
                var musteriBolgeId = int.Parse(ticketValues[6]);
                int? musteriOtelId = string.IsNullOrEmpty(ticketValues[7]) ? null : int.Parse(ticketValues[7]);
                var musteriOdaNo = ticketValues[8];
                var musteriTelNo = ticketValues[9];
                var musteriAdres = ticketValues[10];
                var fullSayi = byte.Parse(ticketValues[11]);
                var halfSayi = byte.Parse(ticketValues[12]);
                var guestSayi = byte.Parse(ticketValues[13]);
                var paraBirimi = ticketValues[14];
                var paid = decimal.Parse(ticketValues[15], CultureInfo.InvariantCulture);
                var rest = decimal.Parse(ticketValues[16], CultureInfo.InvariantCulture);
                var aciklama = ticketValues[17];
                var servisIstiyorMu = bool.Parse(ticketValues[18]);
                TimeOnly? servisSaati = string.IsNullOrEmpty(ticketValues[19]) ? null : TimeOnly.Parse(ticketValues[19]);

                await _biletService.Create(new Bilet
                {
                    TurId = turId,
                    YeniTurId = null,
                    SatanSubeId = satanSubeId,
                    SatanElemanId = satanElemanId,
                    MusteriAd = musteriAd,
                    MusteriSoyad = musteriSoyad,
                    MusteriUyruk = musteriUyruk,
                    MusteriBolgeId = musteriBolgeId,
                    MusteriOtelId = musteriOtelId,
                    MusteriOdaNo = musteriOdaNo,
                    MusteriAdres = musteriAdres,
                    MusteriTelNo = musteriTelNo,
                    FullSayi = fullSayi,
                    HalfSayi = halfSayi,
                    GuestSayi = guestSayi,
                    ParaBirimi = paraBirimi,
                    Paid = paid,
                    Rest = rest,
                    Aciklama = aciklama,
                    ServisIstiyorMu = servisIstiyorMu,
                    ServisSaati = servisSaati,
                    BiletIptalMi = false,
                    PasBiletMi = false,
                    GelenGidenPas = null,
                    PasSirketi = null
                });
                return Ok(new { redirectUrl = Url.Action("TicketIndex", "Home") });
            }
        }

        public IActionResult TicketIndex()
        {
            return View();
        }

        public IActionResult TicketSearch()
        {
            var turList = _context.Turlar.ToList();
            var turTipiList = _context.TurTipleri.ToList();
            var subeList = _context.Subeler.ToList();
            var calisanList = _context.Calisanlar.ToList();
            var subeCalisanList = _context.SubelerCalisanlar.ToList();
            var gorevList = _context.Gorevler.ToList();
            var gorevCalisanList = _context.GorevlerCalisanlar.ToList();
            var bolgeSubeList = _context.BolgelerSubeler.ToList();
            var uyrukList = _context.Uyruklar.ToList();
            var otelList = _context.Oteller.ToList();
            var bolgeList = _context.Bolgeler.ToList();
            var bolgeOtelList = _context.BolgelerOteller.ToList();
            var parabirimiList = _context.ParaBirimleri.ToList();
            var kurList = _context.Kurlar.ToList();
            var biletList = _context.Biletler.ToList();
            var model = new TicketSearchModel
            {
                TurList = turList,
                TurTipiList = turTipiList,
                SubeList = subeList,
                CalisanList = calisanList,
                SubeCalisanList = subeCalisanList,
                GorevList = gorevList,
                GorevCalisanList = gorevCalisanList,
                BolgeSubeList = bolgeSubeList,
                UyrukList = uyrukList,
                OtelList = otelList,
                BolgeList = bolgeList,
                BolgeOtelList = bolgeOtelList,
                ParaBirimiList = parabirimiList,
                KurList = kurList,
                BiletList = biletList
            };

            return View(model);
        }

        public IActionResult OperationCreateTour()
        {
            var aracTipiList = _context.AracTipleri.ToList();
            var aracList = _context.Araclar.ToList();
            var turTipiList = _context.TurTipleri.ToList();
            var sirketList = _context.Sirketler.ToList();
            var paraBirimiList = _context.ParaBirimleri.ToList();
            var sirketTurTipiList = _context.SirketTurTipleri.ToList();
            var kurList = _context.Kurlar.ToList();
            var model = new OperationCreateTourModel
            {
                AracTipiList = aracTipiList,
                AracList = aracList,
                TurTipiList = turTipiList,
                SirketList = sirketList,
                ParaBirimiList = paraBirimiList,
                SirketTurTipiList = sirketTurTipiList,
                KurList = kurList
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SendTourDetails([FromBody] List<string> tourValues)
        {
            if (tourValues == null || tourValues.Count == 0)
            {
                return BadRequest("Array is null or empty");
            }
            else
            {
                foreach (var value in tourValues)
                {
                    Console.WriteLine(value);
                }
                var Tarih = DateOnly.Parse(tourValues[0]);
                var Saat = TimeOnly.Parse(tourValues[1]);
                var TurTipiId = int.Parse(tourValues[2]);
                var FiyatTry = decimal.Parse(tourValues[3], CultureInfo.InvariantCulture);
                var FiyatUsd = decimal.Parse(tourValues[4], CultureInfo.InvariantCulture);
                var FiyatEur = decimal.Parse(tourValues[5], CultureInfo.InvariantCulture);
                int AracId1 = int.Parse(tourValues[6]);
                int? AracId2 = string.IsNullOrEmpty(tourValues[7]) ? null : int.Parse(tourValues[7]);
                int? AracId3 = string.IsNullOrEmpty(tourValues[8]) ? null : int.Parse(tourValues[8]);
                int? AracId4 = string.IsNullOrEmpty(tourValues[9]) ? null : int.Parse(tourValues[9]);
                int? ServisId1 = string.IsNullOrEmpty(tourValues[10]) ? null : int.Parse(tourValues[10]);
                int? ServisId2 = string.IsNullOrEmpty(tourValues[11]) ? null : int.Parse(tourValues[11]);
                int? ServisId3 = string.IsNullOrEmpty(tourValues[12]) ? null : int.Parse(tourValues[12]);
                await _turService.Create(new Tur
                {
                    Tarih = Tarih,
                    Saat = Saat,
                    TurTipiId = TurTipiId,
                    FiyatTRY = FiyatTry,
                    FiyatUSD = FiyatUsd,
                    FiyatEUR = FiyatEur,
                    AracId1 = AracId1,
                    AracId2 = AracId2,
                    AracId3 = AracId3,
                    AracId4 = AracId4,
                    ServisId1 = ServisId1,
                    ServisId2 = ServisId2,
                    ServisId3 = ServisId3,
                    BittiMi = false,
                    TurIptalMi = false
                });
                return Ok(new { redirectUrl = Url.Action("OperationIndex", "Home") });
            }
        }

        public IActionResult OperationIndex()
        {
            return View();
        }

        public IActionResult OperationSearchTour()
        {
            var aracList = _context.Araclar.ToList();
            var aracTipiList = _context.AracTipleri.ToList();
            var biletList = _context.Biletler.ToList();
            var bolgeList = _context.Bolgeler.ToList();
            var bolgeOtelList = _context.BolgelerOteller.ToList();
            var kurList = _context.Kurlar.ToList();
            var otelList = _context.Oteller.ToList();
            var paraBirimiList = _context.ParaBirimleri.ToList();
            var turList = _context.Turlar.ToList();
            var turTipiList = _context.TurTipleri.ToList();
            var uyrukList = _context.Uyruklar.ToList();
            var model = new OperationSearchTourModel
            {
                AracList = aracList,
                AracTipiList = aracTipiList,
                BiletList = biletList,
                BolgeList = bolgeList,
                BolgeOtelList = bolgeOtelList,
                KurList = kurList,
                OtelList = otelList,
                ParaBirimiList = paraBirimiList,
                TurList = turList,
                TurTipiList = turTipiList,
                UyrukList = uyrukList
            };
            return View(model);
        }

        public IActionResult DataInputEdit()
        {
            return View();
        }

        public IActionResult DataInputIndex()
        {
            return View();
        }

        public IActionResult DataInputSearch()
        {
            return View();
        }

        public IActionResult AccountingEdit()
        {
            return View();
        }

        public IActionResult AccountingIndex()
        {
            return View();
        }

        public IActionResult AccountingSearch()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
