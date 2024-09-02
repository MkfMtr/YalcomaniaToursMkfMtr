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

                if (user != null)
                {
                    var gorevCalisan = _dbContext.GorevlerCalisanlar.FirstOrDefault(gc => gc.CalisanId == user.Id);
                    if (gorevCalisan != null)
                    {
                        var gorev = _dbContext.Gorevler.FirstOrDefault(c => c.Id == gorevCalisan.GorevId);
                        if (gorev != null && callingView == "Login")
                        {
                            switch (gorev.GorevAdi)
                            {
                                case "BiletSatis":
                                    //string currentUserId = user.Id.ToString();
                                    //TempData["CurrentUserId"] = currentUserId;
                                    return RedirectToAction("TicketIndex", "Home");
                                case "OperasyonYonetim":
                                    return RedirectToAction("OperationIndex", "Home");
                                case "VeriGiris":
                                    return RedirectToAction("DataInputIndex", "Home");
                                case "Muhasebe":
                                    return RedirectToAction("AccountingIndex", "Home");
                                default:
                                    break;
                            }
                        }
                        else if (gorev != null && gorev.GorevAdi == "Admin" && callingView == "AdminLogin")
                        {
                            return RedirectToAction("AdminIndex", "Admin");
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
        
        // Admin Login
        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AdminLogin(LoginViewModel model, string callingView)
        {
            return Login(model, callingView);
        }
    }
}
