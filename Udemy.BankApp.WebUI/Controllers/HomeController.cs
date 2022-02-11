using Microsoft.AspNetCore.Mvc;

namespace Udemy.BankApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
