using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class EtudiantController : Controller
    {
        public static List<Etudiant> _etudiants = new List<Etudiant>
        {
            new Etudiant
            {
                Id = 1,
                Nom = "Pruvost",
                Prenom = "Jacqueline",
                Age = 58,
                DateNaissance = new DateTime(1987, 05, 21)
            }        
        };
        public IActionResult Index()
        {
            return View();
        }
    }
}
