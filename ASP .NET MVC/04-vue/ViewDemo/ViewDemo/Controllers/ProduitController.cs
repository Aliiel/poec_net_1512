using Microsoft.AspNetCore.Mvc;
using ViewDemo.Models;

namespace ViewDemo.Controllers
{
    public class ProduitController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Nos produits";

            //var produit = new Produit()
            //{
            //   Id = 1,
            //    Nom = "Ordinateur",
            //    Prix = 1299.99m,
            //    Stock = 20
            // };

            var produits = new List<Produit>
            {
                new Produit
                {
                    Id = 1,
                    Nom = "Ordinateur",
                    Prix = 500.25m,
                    Stock = 10
                },
                new Produit
                {
                    Id = 2,
                    Nom = "Clavier",
                    Prix = 15.25m,
                    Stock = 5
                },
                new Produit
                {
                    Id = 3,
                    Nom = "Souris",
                    Prix = 30.99m,
                    Stock = 500
                }
            };

            return View(produits);
        }

        public IActionResult Details ()
        {
            return Content("Page de détails");
        }

        public IActionResult DetailsAvecParametre(int id)
        {
            return Content($"Page de détail du produit à l'id {id}");
        }

        public IActionResult List(string categorie, string sort)
        {
            return Content($"Produit de la catégorie {categorie} dans la sorte {sort} ");
        }
    }
}
