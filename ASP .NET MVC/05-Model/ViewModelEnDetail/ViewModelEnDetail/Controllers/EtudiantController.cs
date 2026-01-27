using Microsoft.AspNetCore.Mvc;
using ViewModelEnDetail.Models;
using ViewModelEnDetail.ViewModel;

namespace ViewModelEnDetail.Controllers
{
    public class EtudiantController : Controller
    {
        public static List<Etudiant> _etudiants = new List<Etudiant>
        {
            new Etudiant
            {
                Id = 1,
                Name = "Truc",
                Prenom = "Mireille",
                Address = "14 rue des oeillets",
                InscriptionDate = new DateTime(2020, 5, 15),
                BirthDate = new DateTime(2000, 8, 21),
                Email = "mireille@mail.com",
                NumberPhone = "0648154978",
                Note = "Etudiant sérieux, quelques absences justifiées.",
                ClasseId = 1,
                Classe = new Classe
                {
                    ClasseId = 1,
                    ClasseName = "L3 Informatique"
                }

            }
        };

        public IActionResult Index()
        {
            var etudiantsViewModels = _etudiants.Select(s => new EtudiantListeViewModel
            {
                Id = s.Id,
                NomComplet = $"{s.Name} {s.Prenom}",
                Email = s.Email,
                NomDeLaClasse = s.Classe?.ClasseName ?? "Sans classe",
                Age = CalculDeLage(s.BirthDate)
            });
            return View(etudiantsViewModels);
        }



        private int CalculDeLage (DateTime DateNaissance)
        {
            var aujourdhui = DateTime.Now;
            var age = aujourdhui.Year - DateNaissance.Year;

            if (DateNaissance.Date > aujourdhui.AddYears(-age)) age--;

            return age;
        }
    }
}
