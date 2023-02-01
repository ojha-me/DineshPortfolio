using DineshPortfolio.State;
using DineshPortfolio.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace DineshPortfolio.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginView)
        {
            LoginState.Login(loginView);
            return RedirectToAction("Index","Home");
        }

        public IActionResult Logout()
        {
            LoginState.Logout();
            return RedirectToAction("Index", "Home");
        }
    }
}
