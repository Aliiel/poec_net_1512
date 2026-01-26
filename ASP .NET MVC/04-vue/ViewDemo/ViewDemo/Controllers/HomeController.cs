using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ViewDemo.Models;

namespace ViewDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var message = "Bienvenue depuis le controller";
            return View((object)message);  // cast pour éviter que le controller croit que le message soit une vue
        }


        public IActionResult IfElse()
        {
            return View();
        }


        public IActionResult ForEach()
        {
            return View();
        }

        public IActionResult AvecModelSimple ()
        {
            return View();
        }

        public IActionResult Privacy()
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
