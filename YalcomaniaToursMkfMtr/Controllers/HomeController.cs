using BusinessLayer.Abstract;
using DataAccessLayer;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using YalcomaniaToursMkfMtr.Models;

namespace YalcomaniaToursMkfMtr.Controllers
{
    public class HomeController : Controller
    {
        #region private readonly ...
        private readonly ILogger<HomeController> _logger;
        private readonly YalcoContext _context;
        private readonly IAracService _aracService;
        private readonly IAracTipiService _aracTipiService;
        private readonly IBiletService _biletService;
        private readonly IBolgeService _bolgeService;
        private readonly IBolgeOtelService _bolgeOtelService;
        private readonly IBolgeSubeService _bolgeSubeService;
        private readonly ICalisanService _calisanService;
        private readonly IGorevService _gorevService;
        private readonly IGorevCalisanService _gorevCalisanService;
        private readonly IKurService _kurService;
        private readonly IOtelService _otelService;
        private readonly IParaBirimiService _paraBirimiService;
        private readonly ISirketService _sirketService;
        private readonly ISirketTurTipiService _sirketTurTipiService;
        private readonly ISubeCalisanService _subeCalisanService;
        private readonly ISubeService _subeService;
        private readonly ITurService _turService;
        private readonly ITurTipiService _turTipiService;
        private readonly IUyrukService _uyrukService; 
        #endregion

        public HomeController(ILogger<HomeController> logger, YalcoContext context, 
            IAracService aracService, IAracTipiService aracTipiService, IBiletService biletService, IBolgeService bolgeService,
            IBolgeOtelService bolgeOtelService, IBolgeSubeService bolgeSubeService, ICalisanService calisanService, IGorevService gorevService, IGorevCalisanService gorevCalisanService,
            IKurService kurService, IOtelService otelService, IParaBirimiService paraBirimiService, ISirketService sirketService,
            ISirketTurTipiService sirketTurTipiService, ISubeCalisanService subeCalisanService, ISubeService subeService, ITurService turService,
            ITurTipiService turTipiService, IUyrukService uyrukService)
        {
            _logger = logger;
            _context = context;
            _aracService = aracService;
            _aracTipiService = aracTipiService;
            _biletService = biletService;
            _bolgeService = bolgeService;
            _bolgeOtelService = bolgeOtelService;
            _bolgeSubeService = bolgeSubeService;
            _calisanService = calisanService;
            _gorevService = gorevService;
            _gorevCalisanService = gorevCalisanService;
            _kurService = kurService;
            _otelService = otelService;
            _paraBirimiService = paraBirimiService;
            _sirketService = sirketService;
            _sirketTurTipiService = sirketTurTipiService;
            _subeCalisanService = subeCalisanService;
            _subeService = subeService;
            _turService = turService;
            _turTipiService = turTipiService;
            _uyrukService = uyrukService;
        }

        public IActionResult AdminIndex()
        {
            return View();
        }
        public IActionResult TicketCreate()
        {
            var turList = _turService.GetAll().ToList();
            var turTipiList = _turTipiService.GetAll().ToList();
            var subeList = _subeService.GetAll().ToList();
            var calisanList = _calisanService.GetAll().ToList();
            var subeCalisanList = _subeCalisanService.GetAll().ToList();
            var bolgeSubeList = _bolgeSubeService.GetAll().ToList();
            var uyrukList = _uyrukService.GetAll().ToList();
            var otelList = _otelService.GetAll().ToList();
            var bolgeList = _bolgeService.GetAll().ToList();
            var bolgeOtelList = _bolgeOtelService.GetAll().ToList();
            var parabirimiList = _paraBirimiService.GetAll().ToList();
            var kurList = _kurService.GetAll().ToList();
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
                    OdendiMi = false,
                    BiletIptalMi = false,
                    PasBiletMi = false,
                    GelenGidenPas = null,
                    PasSirketi = null
                });
                return Ok(new { redirectUrl = Url.Action("TicketIndex", "Home") });
            }
        }

        public async Task<IActionResult> SendTicketUpdate([FromBody] List<string> ticketValues)
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
                var biletId = int.Parse(ticketValues[20]);
                var biletIptalMi = bool.Parse(ticketValues[21]);

                Bilet eskiBilet = _biletService.GetById(biletId);
                if (eskiBilet == null)
                {
                    return BadRequest("Bilet not found");
                }
                else
                {
                    eskiBilet.TurId = turId;
                    eskiBilet.MusteriAd = musteriAd;
                    eskiBilet.MusteriSoyad = musteriSoyad;
                    eskiBilet.MusteriUyruk = musteriUyruk;
                    eskiBilet.MusteriBolgeId = musteriBolgeId;
                    eskiBilet.MusteriOtelId = musteriOtelId;
                    eskiBilet.MusteriOdaNo = musteriOdaNo;
                    eskiBilet.MusteriAdres = musteriAdres;
                    eskiBilet.MusteriTelNo = musteriTelNo;
                    eskiBilet.FullSayi = fullSayi;
                    eskiBilet.HalfSayi = halfSayi;
                    eskiBilet.GuestSayi = guestSayi;
                    eskiBilet.ParaBirimi = paraBirimi;
                    eskiBilet.Paid = paid;
                    eskiBilet.Rest = rest;
                    eskiBilet.Aciklama = aciklama;
                    eskiBilet.ServisIstiyorMu = servisIstiyorMu;
                    eskiBilet.BiletIptalMi = biletIptalMi;
                }

                await _biletService.Update(eskiBilet);
                return Ok(new { redirectUrl = Url.Action("TicketSearch", "Home") });
            }
        }

        public IActionResult TicketIndex()
        {
            return View();
        }

        public IActionResult TicketSearch()
        {
            var turList = _turService.GetAll().ToList();
            var turTipiList = _turTipiService.GetAll().ToList();
            var subeList = _subeService.GetAll().ToList();
            var calisanList = _calisanService.GetAll().ToList();
            var subeCalisanList = _subeCalisanService.GetAll().ToList();
            var gorevList = _gorevService.GetAll().ToList();
            var gorevCalisanList = _gorevCalisanService.GetAll().ToList();
            var bolgeSubeList = _bolgeSubeService.GetAll().ToList();
            var uyrukList = _uyrukService.GetAll().ToList();
            var otelList = _otelService.GetAll().ToList();
            var bolgeList = _bolgeService.GetAll().ToList();
            var bolgeOtelList = _bolgeOtelService.GetAll().ToList();
            var parabirimiList = _paraBirimiService.GetAll().ToList();
            var kurList = _kurService.GetAll().ToList();
            var biletList = _biletService.GetAll().ToList();
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
            var aracTipiList = _aracTipiService.GetAll().ToList();
            var aracList = _aracService.GetAll().ToList();
            var turTipiList = _turTipiService.GetAll().ToList();
            var sirketList = _sirketService.GetAll().ToList();
            var paraBirimiList = _paraBirimiService.GetAll().ToList();
            var sirketTurTipiList = _sirketTurTipiService.GetAll().ToList();
            var kurList = _kurService.GetAll().ToList();
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
            var aracList = _aracService.GetAll().ToList();
            var aracTipiList = _aracTipiService.GetAll().ToList();
            var biletList = _biletService.GetAll().ToList();
            var bolgeList = _bolgeService.GetAll().ToList();
            var bolgeOtelList = _bolgeOtelService.GetAll().ToList();
            var kurList = _kurService.GetAll().ToList();
            var otelList = _otelService.GetAll().ToList();
            var paraBirimiList = _paraBirimiService.GetAll().ToList();
            var turList = _turService.GetAll().ToList();
            var turTipiList = _turTipiService.GetAll().ToList();
            var uyrukList = _uyrukService.GetAll().ToList();
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

        public IActionResult OperationVehicles()
        {
            var aracList = _aracService.GetAll().ToList();
            var aracTipiList = _aracTipiService.GetAll().ToList();
            var model = new OperationVehiclesModel
            {
                AracList = aracList,
                AracTipiList = aracTipiList
            };
            return View(model);
        }

        public async Task<IActionResult> SendNewVehicleDetails([FromBody] List<string> vehicleValues)
        {
            if (vehicleValues == null || vehicleValues.Count == 0)
            {
                return BadRequest("Array is null or empty");
            }
            else
            {
                foreach (var value in vehicleValues)
                {
                    Console.WriteLine(value);
                }
                string plaka = vehicleValues[0];
                int aracTipiId = int.Parse(vehicleValues[1]);
                await _aracService.Create(new Arac
                {
                    PlakaVeyaIsim = plaka,
                    AracTipiId = aracTipiId,
                    SilindiMi = false
                });
                return Ok(new { redirectUrl = Url.Action("OperationVehicles", "Home") });
            }
        }

        public async Task<IActionResult> SendDeleteVehicleDetails([FromBody] List<string> vehicleValues)
        {
            if (vehicleValues == null || vehicleValues.Count == 0)
            {
                return BadRequest("Array is null or empty");
            }
            else
            {
                foreach (var value in vehicleValues)
                {
                    Console.WriteLine(value);
                }
                int aracId = int.Parse(vehicleValues[0]);
                string plaka = vehicleValues[1];
                int aracTipiId = int.Parse(vehicleValues[2]);
                bool silindiMi = bool.Parse(vehicleValues[3]);
                Arac arac = _aracService.GetById(aracId);
                if (arac == null)
                {
                    return BadRequest("Vehicle not found");
                }
                else
                {
                    arac.PlakaVeyaIsim = plaka;
                    arac.AracTipiId = aracTipiId;
                    arac.SilindiMi = silindiMi;
                }
                await _aracService.Update(arac);
                return Ok(new { redirectUrl = Url.Action("OperationVehicles", "Home") });
            }
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
        [HttpPost]
        public IActionResult TicketToUpdate([FromBody] List<string> biletValues)
        {
            if (biletValues == null || biletValues.Count == 0)
            {
                return BadRequest("Array is null or empty");
            }
            else
            {
                string jsonString = JsonConvert.SerializeObject(biletValues);
                HttpContext.Session.SetString("biletValues", jsonString);
                return Ok(new { redirectUrl = Url.Action("TicketCreate", "Home") });
            }
        }
    }
}
