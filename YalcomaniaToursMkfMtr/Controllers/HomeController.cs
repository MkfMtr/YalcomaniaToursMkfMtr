using DataAccessLayer;
using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using YalcomaniaToursMkfMtr.Models;

namespace YalcomaniaToursMkfMtr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly YalcoContext _context;
        private readonly IGenericRepository<Tur> _turRepository;
        private readonly IGenericRepository<AracVerecek> _aracVerecekRepository;

        public HomeController(ILogger<HomeController> logger, YalcoContext context, IGenericRepository<Tur> turRepository, IGenericRepository<AracVerecek> aracVerecekRepository)
        {
            _logger = logger;
            _context = context;
            _turRepository = turRepository;
            _aracVerecekRepository = aracVerecekRepository;
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
            var parabirimiList = _context.ParaBirimleri.ToList();
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
                ParaBirimiList = parabirimiList
            };

            return View(model);
        }

        public IActionResult TicketIndex()
        {
            return View();
        }

        public IActionResult TicketSearch()
        {
            return View();
        }

        public IActionResult OperationCreateTour()
        {
            var aracTipiList = _context.AracTipleri.ToList();
            var aracList = _context.Araclar.ToList();
            var turTipiList = _context.TurTipleri.ToList();
            var sirketList = _context.Sirketler.ToList();
            var paraBirimiList = _context.ParaBirimleri.ToList();
            var sirketTurTipiList = _context.SirketTurTipleri.ToList();
            var model = new OperationCreateTourModel
            {
                AracTipiList = aracTipiList,
                AracList = aracList,
                TurTipiList = turTipiList,
                SirketList = sirketList,
                ParaBirimiList = paraBirimiList,
                SirketTurTipiList = sirketTurTipiList
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult SendTourDetails([FromBody] List<string> tourValues)
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
                var Fiyat = decimal.Parse(tourValues[3]);
                int AracId1 = int.Parse(tourValues[4]);
                int? AracId2 = string.IsNullOrEmpty(tourValues[5]) ? null : int.Parse(tourValues[5]);
                int? AracId3 = string.IsNullOrEmpty(tourValues[6]) ? null : int.Parse(tourValues[6]);
                int? AracId4 = string.IsNullOrEmpty(tourValues[7]) ? null : int.Parse(tourValues[7]);
                int? ServisId1 = string.IsNullOrEmpty(tourValues[8]) ? null : int.Parse(tourValues[8]);
                int? ServisId2 = string.IsNullOrEmpty(tourValues[9]) ? null : int.Parse(tourValues[9]);
                int? ServisId3 = string.IsNullOrEmpty(tourValues[10]) ? null : int.Parse(tourValues[10]);
                _turRepository.Add(new Tur
                {
                    Tarih = Tarih,
                    Saat = Saat,
                    TurTipiId = TurTipiId,
                    Fiyat = Fiyat,
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
                return RedirectToAction("OperationIndex");
            }
        }

        public IActionResult OperationIndex()
        {
            return View();
        }

        public IActionResult OperationSearch()
        {
            return View();
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
