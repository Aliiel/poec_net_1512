using Microsoft.AspNetCore.Mvc;
using ModelDemo.Models;

namespace ModelDemo.Controllers
{
    public class ProductController : Controller
    {
        private static List<Produit> _products = new List<Produit>();

        public IActionResult Index()
        {
            var Produits = new List<Produit>
            {
                new Produit
                {
                    Id = 1,
                    Nom = "Ordinateur",
                    Prix = 599.99m,
                    Stock = 50
                },
                new Produit
                {
                    Id = 2,
                    Nom = "Tablette",
                    Prix = 129.99m,
                    Stock = 3
                },
                new Produit
                {
                    Id = 3,
                    Nom = "Téléphone",
                    Prix = 89.99m,
                    Stock = 50
                }
            };


            return View(Produits);
        }

        public IActionResult Details(int id)
        {
           ;
            return Content("Page de détails");
        }
    }
}
