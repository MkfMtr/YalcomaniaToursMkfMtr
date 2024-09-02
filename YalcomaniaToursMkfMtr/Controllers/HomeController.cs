using DataAccessLayer;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using YalcomaniaToursMkfMtr.Models;

namespace YalcomaniaToursMkfMtr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly YalcoContext _context;

        public HomeController(ILogger<HomeController> logger, YalcoContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult TicketEdit()
        {
            return View();
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

        public IActionResult OperationCreateTour()

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
