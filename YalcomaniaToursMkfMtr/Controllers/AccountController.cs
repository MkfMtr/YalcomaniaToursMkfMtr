using Microsoft.AspNetCore.Mvc;
using YalcomaniaToursMkfMtr.Models;

namespace YalcomaniaToursMkfMtr.Controllers
{
    public class AccountController : Controller
    {

        // User Login
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(model.UserMail == "1" && model.Password == "1")
                {
                    // Perform user login logic
                    // Redirect to user dashboard
                    return RedirectToAction("TicketIndex", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }
            return View(model);
        }

        // Admin Login
        public ActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.UserMail == "1" && model.Password == "1")
                {
                    // Perform user login logic
                    // Redirect to user dashboard
                    return RedirectToAction("AdminIndex", "Admin");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                }
            }
            return View(model);
        }
    }
}
