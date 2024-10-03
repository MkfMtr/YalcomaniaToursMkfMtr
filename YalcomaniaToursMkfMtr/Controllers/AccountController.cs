using DataAccessLayer.Context;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using YalcomaniaToursMkfMtr.Models;

namespace YalcomaniaToursMkfMtr.Controllers
{
    public class AccountController : Controller
    {
        private readonly YalcoContext _dbContext;

        public AccountController(YalcoContext dbContext)
        {
            _dbContext = dbContext;
        }

        // User Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model, string callingView)
        {
            if (ModelState.IsValid)
            {
                var user = _dbContext.Calisanlar.FirstOrDefault(c => c.CalisanMail == model.UserMail && c.CalisanSifre == model.Password);
                if (user == null)
                {
                    return View(callingView);
                }
                var subelerCalisanlar = _dbContext.SubelerCalisanlar.FirstOrDefault(sc => sc.CalisanId == user.Id);
                var sube = _dbContext.Subeler.FirstOrDefault(s => s.Id == subelerCalisanlar.SubeId);

                if (user != null)
                {
                    var gorevCalisan = _dbContext.GorevlerCalisanlar.FirstOrDefault(gc => gc.CalisanId == user.Id);
                    if (gorevCalisan != null)
                    {
                        var gorev = _dbContext.Gorevler.FirstOrDefault(c => c.Id == gorevCalisan.GorevId);
                        if (gorev != null && callingView == "Login")
                        {
                            // Store user information in session
                            HttpContext.Session.SetInt32("UserId", user.Id);
                            HttpContext.Session.SetString("UserName", user.CalisanAdi);
                            HttpContext.Session.SetString("UserSurname", user.CalisanSoyadi ?? "");
                            HttpContext.Session.SetString("UserRole", JsonConvert.SerializeObject(gorev.GorevAdi));
                            HttpContext.Session.SetInt32("SubeId", sube.Id);
                            HttpContext.Session.SetString("SubeName", sube.SubeAd);

                            switch (gorev.GorevAdi)
                            {
                                case "BiletSatis":
                                    return RedirectToAction("TicketIndex", "Home");
                                case "OperasyonYonetim":
                                    return RedirectToAction("OperationIndex", "Home");
                                case "VeriGiris":
                                    return RedirectToAction("DataInputIndex", "Home");
                                case "Muhasebe":
                                    return RedirectToAction("AccountingIndex", "Home");
                                case "Admin":
                                    return RedirectToAction("AdminIndex", "Home");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError(string.Empty, "Invalid role.");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "You do not have a role.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid user.");
                }
            }
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return View(callingView, model);
        }
    }
}
