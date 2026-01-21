using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MonPremierProjet_MVC.Models;

namespace MonPremierProjet_MVC.Controllers
{
    public class HomeController : Controller
    {
        // Action : afficher la page d'acceuil 
        // home/index pour reprendre l'exemple 
        public IActionResult Index()
        {
            return View();  // retourne la vue correspondante à ce controlleur
        }

        // home/privacy
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
