using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json.Linq;
using ViewDemo.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ViewDemo.Controllers
{
    public class UtilisateurController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Affiche un formulaire vide avec une liste de pays
        [HttpGet]
        public IActionResult CreerUtilisateur()
        {
            // ViewBag fonctionne comme ViewData qui permet de transporter de la donnée 
            // prend le nom qu'on lui attribue apres le point 
            ViewBag.pays = new List<SelectListItem>()
            {
                new SelectListItem
                {
                    Value = "FR", Text = "France"
                },
                new SelectListItem
                {
                    Value = "ENG", Text = "Angleterre"
                },
                new SelectListItem
                {
                    Value = "BE", Text = "Belgique"
                },
                new SelectListItem
                {
                    Value = "CA", Text = "Canasa"
                },
            };

            return View(new Utilisateur());
        }
    }
}
