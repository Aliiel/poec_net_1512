using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;
using ModelDemo.ViewModel;

namespace ModelDemo.Controllers
{
    public class EtudiantController : Controller
    {
        public static List<Etudiant> Etudiants = new List<Etudiant>
        {
            new Etudiant
            {
                Id = 1,
                Name = "a",
                Age = 87,
                DateNaissance = new DateTime(1998, 05, 12)
            }
        };

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Inscription()
        {
            return View(new EtudiantInscriptionViewModel());
        }


        [HttpPost]
        [ValidateAntiForgeryToken]  // protection CSRF vérifie que le formulaire vient bien du site 
        public IActionResult Inscription (EtudiantInscriptionViewModel nouvelEtudiant)
        {
            // Si toutes les data annotations ne sont pas satisfaites, on retourne dans le formulaire avec les données 
            // les tags helpers afficheront automatiquement les messages d'erreur 
            if(!ModelState.IsValid)
            {
                return View(nouvelEtudiant);
            }

            // Ajouter dans la bdd 
            TempData["Success"] = "Inscription réussie, bienvenue !";

            // redirige vers une autre action 
            return RedirectToAction("Index");
        }
    }
}
